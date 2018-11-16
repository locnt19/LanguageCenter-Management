using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FormPhongHoc : Form
    {
        PhongDTO phongchon = null;
        List<PhongDTO> ls_phong;
        PhongBUS tkbus = new PhongBUS();
        List<PhongDTO> lsphong = new List<PhongDTO>();
        public FormPhongHoc()
        {
            InitializeComponent();
            dgv_phong.AutoGenerateColumns = false;
            Loadphongtheomaphong();
            loadphong();
        }
        PhongBUS _Phong = new PhongBUS();

        private void Loadphongtheomaphong()
        {
            ls_phong = new List<PhongDTO>();
            ls_phong = _Phong.get_PhongBUS(txtMaP.Text);
            dgv_phong.DataSource = ls_phong;
        }
        private void loadphong()
        {
            ls_phong = new List<PhongDTO>();
            ls_phong = _Phong.load_PhongBUS();
            dgv_phong.DataSource = ls_phong;
        }
        private void refreshphong()
        {
            lsphong = tkbus.load_PhongBUS();
            dgv_phong.DataSource = lsphong;
        }
        private void BindingChiTiet()
        {
            if (phongchon != null)
            {
                txt_TenloadPhong.Text = phongchon.MaPhong;
                txt_mota.Text = phongchon.MoTa;
            }
            else
            {
                txt_TenloadPhong.Text = "";
                txt_mota.Text = "";
            }
        }
        private void GetDataChiTiet()
        {
            if (phongchon == null)
            {
                phongchon = new PhongDTO();
            }
            phongchon.MaPhong = txt_TenloadPhong.Text;
            phongchon.MoTa = txt_mota.Text;
            
        }
        private void btn_TimP_Click(object sender, EventArgs e)
        {
            Loadphongtheomaphong();
        }

        private void btn_ThemP_Click(object sender, EventArgs e)
        {
            if (phongchon != null)
            {
                GetDataChiTiet();
                if (tkbus.add_PhongBUS(phongchon) != 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    refreshphong();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại");
                    phongchon = null;
                }
            }
        }

        private void btn_SuaP_Click(object sender, EventArgs e)
        {
            if (phongchon != null)
            {
                GetDataChiTiet();
                if (tkbus.update_phongBUS(phongchon) != 0)
                {

                    MessageBox.Show("Cập nhật thành công");
                    refreshphong();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");

                }
            }
        }

        private void btn_XoaP_Click(object sender, EventArgs e)
        {
            if (phongchon != null)
            {
                GetDataChiTiet();
                if (tkbus.delete_PhongBUS(phongchon) != 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    refreshphong();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng cần xóa !");
                }
            }
        }
        private void dgv_phong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_phong.SelectedRows.Count > 0)
            {
                phongchon = (PhongDTO)dgv_phong.SelectedRows[0].DataBoundItem;
            }
            else
            {
                phongchon = null;
            }

            BindingChiTiet();
        }

    }
}
