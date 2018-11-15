namespace UC
{
    partial class ucPhongHoc
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
            this.cbb_PhongHoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phòng:";
            // 
            // cbb_PhongHoc
            // 
            this.cbb_PhongHoc.FormattingEnabled = true;
            this.cbb_PhongHoc.Location = new System.Drawing.Point(81, 0);
            this.cbb_PhongHoc.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_PhongHoc.Name = "cbb_PhongHoc";
            this.cbb_PhongHoc.Size = new System.Drawing.Size(200, 33);
            this.cbb_PhongHoc.TabIndex = 4;
            // 
            // ucPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_PhongHoc);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucPhongHoc";
            this.Size = new System.Drawing.Size(284, 36);
            this.Load += new System.EventHandler(this.ucPhongHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_PhongHoc;
    }
}
