namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormLop
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
            this.btn_DiemDanh = new System.Windows.Forms.Button();
            this.btn_Diem = new System.Windows.Forms.Button();
            this.dgv_Lop = new System.Windows.Forms.DataGridView();
            this.btn_TimLop = new System.Windows.Forms.Button();
            this.ucLopHoc = new UC.ucLopHoc();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nghe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Noi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Doc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Viet = new System.Windows.Forms.TextBox();
            this.txt_TimHV = new System.Windows.Forms.TextBox();
            this.btn_TimHV = new System.Windows.Forms.Button();
            this.colMaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayVang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemDanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DiemDanh
            // 
            this.btn_DiemDanh.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_DiemDanh.Location = new System.Drawing.Point(120, 160);
            this.btn_DiemDanh.Name = "btn_DiemDanh";
            this.btn_DiemDanh.Size = new System.Drawing.Size(134, 36);
            this.btn_DiemDanh.TabIndex = 3;
            this.btn_DiemDanh.Text = "Điểm danh";
            this.btn_DiemDanh.UseVisualStyleBackColor = true;
            this.btn_DiemDanh.Click += new System.EventHandler(this.btn_DiemDanh_Click);
            // 
            // btn_Diem
            // 
            this.btn_Diem.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Diem.Location = new System.Drawing.Point(315, 160);
            this.btn_Diem.Name = "btn_Diem";
            this.btn_Diem.Size = new System.Drawing.Size(134, 36);
            this.btn_Diem.TabIndex = 4;
            this.btn_Diem.Text = "Điểm";
            this.btn_Diem.UseVisualStyleBackColor = true;
            // 
            // dgv_Lop
            // 
            this.dgv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHV,
            this.colTenHV,
            this.colLop,
            this.colPhong,
            this.colMaTKB,
            this.colSoNgayVang,
            this.colDiemDanh,
            this.colNghe,
            this.colNoi,
            this.colDoc,
            this.colViet});
            this.dgv_Lop.Location = new System.Drawing.Point(11, 220);
            this.dgv_Lop.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Lop.Name = "dgv_Lop";
            this.dgv_Lop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Lop.Size = new System.Drawing.Size(762, 330);
            this.dgv_Lop.TabIndex = 6;
            this.dgv_Lop.SelectionChanged += new System.EventHandler(this.dgv_Lop_SelectionChanged);
            // 
            // btn_TimLop
            // 
            this.btn_TimLop.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_TimLop.Location = new System.Drawing.Point(679, 12);
            this.btn_TimLop.Name = "btn_TimLop";
            this.btn_TimLop.Size = new System.Drawing.Size(88, 36);
            this.btn_TimLop.TabIndex = 1;
            this.btn_TimLop.Text = "Tìm";
            this.btn_TimLop.UseVisualStyleBackColor = true;
            this.btn_TimLop.Click += new System.EventHandler(this.btn_TimLop_Click);
            // 
            // ucLopHoc
            // 
            this.ucLopHoc.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucLopHoc.Location = new System.Drawing.Point(413, 13);
            this.ucLopHoc.LopHoc = "LOP01     ";
            this.ucLopHoc.Margin = new System.Windows.Forms.Padding(6);
            this.ucLopHoc.Name = "ucLopHoc";
            this.ucLopHoc.Size = new System.Drawing.Size(257, 36);
            this.ucLopHoc.TabIndex = 7;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Luu.Location = new System.Drawing.Point(510, 160);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 36);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_HoTen.Location = new System.Drawing.Point(56, 103);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(311, 33);
            this.txt_HoTen.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label2.Location = new System.Drawing.Point(174, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label3.Location = new System.Drawing.Point(442, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nghe";
            // 
            // txt_Nghe
            // 
            this.txt_Nghe.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_Nghe.Location = new System.Drawing.Point(447, 103);
            this.txt_Nghe.Name = "txt_Nghe";
            this.txt_Nghe.Size = new System.Drawing.Size(50, 33);
            this.txt_Nghe.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label4.Location = new System.Drawing.Point(518, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nói";
            // 
            // txt_Noi
            // 
            this.txt_Noi.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_Noi.Location = new System.Drawing.Point(511, 103);
            this.txt_Noi.Name = "txt_Noi";
            this.txt_Noi.Size = new System.Drawing.Size(50, 33);
            this.txt_Noi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label5.Location = new System.Drawing.Point(575, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đọc";
            // 
            // txt_Doc
            // 
            this.txt_Doc.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_Doc.Location = new System.Drawing.Point(575, 103);
            this.txt_Doc.Name = "txt_Doc";
            this.txt_Doc.Size = new System.Drawing.Size(50, 33);
            this.txt_Doc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label6.Location = new System.Drawing.Point(638, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Viết";
            // 
            // txt_Viet
            // 
            this.txt_Viet.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_Viet.Location = new System.Drawing.Point(639, 103);
            this.txt_Viet.Name = "txt_Viet";
            this.txt_Viet.Size = new System.Drawing.Size(50, 33);
            this.txt_Viet.TabIndex = 17;
            // 
            // txt_TimHV
            // 
            this.txt_TimHV.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txt_TimHV.Location = new System.Drawing.Point(54, 15);
            this.txt_TimHV.Name = "txt_TimHV";
            this.txt_TimHV.Size = new System.Drawing.Size(200, 33);
            this.txt_TimHV.TabIndex = 19;
            // 
            // btn_TimHV
            // 
            this.btn_TimHV.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_TimHV.Location = new System.Drawing.Point(261, 14);
            this.btn_TimHV.Name = "btn_TimHV";
            this.btn_TimHV.Size = new System.Drawing.Size(88, 36);
            this.btn_TimHV.TabIndex = 20;
            this.btn_TimHV.Text = "Tìm";
            this.btn_TimHV.UseVisualStyleBackColor = true;
            this.btn_TimHV.Click += new System.EventHandler(this.btn_TimHV_Click);
            // 
            // colMaHV
            // 
            this.colMaHV.DataPropertyName = "MaHV";
            this.colMaHV.HeaderText = "Mã HV";
            this.colMaHV.Name = "colMaHV";
            this.colMaHV.Width = 55;
            // 
            // colTenHV
            // 
            this.colTenHV.DataPropertyName = "HoTen";
            this.colTenHV.HeaderText = "Họ tên";
            this.colTenHV.Name = "colTenHV";
            this.colTenHV.Width = 120;
            // 
            // colLop
            // 
            this.colLop.DataPropertyName = "MaLop";
            this.colLop.HeaderText = "Lớp";
            this.colLop.Name = "colLop";
            this.colLop.Width = 55;
            // 
            // colPhong
            // 
            this.colPhong.DataPropertyName = "PhongHoc";
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";
            this.colPhong.Width = 55;
            // 
            // colMaTKB
            // 
            this.colMaTKB.DataPropertyName = "MaTKB";
            this.colMaTKB.HeaderText = "Thời khóa biểu";
            this.colMaTKB.Name = "colMaTKB";
            this.colMaTKB.Width = 55;
            // 
            // colSoNgayVang
            // 
            this.colSoNgayVang.DataPropertyName = "SoNgayVang";
            this.colSoNgayVang.HeaderText = "Số ngày vắng";
            this.colSoNgayVang.Name = "colSoNgayVang";
            this.colSoNgayVang.Width = 50;
            // 
            // colDiemDanh
            // 
            this.colDiemDanh.HeaderText = "Điểm danh";
            this.colDiemDanh.Name = "colDiemDanh";
            this.colDiemDanh.Width = 50;
            // 
            // colNghe
            // 
            this.colNghe.DataPropertyName = "Nghe";
            this.colNghe.HeaderText = "Nghe";
            this.colNghe.Name = "colNghe";
            this.colNghe.Width = 50;
            // 
            // colNoi
            // 
            this.colNoi.DataPropertyName = "Noi";
            this.colNoi.HeaderText = "Nói";
            this.colNoi.Name = "colNoi";
            this.colNoi.Width = 50;
            // 
            // colDoc
            // 
            this.colDoc.DataPropertyName = "Doc";
            this.colDoc.HeaderText = "Đọc";
            this.colDoc.Name = "colDoc";
            this.colDoc.Width = 50;
            // 
            // colViet
            // 
            this.colViet.DataPropertyName = "Viet";
            this.colViet.HeaderText = "Viết";
            this.colViet.Name = "colViet";
            this.colViet.Width = 50;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_TimHV);
            this.Controls.Add(this.txt_TimHV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Viet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Doc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Noi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nghe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.ucLopHoc);
            this.Controls.Add(this.btn_TimLop);
            this.Controls.Add(this.dgv_Lop);
            this.Controls.Add(this.btn_Diem);
            this.Controls.Add(this.btn_DiemDanh);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DiemDanh;
        private System.Windows.Forms.Button btn_Diem;
        private System.Windows.Forms.DataGridView dgv_Lop;
        private System.Windows.Forms.Button btn_TimLop;
        private UC.ucLopHoc ucLopHoc;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nghe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Noi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Doc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Viet;
        private System.Windows.Forms.TextBox txt_TimHV;
        private System.Windows.Forms.Button btn_TimHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayVang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViet;
    }
}