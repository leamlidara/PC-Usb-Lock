using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PC_USB_Lock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               // tm_auto_lock.Interval = Class1.setting_timer * 1000;
            }
            catch { MessageBox.Show("សូមអភ័យទោស! កម្មវិធីមានការកែតម្រូវដែលខុសគោលការណ៍ សូមមេត្តាសាកល្បងដំឡើងកម្មវិធីឡើងវិញម្តងទៀត។"); Class1.close_all = 1; Close(); }

            Class1.frm1 = this;
            this.BringToFront();
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.TopMost = true;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys") == false)
            {
                frmCreatePass cc = new frmCreatePass();
                cc.ShowDialog();
                if (Class1.close_all == 1)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    Close();
                }
            }

            try
            {
                StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys");
                Class1.pwd = Security.DecryptStringAES(read.ReadLine(), Class1.key_d);
               // MessageBox.Show(Class1.pwd);
                Class1.pwd_from_frm1 = Class1.pwd.Split('æ');
                read.Close();
                Class1.frm1.BackgroundImage = Image.FromFile(Class1.pwd_from_frm1[3]);
            }
            catch { MessageBox.Show("សូមអភ័យទោស! កម្មវិធីមានការកែតម្រូវដែលខុសគោលការណ៍ សូមមេត្តាសាកល្បងដំឡើងកម្មវិធីឡើងវិញម្តងទៀត។"); Class1.close_all = 1; Close(); }

            timer2.Enabled = true;
            timer1.Enabled = true;
            tm_ctrl_USB_De.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BringToFront();
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.TopMost = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (e.CloseReason == CloseReason.TaskManagerClosing)
                    e.Cancel = true;

                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;

                if (Class1.frm1_close_int == 1) { Class1.frm1_close_int = 0; e.Cancel = false; }
                if (Class1.close_all == 1) e.Cancel = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
            {
                timer1.Enabled = false;
                tm_ctrl_USB_De.Enabled = false;
                System.Threading.Thread.Sleep(100);
                frmLogin frmlogin = new frmLogin();
                frmlogin.ShowDialog();
            }

            tm_ctrl_USB_De.Enabled = true;

            if (Class1.frm1_close_int == 1)
            {
                timer1.Enabled = false;
                //timer2.Enabled = false;
                //Close();
                Visible = false;
                tm_auto_lock.Enabled = true;
                tm_ctrl_USB_De.Enabled = false;
            }
            else timer1.Enabled = true;
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys") == false)
            {
                StreamWriter write = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys");
                write.Write(Security.EncryptStringAES(Class1.pwd, Class1.key_d));
                write.Close();
            }
        }

        byte success = 0;

        private void tm_ctrl_USB_De_Tick(object sender, EventArgs e)
        {
            List<string> count = new List<string>();
            List<string> dri = new List<string>();
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                if (drive.IsReady && drive.DriveType == DriveType.Removable)
                {
                    if (Class1.abb.Contains(drive.Name) == false)
                        dri.Add(drive.Name);
                    count.Add(drive.Name);
                }
            }

            if (Class1.abb.Count > count.Count)
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
                    Visible = true; 
                    Class1.frm1.BackgroundImage = Image.FromFile(Class1.pwd_from_frm1[3]);
                }
            }


            if (dri.Count != 0)
            {
                success = 0;
                for (int m = 0; m < dri.Count; m++)
                {
                    Class1.abb.Add(dri[m]);
                    USBSerialNumber usb = new USBSerialNumber();
                    for (int n = 4; n < Class1.pwd_from_frm1.Length; n++)
                    {
                        string u_ser = usb.getSerialNumberFromDriveLetter(dri[m].Remove(dri[m].Length - 1));
                        if (Class1.pwd_from_frm1[n] == u_ser)
                        {
                            if (File.Exists(dri[m] + "Khmer_usb_locker.dat"))
                            {
                                try
                                {
                                    StreamReader read_1 = new StreamReader(dri[m] + "Khmer_usb_locker.dat");
                                    string sdf = Security.DecryptStringAES(read_1.ReadLine(), Class1.key_d);
                                    read_1.Close();
                                    if ("Kh_usb_locker" + u_ser == sdf)
                                    {
                                        success = 1;
                                        Class1.usb_inserted = 1;
                                        
                                        Class1.usb_inserted_name = dri[m];
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                }

                if (success == 0)
                {
                    tm_ctrl_USB_De.Enabled = false;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    frmmsg_no_com no_co = new frmmsg_no_com();
                    no_co.ShowDialog();
                    timer2.Enabled = true;
                    timer1.Enabled = true;
                    tm_ctrl_USB_De.Enabled = true;
                }
                else
                {
                    success = 0;
                    Class1.frm1_close_int = 1;
                    timer1.Enabled = false;
                   // timer2.Enabled = false;
                    Visible = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Space || e.KeyData == Keys.Escape)
            {
                timer1.Enabled = false;
                tm_ctrl_USB_De.Enabled = false;
                System.Threading.Thread.Sleep(100);
                frmLogin frmlogin = new frmLogin();
                frmlogin.ShowDialog();
            }

            tm_ctrl_USB_De.Enabled = true;
            if (Class1.frm1_close_int == 1)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                //Close();
                Visible = false;
                tm_auto_lock.Enabled = true;
                tm_ctrl_USB_De.Enabled = false;
            }
            else timer1.Enabled = true;
        }
        int xx = 0, yy = 0, count_tm = 0;
        private void tm_auto_lock_Tick(object sender, EventArgs e)
        {
            if (Control.MousePosition.X != xx || Control.MousePosition.Y != yy || Control.ModifierKeys != Keys.Attn)
            {
                xx = Control.MousePosition.X;
                yy = Control.MousePosition.Y;
                count_tm = 0;
            }
            else count_tm = count_tm + 1;

            if (Class1.setting_timer * 60 == count_tm)
            {
                Class1.frm1_close_int = 0;
                Class1.frm1.tm_ctrl_USB_De.Enabled = false;
                Class1.frm1.Visible = true;
                tm_auto_lock.Enabled = false;
                Class1.frm1.BackgroundImage = Image.FromFile(Class1.pwd_from_frm1[3]);
            }
        }
    }
}
