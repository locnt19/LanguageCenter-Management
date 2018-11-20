namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormBienLai
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaBL = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_bienlai = new System.Windows.Forms.DataGridView();
            this.colTentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Inreport = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.grb = new System.Windows.Forms.GroupBox();
            this.txt_MaHV = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.btn_ChonHV = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.cbb_KhoaHoc2 = new System.Windows.Forms.ComboBox();
            this.cbb_KhoaHoc1 = new System.Windows.Forms.ComboBox();
            this.dtp_Ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ucNhanVienKT = new UC.ucNhanVien();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienlai)).BeginInit();
            this.grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Luu.Location = new System.Drawing.Point(577, 285);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(103, 45);
            this.btn_Luu.TabIndex = 37;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_TongTien.Location = new System.Drawing.Point(508, 67);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(200, 33);
            this.txt_TongTien.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label5.Location = new System.Drawing.Point(21, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã biên lai:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(313, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "BIÊN LAI";
            // 
            // txt_MaBL
            // 
            this.txt_MaBL.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_MaBL.Location = new System.Drawing.Point(144, 67);
            this.txt_MaBL.Name = "txt_MaBL";
            this.txt_MaBL.Size = new System.Drawing.Size(200, 33);
            this.txt_MaBL.TabIndex = 34;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Them.Location = new System.Drawing.Point(172, 285);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(103, 45);
            this.btn_Them.TabIndex = 24;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_bienlai
            // 
            this.dgv_bienlai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bienlai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTentk,
            this.colMatKhau,
            this.colLoaiTK,
            this.Column1,
            this.Column2});
            this.dgv_bienlai.Location = new System.Drawing.Point(14, 406);
            this.dgv_bienlai.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_bienlai.Name = "dgv_bienlai";
            this.dgv_bienlai.RowHeadersWidth = 40;
            this.dgv_bienlai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bienlai.Size = new System.Drawing.Size(694, 262);
            this.dgv_bienlai.TabIndex = 27;
            this.dgv_bienlai.SelectionChanged += new System.EventHandler(this.dgv_bienlai_SelectionChanged);
            // 
            // colTentk
            // 
            this.colTentk.DataPropertyName = "MaBienLai";
            this.colTentk.HeaderText = "Mã Biên lai";
            this.colTentk.Name = "colTentk";
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MaHV";
            this.colMatKhau.HeaderText = "Mã Học viên";
            this.colMatKhau.Name = "colMatKhau";
            // 
            // colLoaiTK
            // 
            this.colLoaiTK.DataPropertyName = "TongThanhToan";
            this.colLoaiTK.HeaderText = "Tổng thanh Toán";
            this.colLoaiTK.Name = "colLoaiTK";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NguoiLap";
            this.Column1.HeaderText = "Người lập";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayLap";
            this.Column2.HeaderText = "Ngày lập";
            this.Column2.Name = "Column2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label3.Location = new System.Drawing.Point(371, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tổng số tiền:";
            // 
            // btn_Inreport
            // 
            this.btn_Inreport.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Inreport.Location = new System.Drawing.Point(307, 285);
            this.btn_Inreport.Name = "btn_Inreport";
            this.btn_Inreport.Size = new System.Drawing.Size(103, 45);
            this.btn_Inreport.TabIndex = 25;
            this.btn_Inreport.Text = "In";
            this.btn_Inreport.UseVisualStyleBackColor = true;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Tim.Location = new System.Drawing.Point(429, 349);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(88, 33);
            this.btn_Tim.TabIndex = 22;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_Tim.Location = new System.Drawing.Point(223, 349);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(200, 33);
            this.txt_Tim.TabIndex = 28;
            // 
            // grb
            // 
            this.grb.Controls.Add(this.btn_Check);
            this.grb.Controls.Add(this.txt_MaHV);
            this.grb.Controls.Add(this.txt_HoTen);
            this.grb.Controls.Add(this.btn_ChonHV);
            this.grb.Controls.Add(this.btn_LamMoi);
            this.grb.Controls.Add(this.cbb_KhoaHoc2);
            this.grb.Controls.Add(this.cbb_KhoaHoc1);
            this.grb.Controls.Add(this.dtp_Ngaylap);
            this.grb.Controls.Add(this.label6);
            this.grb.Controls.Add(this.ucNhanVienKT);
            this.grb.Controls.Add(this.label8);
            this.grb.Controls.Add(this.label7);
            this.grb.Controls.Add(this.label2);
            this.grb.Controls.Add(this.btn_Luu);
            this.grb.Controls.Add(this.btn_Huy);
            this.grb.Controls.Add(this.txt_TongTien);
            this.grb.Controls.Add(this.label5);
            this.grb.Controls.Add(this.label1);
            this.grb.Controls.Add(this.txt_MaBL);
            this.grb.Controls.Add(this.btn_Them);
            this.grb.Controls.Add(this.dgv_bienlai);
            this.grb.Controls.Add(this.label3);
            this.grb.Controls.Add(this.btn_Inreport);
            this.grb.Controls.Add(this.btn_Tim);
            this.grb.Controls.Add(this.txt_Tim);
            this.grb.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb.Location = new System.Drawing.Point(12, 12);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(764, 683);
            this.grb.TabIndex = 37;
            this.grb.TabStop = false;
            // 
            // txt_MaHV
            // 
            this.txt_MaHV.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_MaHV.Location = new System.Drawing.Point(144, 172);
            this.txt_MaHV.Name = "txt_MaHV";
            this.txt_MaHV.Size = new System.Drawing.Size(73, 33);
            this.txt_MaHV.TabIndex = 61;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_HoTen.Location = new System.Drawing.Point(223, 172);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(241, 33);
            this.txt_HoTen.TabIndex = 60;
            // 
            // btn_ChonHV
            // 
            this.btn_ChonHV.Location = new System.Drawing.Point(566, 172);
            this.btn_ChonHV.Name = "btn_ChonHV";
            this.btn_ChonHV.Size = new System.Drawing.Size(75, 33);
            this.btn_ChonHV.TabIndex = 59;
            this.btn_ChonHV.Text = "Chọn";
            this.btn_ChonHV.UseVisualStyleBackColor = true;
            this.btn_ChonHV.Click += new System.EventHandler(this.btn_ChonHV_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_LamMoi.Location = new System.Drawing.Point(37, 285);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(103, 45);
            this.btn_LamMoi.TabIndex = 58;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // cbb_KhoaHoc2
            // 
            this.cbb_KhoaHoc2.FormattingEnabled = true;
            this.cbb_KhoaHoc2.Location = new System.Drawing.Point(441, 228);
            this.cbb_KhoaHoc2.Name = "cbb_KhoaHoc2";
            this.cbb_KhoaHoc2.Size = new System.Drawing.Size(200, 33);
            this.cbb_KhoaHoc2.TabIndex = 57;
            this.cbb_KhoaHoc2.SelectedValueChanged += new System.EventHandler(this.cbb_KhoaHoc2_SelectedValueChanged);
            // 
            // cbb_KhoaHoc1
            // 
            this.cbb_KhoaHoc1.FormattingEnabled = true;
            this.cbb_KhoaHoc1.Location = new System.Drawing.Point(225, 228);
            this.cbb_KhoaHoc1.Name = "cbb_KhoaHoc1";
            this.cbb_KhoaHoc1.Size = new System.Drawing.Size(200, 33);
            this.cbb_KhoaHoc1.TabIndex = 56;
            this.cbb_KhoaHoc1.SelectedValueChanged += new System.EventHandler(this.cbb_KhoaHoc1_SelectedValueChanged);
            // 
            // dtp_Ngaylap
            // 
            this.dtp_Ngaylap.Location = new System.Drawing.Point(508, 116);
            this.dtp_Ngaylap.Name = "dtp_Ngaylap";
            this.dtp_Ngaylap.Size = new System.Drawing.Size(200, 33);
            this.dtp_Ngaylap.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label6.Location = new System.Drawing.Point(382, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Ngày lập";
            // 
            // ucNhanVienKT
            // 
            this.ucNhanVienKT.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucNhanVienKT.Location = new System.Drawing.Point(144, 119);
            this.ucNhanVienKT.Margin = new System.Windows.Forms.Padding(6);
            this.ucNhanVienKT.Name = "ucNhanVienKT";
            this.ucNhanVienKT.NhanVien = "NV08";
            this.ucNhanVienKT.Size = new System.Drawing.Size(202, 35);
            this.ucNhanVienKT.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label8.Location = new System.Drawing.Point(43, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Học viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label7.Location = new System.Drawing.Point(114, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Khóa học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Người lập:";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Huy.Location = new System.Drawing.Point(442, 285);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(103, 45);
            this.btn_Huy.TabIndex = 36;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(470, 172);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(90, 33);
            this.btn_Check.TabIndex = 62;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // FormBienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 706);
            this.Controls.Add(this.grb);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBienLai";
            this.Text = "FormBienLai";
            this.Load += new System.EventHandler(this.FormBienLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienlai)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaBL;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_bienlai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Inreport;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTentk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private UC.ucNhanVien ucNhanVienKT;
        private System.Windows.Forms.DateTimePicker dtp_Ngaylap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_KhoaHoc1;
        private System.Windows.Forms.ComboBox cbb_KhoaHoc2;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_ChonHV;
        private System.Windows.Forms.TextBox txt_MaHV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Button btn_Check;

    }
}