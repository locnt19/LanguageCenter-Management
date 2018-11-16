namespace UC
{
    partial class ucLoaiTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LoaiTK = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại:";
            // 
            // cbb_LoaiTK
            // 
            this.cbb_LoaiTK.FormattingEnabled = true;
            this.cbb_LoaiTK.Location = new System.Drawing.Point(62, 0);
            this.cbb_LoaiTK.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_LoaiTK.Name = "cbb_LoaiTK";
            this.cbb_LoaiTK.Size = new System.Drawing.Size(200, 33);
            this.cbb_LoaiTK.TabIndex = 6;
            // 
            // ucLoaiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_LoaiTK);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ucLoaiTaiKhoan";
            this.Size = new System.Drawing.Size(265, 36);
            this.Load += new System.EventHandler(this.ucLoaiTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_LoaiTK;
    }
}
