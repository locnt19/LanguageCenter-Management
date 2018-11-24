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
    public partial class FormKhoaHoc : Form
    {
        KhoaHocDTO _KhoaHocDangChon = null;
        KhoaHocBUS _KhoaHocBUS = new KhoaHocBUS();
        List<KhoaHocDTO> _LstKhoaHoc = new List<KhoaHocDTO>();
        int _chucnang = 0; //1 - Them khoa hoc, 2 - Them chi tiet, 3 - Sua khoa hoc

        public FormKhoaHoc()
        {
            InitializeComponent();
            dgv_khoahoc.AutoGenerateColumns = false;
            FormBorderStyle = FormBorderStyle.None;
            dgv_khoahoc.Anchor = AnchorStyles.None;
            dgv_khoahoc.AllowUserToAddRows = false;
            dgv_khoahoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_khoahoc.ReadOnly = true;
            dgv_khoahoc.MultiSelect = false;
            txt_MaKH.ReadOnly = true;
            txt_tenkh.ReadOnly = true;
            txt_Mota.ReadOnly = true;
            txt_hocphi.ReadOnly = true;
            ucCaHoc.Enabled = false;
            cbb_KhoaHoc.Enabled = false;
            ucPhongHoc.Enabled = false;
            dtp_ngaybatdau.Enabled = false;
            dtp_ngaybatdau.Format = DateTimePickerFormat.Custom;
            dtp_ngaybatdau.CustomFormat = "dd/MM/yyyy";
        }

        private void FormKhoaHoc_Load(object sender, EventArgs e)
        {
            load_KhoaHocVaChiTiet();
            _LstKhoaHoc = _KhoaHocBUS.load_KhoaHocBUS();
            //cbb_KhoaHoc.DataSource = null;
            cbb_KhoaHoc.DataSource = _LstKhoaHoc;
            cbb_KhoaHoc.DisplayMember = "TenKH";
            cbb_KhoaHoc.ValueMember = "MaKH";
        }

        private void load_KhoaHocVaChiTiet()
        {
            _LstKhoaHoc = _KhoaHocBUS.load_KhoaHocVaChiTietBUS();
            dgv_khoahoc.DataSource = _LstKhoaHoc;
        }

        private void load_KhoaHoctheomakh()
        {
            if (txt_tim.Text == "")
            {
                load_KhoaHocVaChiTiet();
            }
            else
            {
                _KhoaHocDangChon = _LstKhoaHoc.Find(o => o.MaKH == txt_tim.Text);
                if (_KhoaHocDangChon != null)
                {
                    dgv_khoahoc.DataSource = null;
                    dgv_khoahoc.DataSource = _LstKhoaHoc.FindAll(o => o.MaKH == txt_tim.Text);

                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgv_khoahoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_khoahoc.SelectedRows.Count > 0)
            {
                _KhoaHocDangChon = (KhoaHocDTO)dgv_khoahoc.SelectedRows[0].DataBoundItem;
            }
            else
            {
                _KhoaHocDangChon = null;
            }

            ThongTinChiTiet();
        }

        private void ThongTinChiTiet()
        {
            if (_KhoaHocDangChon != null)
            {
                txt_MaKH.Text = _KhoaHocDangChon.MaKH;
                txt_tenkh.Text = _KhoaHocDangChon.TenKH;
                ucPhongHoc.PhongHoc = _KhoaHocDangChon.MaPhong;
                txt_hocphi.Text = _KhoaHocDangChon.HocPhi.ToString();
                txt_Mota.Text = _KhoaHocDangChon.MoTa;
                dtp_ngaybatdau.Value = _KhoaHocDangChon.Ngaybatdau;
                ucCaHoc.CaHoc = _KhoaHocDangChon.MaCa;
                cbb_KhoaHoc.SelectedValue = _KhoaHocDangChon.MaKH;
            }
            else
            {
                cbb_KhoaHoc.SelectedValue = "0";
                txt_MaKH.Text = string.Empty;
                txt_tenkh.Text = string.Empty;
                ucPhongHoc.PhongHoc = "0";
                txt_hocphi.Text = string.Empty;
                txt_Mota.Text = string.Empty;
                dtp_ngaybatdau.Value = DateTime.Now;
                ucCaHoc.CaHoc = "0";
            }
        }



        private void refreshkh()
        {
            //_LstKhoaHoc = _KhoaHocBUS.loadKhoaHocBUS();
            dgv_khoahoc.DataSource = _LstKhoaHoc;
        }

        private void GetDataChiTiet()
        {
            //if (_KhoaHocDangChon == null)
            //{
            //    _KhoaHocDangChon = new KhoaHocDTO();
            //}
            //txt_MaKH.Text = _KhoaHocDangChon.MaKH;
            //txt_tenkh.Text = _KhoaHocDangChon.TenKH;
            //ucPhongHoc.PhongHoc = _KhoaHocDangChon.MaPhong;
            //txt_hocphi.Text = _KhoaHocDangChon.HocPhi.ToString();
            //txt_Mota.Text = _KhoaHocDangChon.MoTa;
            //dtp_ngaybatdau.Value = _KhoaHocDangChon.Ngaybatdau;
            //ucCaHoc.CaHoc = _KhoaHocDangChon.MaCa;
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_MaKH.ReadOnly = false;
            txt_tenkh.ReadOnly = false;
            txt_Mota.ReadOnly = false;
            txt_hocphi.ReadOnly = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            dgv_khoahoc.ClearSelection();
            _chucnang = 1;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_MaKH.ReadOnly = true;
            txt_tenkh.ReadOnly = false;
            txt_Mota.ReadOnly = false;
            txt_hocphi.ReadOnly = false;
            cbb_KhoaHoc.Enabled = true;
            ucPhongHoc.Enabled = true;
            ucCaHoc.Enabled = true;
            dtp_ngaybatdau.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_ThemChiTiet.Enabled = false;
            btn_ThemKhoaHoc.Enabled = false;
            _chucnang = 3;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_KhoaHocDangChon != null)
            {
                GetDataChiTiet();
                //if (_KhoaHocBUS.delete_khoahocBUS(_KhoaHocDangChon) != 0)
                //{
                //    MessageBox.Show("Xóa thành công !");
                //    refreshkh();
                //}
                //else
                //{
                //    MessageBox.Show("Vui lòng chọn tài khoản cần xóa !");
                //}
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Huy();
        }

        private void Huy()
        {
            txt_MaKH.ReadOnly = true;
            txt_tenkh.ReadOnly = true;
            txt_Mota.ReadOnly = true;
            txt_hocphi.ReadOnly = true;
            txt_MaKH.Text = string.Empty;
            txt_tenkh.Text = string.Empty;
            txt_Mota.Text = string.Empty;
            txt_hocphi.Text = string.Empty;
            btn_ThemKhoaHoc.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            dgv_khoahoc.ClearSelection();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            switch (_chucnang)
            {
                case 1:
                    #region Thêm khóa học
                    if (txt_MaKH.Text.Trim() == "" || txt_tenkh.Text.Trim() == "" || txt_Mota.Text.Trim() == "" || txt_hocphi.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int r = _KhoaHocBUS.insert_KhoaHocBUS(txt_MaKH.Text, txt_tenkh.Text, txt_Mota.Text, double.Parse(txt_hocphi.Text));
                        if (r > 0)
                        {
                            MessageBox.Show("Thêm khóa học mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Huy();
                        }
                        else MessageBox.Show("Thêm khóa học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                    #endregion
                case 2:
                    #region Thêm chi tiết khóa học

                    if (cbb_KhoaHoc.SelectedValue.ToString() != "0" && ucCaHoc.CaHoc != "0" && ucPhongHoc.PhongHoc != "0")
                    {
                        int r = _KhoaHocBUS.insert_ChiTietKhoaHocBUS(cbb_KhoaHoc.SelectedValue.ToString(), ucPhongHoc.PhongHoc, ucCaHoc.CaHoc, dtp_ngaybatdau.Value);
                        if (r > 0)
                        {
                            MessageBox.Show("Thêm chi tiết thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Huy();
                            load_KhoaHocVaChiTiet();
                            ucCaHoc.Enabled = false;
                            ucPhongHoc.Enabled = false;
                            cbb_KhoaHoc.Enabled = false;
                            dtp_ngaybatdau.Enabled = false;
                        }
                        else MessageBox.Show("Thêm chi tiết thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                    #endregion
                case 3:
                    #region Update khóa học
                    if (cbb_KhoaHoc.SelectedValue.ToString() == "0" || ucPhongHoc.PhongHoc == "0" || ucCaHoc.CaHoc == "0" || txt_tenkh.Text.Trim() == "" || txt_Mota.Text.Trim() == "" || txt_hocphi.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int r = _KhoaHocBUS.update_KhoaHocBUS(txt_MaKH.Text, txt_tenkh.Text, txt_Mota.Text, double.Parse(txt_hocphi.Text));
                        int r2 = _KhoaHocBUS.update_ChiTietKhoaHocBUS(txt_MaKH.Text, ucPhongHoc.PhongHoc, ucCaHoc.CaHoc, dtp_ngaybatdau.Value);
                        if (r > 0 && r2 > 0)
                        {
                            MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_KhoaHocVaChiTiet();
                            txt_tenkh.ReadOnly = true;
                            txt_Mota.ReadOnly = true;
                            txt_hocphi.ReadOnly = true;
                            ucCaHoc.Enabled = false;
                            ucPhongHoc.Enabled = false;
                            cbb_KhoaHoc.Enabled = false;
                            dtp_ngaybatdau.Enabled = false;
                        }
                        else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                    #endregion
                default:
                    break;
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            load_KhoaHoctheomakh();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cbb_KhoaHoc.DataSource = null;
            cbb_KhoaHoc.DataSource = _LstKhoaHoc;
            cbb_KhoaHoc.DisplayMember = "TenKH";
            cbb_KhoaHoc.ValueMember = "MaKH";
            MessageBox.Show("a");
        }

        private void btn_ThemChiTiet_Click(object sender, EventArgs e)
        {
            Huy();
            cbb_KhoaHoc.Enabled = true;
            ucPhongHoc.Enabled = true;
            ucCaHoc.Enabled = true;
            dtp_ngaybatdau.Enabled = true;
            _chucnang = 2;
        }




    }
}
