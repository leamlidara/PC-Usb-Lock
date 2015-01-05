namespace PC_USB_Lock
{
    partial class frmStartUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartUp));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ចកសរឡងវញToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ផលសបតរពកយសមងតToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.បងកតឯកសរសមរបUSBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.បងហញUSBទងអសToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ករកណតToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.អពកមមវធToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.បទកមមវធToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tm_ctrl_timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "យល់ព្រម";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "សូមជ្រើសរើស USB ដែលអ្នកចង់យកវាធ្វើជាសោរ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "សម្រាប់ប្រើប្រាស់កុំព្យូទ័រនេះជំនួស ពាក្យសម្ងាត់";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "អ្នកការពារកុំព្យូទ័រ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ចកសរឡងវញToolStripMenuItem,
            this.toolStripSeparator2,
            this.ផលសបតរពកយសមងតToolStripMenuItem,
            this.បងកតឯកសរសមរបUSBToolStripMenuItem,
            this.បងហញUSBទងអសToolStripMenuItem,
            this.ករកណតToolStripMenuItem,
            this.toolStripSeparator3,
            this.អពកមមវធToolStripMenuItem,
            this.toolStripSeparator1,
            this.បទកមមវធToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 204);
            // 
            // ចកសរឡងវញToolStripMenuItem
            // 
            this.ចកសរឡងវញToolStripMenuItem.Name = "ចកសរឡងវញToolStripMenuItem";
            this.ចកសរឡងវញToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ចកសរឡងវញToolStripMenuItem.Text = "ចាក់សោរឡើងវិញ";
            this.ចកសរឡងវញToolStripMenuItem.Click += new System.EventHandler(this.ចកសរឡងវញToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // ផលសបតរពកយសមងតToolStripMenuItem
            // 
            this.ផលសបតរពកយសមងតToolStripMenuItem.Image = global::PC_USB_Lock.Properties.Resources.keychain_access;
            this.ផលសបតរពកយសមងតToolStripMenuItem.Name = "ផលសបតរពកយសមងតToolStripMenuItem";
            this.ផលសបតរពកយសមងតToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ផលសបតរពកយសមងតToolStripMenuItem.Text = "ផ្លាស់ប្តូរពាក្យសម្ងាត់";
            this.ផលសបតរពកយសមងតToolStripMenuItem.Click += new System.EventHandler(this.ផលសបតរពកយសមងតToolStripMenuItem_Click);
            // 
            // បងកតឯកសរសមរបUSBToolStripMenuItem
            // 
            this.បងកតឯកសរសមរបUSBToolStripMenuItem.Image = global::PC_USB_Lock.Properties.Resources.Flash_Drive_icon;
            this.បងកតឯកសរសមរបUSBToolStripMenuItem.Name = "បងកតឯកសរសមរបUSBToolStripMenuItem";
            this.បងកតឯកសរសមរបUSBToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.បងកតឯកសរសមរបUSBToolStripMenuItem.Text = "បង្កើតឯកសារកូនសោរ USB";
            this.បងកតឯកសរសមរបUSBToolStripMenuItem.Click += new System.EventHandler(this.បងកតឯកសរសមរបUSBToolStripMenuItem_Click);
            // 
            // បងហញUSBទងអសToolStripMenuItem
            // 
            this.បងហញUSBទងអសToolStripMenuItem.Image = global::PC_USB_Lock.Properties.Resources.USBFlashCardWithCardReader2;
            this.បងហញUSBទងអសToolStripMenuItem.Name = "បងហញUSBទងអសToolStripMenuItem";
            this.បងហញUSBទងអសToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.បងហញUSBទងអសToolStripMenuItem.Text = "បង្ហាញ USB ទាំងអស់";
            this.បងហញUSBទងអសToolStripMenuItem.Click += new System.EventHandler(this.បងហញUSBទងអសToolStripMenuItem_Click);
            // 
            // ករកណតToolStripMenuItem
            // 
            this.ករកណតToolStripMenuItem.Image = global::PC_USB_Lock.Properties.Resources.sett2;
            this.ករកណតToolStripMenuItem.Name = "ករកណតToolStripMenuItem";
            this.ករកណតToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ករកណតToolStripMenuItem.Text = "ការកំណត់";
            this.ករកណតToolStripMenuItem.Click += new System.EventHandler(this.ករកណតToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
            // 
            // អពកមមវធToolStripMenuItem
            // 
            this.អពកមមវធToolStripMenuItem.Image = global::PC_USB_Lock.Properties.Resources.user_anonymous_icon;
            this.អពកមមវធToolStripMenuItem.Name = "អពកមមវធToolStripMenuItem";
            this.អពកមមវធToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.អពកមមវធToolStripMenuItem.Text = "អំពីកម្មវិធី";
            this.អពកមមវធToolStripMenuItem.Click += new System.EventHandler(this.អពកមមវធToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // បទកមមវធToolStripMenuItem
            // 
            this.បទកមមវធToolStripMenuItem.Image = global::PC_USB_Lock.Properties.Resources.Error;
            this.បទកមមវធToolStripMenuItem.Name = "បទកមមវធToolStripMenuItem";
            this.បទកមមវធToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.បទកមមវធToolStripMenuItem.Text = "បិទកម្មវិធី";
            this.បទកមមវធToolStripMenuItem.Click += new System.EventHandler(this.បទកមមវធToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tm_ctrl_timer1
            // 
            this.tm_ctrl_timer1.Interval = 1;
            this.tm_ctrl_timer1.Tick += new System.EventHandler(this.tm_ctrl_timer1_Tick);
            // 
            // frmStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Khmer OS System", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStartUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បង្កើតសោរ USB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStartUp_FormClosing);
            this.Load += new System.EventHandler(this.frmStartUp_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem បទកមមវធToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem បងកតឯកសរសមរបUSBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ផលសបតរពកយសមងតToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem បងហញUSBទងអសToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចកសរឡងវញToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tm_ctrl_timer1;
        private System.Windows.Forms.ToolStripMenuItem ករកណតToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem អពកមមវធToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}