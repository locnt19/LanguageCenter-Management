namespace UC
{
    partial class ucThoiKhoaBieu
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
            this.cbb_ThoiKhoaBieu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thời khóa biểu:";
            // 
            // cbb_ThoiKhoaBieu
            // 
            this.cbb_ThoiKhoaBieu.FormattingEnabled = true;
            this.cbb_ThoiKhoaBieu.Location = new System.Drawing.Point(161, 0);
            this.cbb_ThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_ThoiKhoaBieu.Name = "cbb_ThoiKhoaBieu";
            this.cbb_ThoiKhoaBieu.Size = new System.Drawing.Size(200, 33);
            this.cbb_ThoiKhoaBieu.TabIndex = 6;
            // 
            // ucThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_ThoiKhoaBieu);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucThoiKhoaBieu";
            this.Size = new System.Drawing.Size(363, 34);
            this.Load += new System.EventHandler(this.ucThoiKhoaBieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ThoiKhoaBieu;
    }
}
