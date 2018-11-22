namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormKhoaHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hocphi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_ThemKhoaHoc = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.dgv_khoahoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ucCaHoc = new UC.ucCaHoc();
            this.ucPhongHoc = new UC.ucPhongHoc();
            this.ucKhoaHoc = new UC.ucKhoaHoc();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThemChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khóa học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(641, 202);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(199, 33);
            this.dtp_ngaybatdau.TabIndex = 8;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(202, 98);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(199, 33);
            this.txt_tenkh.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên khóa học:";
            // 
            // txt_hocphi
            // 
            this.txt_hocphi.Location = new System.Drawing.Point(202, 144);
            this.txt_hocphi.Name = "txt_hocphi";
            this.txt_hocphi.Size = new System.Drawing.Size(199, 33);
            this.txt_hocphi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Học Phí:";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(345, 284);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(225, 33);
            this.txt_tim.TabIndex = 13;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(573, 284);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 33);
            this.btn_tim.TabIndex = 14;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_ThemKhoaHoc
            // 
            this.btn_ThemKhoaHoc.Location = new System.Drawing.Point(62, 331);
            this.btn_ThemKhoaHoc.Name = "btn_ThemKhoaHoc";
            this.btn_ThemKhoaHoc.Size = new System.Drawing.Size(178, 44);
            this.btn_ThemKhoaHoc.TabIndex = 15;
            this.btn_ThemKhoaHoc.Text = "Thêm khóa học";
            this.btn_ThemKhoaHoc.UseVisualStyleBackColor = true;
            this.btn_ThemKhoaHoc.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(429, 331);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 44);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(542, 331);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 44);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(653, 331);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(94, 44);
            this.btn_huy.TabIndex = 18;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(765, 331);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(94, 44);
            this.btn_luu.TabIndex = 19;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // dgv_khoahoc
            // 
            this.dgv_khoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khoahoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_khoahoc.Location = new System.Drawing.Point(62, 395);
            this.dgv_khoahoc.Name = "dgv_khoahoc";
            this.dgv_khoahoc.Size = new System.Drawing.Size(802, 334);
            this.dgv_khoahoc.TabIndex = 20;
            this.dgv_khoahoc.SelectionChanged += new System.EventHandler(this.dgv_khoahoc_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã Khóa học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khóa học";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MoTa";
            this.Column3.HeaderText = "Mô tả";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HocPhi";
            this.Column4.HeaderText = "Học phí";
            this.Column4.Name = "Column4";
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(202, 189);
            this.txt_Mota.Multiline = true;
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(199, 59);
            this.txt_Mota.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mô tả:";
            // 
            // ucCaHoc
            // 
            this.ucCaHoc.CaHoc = "CA01";
            this.ucCaHoc.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucCaHoc.Location = new System.Drawing.Point(552, 155);
            this.ucCaHoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ucCaHoc.Name = "ucCaHoc";
            this.ucCaHoc.Size = new System.Drawing.Size(290, 33);
            this.ucCaHoc.TabIndex = 23;
            // 
            // ucPhongHoc
            // 
            this.ucPhongHoc.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucPhongHoc.Location = new System.Drawing.Point(557, 103);
            this.ucPhongHoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ucPhongHoc.Name = "ucPhongHoc";
            this.ucPhongHoc.PhongHoc = "F1.1";
            this.ucPhongHoc.Size = new System.Drawing.Size(285, 36);
            this.ucPhongHoc.TabIndex = 24;
            // 
            // ucKhoaHoc
            // 
            this.ucKhoaHoc.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucKhoaHoc.KhoaHoc = "0";
            this.ucKhoaHoc.Location = new System.Drawing.Point(639, 53);
            this.ucKhoaHoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ucKhoaHoc.Name = "ucKhoaHoc";
            this.ucKhoaHoc.Size = new System.Drawing.Size(202, 34);
            this.ucKhoaHoc.TabIndex = 25;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(202, 55);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(199, 33);
            this.txt_MaKH.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã Khóa học:";
            // 
            // btn_ThemChiTiet
            // 
            this.btn_ThemChiTiet.Location = new System.Drawing.Point(245, 331);
            this.btn_ThemChiTiet.Name = "btn_ThemChiTiet";
            this.btn_ThemChiTiet.Size = new System.Drawing.Size(178, 44);
            this.btn_ThemChiTiet.TabIndex = 28;
            this.btn_ThemChiTiet.Text = "Thêm chi tiết";
            this.btn_ThemChiTiet.UseVisualStyleBackColor = true;
            // 
            // FormKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 741);
            this.Controls.Add(this.btn_ThemChiTiet);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucKhoaHoc);
            this.Controls.Add(this.ucPhongHoc);
            this.Controls.Add(this.ucCaHoc);
            this.Controls.Add(this.txt_Mota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_khoahoc);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_ThemKhoaHoc);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.txt_hocphi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_ngaybatdau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormKhoaHoc";
            this.Text = "FormKhoaHoc";
            this.Load += new System.EventHandler(this.ForKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_ngaybatdau;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hocphi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_ThemKhoaHoc;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridView dgv_khoahoc;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private UC.ucCaHoc ucCaHoc;
        private UC.ucPhongHoc ucPhongHoc;
        private UC.ucKhoaHoc ucKhoaHoc;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThemChiTiet;
    }
}