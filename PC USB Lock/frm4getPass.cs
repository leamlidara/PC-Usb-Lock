using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PC_USB_Lock
{
    public partial class frm4getPass : Form
    {
        public frm4getPass()
        {
            InitializeComponent();
        }

        private void frm4getPass_Load(object sender, EventArgs e)
        {
            TopMost = true;
            lblSecu_q.Text = Class1.security_question[int.Parse(Class1.pwd_from_frm1[1])];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                click();

        }

        void click()
        {
            errorProvider1.Clear();
            if (textBox1.Text.Trim() != Class1.pwd_from_frm1[2])
            {
                errorProvider1.SetError(textBox1, "ចម្លើយមិនត្រឹមត្រូវ សូមព្យាយាមឆ្លើយម្តងទៀត");
            }
            else
            {
                Class1.pass4get = 1;
                frmPass_Chang passch = new frmPass_Chang();
                passch.ShowDialog();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
