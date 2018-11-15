namespace UC
{
    partial class ucKetQuaHocTap
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
            this.cbb_KetQuaHocTap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kết quả học:";
           
            // 
            // cbb_KetQuaHocTap
            // 
            this.cbb_KetQuaHocTap.FormattingEnabled = true;
            this.cbb_KetQuaHocTap.Location = new System.Drawing.Point(136, 0);
            this.cbb_KetQuaHocTap.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_KetQuaHocTap.Name = "cbb_KetQuaHocTap";
            this.cbb_KetQuaHocTap.Size = new System.Drawing.Size(200, 33);
            this.cbb_KetQuaHocTap.TabIndex = 2;
            // 
            // ucKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_KetQuaHocTap);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucKetQuaHocTap";
            this.Size = new System.Drawing.Size(339, 34);
            this.Load += new System.EventHandler(this.ucKetQuaHocTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_KetQuaHocTap;
    }
}
