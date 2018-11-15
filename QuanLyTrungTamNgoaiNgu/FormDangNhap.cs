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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            pnl_DangNhap.Anchor = AnchorStyles.None;
            AcceptButton = btn_DangNhap;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            NhanVienBUS nvbus = new NhanVienBUS();
            NhanVienDTO nvdto = new NhanVienDTO();
            if (ucDangNhap.get_TaiKhoan.Trim() == "" || ucDangNhap.get_MatKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                nvdto = nvbus.DangNhapBUS(ucDangNhap.get_TaiKhoan, ucDangNhap.get_MatKhau);
                if (nvdto.MaNV != null)
                {
                    string thongbao = String.Format("Chào mừng {0} đã quay trở lại hệ thống", ucDangNhap.get_TaiKhoan);
                    MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMain frmMain = (FormMain)this.MdiParent;
                    frmMain._nvDTO = nvdto;
                    frmMain.setDangNhapThanhCong();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
