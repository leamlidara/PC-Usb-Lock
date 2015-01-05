using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PC_USB_Lock
{
    public partial class frmShow_all_Usb : Form
    {
        public frmShow_all_Usb()
        {
            InitializeComponent();
        }

        int i = 0;
        private void frmShow_all_Usb_Load(object sender, EventArgs e)
        {
            if (Class1.usb_inserted == 1)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                if (Class1.frm1_close_int == 0) Close();
            }

            listView1.Items.Clear();

            if (Class1.pwd_from_frm1[4] != "")
            {
                TopMost = true;
                for (int a = 4; a < Class1.pwd_from_frm1.Length; a++)
                {
                    i++;
                    string pp = Class1.pwd_from_frm1[a];
                    listView1.Items.Add(i.ToString());
                    listView1.Items[i - 1].SubItems.Add(pp);
                }
                listView1.Items.RemoveAt(listView1.Items.Count-1);
            }
            else
            {
                frmMsg_no_Usb_Key usbkey = new frmMsg_no_Usb_Key();
                usbkey.ShowDialog();
                Close();
            }
        }


        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedIndices.Count.ToString() == "1")
                {
                    contextMenuStrip1.Show(listView1, new Point(e.X, e.Y));
                }
            }
        }

        private void បទToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        int b;
        private void លបToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.pwd = "";
            try
            {
                for (int a = 0; a < listView1.Items.Count; a++)
                {
                    if (listView1.Items[a].Text == listView1.SelectedItems[0].Text)
                    {
                        b = a;
                    }
                }

                listView1.Items.RemoveAt(b);

                for (int a = 0; a <= 3; a++)
                    Class1.pwd = Class1.pwd + Class1.pwd_from_frm1[a] + "æ";

                for (int a = 0; a < listView1.Items.Count; a++)
                    Class1.pwd = Class1.pwd + listView1.Items[a].SubItems[0].Text + "æ";
                
                StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys");
                write.Write(Security.EncryptStringAES(Class1.pwd, Class1.key_d));
                write.Close();

                Class1.pwd_from_frm1 = Class1.pwd.Split('æ');

                if (listView1.Items.Count <= 0) Close();
            }
            catch { }
        }
    }
}
