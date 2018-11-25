namespace QuanLyTrungTamNgoaiNgu
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyTrungTamNgoaiNguDataSet = new QuanLyTrungTamNgoaiNgu.QuanLyTrungTamNgoaiNguDataSet();
            this.BienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BienLaiTableAdapter = new QuanLyTrungTamNgoaiNgu.QuanLyTrungTamNgoaiNguDataSetTableAdapters.BienLaiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTrungTamNgoaiNguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(5, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 335);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 42;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.BienLaiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTrungTamNgoaiNgu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(726, 335);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyTrungTamNgoaiNguDataSet
            // 
            this.QuanLyTrungTamNgoaiNguDataSet.DataSetName = "QuanLyTrungTamNgoaiNguDataSet";
            this.QuanLyTrungTamNgoaiNguDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BienLaiBindingSource
            // 
            this.BienLaiBindingSource.DataMember = "BienLai";
            this.BienLaiBindingSource.DataSource = this.QuanLyTrungTamNgoaiNguDataSet;
            // 
            // BienLaiTableAdapter
            // 
            this.BienLaiTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 479);
            this.Controls.Add(this.panel1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTrungTamNgoaiNguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BienLaiBindingSource;
        private QuanLyTrungTamNgoaiNguDataSet QuanLyTrungTamNgoaiNguDataSet;
        private QuanLyTrungTamNgoaiNguDataSetTableAdapters.BienLaiTableAdapter BienLaiTableAdapter;
    }
}