using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PC_USB_Lock
{
    public partial class frmCreatePass : Form
    {
        public frmCreatePass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                proces();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                if (txtpass.Focused == true) txtpass_aga.Focus();
                else if (txtpass_aga.Focused == true) cbbQuestion.Focus();
                else if (cbbQuestion.Focused == true) textBox1.Focus();
                else if (textBox1.Focused == true) proces();
            }
        }

        protected void proces()
        {
            errorProvider1.Clear();
            if (txtpass.Text == "")
                errorProvider1.SetError(txtpass, "សូមបញ្ចូលពាក្យសម្ងាត់");
            else if (txtpass.Text != txtpass_aga.Text)
                errorProvider1.SetError(txtpass_aga, "ការបញ្ជាក់លេខសម្ងាត់មិនត្រឹមត្រូវ សូមមេត្តាសាកល្បងម្តងទៀត");
            else if (cbbQuestion.Text == "")
                errorProvider1.SetError(cbbQuestion, "សូមជ្រើសរើសសំនួរ");
            else if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "សូមបញ្ចូលចម្លើយ");
            else
            {
                string pat = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                string avb = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Khmer_USB_locker\\image\\Default.jpg";
                StreamWriter write = new StreamWriter(pat + "\\windows_Lock.sys");
                write.Write(Security.EncryptStringAES(txtpass_aga.Text.Trim() + "æ" + cbbQuestion.SelectedIndex.ToString() + "æ" + textBox1.Text.Trim() + "æ" + avb + "æ", Class1.key_d));
                write.Close();
                Close();
            }
        }

        private void frmCreatePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtpass.Text != txtpass_aga.Text || txtpass_aga.Text == "" || txtpass.Text == "" || textBox1.Text == "" || cbbQuestion.Text == "")
                Class1.close_all = 1;
        }

        private void frmCreatePass_Load(object sender, EventArgs e)
        {
            for (int a = 0; a < Class1.security_question.Length; a++)
                cbbQuestion.Items.Add(Class1.security_question[a]);
        }
    }
}
