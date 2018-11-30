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
        NhanVienDTO nvchon = null;
        List<NhanVienDTO> ls_nv;
        NhanVienBUS nvbus = new NhanVienBUS();
        NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        NhanVienDTO nvdto = new NhanVienDTO();
        List<NhanVienDTO> lsnhanvien = new List<NhanVienDTO>();
        int _chucnang = 0; //1- Them, 2-Sua
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
            txt_MaNV.Enabled = false;
            txt_TenTK.Enabled = false;
            ucThongTinNV.Enabled = false;
            ucChucVu.Enabled = false;
            txt_Luong.Enabled = false;
            txt_HeSoLuong.Enabled = false;
            dtp_NgayVaoLam.Enabled = false;
            btn_sua.Enabled = true;
            btn_huy.Enabled = true;
            btn_xoa.Enabled = true;
            dgv_NhanVien.ClearSelection();
        }

        NhanVienBUS _nv = new NhanVienBUS();

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
        private void timnhanvien()
        {
            ls_nv = new List<NhanVienDTO>();
            ls_nv = _nhanvienBUS.tim_NhanVienBUS(txt_Tim.Text);
            dgv_NhanVien.DataSource = ls_nv;
        }
        private void refreshnv()
        {
            lsnhanvien = nvbus.get_NhanVienBUS();
            dgv_NhanVien.DataSource = lsnhanvien;
        }
        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                nvchon = (NhanVienDTO)dgv_NhanVien.SelectedRows[0].DataBoundItem;
            }
            else
            {
                nvchon = null;
            }
            BindingChiTietNhanVien();
        }

        private void BindingChiTietNhanVien()
        {
            if (nvchon != null)
            {
                txt_MaNV.Text = nvchon.MaNV;
                ucThongTinNV.HoTen = nvchon.HoTen;
                ucThongTinNV.GioiTinh = nvchon.GioiTinh;
                ucThongTinNV.NgaySinh = nvchon.NgaySinh;
                ucThongTinNV.Email = nvchon.Email;
                ucThongTinNV.SDT = nvchon.SDT;
                ucThongTinNV.DiaChi = nvchon.DiaChi;
                ucChucVu.ChucVu = nvchon.ChucVu;
                dtp_NgayVaoLam.Value = nvchon.NgayVaoLam;
                txt_TenTK.Text = nvchon.TenTK;
                txt_Luong.Text = nvchon.Luong.ToString();
                txt_HeSoLuong.Text = nvchon.HeSoLuong.ToString();

            }
            else
            {
                Clear();
            }
        }
        private void GetDataChiTiet()
        {
            if (nvchon == null)
            {
                nvchon = new NhanVienDTO();
            }
            else
            {


                nvchon.TenTK = txt_TenTK.Text;
                nvchon.Luong = double.Parse(txt_Luong.Text);
                nvchon.HeSoLuong = double.Parse(txt_HeSoLuong.Text);
                nvchon.ChucVu = ucChucVu.ChucVu;
                nvchon.NgayVaoLam = dtp_NgayVaoLam.Value;
                nvchon.HoTen = ucThongTinNV.HoTen;
                nvchon.GioiTinh = ucThongTinNV.GioiTinh;
                nvchon.NgaySinh = ucThongTinNV.NgaySinh;
                nvchon.Email = ucThongTinNV.Email;
                nvchon.SDT = ucThongTinNV.SDT;
                nvchon.DiaChi = ucThongTinNV.DiaChi;
                nvchon.MaNV = txt_MaNV.Text;
            }
        }
        //private void BindingChiTiet()
        //{
        //    if (tkchon != null)
        //    {
        //        txt_TenTK.Text = tkchon.TenTK;
        //        txt_matkhau.Text = tkchon.MatKhau;
        //        ucLoaiTaiKhoan.LoaiTK = tkchon.LoaiTK;
        //    }
        //    else
        //    {
        //        txt_TenTK.Text = string.Empty;
        //        txt_matkhau.Text = string.Empty;
        //        ucLoaiTaiKhoan.Clear();
        //    }
        //}
        //private void GetDataChiTiet()
        //{
        //    if (tkchon == null)
        //    {
        //        tkchon = new TaiKhoanDTO();
        //    }
        //    tkchon.TenTK = txt_TenTK.Text;
        //    tkchon.MatKhau = txt_matkhau.Text;
        //    tkchon.LoaiTK = ucLoaiTaiKhoan.LoaiTK;
        //}

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_MaNV.Enabled = true;
            txt_TenTK.Enabled = true;
            ucThongTinNV.Enabled = true;
            ucChucVu.Enabled = true;
            txt_Luong.Enabled = true;
            txt_HeSoLuong.Enabled = true;
            dtp_NgayVaoLam.Enabled = true;
            btn_sua.Enabled = false;
            btn_huy.Enabled = false;
            btn_xoa.Enabled = false;
            dgv_NhanVien.ClearSelection();
            _chucnang = 1;
        }

       

       

     
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            timnhanvien();
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (nvchon != null)
            {
                if (nvbus.delete_NhanvienBUS(nvchon) != 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    refreshnv();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa !");
                }
            }
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            ucThongTinNV.Enabled = true;
            ucChucVu.Enabled = true;
            txt_Luong.Enabled = true;
            txt_HeSoLuong.Enabled = true;
            dtp_NgayVaoLam.Enabled = true;
            btn_sua.Enabled = false;
            btn_huy.Enabled = false;
            btn_xoa.Enabled = false;
            dgv_NhanVien.ClearSelection();
            _chucnang = 1;
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            ucThongTinNV.Enabled = true;
            ucChucVu.Enabled = true;
            txt_Luong.Enabled = true;
            txt_HeSoLuong.Enabled = true;
            dtp_NgayVaoLam.Enabled = true;
            txt_TenTK.Enabled = false;
            btn_sua.Enabled = false;
            btn_huy.Enabled = false;
            btn_xoa.Enabled = false;
            //dgv_NhanVien.ClearSelection();
            _chucnang = 2;
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            txt_MaNV.Enabled = false;
            txt_TenTK.Enabled = false;
            ucThongTinNV.Enabled = false;
            ucChucVu.Enabled = false;
            txt_Luong.Enabled = true;
            txt_HeSoLuong.Enabled = false;
            dtp_NgayVaoLam.Enabled = false;
            btn_sua.Enabled = false;
            btn_huy.Enabled = false;
            btn_xoa.Enabled = false;
            dgv_NhanVien.ClearSelection();
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            switch (_chucnang)
            {
                case 1:
                    #region Thêm nhân viên
                    if (txt_TenTK.Text.Trim() == "" || txt_MaNV.Text.Trim() == "" || txt_Luong.Text.Trim() == "" ||
                        txt_Luong.Text.Trim() == "" || txt_HeSoLuong.Text.Trim() == "" || ucChucVu.ChucVu.Trim() == "" || dtp_NgayVaoLam.ToString() == "" || ucThongTinNV.HoTen.Trim() == "" ||
                        ucThongTinNV.GioiTinh.ToString() == "" || ucThongTinNV.NgaySinh.ToString() == "" || ucThongTinNV.Email == "" || ucThongTinNV.SDT == "" || ucThongTinNV.DiaChi == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int r = _nhanvienBUS.add_NhanvienBUS(nvdto);
                        if (r > 0)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNhanVien();
                            txt_MaNV.Enabled = false;
                            txt_TenTK.Enabled = false;
                            ucThongTinNV.Enabled = false;
                            ucChucVu.Enabled = false;
                            txt_Luong.Enabled = true;
                            txt_HeSoLuong.Enabled = false;
                            dtp_NgayVaoLam.Enabled = false;
                        }
                        else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                    #endregion
                case 2:
                    #region Sửa nhân viên
                    if (txt_Luong.Text.Trim() == "" || txt_Luong.Text.Trim() == "" || txt_HeSoLuong.Text.Trim() == "" || ucChucVu.ChucVu.Trim() == "" || dtp_NgayVaoLam.ToString() == "" || ucThongTinNV.HoTen.Trim() == "" ||
                        ucThongTinNV.GioiTinh.ToString() == "" || ucThongTinNV.NgaySinh.ToString() == "" || ucThongTinNV.Email == "" || ucThongTinNV.SDT == "" || ucThongTinNV.DiaChi == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int r = _nhanvienBUS.update_NhanvienBUS(nvdto);
                        if (r > 0)
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNhanVien();
                            txt_MaNV.Enabled = false;
                            txt_TenTK.Enabled = false;
                            ucThongTinNV.Enabled = false;
                            ucChucVu.Enabled = false;
                            txt_Luong.Enabled = true;
                            txt_HeSoLuong.Enabled = false;
                            dtp_NgayVaoLam.Enabled = false;
                        }
                        else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                    #endregion
                default:
                    break;
            }
        }

        
    }
}
