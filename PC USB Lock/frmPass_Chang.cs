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
    public partial class frmPass_Chang : Form
    {
        public frmPass_Chang()
        {
            InitializeComponent();
        }

        private void frmPass_Chang_Load(object sender, EventArgs e)
        {
            TopMost = true;
            if (Class1.pass4get == 1)
            {
                Class1.frm1.timer2.Enabled = false;
                rbbPasschang.Enabled = false;
                rbbSe_Q.Enabled = false;
                txtOldPass.Text = Class1.pwd_from_frm1[0];
                txtOldPass.ReadOnly = true;
                System.Threading.Thread.Sleep(100);
                txtN_pass.Text = "";
                txtN_pass.Focus();
                Class1.pass4get = 0;
            }
        }

        private void txtOldPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtOldPass.Focused == true)
                    txtN_pass.Focus();
                else if (txtN_pass.Focused == true)
                    txtN_pass_ag.Focus();
                else click();
            }
            else if (e.KeyData == Keys.Escape) Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPass_Chang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Class1.frm1.timer2.Enabled == false)
                Class1.frm1.timer2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click();
        }

        private void rbbPasschang_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "ពាក្យសម្ងាត់ចាស់";
            lblQs.Visible = false;
            txtOldPass.Visible = true;
            txtOldPass.Text = "";
            label2.Text = "ពាក្យសម្ងាត់ថ្មី";
            label3.Text = "បញ្ជាក់ពាក្យសម្ងាត់ថ្មី";
            txtN_pass.UseSystemPasswordChar = true;
            txtN_pass_ag.UseSystemPasswordChar = true;
        }

        private void rbbSe_Q_CheckedChanged(object sender, EventArgs e)
        {
            lblQs.Visible = true;
            lblQs.Text = Class1.security_question[int.Parse(Class1.pwd_from_frm1[1])];
            txtOldPass.Visible = false;
            label1.Text = "សំនួរសុវត្ថិភាព";
            label2.Text = "ចម្លើយចាស់";
            label3.Text = "ចម្លើយថ្មី";
            txtN_pass.UseSystemPasswordChar = false;
            txtN_pass_ag.UseSystemPasswordChar = false;
        }

        private void click()
        {
            errorProvider1.Clear();
            if (rbbPasschang.Checked)
            {
                if (txtOldPass.Text == Class1.pwd_from_frm1[0])
                {
                    if (txtN_pass.Text == txtN_pass_ag.Text)
                    {
                        Class1.pwd_from_frm1[0] = txtN_pass_ag.Text.Trim();
                        Class1.pwd = "";
                        for (int a = 0; a < Class1.pwd_from_frm1.Length - 1; a++)
                            Class1.pwd = Class1.pwd + Class1.pwd_from_frm1[a] + "æ";

                        StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys");
                        write.Write(Security.EncryptStringAES(Class1.pwd, Class1.key_d));
                        write.Close();
                        Close();

                        Class1.pwd_from_frm1=Class1.pwd.Split('æ');
                    }
                    else { txtN_pass_ag.Focus(); errorProvider1.SetError(txtN_pass_ag, "ពាក្យសម្ងាត់ដែលបានបញ្ជាក់មិនត្រឹមត្រូវ"); }
                }
                else { txtOldPass.Focus(); errorProvider1.SetError(txtOldPass, "សូមអភ័យទោស ពាក្យសម្ងាត់ដែលលោកអ្នកបញ្ចូលមិនត្រឹមត្រូវ"); }
            }
            else if (rbbSe_Q.Checked)
            {
                    if (txtN_pass.Text == Class1.pwd_from_frm1[2])
                    {
                        if (txtN_pass_ag.Text != "")
                        {
                            Class1.pwd_from_frm1[2] = txtN_pass_ag.Text.Trim();
                            Class1.pwd = "";
                            for (int a = 0; a < Class1.pwd_from_frm1.Length - 1; a++)
                                Class1.pwd = Class1.pwd + Class1.pwd_from_frm1[a] + "æ";

                            StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\windows_Lock.sys");
                            write.Write(Security.EncryptStringAES(Class1.pwd, Class1.key_d));
                            write.Close();
                            Close();

                            Class1.pwd_from_frm1 = Class1.pwd.Split('æ');
                        }
                        else { txtN_pass_ag.Focus(); errorProvider1.SetError(txtN_pass_ag, "សូមបញ្ចូលចម្លើយ"); }
                }
                else { txtOldPass.Focus(); errorProvider1.SetError(txtN_pass, "សូមអភ័យទោស ចម្លើយដែលលោកអ្នកបញ្ចូលមិនត្រឹមត្រូវ"); }
            }
        }
    }
}
