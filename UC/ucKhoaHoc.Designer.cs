namespace UC
{
    partial class ucKhoaHoc
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
            this.cbb_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_KhoaHoc
            // 
            this.cbb_KhoaHoc.FormattingEnabled = true;
            this.cbb_KhoaHoc.Location = new System.Drawing.Point(112, 0);
            this.cbb_KhoaHoc.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_KhoaHoc.Name = "cbb_KhoaHoc";
            this.cbb_KhoaHoc.Size = new System.Drawing.Size(200, 33);
            this.cbb_KhoaHoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khóa học:";
            // 
            // ucKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_KhoaHoc);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucKhoaHoc";
            this.Size = new System.Drawing.Size(314, 35);
            this.Load += new System.EventHandler(this.ucKhoaHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_KhoaHoc;
        private System.Windows.Forms.Label label1;
    }
}
