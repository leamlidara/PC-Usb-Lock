using System;
using System.Collections.Generic;
using System.Text;

namespace PC_USB_Lock
{
    class Class1
    {
        public static byte key_ctrl_f4 = 0;
        public static string key_d = "LeamLidara_PC_USB_loCk3r";
        public static string pwd = "";
        public static byte frm1_close_int = 0;
        public static byte frm1_close_int_last = 0;
        public static byte close_all = 0;
        public static string[] pwd_from_frm1;
        public static byte usb_inserted = 0;
        public static string usb_inserted_name = "";
        public static string[] security_question = { "តើអ្នកកើតនៅថ្ងៃណា?", "តើទីកន្លៃងកំនើតរបស់អ្នកនៅឯណា?", "តើអ្នកចូលចិត្តញ៉ាំអ្វីជាងគេ?", "តើបងប្អូនប្រុសរបស់អ្នកឈ្មោះអ្វី?", "តើសង្សារគ្រាដំបូងរបស់អ្នកមានឈ្មោះអ្វី?", "តើអ្នកមានស្នេហាចំនួនប៉ុន្មានដងហើយ?" };
        public static byte pass4get = 0;
        public static Form1 frm1;
        public static frmStartUp frmStart;

        public static byte setting_auto_start;
        public static string setting_path = "";
        public static int setting_timer = 0;

        public static List<string> abb = new List<string>();
    }
}
