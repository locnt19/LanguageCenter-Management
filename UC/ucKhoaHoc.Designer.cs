﻿namespace UC
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
            this.SuspendLayout();
            // 
            // cbb_KhoaHoc
            // 
            this.cbb_KhoaHoc.FormattingEnabled = true;
            this.cbb_KhoaHoc.Items.AddRange(new object[] {
            "--None--"});
            this.cbb_KhoaHoc.Location = new System.Drawing.Point(0, 0);
            this.cbb_KhoaHoc.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_KhoaHoc.Name = "cbb_KhoaHoc";
            this.cbb_KhoaHoc.Size = new System.Drawing.Size(200, 33);
            this.cbb_KhoaHoc.TabIndex = 0;
            // 
            // ucKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_KhoaHoc);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucKhoaHoc";
            this.Size = new System.Drawing.Size(202, 35);
            this.Load += new System.EventHandler(this.ucKhoaHoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_KhoaHoc;
    }
}
