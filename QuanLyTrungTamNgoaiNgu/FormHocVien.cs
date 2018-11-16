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
    public partial class FormHocVien : Form
    {
        public FormHocVien()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            grb_control.Anchor = AnchorStyles.None;
            grb_Thongtin.Anchor = AnchorStyles.None;
            dgv_HocVien.Anchor = AnchorStyles.None;
            dgv_HocVien.AutoGenerateColumns = false;
            dgv_HocVien.AllowUserToAddRows = false;
            dgv_HocVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HocVien.ReadOnly = true;
            dgv_HocVien.MultiSelect = false;
        }

        HocVienBUS _hv = new HocVienBUS();
        int _chucnang = 0; // 1-Them, 2-Sua
        HocVienDTO _HocVienDaChon;

        private void Clear()
        {
            txt_MaHV.Text = string.Empty;
            ucCaHocHV.Clear();
            ucKhoaHocHV.Clear();
            ucLopHocHV.Clear();
            ucPhongHocHV.Clear();
            ucThoiKhoaBieuHV.Clear();
            ucThongTinCoBanHV.Clear();
        }

        private void LoadHocVien()
        {
            List<HocVienDTO> lst_HocVien = new List<HocVienDTO>();
            lst_HocVien = _hv.get_HocVienBUS();
            dgv_HocVien.DataSource = lst_HocVien;
        }

        private void enableControl(bool value)
        {
            ucThongTinCoBanHV.Enabled = value;
            ucThoiKhoaBieuHV.Enabled = value;
            ucPhongHocHV.Enabled = value;
            ucLopHocHV.Enabled = value;
            ucKhoaHocHV.Enabled = value;
            ucCaHocHV.Enabled = value;
            txt_MaHV.Enabled = value;
        }

        private void enableButton(bool value)
        {
            btn_DiemDanh.Enabled = value;
            btn_Diem.Enabled = value;
            btn_Them.Enabled = value;
            btn_Sua.Enabled = value;
            btn_Xoa.Enabled = value;
        }

        private void FormHocVien_Load(object sender, EventArgs e)
        {
            Clear();
            LoadHocVien();
            enableControl(false);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Clear();
            enableButton(false);
            btn_Them.Enabled = true;
            enableControl(false);
            ucThongTinCoBanHV.Enabled = true;
            txt_MaHV.Enabled = true;
            _chucnang = 1;
        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            FormLop frm_ChiTietLopHoc = new FormLop();
            frm_ChiTietLopHoc.Show();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Clear();
            enableButton(true);
            enableControl(false);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            switch (_chucnang)
            {
                case 0:
                    MessageBox.Show("Vui lòng chọn chức năng cần thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    ThemHocVien();
                    break;
                case 2:
                    SuaHocVien();
                    break;
            }

        }

        private void dgv_HocVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_HocVien.SelectedRows.Count > 0)
            {
                _HocVienDaChon = (HocVienDTO)dgv_HocVien.SelectedRows[0].DataBoundItem;
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
                txt_MaHV.Text = _HocVienDaChon.MaHV;
                ucThongTinCoBanHV.HoTen = _HocVienDaChon.HoTen;
                ucThongTinCoBanHV.GioiTinh = _HocVienDaChon.GioiTinh;
                ucThongTinCoBanHV.NgaySinh = _HocVienDaChon.NgaySinh;
                ucThongTinCoBanHV.Email = _HocVienDaChon.Email;
                ucThongTinCoBanHV.SDT = _HocVienDaChon.SDT;
                ucThongTinCoBanHV.DiaChi = _HocVienDaChon.DiaChi;
            }
            else
            {
                Clear();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            enableButton(false);
            btn_Sua.Enabled = true;
            enableControl(false);
            ucThongTinCoBanHV.Enabled = true;
            txt_MaHV.Enabled = false;
            _chucnang = 3;
        }

        private void ThemHocVien()
        {
            if (txt_MaHV.Text == "" || ucThongTinCoBanHV.DiaChi == "" || ucThongTinCoBanHV.Email == "" || ucThongTinCoBanHV.GioiTinh == -1 || ucThongTinCoBanHV.HoTen == "" || ucThongTinCoBanHV.SDT == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int result = _hv.them_HocVienBUS(txt_MaHV.Text, ucThongTinCoBanHV.HoTen, ucThongTinCoBanHV.GioiTinh, ucThongTinCoBanHV.NgaySinh, ucThongTinCoBanHV.Email, ucThongTinCoBanHV.SDT, ucThongTinCoBanHV.DiaChi);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadHocVien();
                    enableButton(true);
                    enableControl(false);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SuaHocVien()
        {
            if (txt_MaHV.Text == "" || ucThongTinCoBanHV.DiaChi == "" || ucThongTinCoBanHV.Email == "" || ucThongTinCoBanHV.GioiTinh == -1 || ucThongTinCoBanHV.HoTen == "" || ucThongTinCoBanHV.SDT == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int result = _hv.sua_HocVienBUS(txt_MaHV.Text, ucThongTinCoBanHV.HoTen, ucThongTinCoBanHV.GioiTinh, ucThongTinCoBanHV.NgaySinh, ucThongTinCoBanHV.Email, ucThongTinCoBanHV.SDT, ucThongTinCoBanHV.DiaChi);
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadHocVien();
                    enableButton(true);
                    enableControl(false);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void XoaHocVien()
        {
            if (dgv_HocVien.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_HocVien.CurrentCell.RowIndex;
                dgv_HocVien.Rows.RemoveAt(rowIndex); // lỗi
                dgv_HocVien.Refresh();
                MessageBox.Show("Tạm xóa thành công");
            }
            else MessageBox.Show("Chọn học viên cần xóa");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa học viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                int result = _hv.xoa_HocVienBUS(_HocVienDaChon.MaHV);
                if (result > 0)
                {
                    MessageBox.Show("Xóa học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Xóa học viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadHocVien();
        }

        private void btn_Diem_Click(object sender, EventArgs e)
        {
            FormLop frm_ChiTietLopHoc = new FormLop();
            frm_ChiTietLopHoc.Show();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            List<HocVienDTO> lst_HocVien = new List<HocVienDTO>();
            lst_HocVien = _hv.tim_HocVienDAO(txt_Tim.Text);
            dgv_HocVien.DataSource = null;
            dgv_HocVien.DataSource = lst_HocVien;
        }
    }
}
