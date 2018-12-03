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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietBienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyTrungTamNgoaiNguDataSet = new QuanLyTrungTamNgoaiNgu.QuanLyTrungTamNgoaiNguDataSet();
            this.BienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BienLaiTableAdapter = new QuanLyTrungTamNgoaiNgu.QuanLyTrungTamNgoaiNguDataSetTableAdapters.BienLaiTableAdapter();
            this.ChiTietBienLaiTableAdapter = new QuanLyTrungTamNgoaiNgu.QuanLyTrungTamNgoaiNguDataSetTableAdapters.ChiTietBienLaiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietBienLaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTrungTamNgoaiNguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(5, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 307);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 42;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BienLaiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTrungTamNgoaiNgu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(726, 307);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(380, 51);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 1;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.txt_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(201, 54);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(149, 20);
            this.txt_tim.TabIndex = 2;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ChiTietBienLaiBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyTrungTamNgoaiNgu.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(5, 393);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(726, 135);
            this.reportViewer2.TabIndex = 3;
            // 
            // ChiTietBienLaiBindingSource
            // 
            this.ChiTietBienLaiBindingSource.DataMember = "ChiTietBienLai";
            this.ChiTietBienLaiBindingSource.DataSource = this.QuanLyTrungTamNgoaiNguDataSet;
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
            // ChiTietBienLaiTableAdapter
            // 
            this.ChiTietBienLaiTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 567);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.panel1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietBienLaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTrungTamNgoaiNguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BienLaiBindingSource;
        private QuanLyTrungTamNgoaiNguDataSet QuanLyTrungTamNgoaiNguDataSet;
        private QuanLyTrungTamNgoaiNguDataSetTableAdapters.BienLaiTableAdapter BienLaiTableAdapter;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ChiTietBienLaiBindingSource;
        private QuanLyTrungTamNgoaiNguDataSetTableAdapters.ChiTietBienLaiTableAdapter ChiTietBienLaiTableAdapter;
    }
}