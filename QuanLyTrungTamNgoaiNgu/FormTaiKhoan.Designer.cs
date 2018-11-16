namespace QuanLyTrungTamNgoaiNgu
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Timtk = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.colLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.ucLoaiTaiKhoan = new UC.ucLoaiTaiKhoan();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label5.Location = new System.Drawing.Point(45, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên tài khoản:";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_TenTK.Location = new System.Drawing.Point(198, 67);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(200, 33);
            this.txt_TenTK.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label3.Location = new System.Drawing.Point(87, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mật khẩu:";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_matkhau.Location = new System.Drawing.Point(198, 128);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(200, 33);
            this.txt_matkhau.TabIndex = 30;
            // 
            // txt_Tim
            // 
            this.txt_Tim.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_Tim.Location = new System.Drawing.Point(93, 300);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(200, 33);
            this.txt_Tim.TabIndex = 28;
            // 
            // btn_Timtk
            // 
            this.btn_Timtk.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Timtk.Location = new System.Drawing.Point(299, 300);
            this.btn_Timtk.Name = "btn_Timtk";
            this.btn_Timtk.Size = new System.Drawing.Size(88, 33);
            this.btn_Timtk.TabIndex = 22;
            this.btn_Timtk.Text = "Tìm";
            this.btn_Timtk.UseVisualStyleBackColor = true;
            this.btn_Timtk.Click += new System.EventHandler(this.btn_Timtk_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Xoa.Location = new System.Drawing.Point(204, 246);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_Xoa.TabIndex = 26;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoatk_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Sua.Location = new System.Drawing.Point(114, 246);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 33);
            this.btn_Sua.TabIndex = 25;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Doimk_Click);
            // 
            // colLoaiTK
            // 
            this.colLoaiTK.DataPropertyName = "LoaiTK";
            this.colLoaiTK.HeaderText = "Loại tài khoản";
            this.colLoaiTK.Name = "colLoaiTK";
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.Name = "colMatKhau";
            // 
            // colTentk
            // 
            this.colTentk.DataPropertyName = "TenTK";
            this.colTentk.HeaderText = "Tên Tài khoản";
            this.colTentk.Name = "colTentk";
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTentk,
            this.colMatKhau,
            this.colLoaiTK});
            this.dgv_taikhoan.Location = new System.Drawing.Point(15, 352);
            this.dgv_taikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.RowHeadersWidth = 40;
            this.dgv_taikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_taikhoan.Size = new System.Drawing.Size(456, 181);
            this.dgv_taikhoan.TabIndex = 27;
            this.dgv_taikhoan.SelectionChanged += new System.EventHandler(this.dgv_taikhoan_SelectionChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Them.Location = new System.Drawing.Point(24, 246);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 33);
            this.btn_Them.TabIndex = 24;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Themtk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.ucLoaiTaiKhoan);
            this.grb.Controls.Add(this.btn_Luu);
            this.grb.Controls.Add(this.btn_Huy);
            this.grb.Controls.Add(this.txt_matkhau);
            this.grb.Controls.Add(this.label5);
            this.grb.Controls.Add(this.label1);
            this.grb.Controls.Add(this.txt_TenTK);
            this.grb.Controls.Add(this.btn_Them);
            this.grb.Controls.Add(this.dgv_taikhoan);
            this.grb.Controls.Add(this.label3);
            this.grb.Controls.Add(this.btn_Sua);
            this.grb.Controls.Add(this.btn_Xoa);
            this.grb.Controls.Add(this.btn_Timtk);
            this.grb.Controls.Add(this.txt_Tim);
            this.grb.Location = new System.Drawing.Point(155, 22);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(487, 547);
            this.grb.TabIndex = 36;
            this.grb.TabStop = false;
            // 
            // ucLoaiTaiKhoan
            // 
            this.ucLoaiTaiKhoan.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucLoaiTaiKhoan.LoaiTK = ".         ";
            this.ucLoaiTaiKhoan.Location = new System.Drawing.Point(133, 189);
            this.ucLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(6);
            this.ucLoaiTaiKhoan.Name = "ucLoaiTaiKhoan";
            this.ucLoaiTaiKhoan.Size = new System.Drawing.Size(265, 36);
            this.ucLoaiTaiKhoan.TabIndex = 38;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Luu.Location = new System.Drawing.Point(384, 246);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 33);
            this.btn_Luu.TabIndex = 37;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Huy.Location = new System.Drawing.Point(294, 246);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 33);
            this.btn_Huy.TabIndex = 36;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 599);
            this.Controls.Add(this.grb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Timtk;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTentk;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private UC.ucLoaiTaiKhoan ucLoaiTaiKhoan;

    }
}