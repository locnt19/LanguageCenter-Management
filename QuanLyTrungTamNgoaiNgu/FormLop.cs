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
            dgv_Lop.AllowUserToAddRows = false;
            dgv_Lop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Lop.MultiSelect = false;
            colDiemDanh.Visible = false;
            //colNghe.Visible = false;
            //colNoi.Visible = false;
            //colDoc.Visible = false;
            //colViet.Visible = false;
            colMaHV.ReadOnly = true;
            colLop.ReadOnly = true;
            colMaTKB.ReadOnly = true;
            colPhong.ReadOnly = true;
            colSoNgayVang.ReadOnly = true;
            colTenHV.ReadOnly = true;
            colNghe.ReadOnly = true;
            colNoi.ReadOnly = true;
            colDoc.ReadOnly = true;
            colViet.ReadOnly = true;
            txt_Nghe.ReadOnly = true;
            txt_Noi.ReadOnly = true;
            txt_Doc.ReadOnly = true;
            txt_Viet.ReadOnly = true;
            txt_HoTen.ReadOnly = true;
        }

        LopHocBUS _lopHocBUS = new LopHocBUS();
        ChiTietLopHocDTO _HocVienDaChon;

        private void LoadLopHoc()
        {
            string MaLop = ucLopHoc.LopHoc;
            List<ChiTietLopHocDTO> lstLopHocDTO = new List<ChiTietLopHocDTO>();
            lstLopHocDTO = _lopHocBUS.get_LopHocBUS(MaLop);
            dgv_Lop.DataSource = lstLopHocDTO;
        }

        private void TimHocVien()
        {
            List<ChiTietLopHocDTO> lstLopHocDTO = new List<ChiTietLopHocDTO>();
            lstLopHocDTO = _lopHocBUS.tim_LopHocBUS(txt_TimHV.Text);
            dgv_Lop.DataSource = null;
            dgv_Lop.DataSource = lstLopHocDTO;
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            colDiemDanh.Visible = true;
        }

        private void btn_TimLop_Click(object sender, EventArgs e)
        {
            LoadLopHoc();
        }

        private void btn_TimHV_Click(object sender, EventArgs e)
        {
            TimHocVien();
        }

        private void dgv_Lop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Lop.SelectedRows.Count > 0)
            {
                _HocVienDaChon = (ChiTietLopHocDTO)dgv_Lop.SelectedRows[0].DataBoundItem;
            }
            else
            {
                _HocVienDaChon = null;
            }
            BindingChiTietHocVien();
        }

        private void BindingChiTietHocVien()
        {
            if (_HocVienDaChon != null)
            {
                txt_HoTen.Text = _HocVienDaChon.HoTen;
                txt_Nghe.Text = _HocVienDaChon.Nghe.ToString();
                txt_Noi.Text = _HocVienDaChon.Noi.ToString();
                txt_Doc.Text = _HocVienDaChon.Doc.ToString();
                txt_Viet.Text = _HocVienDaChon.Viet.ToString();
            }
            else
            {
                txt_HoTen.Text = string.Empty;
                txt_Nghe.Text = string.Empty;
                txt_Noi.Text = string.Empty;
                txt_Doc.Text = string.Empty;
                txt_Viet.Text = string.Empty;
            }
        }
    }
}
