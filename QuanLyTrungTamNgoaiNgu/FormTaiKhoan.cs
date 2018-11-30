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
    public partial class FormTaiKhoan : Form
    {
        TaiKhoanDTO tkchon = null;
        List<TaiKhoanDTO> ls_tk;
        TaiKhoanBUS tkbus = new TaiKhoanBUS();
        TaiKhoanBUS _taikhoanBUS = new TaiKhoanBUS();
        List<TaiKhoanDTO> lstaikhoan = new List<TaiKhoanDTO>();
        int _chucnang = 0; //1- Them, 2-Sua

        public FormTaiKhoan()
        {
            InitializeComponent();
            dgv_taikhoan.AutoGenerateColumns = false;
            FormBorderStyle = FormBorderStyle.None;
            grb.Anchor = AnchorStyles.None;
            dgv_taikhoan.Anchor = AnchorStyles.None;
            dgv_taikhoan.AllowUserToAddRows = false;
            dgv_taikhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_taikhoan.ReadOnly = true;
            dgv_taikhoan.MultiSelect = false;
            txt_TenTK.Enabled = false;
            txt_matkhau.Enabled = false;
            ucLoaiTaiKhoan.Enabled = false;
            txt_matkhau.UseSystemPasswordChar = true;
        }
        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoantheotentk(); // Tìm
            loadTaikhoan(); // Load dữ liệu
        }

        private void LoadTaiKhoantheotentk()
        {
            ls_tk = new List<TaiKhoanDTO>();
            ls_tk = _taikhoanBUS.get_TaiKhoanBUS(txt_Tim.Text);
            dgv_taikhoan.DataSource = ls_tk;
        }
        private void refreshtk()
        {
            lstaikhoan = tkbus.load_TaiKhoanBUS();
            dgv_taikhoan.DataSource = lstaikhoan;
        }
        private void loadTaikhoan()
        {
            ls_tk = new List<TaiKhoanDTO>();
            ls_tk = _taikhoanBUS.load_TaiKhoanBUS();
            dgv_taikhoan.DataSource = ls_tk;
        }
        private void BindingChiTiet()
        {
            if (tkchon != null)
            {
                txt_TenTK.Text = tkchon.TenTK;
                txt_matkhau.Text = tkchon.MatKhau;
                ucLoaiTaiKhoan.LoaiTK = tkchon.LoaiTK;
            }
            else
            {
                txt_TenTK.Text = string.Empty;
                txt_matkhau.Text = string.Empty;
                ucLoaiTaiKhoan.Clear();
            }
        }
        private void GetDataChiTiet()
        {
            if (tkchon == null)
            {
                tkchon = new TaiKhoanDTO();
            }
            tkchon.TenTK = txt_TenTK.Text;
            tkchon.MatKhau = txt_matkhau.Text;
            tkchon.LoaiTK = ucLoaiTaiKhoan.LoaiTK;
        }


        private void btn_Timtk_Click(object sender, EventArgs e)
        {
            LoadTaiKhoantheotentk();
        }

        private void btn_Themtk_Click(object sender, EventArgs e)
        {
            txt_TenTK.Enabled = true;
            txt_matkhau.Enabled = true;
            ucLoaiTaiKhoan.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            dgv_taikhoan.ClearSelection();
            _chucnang = 1;
        }

        private void btn_Doimk_Click(object sender, EventArgs e)
        {
            txt_TenTK.Enabled = false;
            txt_matkhau.Enabled = true;
            ucLoaiTaiKhoan.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = false;
            _chucnang = 2;
        }

        private void btn_Xoatk_Click(object sender, EventArgs e)
        {
            if (tkchon != null)
            {
                GetDataChiTiet();
                if (tkbus.delete_TaiKhoanBUS(tkchon) != 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    refreshtk();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa !");
                }
            }
        }
        private void dgv_taikhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_taikhoan.SelectedRows.Count > 0)
            {
                tkchon = (TaiKhoanDTO)dgv_taikhoan.SelectedRows[0].DataBoundItem;
            }
            else
            {
                tkchon = null;
            }

            BindingChiTiet();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            switch (_chucnang)
            {
                case 1:
                    #region Thêm tài khoản
                    if (txt_TenTK.Text.Trim() == "" || txt_matkhau.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int r = _taikhoanBUS.insert_TaiKhoanBUS(txt_TenTK.Text, txt_matkhau.Text, ucLoaiTaiKhoan.LoaiTK);
                        if (r > 0)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadTaikhoan();
                            txt_TenTK.Enabled = false;
                            txt_matkhau.Enabled = false;
                            ucLoaiTaiKhoan.Enabled = false;
                        }
                        else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                    #endregion
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenTK.Enabled = false;
            txt_matkhau.Enabled = false;
            ucLoaiTaiKhoan.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
        }
    }
}
