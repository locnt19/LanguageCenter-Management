using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_tim_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyTrungTamNgoaiNguDataSet.BienLai' table. You can move, or remove it, as needed.
            this.BienLaiTableAdapter.Fill(this.QuanLyTrungTamNgoaiNguDataSet.BienLai, txt_tim.Text);

            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'QuanLyTrungTamNgoaiNguDataSet.ChiTietBienLai' table. You can move, or remove it, as needed.
            this.ChiTietBienLaiTableAdapter.Fill(this.QuanLyTrungTamNgoaiNguDataSet.ChiTietBienLai, txt_tim.Text);

            this.reportViewer2.RefreshReport();
        }
    }
}
