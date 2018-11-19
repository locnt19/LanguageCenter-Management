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
    public partial class FormBienLai : Form
    {
        BienLaiDTO blchon = null;
        List<BienLaiDTO> ls_bl;
        BienLaiBUS blbus = new BienLaiBUS();
        BienLaiBUS _bienlaiBUS = new BienLaiBUS();
        List<BienLaiDTO> lsbienlai = new List<BienLaiDTO>();
        int _chucnang = 0; //1- Them, 2-Sua
        public FormBienLai()
        {
            InitializeComponent();
            dgv_bienlai.AutoGenerateColumns = false;
            FormBorderStyle = FormBorderStyle.None;
            dgv_bienlai.Anchor = AnchorStyles.None;
            dgv_bienlai.AllowUserToAddRows = false;
            dgv_bienlai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bienlai.ReadOnly = true;
            dgv_bienlai.MultiSelect = false;
            dtp_Ngaylap.Format = DateTimePickerFormat.Custom;
            dtp_Ngaylap.CustomFormat = "dd/MM/yyyy";
            //txt_TenTK.Enabled = false;
            //txt_matkhau.Enabled = false;
            //ucLoaiTaiKhoan.Enabled = false;
            //txt_matkhau.UseSystemPasswordChar = true;
        }

        private void FormBienLai_Load(object sender, EventArgs e)
        {
            TimBienlaitheoma();
            loadBienlai();
        }

        private void loadBienlai()
        {
            ls_bl = new List<BienLaiDTO>();
            ls_bl = _bienlaiBUS.load_BienLaiBUS();
            dgv_bienlai.DataSource = ls_bl;
        }

        private void TimBienlaitheoma()
        {
            ls_bl = new List<BienLaiDTO>();
            ls_bl = _bienlaiBUS.get_BienlaiBUS(txt_Tim.Text);
            dgv_bienlai.DataSource = ls_bl;
        }
        private void refreshbl()
        {
            lsbienlai = blbus.load_BienLaiBUS();
            dgv_bienlai.DataSource = lsbienlai;
        }
        private void BindingChiTiet()
        {
            if (blchon != null)
            {
                txt_MaBL.Text = blchon.MaBienLai;
                txt_MaHv.Text = blchon.MaHV;
                txt_TongTien.Text = blchon.TongThanhToan.ToString();
                //cbb_Nguoilap.Text = blchon.NguoiLap;
                dtp_Ngaylap.Text = blchon.NgayLap.ToString(); ;

            }
            else
            {
                txt_MaBL.Text = string.Empty;
                txt_MaHv.Text = string.Empty;
                txt_TongTien.Text = string.Empty;
                
            }
        }
        private void GetDataChiTiet()
        {
            if (blchon == null)
            {
                blchon = new BienLaiDTO();
            }
            txt_MaBL.Text = blchon.MaBienLai;
            txt_MaHv.Text = blchon.MaHV;
            txt_TongTien.Text = blchon.TongThanhToan.ToString();
            //cbb_Nguoilap.Text = blchon.NguoiLap;
            dtp_Ngaylap.Text = blchon.NgayLap.ToString(); ;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            TimBienlaitheoma();

        }

    }
}
