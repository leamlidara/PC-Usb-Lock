namespace PC_USB_Lock
{
    partial class frmShow_all_Usb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShow_all_Usb));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.លបToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.បទToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Khmer OS System", 9.25F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 291);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "លេខរៀង";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "លេខសេរ៊ី";
            this.columnHeader1.Width = 241;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ផ្សេងៗ";
            this.columnHeader2.Width = 152;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.លបToolStripMenuItem,
            this.បទToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 56);
            // 
            // លបToolStripMenuItem
            // 
            this.លបToolStripMenuItem.Name = "លបToolStripMenuItem";
            this.លបToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.លបToolStripMenuItem.Text = "លុប";
            this.លបToolStripMenuItem.Click += new System.EventHandler(this.លបToolStripMenuItem_Click);
            // 
            // បទToolStripMenuItem
            // 
            this.បទToolStripMenuItem.Name = "បទToolStripMenuItem";
            this.បទToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.បទToolStripMenuItem.Text = "បិទ";
            this.បទToolStripMenuItem.Click += new System.EventHandler(this.បទToolStripMenuItem_Click);
            // 
            // frmShow_all_Usb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 291);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShow_all_Usb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បញ្ជី USB ដែលជាកូនសោរ";
            this.Load += new System.EventHandler(this.frmShow_all_Usb_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem លបToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem បទToolStripMenuItem;
    }
}