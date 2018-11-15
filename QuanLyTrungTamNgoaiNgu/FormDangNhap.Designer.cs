namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormDangNhap
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
            this.pnl_DangNhap = new System.Windows.Forms.Panel();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.ucDangNhap = new UC.ucDangNhap();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_DangNhap
            // 
            this.pnl_DangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_DangNhap.Controls.Add(this.btn_DangNhap);
            this.pnl_DangNhap.Controls.Add(this.ucDangNhap);
            this.pnl_DangNhap.Controls.Add(this.pictureBox1);
            this.pnl_DangNhap.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_DangNhap.Location = new System.Drawing.Point(82, 48);
            this.pnl_DangNhap.Name = "pnl_DangNhap";
            this.pnl_DangNhap.Size = new System.Drawing.Size(437, 302);
            this.pnl_DangNhap.TabIndex = 2;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Image = global::QuanLyTrungTamNgoaiNgu.Properties.Resources.login;
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangNhap.Location = new System.Drawing.Point(143, 249);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(149, 37);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // ucDangNhap
            // 
            this.ucDangNhap.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDangNhap.Location = new System.Drawing.Point(15, 145);
            this.ucDangNhap.Margin = new System.Windows.Forms.Padding(6);
            this.ucDangNhap.Name = "ucDangNhap";
            this.ucDangNhap.Size = new System.Drawing.Size(405, 100);
            this.ucDangNhap.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyTrungTamNgoaiNgu.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(153, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(632, 432);
            this.Controls.Add(this.pnl_DangNhap);
            this.Name = "FormDangNhap";
            this.Text = "Quản lý trung tâm Ezi";
            this.pnl_DangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_DangNhap;
        private UC.ucDangNhap ucDangNhap;
        private System.Windows.Forms.Button btn_DangNhap;
    }
}

