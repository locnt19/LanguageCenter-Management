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
using System.Data.SqlClient;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FormBienLai : Form
    {
        BienLaiDTO blchon = null;
        BienLaiBUS _bienlaiBUS = new BienLaiBUS();
        List<BienLaiDTO> lsbienlai = new List<BienLaiDTO>();
        BienLaiDTO bienlaidto = new BienLaiDTO();
        int _chucnang = 0; //1- Them
        int _TongTien = 0;
        FormTimHocVien frmTimHV = null;
        KhoaHocBUS _KhoaHocBUS = new KhoaHocBUS();
        HocVienDTO _TimChonHocVien = null;

        public FormBienLai()
        {
            InitializeComponent();
            dgv_bienlai.AutoGenerateColumns = false;
            FormBorderStyle = FormBorderStyle.None;
            grb.Anchor = AnchorStyles.None;
            dgv_bienlai.Anchor = AnchorStyles.None;
            dgv_bienlai.AllowUserToAddRows = false;
            dgv_bienlai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bienlai.ReadOnly = true;
            dgv_bienlai.MultiSelect = false;
            dtp_Ngaylap.Format = DateTimePickerFormat.Custom;
            dtp_Ngaylap.CustomFormat = "dd/MM/yyyy";
            txt_MaBL.Enabled = false;
            txt_MaHV.Enabled = false;
            txt_TongTien.Enabled = false;
            ucNhanVienKT.Enabled = false;
            dtp_Ngaylap.Enabled = false;
            cbb_KhoaHoc1.Enabled = false;
            cbb_KhoaHoc2.Enabled = false;
            txt_TongTien.Enabled = false;
            txt_HoTen.Enabled = false;
            btn_ChonHV.Enabled = false;
            btn_OK.Enabled = false;
            btn_Check.Enabled = false;
        }
        private void FormBienLai_Load(object sender, EventArgs e)
        {
            timBienLai();
            loadBienlai();
            loadKhoaHoc();
        }

        private void loadBienlai()
        {
            lsbienlai = _bienlaiBUS.load_BienLaiBUS();
            dgv_bienlai.DataSource = lsbienlai;
        }

        private void timBienLai()
        {
            lsbienlai = _bienlaiBUS.tim_BienlaiBUS(txt_Tim.Text);
            dgv_bienlai.DataSource = null;
            dgv_bienlai.DataSource = lsbienlai;
        }
        private void BindingChiTiet()
        {
            if (blchon != null)
            {
                txt_MaBL.Text = blchon.MaBienLai;
                txt_MaHV.Text = blchon.MaHV;
                txt_HoTen.Text = blchon.HoTenHV;
                txt_TongTien.Text = blchon.TongThanhToan.ToString();
                ucNhanVienKT.NhanVien = blchon.NguoiLap;
                dtp_Ngaylap.Text = blchon.NgayLap.ToString();
                cbb_KhoaHoc1.SelectedValue = blchon.MaKH;
            }
            else
            {
                txt_MaHV.Text = string.Empty;
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
            txt_MaHV.Text = blchon.MaHV;
            txt_TongTien.Text = blchon.TongThanhToan.ToString();
            ucNhanVienKT.NhanVien = blchon.NguoiLap;
            dtp_Ngaylap.Text = blchon.NgayLap.ToString();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            timBienLai();
        }

        private void dgv_bienlai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_bienlai.SelectedRows.Count > 0)
            {
                blchon = (BienLaiDTO)dgv_bienlai.SelectedRows[0].DataBoundItem;
            }
            else
            {
                blchon = null;
            }

            BindingChiTiet();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            switch (_chucnang)
            {
                case 1:
                    #region Thêm Biên lai
                    if (txt_MaBL.Text.Trim() == "" || txt_MaHV.Text.Trim() == "" || txt_TongTien.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int r1, r2, r3;
                        r1 = 0;
                        r2 = 0;
                        r3 = 0;
                        r1 = _bienlaiBUS.insert_BienLaiBUS(txt_MaBL.Text, txt_MaHV.Text, double.Parse(txt_TongTien.Text), ucNhanVienKT.NhanVien, dtp_Ngaylap.Value);
                        if (cbb_KhoaHoc1.SelectedValue.ToString() == cbb_KhoaHoc2.SelectedValue.ToString())
                        {
                            MessageBox.Show("Vui lòng chọn 2 khóa học khác nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else
                        {
                            if (cbb_KhoaHoc1.SelectedValue.ToString() != "0")
                            {
                                r2 = _bienlaiBUS.insert_ChiTietBienLaiBUS(txt_MaBL.Text, cbb_KhoaHoc1.SelectedValue.ToString(), _KhoaHocBUS.get_HocPhi(cbb_KhoaHoc1.SelectedValue.ToString()));
                            }
                            if (cbb_KhoaHoc2.SelectedValue.ToString() != "0")
                            {
                                r3 = _bienlaiBUS.insert_ChiTietBienLaiBUS(txt_MaBL.Text, cbb_KhoaHoc2.SelectedValue.ToString(), _KhoaHocBUS.get_HocPhi(cbb_KhoaHoc2.SelectedValue.ToString()));
                            }
                            if ((r1 > 0 && r2 > 0) || (r1 > 0 && r3 > 0))
                            {
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadBienlai();
                                _TimChonHocVien = null;
                                txt_MaBL.Enabled = false;
                                txt_MaHV.Enabled = false;
                                btn_OK.Enabled = false;
                                txt_TongTien.Enabled = false;
                                ucNhanVienKT.Enabled = false;
                                dtp_Ngaylap.Enabled = false;
                                cbb_KhoaHoc1.Enabled = false;
                                cbb_KhoaHoc2.Enabled = false;
                            }
                            else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    //_chucnang = 0;
                    break;
                    #endregion
                case 2:
                    //_chucnang = 0;
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_OK.Enabled = true;
            btn_Them.Enabled = false;
            ucNhanVienKT.Enabled = true;
            cbb_KhoaHoc1.Enabled = true;
            cbb_KhoaHoc2.Enabled = true;
            dtp_Ngaylap.Enabled = true;
            btn_Inreport.Enabled = false;
            btn_Check.Enabled = true;
            btn_ChonHV.Enabled = true;
            dgv_bienlai.ClearSelection();
            _chucnang = 1;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_MaHV.Enabled = false;
            txt_TongTien.Enabled = false;
            txt_TongTien.Text = string.Empty;
            ucNhanVienKT.Enabled = false;
            dtp_Ngaylap.Enabled = false;
            cbb_KhoaHoc1.Enabled = false;
            cbb_KhoaHoc2.Enabled = false;
            btn_Inreport.Enabled = true;
            btn_OK.Enabled = false;
            dgv_bienlai.ClearSelection();
        }

        private void loadKhoaHoc()
        {
            List<KhoaHocDTO> lst_KhoaHoc1 = _KhoaHocBUS.load_KhoaHocBUS();
            List<KhoaHocDTO> lst_KhoaHoc2 = _KhoaHocBUS.load_KhoaHocBUS();
            cbb_KhoaHoc1.DataSource = lst_KhoaHoc1;
            cbb_KhoaHoc1.ValueMember = "MaKH";
            cbb_KhoaHoc1.DisplayMember = "TenKH";
            cbb_KhoaHoc2.DataSource = lst_KhoaHoc2;
            cbb_KhoaHoc2.ValueMember = "MaKH";
            cbb_KhoaHoc2.DisplayMember = "TenKH";
        }

        private void cbb_KhoaHoc1_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbb_KhoaHoc2_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            if (lsbienlai.Count == 0)
            {
                txt_MaBL.Text = "BL01";
            }
            else
            {
                string strMaLonNhat = lsbienlai.Max(o => o.MaBienLai);
                int matieptheo = int.Parse(strMaLonNhat.Replace("BL", "")) + 1;
                txt_MaBL.Text = "BL" + matieptheo.ToString("00");
                txt_TongTien.Text = string.Empty;
            }
            dgv_bienlai.ClearSelection();
            txt_HoTen.Text = string.Empty;
        }

        private void btn_ChonHV_Click(object sender, EventArgs e)
        {
            frmTimHV = new FormTimHocVien();
            frmTimHV.Show();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (frmTimHV != null)
            {
                _TimChonHocVien = frmTimHV.HocVienDaChon;
                txt_MaHV.Text = _TimChonHocVien.MaHV;
                txt_HoTen.Text = _TimChonHocVien.HoTen;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (cbb_KhoaHoc1.SelectedValue.ToString() != "0" && cbb_KhoaHoc2.SelectedValue.ToString() != "0")
            {
                _TongTien = _KhoaHocBUS.get_HocPhi(cbb_KhoaHoc1.SelectedValue.ToString()) + _KhoaHocBUS.get_HocPhi(cbb_KhoaHoc2.SelectedValue.ToString());
                txt_TongTien.Text = _TongTien.ToString();
            }
            else if (cbb_KhoaHoc1.SelectedValue.ToString() != "0" && cbb_KhoaHoc2.SelectedValue.ToString() == "0")
            {
                _TongTien = _KhoaHocBUS.get_HocPhi(cbb_KhoaHoc1.SelectedValue.ToString());
                txt_TongTien.Text = _TongTien.ToString();
            }
            else if (cbb_KhoaHoc1.SelectedValue.ToString() == "0" && cbb_KhoaHoc2.SelectedValue.ToString() != "0")
            {
                _TongTien = _KhoaHocBUS.get_HocPhi(cbb_KhoaHoc2.SelectedValue.ToString());
                txt_TongTien.Text = _TongTien.ToString();
            }
            else txt_TongTien.Text = string.Empty;
        }
    }
}
