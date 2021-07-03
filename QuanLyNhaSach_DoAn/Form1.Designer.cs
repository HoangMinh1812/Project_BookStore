namespace QuanLyNhaSach_DoAn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbltendn = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.formsach = new System.Windows.Forms.ToolStripButton();
            this.formbanhang = new System.Windows.Forms.ToolStripButton();
            this.formquanlyhd = new System.Windows.Forms.ToolStripButton();
            this.formtaikhoan = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 3;
            // 
            // lbltendn
            // 
            this.lbltendn.AutoSize = true;
            this.lbltendn.Location = new System.Drawing.Point(634, 9);
            this.lbltendn.Name = "lbltendn";
            this.lbltendn.Size = new System.Drawing.Size(0, 13);
            this.lbltendn.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsach,
            this.formbanhang,
            this.formquanlyhd,
            this.formtaikhoan,
            this.label4,
            this.label2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(820, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // formsach
            // 
            this.formsach.Image = ((System.Drawing.Image)(resources.GetObject("formsach.Image")));
            this.formsach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formsach.Name = "formsach";
            this.formsach.Size = new System.Drawing.Size(98, 22);
            this.formsach.Text = "Quản Lý Sách";
            this.formsach.Click += new System.EventHandler(this.formsach_Click);
            // 
            // formbanhang
            // 
            this.formbanhang.Image = ((System.Drawing.Image)(resources.GetObject("formbanhang.Image")));
            this.formbanhang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formbanhang.Name = "formbanhang";
            this.formbanhang.Size = new System.Drawing.Size(77, 22);
            this.formbanhang.Text = "Bán hàng";
            this.formbanhang.Click += new System.EventHandler(this.formbanhang_Click);
            // 
            // formquanlyhd
            // 
            this.formquanlyhd.Image = ((System.Drawing.Image)(resources.GetObject("formquanlyhd.Image")));
            this.formquanlyhd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formquanlyhd.Name = "formquanlyhd";
            this.formquanlyhd.Size = new System.Drawing.Size(120, 22);
            this.formquanlyhd.Text = "Quản Lý Hóa Đơn";
            this.formquanlyhd.Click += new System.EventHandler(this.formquanlyhd_Click);
            // 
            // formtaikhoan
            // 
            this.formtaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("formtaikhoan.Image")));
            this.formtaikhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formtaikhoan.Name = "formtaikhoan";
            this.formtaikhoan.Size = new System.Drawing.Size(78, 22);
            this.formtaikhoan.Text = "Tài Khoản";
            this.formtaikhoan.Click += new System.EventHandler(this.formtaikhoan_Click);
            // 
            // label4
            // 
            this.label4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.Text = "toolStripLabel1";
            // 
            // label2
            // 
            this.label2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.Text = "toolStripLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbltendn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltendn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton formsach;
        private System.Windows.Forms.ToolStripButton formbanhang;
        private System.Windows.Forms.ToolStripButton formtaikhoan;
        private System.Windows.Forms.ToolStripLabel label4;
        private System.Windows.Forms.ToolStripLabel label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton formquanlyhd;

    }
}

