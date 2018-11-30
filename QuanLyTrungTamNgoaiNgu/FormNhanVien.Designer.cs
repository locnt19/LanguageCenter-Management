namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormNhanVien
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
            this.grb_Thongtin = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Luong = new System.Windows.Forms.TextBox();
            this.txt_HeSoLuong = new System.Windows.Forms.TextBox();
            this.ucChucVu = new UC.ucChucVu();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.ucThongTinNV = new UC.ucThongTinCoBan();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_Thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Thongtin
            // 
            this.grb_Thongtin.Controls.Add(this.btn_luu);
            this.grb_Thongtin.Controls.Add(this.label5);
            this.grb_Thongtin.Controls.Add(this.dtp_NgayVaoLam);
            this.grb_Thongtin.Controls.Add(this.btn_huy);
            this.grb_Thongtin.Controls.Add(this.label4);
            this.grb_Thongtin.Controls.Add(this.txt_TenTK);
            this.grb_Thongtin.Controls.Add(this.btn_sua);
            this.grb_Thongtin.Controls.Add(this.label3);
            this.grb_Thongtin.Controls.Add(this.btn_xoa);
            this.grb_Thongtin.Controls.Add(this.btn_them);
            this.grb_Thongtin.Controls.Add(this.txt_MaNV);
            this.grb_Thongtin.Controls.Add(this.label2);
            this.grb_Thongtin.Controls.Add(this.label1);
            this.grb_Thongtin.Controls.Add(this.txt_Luong);
            this.grb_Thongtin.Controls.Add(this.txt_HeSoLuong);
            this.grb_Thongtin.Controls.Add(this.ucChucVu);
            this.grb_Thongtin.Controls.Add(this.btn_Tim);
            this.grb_Thongtin.Controls.Add(this.txt_Tim);
            this.grb_Thongtin.Controls.Add(this.ucThongTinNV);
            this.grb_Thongtin.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.grb_Thongtin.Location = new System.Drawing.Point(22, 10);
            this.grb_Thongtin.Name = "grb_Thongtin";
            this.grb_Thongtin.Size = new System.Drawing.Size(910, 416);
            this.grb_Thongtin.TabIndex = 10;
            this.grb_Thongtin.TabStop = false;
            this.grb_Thongtin.Text = "Thông tin";
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(784, 292);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 33);
            this.btn_luu.TabIndex = 35;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày vào làm:";
            // 
            // dtp_NgayVaoLam
            // 
            this.dtp_NgayVaoLam.Location = new System.Drawing.Point(504, 296);
            this.dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            this.dtp_NgayVaoLam.Size = new System.Drawing.Size(200, 33);
            this.dtp_NgayVaoLam.TabIndex = 28;
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(784, 229);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 33);
            this.btn_huy.TabIndex = 34;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên TK:";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Location = new System.Drawing.Point(504, 37);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(200, 33);
            this.txt_TenTK.TabIndex = 26;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(784, 165);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 33);
            this.btn_sua.TabIndex = 33;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã NV:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(784, 100);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_xoa.TabIndex = 32;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(784, 37);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 33);
            this.btn_them.TabIndex = 31;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(152, 362);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(200, 33);
            this.txt_MaNV.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "HS lương:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lương:";
            // 
            // txt_Luong
            // 
            this.txt_Luong.Location = new System.Drawing.Point(504, 101);
            this.txt_Luong.Name = "txt_Luong";
            this.txt_Luong.Size = new System.Drawing.Size(200, 33);
            this.txt_Luong.TabIndex = 19;
            // 
            // txt_HeSoLuong
            // 
            this.txt_HeSoLuong.Location = new System.Drawing.Point(504, 165);
            this.txt_HeSoLuong.Name = "txt_HeSoLuong";
            this.txt_HeSoLuong.Size = new System.Drawing.Size(200, 33);
            this.txt_HeSoLuong.TabIndex = 18;
            // 
            // ucChucVu
            // 
            this.ucChucVu.ChucVu = "GV";
            this.ucChucVu.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucChucVu.Location = new System.Drawing.Point(400, 229);
            this.ucChucVu.Margin = new System.Windows.Forms.Padding(6);
            this.ucChucVu.Name = "ucChucVu";
            this.ucChucVu.Size = new System.Drawing.Size(304, 36);
            this.ucChucVu.TabIndex = 30;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(629, 362);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 33);
            this.btn_Tim.TabIndex = 16;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(423, 362);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(200, 33);
            this.txt_Tim.TabIndex = 15;
            // 
            // ucThongTinNV
            // 
            this.ucThongTinNV.DiaChi = "";
            this.ucThongTinNV.Email = "";
            this.ucThongTinNV.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucThongTinNV.GioiTinh = -1;
            this.ucThongTinNV.HoTen = "";
            this.ucThongTinNV.Location = new System.Drawing.Point(9, 37);
            this.ucThongTinNV.Margin = new System.Windows.Forms.Padding(6);
            this.ucThongTinNV.Name = "ucThongTinNV";
            this.ucThongTinNV.NgaySinh = new System.DateTime(2018, 11, 8, 23, 59, 34, 887);
            this.ucThongTinNV.SDT = "";
            this.ucThongTinNV.Size = new System.Drawing.Size(349, 295);
            this.ucThongTinNV.TabIndex = 9;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.Email,
            this.SDT,
            this.DiaChi,
            this.ChucVu,
            this.NgayVaoLam,
            this.Luong,
            this.HeSoLuong,
            this.TenTK});
            this.dgv_NhanVien.Location = new System.Drawing.Point(4, 486);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.Size = new System.Drawing.Size(928, 251);
            this.dgv_NhanVien.TabIndex = 11;
            this.dgv_NhanVien.SelectionChanged += new System.EventHandler(this.dgv_NhanVien_SelectionChanged);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 60;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày vào làm";
            this.NgayVaoLam.Name = "NgayVaoLam";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ số lương";
            this.HeSoLuong.Name = "HeSoLuong";
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TenTK";
            this.TenTK.HeaderText = "Tên TK";
            this.TenTK.Name = "TenTK";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 749);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.grb_Thongtin);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.grb_Thongtin.ResumeLayout(false);
            this.grb_Thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Thongtin;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private UC.ucThongTinCoBan ucThongTinNV;
        private UC.ucChucVu ucChucVu;
        private System.Windows.Forms.TextBox txt_HeSoLuong;
        private System.Windows.Forms.TextBox txt_Luong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoLam;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
    }
}