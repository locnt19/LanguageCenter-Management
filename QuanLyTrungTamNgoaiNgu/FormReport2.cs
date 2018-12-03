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
    public partial class FormReport2 : Form
    {
        public FormReport2()
        {
            InitializeComponent();
        }

        private void FormReport2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyTrungTamNgoaiNguDataSet1.BienLai' table. You can move, or remove it, as needed.
            this.BienLaiTableAdapter.Fill(this.QuanLyTrungTamNgoaiNguDataSet1.BienLai);

            this.reportViewer1.RefreshReport();
        }
    }
}
