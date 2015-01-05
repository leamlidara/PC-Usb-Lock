using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace PC_USB_Lock
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 32))
                e.Handled = true;
             if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                if (int.Parse(textBox2.Text) <= 30 && int.Parse(textBox2.Text) >= 1)
                    click_();
                else MessageBox.Show("អនុញ្ញាតឱ្យតែចំនួនដែលធំជាង 1 តែតូចជាង 30 ប៉ុននោះ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        byte press_pic = 0;
        string _name_pic;

        private void button3_Click(object sender, EventArgs e)
        {
            click_();
        }

        string path_to;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_to = Class1.setting_path + "\\image";
                if (Directory.Exists(path_to) == false) Directory.CreateDirectory(path_to);
                textBox1.Text = openFileDialog1.FileName;
                press_pic = 1;
            }
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            if (Class1.usb_inserted == 1)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                if (Class1.frm1_close_int == 0) Close();
            }

            if (Class1.setting_auto_start == 1) checkBox1.Checked = true;
            else checkBox1.Checked = false;
            textBox2.Text = Class1.setting_timer.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) Class1.setting_auto_start = 1;
            else Class1.setting_auto_start = 0;
        }

        void click_()
        {
            if (press_pic == 1)
            {
                string[] ss = Class1.pwd_from_frm1[3].Split('\\');

                if (ss[ss.Length - 1] == "Default.jpg") _name_pic = "Default_1.jpg";
                else if (ss[ss.Length - 1] == "Default_1.jpg") _name_pic = "Default_2.jpg";
                else if (ss[ss.Length - 1] == "Default_2.jpg") _name_pic = "Default_3.jpg";
                else if (ss[ss.Length - 1] == "Default_3.jpg") _name_pic = "Default_4.jpg";
                else if (ss[ss.Length - 1] == "Default_4.jpg") _name_pic = "Default_5.jpg";
                else if (ss[ss.Length - 1] == "Default_5.jpg") _name_pic = "Default.jpg";

                System.IO.File.Copy(openFileDialog1.FileName, path_to + "\\" + _name_pic, true);

                Class1.pwd_from_frm1[3] = path_to + "\\" + _name_pic;
                Class1.frm1.BackgroundImage = Image.FromFile(Class1.pwd_from_frm1[3]);
                Class1.pwd = "";
                for (int a = 0; a < Class1.pwd_from_frm1.Length - 1; a++)
                    Class1.pwd = Class1.pwd + Class1.pwd_from_frm1[a] + "æ";

                StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys");
                write.Write(Security.EncryptStringAES(Class1.pwd, Class1.key_d));
                write.Close();
                Close();

                Class1.pwd_from_frm1 = Class1.pwd.Split('æ');
                Class1.frm1.BackgroundImage = Image.FromFile(Class1.pwd_from_frm1[3]);
                press_pic = 0;
                foreach (var ppic in Directory.GetFiles(path_to))
                    try
                    {
                        System.IO.File.Delete(ppic);
                    }
                    catch { }
            }

            StreamWriter write1 = new StreamWriter(Class1.setting_path + "\\setting.dll");
            write1.Write(Class1.setting_auto_start.ToString() + "|" + textBox2.Text);
            write1.Close();

            Class1.setting_timer = int.Parse(textBox2.Text);

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
            else
            {
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Khmer_USB_locker.lnk")) System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Khmer_USB_locker.lnk");
            }
            Close();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) <= 30 && int.Parse(textBox2.Text) >= 1) { }
            else
            {
                MessageBox.Show("អនុញ្ញាតឱ្យតែចំនួនដែលធំជាង 1 តែតូចជាង 30 ប៉ុននោះ!");
                if (int.Parse(textBox2.Text) > 30)
                    textBox2.Text = "30";
                else if (int.Parse(textBox2.Text) < 0)
                    textBox2.Text = "1";
            }
            
        }
    }
}
