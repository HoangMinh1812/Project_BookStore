namespace QuanLyNhaSach_DoAn
{
    partial class FormTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.datagridViewQLNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.lbltenuser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.btnSaThai = new System.Windows.Forms.Button();
            this.groupBoxBaoMat = new System.Windows.Forms.GroupBox();
            this.txtnewmkxn = new System.Windows.Forms.TextBox();
            this.txtnewmk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btndoimk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewQLNV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxBaoMat.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridViewQLNV
            // 
            this.datagridViewQLNV.AllowUserToAddRows = false;
            this.datagridViewQLNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridViewQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.datagridViewQLNV.Location = new System.Drawing.Point(6, 21);
            this.datagridViewQLNV.Name = "datagridViewQLNV";
            this.datagridViewQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewQLNV.Size = new System.Drawing.Size(420, 265);
            this.datagridViewQLNV.TabIndex = 2;
            this.datagridViewQLNV.SelectionChanged += new System.EventHandler(this.dataGridViewqlnv_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tknhanvien";
            this.Column1.HeaderText = "Tên TK";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "matkhau";
            dataGridViewCellStyle3.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hotennhanvien";
            this.Column3.HeaderText = "Họ và tên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gioitinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaysinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "diachi";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthoat,
            this.lbltenuser,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(832, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthoat
            // 
            this.btnthoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnthoat.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(83, 24);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lbltenuser
            // 
            this.lbltenuser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbltenuser.ForeColor = System.Drawing.Color.Maroon;
            this.lbltenuser.Name = "lbltenuser";
            this.lbltenuser.Size = new System.Drawing.Size(24, 24);
            this.lbltenuser.Text = "tên";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 24);
            this.toolStripLabel2.Text = "Xin chào";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.btnSaThai);
            this.groupBox1.Controls.Add(this.datagridViewQLNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 333);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nhân Viên";
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(330, 286);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(96, 47);
            this.btnluu.TabIndex = 6;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(155, 292);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(55, 35);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(18, 295);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(51, 16);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "label1";
            // 
            // btnSaThai
            // 
            this.btnSaThai.Image = ((System.Drawing.Image)(resources.GetObject("btnSaThai.Image")));
            this.btnSaThai.Location = new System.Drawing.Point(228, 292);
            this.btnSaThai.Name = "btnSaThai";
            this.btnSaThai.Size = new System.Drawing.Size(54, 35);
            this.btnSaThai.TabIndex = 3;
            this.btnSaThai.UseVisualStyleBackColor = true;
            this.btnSaThai.Click += new System.EventHandler(this.btnsathai_Click);
            // 
            // groupBoxBaoMat
            // 
            this.groupBoxBaoMat.Controls.Add(this.txtnewmkxn);
            this.groupBoxBaoMat.Controls.Add(this.txtnewmk);
            this.groupBoxBaoMat.Controls.Add(this.txtmk);
            this.groupBoxBaoMat.Controls.Add(this.txtten);
            this.groupBoxBaoMat.Controls.Add(this.btndoimk);
            this.groupBoxBaoMat.Controls.Add(this.label5);
            this.groupBoxBaoMat.Controls.Add(this.label4);
            this.groupBoxBaoMat.Controls.Add(this.label3);
            this.groupBoxBaoMat.Controls.Add(this.label2);
            this.groupBoxBaoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBaoMat.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBoxBaoMat.Location = new System.Drawing.Point(492, 31);
            this.groupBoxBaoMat.Name = "groupBoxBaoMat";
            this.groupBoxBaoMat.Size = new System.Drawing.Size(321, 333);
            this.groupBoxBaoMat.TabIndex = 7;
            this.groupBoxBaoMat.TabStop = false;
            this.groupBoxBaoMat.Text = "Bảo mật";
            // 
            // txtnewmkxn
            // 
            this.txtnewmkxn.Location = new System.Drawing.Point(148, 172);
            this.txtnewmkxn.Name = "txtnewmkxn";
            this.txtnewmkxn.PasswordChar = '*';
            this.txtnewmkxn.Size = new System.Drawing.Size(148, 24);
            this.txtnewmkxn.TabIndex = 8;
            // 
            // txtnewmk
            // 
            this.txtnewmk.Location = new System.Drawing.Point(148, 130);
            this.txtnewmk.Name = "txtnewmk";
            this.txtnewmk.PasswordChar = '*';
            this.txtnewmk.Size = new System.Drawing.Size(148, 24);
            this.txtnewmk.TabIndex = 7;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(148, 85);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(148, 24);
            this.txtmk.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(148, 41);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(148, 24);
            this.txtten.TabIndex = 5;
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(22, 253);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(274, 47);
            this.btndoimk.TabIndex = 4;
            this.btndoimk.Text = "Đổi mật khẩu";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 376);
            this.Controls.Add(this.groupBoxBaoMat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQLyNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormQLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewQLNV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBaoMat.ResumeLayout(false);
            this.groupBoxBaoMat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridViewQLNV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.ToolStripLabel lbltenuser;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button btnSaThai;
        private System.Windows.Forms.GroupBox groupBoxBaoMat;
        private System.Windows.Forms.TextBox txtnewmkxn;
        private System.Windows.Forms.TextBox txtnewmk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}