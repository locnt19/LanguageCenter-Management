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

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            grb_ThongTin.Anchor = AnchorStyles.Left;
            lbl_TaiKhoan.Anchor = AnchorStyles.None;
        }

        bool _DaDangNhap;
        public NhanVienDTO _nvDTO = null;
        FormDangNhap frm_DangNhap;
        FormHocVien frm_HocVien;
        FormNhanVien frm_NhanVien;

        private void DongTatCaForm()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }

        public void HienMenu(bool value)
        {
            grb_ThongTin.Visible = value;
            mnu_Main.Visible = value;
        }

        private void KiemTraDangNhap()
        {
            if (_DaDangNhap)
            {
                HienMenu(true);
            }
            else
            {
                HienMenu(false);
            }
        }

        public void setDangNhapThanhCong()
        {
            _DaDangNhap = true;
            KiemTraDangNhap();
            lbl_TaiKhoan.Text = _nvDTO.TenTK;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            frm_DangNhap = new FormDangNhap();
            frm_DangNhap.MdiParent = this;
            frm_DangNhap.Dock = DockStyle.Fill;
            frm_DangNhap.Show();
            KiemTraDangNhap();
        }

        private void mni_HocVien_Click(object sender, EventArgs e)
        {
            DongTatCaForm();
            frm_HocVien = new FormHocVien();
            frm_HocVien.MdiParent = this;
            frm_HocVien.Dock = DockStyle.Fill;
            frm_HocVien.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if (_DaDangNhap)
            {
                _DaDangNhap = false;
                KiemTraDangNhap();
                DongTatCaForm();
                frm_DangNhap = new FormDangNhap();
                frm_DangNhap.MdiParent = this;
                frm_DangNhap.Dock = DockStyle.Fill;
                frm_DangNhap.Show();
            }
        }

        private void mni_NhanVien_Click(object sender, EventArgs e)
        {
            DongTatCaForm();
            frm_NhanVien = new FormNhanVien();
            frm_NhanVien.MdiParent = this;
            frm_NhanVien.Dock = DockStyle.Fill;
            frm_NhanVien.Show();
        }
    }
}
