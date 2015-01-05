namespace PC_USB_Lock
{
    partial class frmPass_Chang
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.rbbPasschang = new System.Windows.Forms.RadioButton();
            this.rbbSe_Q = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN_pass_ag = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblQs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ពាក្យសម្ងាត់ចាស់";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "យល់ព្រម";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(171, 49);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(295, 32);
            this.txtOldPass.TabIndex = 0;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOldPass_KeyUp);
            // 
            // rbbPasschang
            // 
            this.rbbPasschang.AutoSize = true;
            this.rbbPasschang.Checked = true;
            this.rbbPasschang.Location = new System.Drawing.Point(12, 12);
            this.rbbPasschang.Name = "rbbPasschang";
            this.rbbPasschang.Size = new System.Drawing.Size(153, 29);
            this.rbbPasschang.TabIndex = 5;
            this.rbbPasschang.TabStop = true;
            this.rbbPasschang.Text = "ផ្លាស់ប្តូរពាក្យសម្ងាត់";
            this.rbbPasschang.UseVisualStyleBackColor = true;
            this.rbbPasschang.CheckedChanged += new System.EventHandler(this.rbbPasschang_CheckedChanged);
            // 
            // rbbSe_Q
            // 
            this.rbbSe_Q.AutoSize = true;
            this.rbbSe_Q.Location = new System.Drawing.Point(171, 12);
            this.rbbSe_Q.Name = "rbbSe_Q";
            this.rbbSe_Q.Size = new System.Drawing.Size(228, 29);
            this.rbbSe_Q.TabIndex = 6;
            this.rbbSe_Q.Text = "ផ្លាស់ប្តូរចម្លើយនៃសំនួរសុវត្ថិភាព";
            this.rbbSe_Q.UseVisualStyleBackColor = true;
            this.rbbSe_Q.CheckedChanged += new System.EventHandler(this.rbbSe_Q_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ពាក្យសម្ងាត់ថ្មី";
            // 
            // txtN_pass
            // 
            this.txtN_pass.Location = new System.Drawing.Point(171, 91);
            this.txtN_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN_pass.Name = "txtN_pass";
            this.txtN_pass.Size = new System.Drawing.Size(295, 32);
            this.txtN_pass.TabIndex = 1;
            this.txtN_pass.UseSystemPasswordChar = true;
            this.txtN_pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOldPass_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "បញ្ជាក់ពាក្យសម្ងាត់ថ្មី";
            // 
            // txtN_pass_ag
            // 
            this.txtN_pass_ag.Location = new System.Drawing.Point(171, 133);
            this.txtN_pass_ag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN_pass_ag.Name = "txtN_pass_ag";
            this.txtN_pass_ag.Size = new System.Drawing.Size(295, 32);
            this.txtN_pass_ag.TabIndex = 2;
            this.txtN_pass_ag.UseSystemPasswordChar = true;
            this.txtN_pass_ag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOldPass_KeyUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 175);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "បោះបង់";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblQs
            // 
            this.lblQs.AutoSize = true;
            this.lblQs.Location = new System.Drawing.Point(166, 52);
            this.lblQs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQs.Name = "lblQs";
            this.lblQs.Size = new System.Drawing.Size(119, 25);
            this.lblQs.TabIndex = 1;
            this.lblQs.Text = "ពាក្យសម្ងាត់ចាស់";
            // 
            // frmPass_Chang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 245);
            this.Controls.Add(this.rbbSe_Q);
            this.Controls.Add(this.rbbPasschang);
            this.Controls.Add(this.txtN_pass_ag);
            this.Controls.Add(this.txtN_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS System", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPass_Chang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ផ្លាស់ប្តូរប្រព័ន្ធសុវត្ថិភាព";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPass_Chang_FormClosing);
            this.Load += new System.EventHandler(this.frmPass_Chang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.RadioButton rbbPasschang;
        private System.Windows.Forms.RadioButton rbbSe_Q;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN_pass_ag;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblQs;
    }
}