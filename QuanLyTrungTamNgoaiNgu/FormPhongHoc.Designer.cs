namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormPhongHoc
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
            this.txt_TenloadPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.btn_TimP = new System.Windows.Forms.Button();
            this.btn_XoaP = new System.Windows.Forms.Button();
            this.btn_SuaP = new System.Windows.Forms.Button();
            this.dgv_phong = new System.Windows.Forms.DataGridView();
            this.btn_ThemP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tên Phòng";
            // 
            // txt_TenloadPhong
            // 
            this.txt_TenloadPhong.Location = new System.Drawing.Point(34, 220);
            this.txt_TenloadPhong.Name = "txt_TenloadPhong";
            this.txt_TenloadPhong.Size = new System.Drawing.Size(155, 20);
            this.txt_TenloadPhong.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mô tả";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(34, 275);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(155, 20);
            this.txt_mota.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "MÃ PHÒNG";
            // 
            // txtMaP
            // 
            this.txtMaP.Location = new System.Drawing.Point(317, 82);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(174, 20);
            this.txtMaP.TabIndex = 42;
            // 
            // btn_TimP
            // 
            this.btn_TimP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_TimP.Location = new System.Drawing.Point(510, 66);
            this.btn_TimP.Name = "btn_TimP";
            this.btn_TimP.Size = new System.Drawing.Size(88, 36);
            this.btn_TimP.TabIndex = 36;
            this.btn_TimP.Text = "Tìm";
            this.btn_TimP.UseVisualStyleBackColor = true;
            this.btn_TimP.Click += new System.EventHandler(this.btn_TimP_Click);
            // 
            // btn_XoaP
            // 
            this.btn_XoaP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_XoaP.Location = new System.Drawing.Point(553, 126);
            this.btn_XoaP.Name = "btn_XoaP";
            this.btn_XoaP.Size = new System.Drawing.Size(134, 36);
            this.btn_XoaP.TabIndex = 40;
            this.btn_XoaP.Text = "XÓA PHÒNG";
            this.btn_XoaP.UseVisualStyleBackColor = true;
            this.btn_XoaP.Click += new System.EventHandler(this.btn_XoaP_Click);
            // 
            // btn_SuaP
            // 
            this.btn_SuaP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_SuaP.Location = new System.Drawing.Point(368, 126);
            this.btn_SuaP.Name = "btn_SuaP";
            this.btn_SuaP.Size = new System.Drawing.Size(134, 36);
            this.btn_SuaP.TabIndex = 39;
            this.btn_SuaP.Text = "SỬA PHÒNG";
            this.btn_SuaP.UseVisualStyleBackColor = true;
            this.btn_SuaP.Click += new System.EventHandler(this.btn_SuaP_Click);
            // 
            // dgv_phong
            // 
            this.dgv_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colMoTa});
            this.dgv_phong.Location = new System.Drawing.Point(255, 188);
            this.dgv_phong.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_phong.Name = "dgv_phong";
            this.dgv_phong.RowHeadersWidth = 40;
            this.dgv_phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phong.Size = new System.Drawing.Size(343, 256);
            this.dgv_phong.TabIndex = 41;
            this.dgv_phong.SelectionChanged += new System.EventHandler(this.dgv_phong_SelectionChanged);
            // 
            // btn_ThemP
            // 
            this.btn_ThemP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_ThemP.Location = new System.Drawing.Point(183, 126);
            this.btn_ThemP.Name = "btn_ThemP";
            this.btn_ThemP.Size = new System.Drawing.Size(134, 36);
            this.btn_ThemP.TabIndex = 38;
            this.btn_ThemP.Text = "THÊM PHÒNG";
            this.btn_ThemP.UseVisualStyleBackColor = true;
            this.btn_ThemP.Click += new System.EventHandler(this.btn_ThemP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(411, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "PHÒNG HỌC";
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Tên Phòng";
            this.colMaPhong.Name = "colMaPhong";
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            // 
            // FormPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenloadPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaP);
            this.Controls.Add(this.btn_TimP);
            this.Controls.Add(this.btn_XoaP);
            this.Controls.Add(this.btn_SuaP);
            this.Controls.Add(this.dgv_phong);
            this.Controls.Add(this.btn_ThemP);
            this.Controls.Add(this.label1);
            this.Name = "FormPhongHoc";
            this.Text = "FormPhongHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenloadPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaP;
        private System.Windows.Forms.Button btn_TimP;
        private System.Windows.Forms.Button btn_XoaP;
        private System.Windows.Forms.Button btn_SuaP;
        private System.Windows.Forms.DataGridView dgv_phong;
        private System.Windows.Forms.Button btn_ThemP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}