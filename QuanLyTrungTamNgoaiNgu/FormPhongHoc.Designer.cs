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
            this.pnl_control = new System.Windows.Forms.Panel();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).BeginInit();
            this.pnl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tên Phòng:";
            // 
            // txt_TenloadPhong
            // 
            this.txt_TenloadPhong.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenloadPhong.Location = new System.Drawing.Point(139, 52);
            this.txt_TenloadPhong.Name = "txt_TenloadPhong";
            this.txt_TenloadPhong.Size = new System.Drawing.Size(200, 33);
            this.txt_TenloadPhong.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mô tả:";
            // 
            // txt_mota
            // 
            this.txt_mota.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mota.Location = new System.Drawing.Point(139, 110);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(200, 33);
            this.txt_mota.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã phòng:";
            // 
            // txtMaP
            // 
            this.txtMaP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaP.Location = new System.Drawing.Point(139, 168);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(200, 33);
            this.txtMaP.TabIndex = 42;
            // 
            // btn_TimP
            // 
            this.btn_TimP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_TimP.Location = new System.Drawing.Point(345, 168);
            this.btn_TimP.Name = "btn_TimP";
            this.btn_TimP.Size = new System.Drawing.Size(88, 33);
            this.btn_TimP.TabIndex = 36;
            this.btn_TimP.Text = "Tìm";
            this.btn_TimP.UseVisualStyleBackColor = true;
            this.btn_TimP.Click += new System.EventHandler(this.btn_TimP_Click);
            // 
            // btn_XoaP
            // 
            this.btn_XoaP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_XoaP.Location = new System.Drawing.Point(158, 226);
            this.btn_XoaP.Name = "btn_XoaP";
            this.btn_XoaP.Size = new System.Drawing.Size(134, 33);
            this.btn_XoaP.TabIndex = 40;
            this.btn_XoaP.Text = "XÓA PHÒNG";
            this.btn_XoaP.UseVisualStyleBackColor = true;
            this.btn_XoaP.Click += new System.EventHandler(this.btn_XoaP_Click);
            // 
            // btn_SuaP
            // 
            this.btn_SuaP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_SuaP.Location = new System.Drawing.Point(298, 226);
            this.btn_SuaP.Name = "btn_SuaP";
            this.btn_SuaP.Size = new System.Drawing.Size(134, 33);
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
            this.dgv_phong.Location = new System.Drawing.Point(66, 282);
            this.dgv_phong.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_phong.Name = "dgv_phong";
            this.dgv_phong.RowHeadersWidth = 40;
            this.dgv_phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phong.Size = new System.Drawing.Size(321, 243);
            this.dgv_phong.TabIndex = 41;
            this.dgv_phong.SelectionChanged += new System.EventHandler(this.dgv_phong_SelectionChanged);
            // 
            // btn_ThemP
            // 
            this.btn_ThemP.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_ThemP.Location = new System.Drawing.Point(18, 226);
            this.btn_ThemP.Name = "btn_ThemP";
            this.btn_ThemP.Size = new System.Drawing.Size(134, 33);
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
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "PHÒNG HỌC";
            // 
            // pnl_control
            // 
            this.pnl_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_control.Controls.Add(this.label1);
            this.pnl_control.Controls.Add(this.dgv_phong);
            this.pnl_control.Controls.Add(this.label3);
            this.pnl_control.Controls.Add(this.label5);
            this.pnl_control.Controls.Add(this.txt_mota);
            this.pnl_control.Controls.Add(this.txtMaP);
            this.pnl_control.Controls.Add(this.txt_TenloadPhong);
            this.pnl_control.Controls.Add(this.btn_TimP);
            this.pnl_control.Controls.Add(this.label2);
            this.pnl_control.Controls.Add(this.btn_ThemP);
            this.pnl_control.Controls.Add(this.btn_SuaP);
            this.pnl_control.Controls.Add(this.btn_XoaP);
            this.pnl_control.Location = new System.Drawing.Point(12, 8);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(443, 537);
            this.pnl_control.TabIndex = 50;
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Width = 60;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Width = 120;
            // 
            // FormPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 551);
            this.Controls.Add(this.pnl_control);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FormPhongHoc";
            this.Text = "FormPhongHoc";
            this.Load += new System.EventHandler(this.FormPhongHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).EndInit();
            this.pnl_control.ResumeLayout(false);
            this.pnl_control.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}