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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DiemDanh = new System.Windows.Forms.Button();
            this.btn_Diem = new System.Windows.Forms.Button();
            this.btn_SuaDiem = new System.Windows.Forms.Button();
            this.dgv_Lop = new System.Windows.Forms.DataGridView();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.ucLopHoc = new UC.ucLopHoc();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayVang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(358, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LỚP";
            // 
            // btn_DiemDanh
            // 
            this.btn_DiemDanh.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_DiemDanh.Location = new System.Drawing.Point(130, 116);
            this.btn_DiemDanh.Name = "btn_DiemDanh";
            this.btn_DiemDanh.Size = new System.Drawing.Size(134, 36);
            this.btn_DiemDanh.TabIndex = 3;
            this.btn_DiemDanh.Text = "Điểm danh";
            this.btn_DiemDanh.UseVisualStyleBackColor = true;
            // 
            // btn_Diem
            // 
            this.btn_Diem.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Diem.Location = new System.Drawing.Point(315, 116);
            this.btn_Diem.Name = "btn_Diem";
            this.btn_Diem.Size = new System.Drawing.Size(134, 36);
            this.btn_Diem.TabIndex = 4;
            this.btn_Diem.Text = "Điểm";
            this.btn_Diem.UseVisualStyleBackColor = true;
            // 
            // btn_SuaDiem
            // 
            this.btn_SuaDiem.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_SuaDiem.Location = new System.Drawing.Point(500, 116);
            this.btn_SuaDiem.Name = "btn_SuaDiem";
            this.btn_SuaDiem.Size = new System.Drawing.Size(134, 36);
            this.btn_SuaDiem.TabIndex = 5;
            this.btn_SuaDiem.Text = "Sửa điểm";
            this.btn_SuaDiem.UseVisualStyleBackColor = true;
            // 
            // dgv_Lop
            // 
            this.dgv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHV,
            this.TenHV,
            this.Lop,
            this.Phong,
            this.TKB,
            this.SoNgayVang,
            this.DiemDanh});
            this.dgv_Lop.Location = new System.Drawing.Point(11, 172);
            this.dgv_Lop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Lop.Name = "dgv_Lop";
            this.dgv_Lop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Lop.Size = new System.Drawing.Size(762, 378);
            this.dgv_Lop.TabIndex = 6;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Tim.Location = new System.Drawing.Point(457, 56);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(88, 36);
            this.btn_Tim.TabIndex = 1;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // ucLopHoc
            // 
            this.ucLopHoc.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ucLopHoc.Location = new System.Drawing.Point(198, 57);
            this.ucLopHoc.LopHoc = null;
            this.ucLopHoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucLopHoc.Name = "ucLopHoc";
            this.ucLopHoc.Size = new System.Drawing.Size(259, 40);
            this.ucLopHoc.TabIndex = 0;
            // 
            // MaHV
            // 
            this.MaHV.HeaderText = "Mã HV";
            this.MaHV.Name = "MaHV";
            // 
            // TenHV
            // 
            this.TenHV.HeaderText = "Họ tên";
            this.TenHV.Name = "TenHV";
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            // 
            // Phong
            // 
            this.Phong.HeaderText = "Phòng";
            this.Phong.Name = "Phong";
            // 
            // TKB
            // 
            this.TKB.HeaderText = "Thời khóa biểu";
            this.TKB.Name = "TKB";
            // 
            // SoNgayVang
            // 
            this.SoNgayVang.HeaderText = "Số ngày vắng";
            this.SoNgayVang.Name = "SoNgayVang";
            // 
            // DiemDanh
            // 
            this.DiemDanh.HeaderText = "Điểm danh";
            this.DiemDanh.Name = "DiemDanh";
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ucLopHoc);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.dgv_Lop);
            this.Controls.Add(this.btn_SuaDiem);
            this.Controls.Add(this.btn_Diem);
            this.Controls.Add(this.btn_DiemDanh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DiemDanh;
        private System.Windows.Forms.Button btn_Diem;
        private System.Windows.Forms.Button btn_SuaDiem;
        private System.Windows.Forms.DataGridView dgv_Lop;
        private System.Windows.Forms.Button btn_Tim;
        private UC.ucLopHoc ucLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayVang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DiemDanh;
    }
}