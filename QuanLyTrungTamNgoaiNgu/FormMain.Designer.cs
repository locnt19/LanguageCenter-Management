namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormMain
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
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.mni_HocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_KeToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_KhoaHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_PhongHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_TaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.mnu_Main.SuspendLayout();
            this.grb_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Main
            // 
            this.mnu_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnu_Main.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_HocVien,
            this.mni_NhanVien,
            this.mni_KeToan,
            this.mni_KhoaHoc,
            this.mni_PhongHoc,
            this.mni_TaiKhoan});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Size = new System.Drawing.Size(129, 449);
            this.mnu_Main.TabIndex = 0;
            this.mnu_Main.Text = "menu main";
            // 
            // mni_HocVien
            // 
            this.mni_HocVien.Name = "mni_HocVien";
            this.mni_HocVien.Size = new System.Drawing.Size(116, 29);
            this.mni_HocVien.Text = "Học viên";
            this.mni_HocVien.Click += new System.EventHandler(this.mni_HocVien_Click);
            // 
            // mni_NhanVien
            // 
            this.mni_NhanVien.Name = "mni_NhanVien";
            this.mni_NhanVien.Size = new System.Drawing.Size(116, 29);
            this.mni_NhanVien.Text = "Nhân viên";
            this.mni_NhanVien.Click += new System.EventHandler(this.mni_NhanVien_Click);
            // 
            // mni_KeToan
            // 
            this.mni_KeToan.Name = "mni_KeToan";
            this.mni_KeToan.Size = new System.Drawing.Size(116, 29);
            this.mni_KeToan.Text = "Kế toán";
            this.mni_KeToan.Click += new System.EventHandler(this.mni_KeToan_Click);
            // 
            // mni_KhoaHoc
            // 
            this.mni_KhoaHoc.Name = "mni_KhoaHoc";
            this.mni_KhoaHoc.Size = new System.Drawing.Size(116, 29);
            this.mni_KhoaHoc.Text = "Khóa học";
            this.mni_KhoaHoc.Click += new System.EventHandler(this.mni_KhoaHoc_Click);
            // 
            // mni_PhongHoc
            // 
            this.mni_PhongHoc.Name = "mni_PhongHoc";
            this.mni_PhongHoc.Size = new System.Drawing.Size(116, 29);
            this.mni_PhongHoc.Text = "Phòng học";
            this.mni_PhongHoc.Click += new System.EventHandler(this.mni_PhongHoc_Click);
            // 
            // mni_TaiKhoan
            // 
            this.mni_TaiKhoan.Name = "mni_TaiKhoan";
            this.mni_TaiKhoan.Size = new System.Drawing.Size(116, 29);
            this.mni_TaiKhoan.Text = "Tài khoản";
            this.mni_TaiKhoan.Click += new System.EventHandler(this.mni_TaiKhoan_Click);
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grb_ThongTin.Controls.Add(this.btn_DangXuat);
            this.grb_ThongTin.Controls.Add(this.lbl_TaiKhoan);
            this.grb_ThongTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongTin.Location = new System.Drawing.Point(0, 217);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(129, 232);
            this.grb_ThongTin.TabIndex = 1;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "THÔNG TIN";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(5, 178);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(117, 34);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(15, 144);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(99, 19);
            this.lbl_TaiKhoan.TabIndex = 1;
            this.lbl_TaiKhoan.Text = "1234567890";
            this.lbl_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 449);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.mnu_Main);
            this.MainMenuStrip = this.mnu_Main;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_Main;
        private System.Windows.Forms.ToolStripMenuItem mni_HocVien;
        private System.Windows.Forms.ToolStripMenuItem mni_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem mni_KeToan;
        private System.Windows.Forms.ToolStripMenuItem mni_KhoaHoc;
        private System.Windows.Forms.ToolStripMenuItem mni_PhongHoc;
        private System.Windows.Forms.ToolStripMenuItem mni_TaiKhoan;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private System.Windows.Forms.Button btn_DangXuat;

    }
}