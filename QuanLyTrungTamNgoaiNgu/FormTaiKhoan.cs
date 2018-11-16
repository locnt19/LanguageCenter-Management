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
        List<TaiKhoanDTO> lstaikhoan = new List<TaiKhoanDTO>();
        public FormTaiKhoan()
        {

            InitializeComponent();
            dgv_taikhoan.AutoGenerateColumns = false;
            LoadTaiKhoantheotentk();
            loadTaikhoan();
        }
        TaiKhoanBUS _taikhoan = new TaiKhoanBUS();

        private void LoadTaiKhoantheotentk()
        {
            ls_tk = new List<TaiKhoanDTO>();
            ls_tk = _taikhoan.get_TaiKhoanBUS(txtTentk.Text);
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
            ls_tk = _taikhoan.load_TaiKhoanBUS();
            dgv_taikhoan.DataSource = ls_tk;
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        

        
        private void BindingChiTiet()
        {
            if (tkchon != null)
            {
                txt_TenloadTK.Text = tkchon.TenTK;
                txt_matkhau.Text = tkchon.MatKhau;
                txt_loaitk.Text = tkchon.LoaiTK;
            }
            else
            {
                txt_TenloadTK.Text = "";
                txt_matkhau.Text = "";
                txt_loaitk.Text = "";
            }
        }
        private void GetDataChiTiet()
        {
            if (tkchon == null)
            {
                tkchon = new TaiKhoanDTO();
            }
            tkchon.TenTK = txt_TenloadTK.Text;
            tkchon.MatKhau = txt_matkhau.Text;
            tkchon.LoaiTK = txt_loaitk.Text;
        }

        private void btn_Timtk_Click(object sender, EventArgs e)
        {
            LoadTaiKhoantheotentk();
        }

        private void btn_Themtk_Click(object sender, EventArgs e)
        {
            if (tkchon != null)
            {
                GetDataChiTiet();
                if (tkbus.add_TaiKhoanBUS(tkchon) != 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    refreshtk();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại");
                    tkchon = null;
                }
            }
        }

        private void btn_Doimk_Click(object sender, EventArgs e)
        {
            if (tkchon != null)
            {
                GetDataChiTiet();
                if (tkbus.update_TaiKhoanBUS(tkchon) != 0)
                {

                    MessageBox.Show("Cập nhật thành công");
                    refreshtk();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");

                }
            }
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

    }
}
