namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormReport2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyTrungTamNgoaiNguDataSet1 = new QuanLyTrungTamNgoaiNgu.QuanLyTrungTamNgoaiNguDataSet1();
            this.BienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BienLaiTableAdapter = new QuanLyTrungTamNgoaiNgu.QuanLyTrungTamNgoaiNguDataSet1TableAdapters.BienLaiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTrungTamNgoaiNguDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Biên Lai";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(4, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 444);
            this.panel1.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 62;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BienLaiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTrungTamNgoaiNgu.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(856, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyTrungTamNgoaiNguDataSet1
            // 
            this.QuanLyTrungTamNgoaiNguDataSet1.DataSetName = "QuanLyTrungTamNgoaiNguDataSet1";
            this.QuanLyTrungTamNgoaiNguDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BienLaiBindingSource
            // 
            this.BienLaiBindingSource.DataMember = "BienLai";
            this.BienLaiBindingSource.DataSource = this.QuanLyTrungTamNgoaiNguDataSet1;
            // 
            // BienLaiTableAdapter
            // 
            this.BienLaiTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormReport2";
            this.Text = "FormReport2";
            this.Load += new System.EventHandler(this.FormReport2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTrungTamNgoaiNguDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BienLaiBindingSource;
        private QuanLyTrungTamNgoaiNguDataSet1 QuanLyTrungTamNgoaiNguDataSet1;
        private QuanLyTrungTamNgoaiNguDataSet1TableAdapters.BienLaiTableAdapter BienLaiTableAdapter;
    }
}