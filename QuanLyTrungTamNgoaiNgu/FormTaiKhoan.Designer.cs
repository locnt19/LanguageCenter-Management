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
            this.txt_TenloadTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_loaitk = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.btn_Timtk = new System.Windows.Forms.Button();
            this.btn_Xoatk = new System.Windows.Forms.Button();
            this.btn_Doimk = new System.Windows.Forms.Button();
            this.colLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.btn_Themtk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên tài khoản";
            // 
            // txt_TenloadTK
            // 
            this.txt_TenloadTK.Location = new System.Drawing.Point(44, 241);
            this.txt_TenloadTK.Name = "txt_TenloadTK";
            this.txt_TenloadTK.Size = new System.Drawing.Size(155, 20);
            this.txt_TenloadTK.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Loại tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_loaitk
            // 
            this.txt_loaitk.Location = new System.Drawing.Point(44, 358);
            this.txt_loaitk.Name = "txt_loaitk";
            this.txt_loaitk.Size = new System.Drawing.Size(155, 20);
            this.txt_loaitk.TabIndex = 31;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(44, 296);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(155, 20);
            this.txt_matkhau.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "TÀI KHOẢN";
            // 
            // txtTentk
            // 
            this.txtTentk.Location = new System.Drawing.Point(327, 103);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(174, 20);
            this.txtTentk.TabIndex = 28;
            // 
            // btn_Timtk
            // 
            this.btn_Timtk.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Timtk.Location = new System.Drawing.Point(520, 87);
            this.btn_Timtk.Name = "btn_Timtk";
            this.btn_Timtk.Size = new System.Drawing.Size(88, 36);
            this.btn_Timtk.TabIndex = 22;
            this.btn_Timtk.Text = "Tìm";
            this.btn_Timtk.UseVisualStyleBackColor = true;
            this.btn_Timtk.Click += new System.EventHandler(this.btn_Timtk_Click);
            // 
            // btn_Xoatk
            // 
            this.btn_Xoatk.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Xoatk.Location = new System.Drawing.Point(563, 147);
            this.btn_Xoatk.Name = "btn_Xoatk";
            this.btn_Xoatk.Size = new System.Drawing.Size(134, 36);
            this.btn_Xoatk.TabIndex = 26;
            this.btn_Xoatk.Text = "XÓA TK";
            this.btn_Xoatk.UseVisualStyleBackColor = true;
            this.btn_Xoatk.Click += new System.EventHandler(this.btn_Xoatk_Click);
            // 
            // btn_Doimk
            // 
            this.btn_Doimk.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Doimk.Location = new System.Drawing.Point(378, 147);
            this.btn_Doimk.Name = "btn_Doimk";
            this.btn_Doimk.Size = new System.Drawing.Size(134, 36);
            this.btn_Doimk.TabIndex = 25;
            this.btn_Doimk.Text = "ĐỔI MK";
            this.btn_Doimk.UseVisualStyleBackColor = true;
            this.btn_Doimk.Click += new System.EventHandler(this.btn_Doimk_Click);
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
            this.dgv_taikhoan.Location = new System.Drawing.Point(265, 209);
            this.dgv_taikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.RowHeadersWidth = 40;
            this.dgv_taikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_taikhoan.Size = new System.Drawing.Size(343, 256);
            this.dgv_taikhoan.TabIndex = 27;
            this.dgv_taikhoan.SelectionChanged += new System.EventHandler(this.dgv_taikhoan_SelectionChanged);
            // 
            // btn_Themtk
            // 
            this.btn_Themtk.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_Themtk.Location = new System.Drawing.Point(193, 147);
            this.btn_Themtk.Name = "btn_Themtk";
            this.btn_Themtk.Size = new System.Drawing.Size(134, 36);
            this.btn_Themtk.TabIndex = 24;
            this.btn_Themtk.Text = "THÊM TK";
            this.btn_Themtk.UseVisualStyleBackColor = true;
            this.btn_Themtk.Click += new System.EventHandler(this.btn_Themtk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(421, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenloadTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_loaitk);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTentk);
            this.Controls.Add(this.btn_Timtk);
            this.Controls.Add(this.btn_Xoatk);
            this.Controls.Add(this.btn_Doimk);
            this.Controls.Add(this.dgv_taikhoan);
            this.Controls.Add(this.btn_Themtk);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenloadTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_loaitk;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.Button btn_Timtk;
        private System.Windows.Forms.Button btn_Xoatk;
        private System.Windows.Forms.Button btn_Doimk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTentk;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.Button btn_Themtk;
        private System.Windows.Forms.Label label1;

    }
}