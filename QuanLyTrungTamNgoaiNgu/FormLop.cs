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
using System.Text.RegularExpressions;

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
        int _chucnang = 0; //1- Điểm danh, 2-Nhập, sửa điểm

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
            _chucnang = 1;
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

        private void btn_Diem_Click(object sender, EventArgs e)
        {
            txt_Nghe.ReadOnly = false;
            txt_Noi.ReadOnly = false;
            txt_Doc.ReadOnly = false;
            txt_Viet.ReadOnly = false;
            _chucnang = 2;
        }

        private int kiemTraHopLe()
        {
            Regex Number = new Regex("[0-9]");
            if (Number.IsMatch(txt_Nghe.Text) && Number.IsMatch(txt_Noi.Text) && Number.IsMatch(txt_Doc.Text) && Number.IsMatch(txt_Viet.Text))
            {
                return 1;
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo");
                return 0;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            switch (_chucnang)
            {
                case 1:
                    diemDanh();
                    colDiemDanh.Visible = false;
                    LoadLopHoc();
                    break;
                case 2:
                    int isNumber = kiemTraHopLe();
                    if (isNumber == 1)
                    {
                        nhapDiem();
                    }
                    break;
                default:
                    MessageBox.Show("Mời bạn chọn chức năng", "Thông báo");
                    break;
            }
        }

        private void nhapDiem()
        {
            int result = _lopHocBUS.nhap_DiemBUS(_HocVienDaChon.MaHV, _HocVienDaChon.MaLop, double.Parse(txt_Nghe.Text), double.Parse(txt_Noi.Text), double.Parse(txt_Doc.Text), double.Parse(txt_Viet.Text));
            if (result > 0)
            {
                MessageBox.Show("Nhập điểm thành công", "Thông báo");
                txt_Nghe.ReadOnly = true;
                txt_Noi.ReadOnly = true;
                txt_Doc.ReadOnly = true;
                txt_Viet.ReadOnly = true;
                LoadLopHoc();
            }
        }

        private void diemDanh()
        {
            foreach (DataGridViewRow row in dgv_Lop.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[6].Value)) == true)
                {
                    string t_mahv = Convert.ToString(row.Cells[0].Value);
                    string t_malop = Convert.ToString(row.Cells[2].Value);
                    int t_ngaynghi = Convert.ToInt32(row.Cells[5].Value) + 1;
                    int result = _lopHocBUS.diem_DanhBUS(t_mahv, t_malop, t_ngaynghi);
                }
            }
            MessageBox.Show("Điểm danh thành công", "Thông báo");
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            colDiemDanh.Visible = false;
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
            dgv_Lop.ClearSelection();
        }
    }
}
