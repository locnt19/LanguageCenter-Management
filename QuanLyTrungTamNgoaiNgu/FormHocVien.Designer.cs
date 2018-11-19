namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormHocVien
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
            this.grb_control = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_DiemDanh = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_HocVien = new System.Windows.Forms.DataGridView();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_Thongtin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHV = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.ucPhongHocHV = new UC.ucPhongHoc();
            this.ucThoiKhoaBieuHV = new UC.ucThoiKhoaBieu();
            this.ucCaHocHV = new UC.ucCaHoc();
            this.ucLopHocHV = new UC.ucLopHoc();
            this.ucThongTinCoBanHV = new UC.ucThongTinCoBan();
            this.ucKhoaHocHV = new UC.ucKhoaHoc();
            this.lbl_KhoaHoc = new System.Windows.Forms.Label();
            this.grb_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).BeginInit();
            this.grb_Thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_control
            // 
            this.grb_control.Controls.Add(this.btn_LamMoi);
            this.grb_control.Controls.Add(this.btn_DiemDanh);
            this.grb_control.Controls.Add(this.btn_Luu);
            this.grb_control.Controls.Add(this.btn_Huy);
            this.grb_control.Controls.Add(this.btn_Sua);
            this.grb_control.Controls.Add(this.btn_Xoa);
            this.grb_control.Controls.Add(this.btn_Them);
            this.grb_control.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_control.Location = new System.Drawing.Point(744, 10);
            this.grb_control.Name = "grb_control";
            this.grb_control.Size = new System.Drawing.Size(193, 416);
            this.grb_control.TabIndex = 1;
            this.grb_control.TabStop = false;
            this.grb_control.Text = "Tương tác";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(11, 88);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(170, 37);
            this.btn_LamMoi.TabIndex = 11;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_DiemDanh
            // 
            this.btn_DiemDanh.Location = new System.Drawing.Point(11, 37);
            this.btn_DiemDanh.Name = "btn_DiemDanh";
            this.btn_DiemDanh.Size = new System.Drawing.Size(170, 37);
            this.btn_DiemDanh.TabIndex = 10;
            this.btn_DiemDanh.Text = "Điểm danh";
            this.btn_DiemDanh.UseVisualStyleBackColor = true;
            this.btn_DiemDanh.Click += new System.EventHandler(this.btn_DiemDanh_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(11, 346);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(170, 61);
            this.btn_Luu.TabIndex = 16;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(11, 292);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(170, 38);
            this.btn_Huy.TabIndex = 15;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(11, 241);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(170, 37);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(11, 190);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(170, 37);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(11, 139);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(170, 37);
            this.btn_Them.TabIndex = 12;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_HocVien
            // 
            this.dgv_HocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHV,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.Email,
            this.SDT,
            this.DiaChi});
            this.dgv_HocVien.Location = new System.Drawing.Point(9, 438);
            this.dgv_HocVien.Name = "dgv_HocVien";
            this.dgv_HocVien.Size = new System.Drawing.Size(928, 263);
            this.dgv_HocVien.TabIndex = 2;
            this.dgv_HocVien.SelectionChanged += new System.EventHandler(this.dgv_HocVien_SelectionChanged);
            // 
            // MaHV
            // 
            this.MaHV.DataPropertyName = "MaHV";
            this.MaHV.HeaderText = "Mã HV";
            this.MaHV.Name = "MaHV";
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
            // grb_Thongtin
            // 
            this.grb_Thongtin.Controls.Add(this.lbl_KhoaHoc);
            this.grb_Thongtin.Controls.Add(this.ucKhoaHocHV);
            this.grb_Thongtin.Controls.Add(this.label2);
            this.grb_Thongtin.Controls.Add(this.txt_MaHV);
            this.grb_Thongtin.Controls.Add(this.btn_Tim);
            this.grb_Thongtin.Controls.Add(this.txt_Tim);
            this.grb_Thongtin.Controls.Add(this.ucPhongHocHV);
            this.grb_Thongtin.Controls.Add(this.ucThoiKhoaBieuHV);
            this.grb_Thongtin.Controls.Add(this.ucCaHocHV);
            this.grb_Thongtin.Controls.Add(this.ucLopHocHV);
            this.grb_Thongtin.Controls.Add(this.ucThongTinCoBanHV);
            this.grb_Thongtin.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.grb_Thongtin.Location = new System.Drawing.Point(9, 10);
            this.grb_Thongtin.Name = "grb_Thongtin";
            this.grb_Thongtin.Size = new System.Drawing.Size(729, 416);
            this.grb_Thongtin.TabIndex = 9;
            this.grb_Thongtin.TabStop = false;
            this.grb_Thongtin.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã HV:";
            // 
            // txt_MaHV
            // 
            this.txt_MaHV.Location = new System.Drawing.Point(154, 361);
            this.txt_MaHV.Name = "txt_MaHV";
            this.txt_MaHV.Size = new System.Drawing.Size(200, 33);
            this.txt_MaHV.TabIndex = 2;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(648, 361);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 33);
            this.btn_Tim.TabIndex = 9;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(446, 361);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(200, 33);
            this.txt_Tim.TabIndex = 8;
            // 
            // ucPhongHocHV
            // 
            this.ucPhongHocHV.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucPhongHocHV.Location = new System.Drawing.Point(436, 229);
            this.ucPhongHocHV.Margin = new System.Windows.Forms.Padding(6);
            this.ucPhongHocHV.Name = "ucPhongHocHV";
            this.ucPhongHocHV.PhongHoc = "F1.1      ";
            this.ucPhongHocHV.Size = new System.Drawing.Size(284, 36);
            this.ucPhongHocHV.TabIndex = 6;
            // 
            // ucThoiKhoaBieuHV
            // 
            this.ucThoiKhoaBieuHV.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucThoiKhoaBieuHV.Location = new System.Drawing.Point(357, 295);
            this.ucThoiKhoaBieuHV.Margin = new System.Windows.Forms.Padding(6);
            this.ucThoiKhoaBieuHV.Name = "ucThoiKhoaBieuHV";
            this.ucThoiKhoaBieuHV.Size = new System.Drawing.Size(363, 34);
            this.ucThoiKhoaBieuHV.TabIndex = 7;
            this.ucThoiKhoaBieuHV.ThoiKhoaBieu = "TKB01     ";
            // 
            // ucCaHocHV
            // 
            this.ucCaHocHV.CaHoc = "CA01      ";
            this.ucCaHocHV.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucCaHocHV.Location = new System.Drawing.Point(431, 166);
            this.ucCaHocHV.Margin = new System.Windows.Forms.Padding(6);
            this.ucCaHocHV.Name = "ucCaHocHV";
            this.ucCaHocHV.Size = new System.Drawing.Size(289, 33);
            this.ucCaHocHV.TabIndex = 5;
            // 
            // ucLopHocHV
            // 
            this.ucLopHocHV.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucLopHocHV.Location = new System.Drawing.Point(463, 35);
            this.ucLopHocHV.LopHoc = "LOP01     ";
            this.ucLopHocHV.Margin = new System.Windows.Forms.Padding(6);
            this.ucLopHocHV.Name = "ucLopHocHV";
            this.ucLopHocHV.Size = new System.Drawing.Size(257, 36);
            this.ucLopHocHV.TabIndex = 3;
            // 
            // ucThongTinCoBanHV
            // 
            this.ucThongTinCoBanHV.DiaChi = "";
            this.ucThongTinCoBanHV.Email = "";
            this.ucThongTinCoBanHV.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucThongTinCoBanHV.GioiTinh = -1;
            this.ucThongTinCoBanHV.HoTen = "";
            this.ucThongTinCoBanHV.Location = new System.Drawing.Point(9, 35);
            this.ucThongTinCoBanHV.Margin = new System.Windows.Forms.Padding(6);
            this.ucThongTinCoBanHV.Name = "ucThongTinCoBanHV";
            this.ucThongTinCoBanHV.NgaySinh = new System.DateTime(2018, 11, 15, 1, 18, 59, 833);
            this.ucThongTinCoBanHV.SDT = "";
            this.ucThongTinCoBanHV.Size = new System.Drawing.Size(347, 294);
            this.ucThongTinCoBanHV.TabIndex = 1;
            // 
            // ucKhoaHocHV
            // 
            this.ucKhoaHocHV.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucKhoaHocHV.KhoaHoc = "KH01      ";
            this.ucKhoaHocHV.Location = new System.Drawing.Point(518, 101);
            this.ucKhoaHocHV.Margin = new System.Windows.Forms.Padding(6);
            this.ucKhoaHocHV.Name = "ucKhoaHocHV";
            this.ucKhoaHocHV.Size = new System.Drawing.Size(202, 35);
            this.ucKhoaHocHV.TabIndex = 24;
            // 
            // lbl_KhoaHoc
            // 
            this.lbl_KhoaHoc.AutoSize = true;
            this.lbl_KhoaHoc.Location = new System.Drawing.Point(413, 106);
            this.lbl_KhoaHoc.Name = "lbl_KhoaHoc";
            this.lbl_KhoaHoc.Size = new System.Drawing.Size(105, 25);
            this.lbl_KhoaHoc.TabIndex = 25;
            this.lbl_KhoaHoc.Text = "Khóa học:";
            // 
            // FormHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 719);
            this.Controls.Add(this.grb_Thongtin);
            this.Controls.Add(this.dgv_HocVien);
            this.Controls.Add(this.grb_control);
            this.Name = "FormHocVien";
            this.Text = "FormHocVien";
            this.Load += new System.EventHandler(this.FormHocVien_Load);
            this.grb_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).EndInit();
            this.grb_Thongtin.ResumeLayout(false);
            this.grb_Thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_control;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        //private System.Windows.Forms.Button button6;
        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_HocVien;
        private System.Windows.Forms.Button btn_DiemDanh;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.GroupBox grb_Thongtin;
        private UC.ucPhongHoc ucPhongHocHV;
        private UC.ucThoiKhoaBieu ucThoiKhoaBieuHV;
        private UC.ucCaHoc ucCaHocHV;
        private UC.ucLopHoc ucLopHocHV;
        private UC.ucThongTinCoBan ucThongTinCoBanHV;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaHV;
        private UC.ucKhoaHoc ucKhoaHocHV;
        private System.Windows.Forms.Label lbl_KhoaHoc;
    }
}