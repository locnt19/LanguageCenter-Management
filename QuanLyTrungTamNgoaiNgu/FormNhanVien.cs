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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            grb_Thongtin.Anchor = AnchorStyles.None;
            dgv_NhanVien.Anchor = AnchorStyles.None;
            dgv_NhanVien.AutoGenerateColumns = false;
            dgv_NhanVien.AllowUserToAddRows = false;
            dgv_NhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_NhanVien.ReadOnly = true;
            dgv_NhanVien.MultiSelect = false;
            dtp_NgayVaoLam.Format = DateTimePickerFormat.Custom;
            dtp_NgayVaoLam.CustomFormat = "dd/MM/yyyy";
        }

        NhanVienBUS _nv = new NhanVienBUS();
        NhanVienDTO _NhanVienDaChon;

        private void Clear()
        {
            txt_MaNV.Text = string.Empty;
            ucThongTinNV.Clear();
        }

        private void enableControl(bool value)
        {
            ucThongTinNV.Enabled = value;
            ucChucVu.Enabled = value;
            txt_MaNV.Enabled = value;
            txt_Luong.Enabled = value;
            txt_HeSoLuong.Enabled = value;
        }

        private void enableButton(bool value)
        {
            //btn_DiemDanh.Enabled = value;
            //btn_Diem.Enabled = value;
            //btn_Them.Enabled = value;
            //btn_Sua.Enabled = value;
            //btn_Xoa.Enabled = value;
        }

        private void LoadNhanVien()
        {
            List<NhanVienDTO> lst_NhanVien = new List<NhanVienDTO>();
            lst_NhanVien = _nv.get_NhanVienBUS();
            dgv_NhanVien.DataSource = lst_NhanVien;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                _NhanVienDaChon = (NhanVienDTO)dgv_NhanVien.SelectedRows[0].DataBoundItem;
            }
            else
            {
                _NhanVienDaChon = null;
            }
            BindingChiTietNhanVien();
        }

        private void BindingChiTietNhanVien()
        {
            if (_NhanVienDaChon != null)
            {
                txt_MaNV.Text = _NhanVienDaChon.MaNV;
                ucThongTinNV.HoTen = _NhanVienDaChon.HoTen;
                ucThongTinNV.GioiTinh = _NhanVienDaChon.GioiTinh;
                ucThongTinNV.NgaySinh = _NhanVienDaChon.NgaySinh;
                ucThongTinNV.Email = _NhanVienDaChon.Email;
                ucThongTinNV.SDT = _NhanVienDaChon.SDT;
                ucThongTinNV.DiaChi = _NhanVienDaChon.DiaChi;
                ucChucVu.ChucVu = _NhanVienDaChon.ChucVu;
                dtp_NgayVaoLam.Value = _NhanVienDaChon.NgayVaoLam;
            }
            else
            {
                Clear();
            }
        }
    }
}
