using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PC_USB_Lock
{
    public partial class frmmsg_no_com : Form
    {
        public frmmsg_no_com()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmmsg_no_com_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
