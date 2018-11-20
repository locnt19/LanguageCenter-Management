namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormTimHocVien
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
            this.dgv_HocVien = new System.Windows.Forms.DataGridView();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).BeginInit();
            this.grb.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv_HocVien.Location = new System.Drawing.Point(12, 76);
            this.dgv_HocVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_HocVien.Name = "dgv_HocVien";
            this.dgv_HocVien.Size = new System.Drawing.Size(850, 328);
            this.dgv_HocVien.TabIndex = 3;
            this.dgv_HocVien.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HocVien_CellContentDoubleClick);
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
            // grb
            // 
            this.grb.Controls.Add(this.btn_Refresh);
            this.grb.Controls.Add(this.label2);
            this.grb.Controls.Add(this.btn_Tim);
            this.grb.Controls.Add(this.txt_Tim);
            this.grb.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.grb.Location = new System.Drawing.Point(12, -5);
            this.grb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb.Size = new System.Drawing.Size(850, 74);
            this.grb.TabIndex = 4;
            this.grb.TabStop = false;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(452, 26);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(72, 33);
            this.btn_Tim.TabIndex = 11;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(248, 27);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(200, 33);
            this.txt_Tim.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Họ tên:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(528, 26);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(119, 33);
            this.btn_Refresh.TabIndex = 25;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FormTimHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 412);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.dgv_HocVien);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTimHocVien";
            this.Text = "FormTimHocVien";
            this.Load += new System.EventHandler(this.FormTimHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Refresh;

    }
}