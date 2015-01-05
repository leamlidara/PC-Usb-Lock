using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PC_USB_Lock
{
    public partial class frm_about : Form
    {
        public frm_about()
        {
            InitializeComponent();
        }

        string a1 = "សូមអគុណសម្រាប់ការគាំទ្រ និងប្រើប្រាស់កម្មវិធីជាភាសាខ្មែរ";
        string a2 = "សូមចូលរួមលើកស្ទួយភាសាខ្មែរដោយការប្រើប្រាស់ និងបង្កើត";
        string a3 = "កម្មវិធី ឬគេហទំព័រដែលជាភាសាខ្មែរ។";
        string a4 = "យើងខ្ញុំរង់ចាំទទួលមតិរិះគន់ក្នុងន័យស្ថាបនារបស់លោកអ្នក";
        string a5 = "ដើម្បីកែប្រែ និងស្ថាបនាកម្មវិធីកុំព្យូទ័រដែលជាភាសាខ្មែរ។";
        //string a6 = "យើងខ្ញុំនឹងខិតខំថែមទៀតដើម្បីបង្កើតកម្មវិធីដែលជាភាសាខ្មែរ";
        //string a7 = "បំណង់ចង់ឱ្យប្រជាជនខ្មែរមានកម្មវិធីកុំព្យូទ័រដែលជាភាសារ";
        //string a8 = "របស់ខ្លួន។";
        int line = 1;
        int cu = 0;
        int f = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (line == 1)
            {
                int lett = a1.Length;
                l1.Text = l1.Text + a1[cu].ToString();
                if (cu >= a1.Length - 1) { line++; cu = 0; f = 1; }
            }
            else if (line == 2)
            {
                if (f == 1) { cu--; f = 2; }
                int lett = a2.Length;
                l2.Text = l2.Text + a2[cu].ToString();
                if (cu >= a2.Length - 1) { line++; cu = 0; f = 1; }
            }
            else if (line == 3)
            {
                if (f == 1) { cu--; f = 2; }
                int lett = a3.Length;
                l3.Text = l3.Text + a3[cu].ToString();
                if (cu >= a3.Length - 1) { line++; cu = 0; f = 1; }
            }
            else if (line == 4)
            {
                if (f == 1) { cu--; f = 2; }
                int lett = a4.Length;
                l4.Text = l4.Text + a4[cu].ToString();
                if (cu >= a4.Length - 1) { line++; cu = 0; f = 1; }
            }
            else if (line == 5)
            {
                if (f == 1) { cu--; f = 2; }
                int lett = a5.Length;
                l5.Text = l5.Text + a5[cu].ToString();
                if (cu >= a5.Length - 1) { line++; cu = 0; f = 1; }
            }
            if (line >= 6)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                b = 0;
            }
            //else if (line == 6)
            //{
            //    if (f == 1) { cu--; f = 2; }
            //    int lett = a6.Length;
            //    l6.Text = l6.Text + a2[cu].ToString();
            //    if (cu >= a6.Length - 1) { line++; cu = 0; f = 1; }
            //}
            //else if (line == 7)
            //{
            //    if (f == 1) { cu--; f = 2; }
            //    int lett = a7.Length;
            //    l7.Text = l7.Text + a7[cu].ToString();
            //    if (cu >= a7.Length - 1) { line++; cu = 0; f = 1; }
            //}
            //else if (line == 8)
            //{
            //    if (f == 1) { cu--; f = 2; }
            //    int lett = a8.Length;
            //    l8.Text = a8[cu].ToString();
            //    if (cu >= a8.Length - 1) { line = 1; cu = 0; f = 1; }
            //}
            cu++;
        }

        private void frm_about_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(a1.Length.ToString());
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            l5.Text = "";
            l6.Text = "";
            l7.Text = "";
            l8.Text = "";
            
        }

        int b = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            b = b + 1;
            if (b >= 100)
            {
                timer2.Enabled = false; timer1.Enabled = true;
                line = 1; cu = 0; f = 1;
                l1.Text = "";
                l2.Text = "";
                l3.Text = "";
                l4.Text = "";
                l5.Text = "";
                l6.Text = "";
                l7.Text = "";
                l8.Text = "";
            }
        }
    }
}
