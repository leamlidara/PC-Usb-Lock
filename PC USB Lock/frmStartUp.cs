using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using IWshRuntimeLibrary;

namespace PC_USB_Lock
{
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
        }

        byte start_up = 0;
        byte remote_close = 0;

        private void frmStartUp_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
            Class1.setting_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Khmer_USB_locker";

            if (Directory.Exists(Class1.setting_path) == false) Directory.CreateDirectory(Class1.setting_path);

            if (System.IO.File.Exists(Class1.setting_path + "\\setting.dll") == false)
            {
                StreamWriter write = new StreamWriter(Class1.setting_path + "\\setting.dll");
                write.Write("1|5");
                write.Close();

                //WshShell shell = new WshShell();
                //IWshShortcut sh = (IWshShortcut)shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Khmer Usb Locker.lnk");
                //sh.TargetPath = Application.ExecutablePath;
                //sh.IconLocation = Application.ExecutablePath;
                //sh.Save();
            }

            try
            {
                StreamReader read = new StreamReader(Class1.setting_path + "\\setting.dll");
                string[] dddd = read.ReadLine().Split('|');
                Class1.setting_timer = int.Parse(dddd[1]);
                Class1.setting_auto_start = byte.Parse(dddd[0]);
                read.Close();
            }
            catch { MessageBox.Show("សូមអភ័យទោស! កម្មវិធីមានការកែតម្រូវដែលខុសគោលការណ៍ សូមមេត្តាសាកល្បងដំឡើងកម្មវិធីឡើងវិញម្តងទៀត។"); Class1.close_all = 1; Close(); }

           // MessageBox.Show(Class1.setting_path);
            if (Class1.setting_auto_start.ToString() == "1")
            {
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Khmer_USB_locker.lnk") == false)
                {
                    WshShell sho = new WshShell();
                    WshShortcut shortcut = (WshShortcut)sho.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Khmer_USB_locker.lnk");

                    shortcut.TargetPath = Application.ExecutablePath;
                    shortcut.Save();
                }
            }

            Class1.frmStart = this;
            if (start_up == 0)
            {
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
                this.Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                start_up = 1;
                if (Class1.close_all == 1) Close();
               // if (Class1.usb_inserted == 1) tm_ctrl_timer1.Enabled = true;
            }
        }

        private void frmStartUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (remote_close == 0)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
                ShowInTaskbar = false;
            }

            if (Class1.usb_inserted == 1)
            {
                Class1.frm1_close_int = 0;
                frmLogin login = new frmLogin();
                login.ShowDialog();
                if (Class1.frm1_close_int == 1) e.Cancel = false;
                else if (Class1.frm1_close_int == 0) e.Cancel = true;
            }

            if (Class1.close_all == 1 || (remote_close == 1 && Class1.frm1_close_int == 1)) e.Cancel = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TopMost = true;
            this.Show();
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;

            var drive = DriveInfo.GetDrives();
            foreach (var driv in drive)
                if (driv.IsReady && driv.DriveType == DriveType.Removable)
                    comboBox1.Items.Add(driv);
        }

        byte check_exit_usb = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(comboBox1.Text + "\\Khmer_usb_locker.dat") == false)
            {
                make_usb(comboBox1.Text);
            }
            else
            {
                DialogResult dd = MessageBox.Show("សូមអភ័យទោស USB នេះមានឯកសារសម្រាប់កម្មវិធីហើយ តើអ្នកចង់បន្តរទេ?", "មានឯកសារកូនសោររួចរាល់", MessageBoxButtons.YesNo);
                if (dd == DialogResult.Yes)
                {
                    System.IO.File.SetAttributes(comboBox1.Text + "Khmer_usb_locker.dat", FileAttributes.Normal);
                    System.IO.File.Delete(comboBox1.Text + "Khmer_usb_locker.dat");
                    make_usb(comboBox1.Text);
                }
                else Close();
            }
        }

        void make_usb(string ss)
        {
            USBSerialNumber usb = new USBSerialNumber();

            check_exit_usb = 0;
            for (int a = 4; a < Class1.pwd_from_frm1.Length; a++)
                if (Class1.pwd_from_frm1[a] == usb.getSerialNumberFromDriveLetter(comboBox1.Text.Remove(comboBox1.Text.Length - 1))) 
                    check_exit_usb = 1;
            try
            {
                StreamWriter write = new StreamWriter(ss + "\\Khmer_usb_locker.dat");
                string ud = usb.getSerialNumberFromDriveLetter(ss.Remove(comboBox1.Text.Length - 1));
                write.Write(Security.EncryptStringAES("Kh_usb_locker" + ud, Class1.key_d));
                write.Close();

                StreamWriter write2 = new StreamWriter(ss + "234234234234232342.cmd");
                write2.WriteLine("attrib +r +s +h /s /d " + ss + "Khmer_usb_locker.dat");
                write2.Close();

                if (check_exit_usb == 0)
                {
                    Class1.pwd = Class1.pwd + ud + "æ";
                    string pat = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                    StreamWriter write1 = new StreamWriter(pat + "\\windows_Lock.sys");
                    write1.Write(Security.EncryptStringAES(Class1.pwd, Class1.key_d));
                    write1.Close();

                    Class1.pwd_from_frm1 = Class1.pwd.Split('æ');
                }

                runFile(ss + "234234234234232342.cmd");

                System.IO.File.Delete(ss + "234234234234232342.cmd");
                Close();
            }
            catch
            {
                MessageBox.Show("សូមអភ័យទោស USB Flash នេះមិនអាចយកធ្វើជាសោរបានទេ សុំធ្វើការផ្លាស់ប្តូរ!", "កំហុស USB", MessageBoxButtons.OK);
            }
        }
        
        private void បទកមមវធToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remote_close = 1;
            Close();
        }

        private void បងកតឯកសរសមរបUSBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
            this.Show();
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            comboBox1.Items.Clear();

            var drive = DriveInfo.GetDrives();
            foreach (var driv in drive)
                if (driv.IsReady && driv.DriveType == DriveType.Removable)
                    comboBox1.Items.Add(driv);
        }

        private void ផលសបតរពកយសមងតToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPass_Chang passchange = new frmPass_Chang();
            passchange.ShowDialog();
        }

        private void ចកសរឡងវញToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.frm1_close_int = 0;

            if (Class1.frm1.tm_ctrl_USB_De.Enabled == false) Class1.frm1.tm_ctrl_USB_De.Enabled = true;

            Class1.frm1.Visible = true;

            if (Class1.frm1.tm_auto_lock.Enabled == false) Class1.frm1.tm_auto_lock.Enabled = true;

            Class1.frm1.BackgroundImage = Image.FromFile(Class1.pwd_from_frm1[3]);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> count = new List<string>();
            List<string> dri = new List<string>();
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                if (drive.IsReady && drive.DriveType == DriveType.Removable)
                    if (Class1.abb.Contains(drive.Name) == false)
                        dri.Add(drive.Name);
                count.Add(drive.Name);
            }

            if (Class1.abb.Count < count.Count)
            {
                List<string> ccc = new List<string>();
                for (int y = 0; y < count.Count; y++)
                {
                    if (Class1.abb.Contains(count[y]))
                        ccc.Add(count[y]);
                }
                Class1.abb.Clear();
                for (int y = 0; y < ccc.Count; y++)
                    Class1.abb.Add(ccc[y]);
                if (Class1.abb.Contains(Class1.usb_inserted_name) == false)
                {
                    tm_ctrl_timer1.Enabled = true;
                    Class1.usb_inserted = 0;
                }
            }

            if (dri.Count != 0)
            {
                for (int m = 0; m < dri.Count; m++)
                {
                    Class1.abb.Add(dri[m]);
                }
                if (dri.Contains(Class1.usb_inserted_name) == false)
                {
                    tm_ctrl_timer1.Enabled = true;
                    Class1.usb_inserted = 0;
                }
            }
        }

        private void tm_ctrl_timer1_Tick(object sender, EventArgs e)
        {
            if (Class1.usb_inserted == 1)
            {
                tm_ctrl_timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (Class1.usb_inserted == 0)
            {
                tm_ctrl_timer1.Enabled = false;
                timer1.Enabled = false;

                Class1.frm1.Visible = true;

                if (Class1.usb_inserted == 1)
                    tm_ctrl_timer1.Enabled = true;
            }
        }

        private void បងហញUSBទងអសToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShow_all_Usb show_all_usb = new frmShow_all_Usb();
            show_all_usb.ShowDialog();
        }

        private void runFile(string path)
        {
            Process proc = new Process
            {
                StartInfo = { FileName = path, RedirectStandardError = false, RedirectStandardOutput = false, UseShellExecute = false, WindowStyle = ProcessWindowStyle.Hidden }
            };
            proc.Start();
            proc.WaitForExit();
        }

        private void ករកណតToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        private void អពកមមវធToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about abt = new frm_about();
            abt.ShowDialog();
        }
    }
}
