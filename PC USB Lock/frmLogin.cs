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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int i = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            click();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frm4getPass forgetpa = new frm4getPass();
            forgetpa.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                click();
            else if (e.KeyData == Keys.Escape) Close();
        }
        void click()
        {
            Class1.frm1_close_int = 0;
            USBSerialNumber s = new USBSerialNumber();

            errorProvider1.Clear();
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "សូមបញ្ចូលពាក្យសម្ងាត់ត្រង់ប្រអប់នេះ!");
            else
            {
                if (Class1.pwd_from_frm1[0] == textBox1.Text)
                {
                    Class1.frm1_close_int = 1;
                    Close();
                }
                else
                {
                    errorProvider1.SetError(textBox1, "ពាក្យសម្ងាត់មិនត្រឹមត្រូវ សូមសាកល្បងម្តងទៀត!");
                    i++;
                    textBox1.Focus();
                    textBox1.Text = "";
                }
                if (i == 3)
                    Close();
            }
        }
    }
}
