using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
            dgv_Lop.AutoGenerateColumns = false;
        }

        LopHocBUS _lophoc = new LopHocBUS();

        private void LoadLopHoc(string MaLop)
        {
            MaLop = ucLopHoc.LopHoc.Trim();
            _lophoc.get_LopHocBUS(MaLop);
        }

        private void FormLop_Load(object sender, EventArgs e)
        {

        }
    }
}
