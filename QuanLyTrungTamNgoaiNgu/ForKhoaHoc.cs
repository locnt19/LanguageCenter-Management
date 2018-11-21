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
    public partial class ForKhoaHoc : Form
    {
        KhoaHocDTO khchon = null;
      //  List<KhoaHocDTO> ls_kh;
        KhoaHocBUS khbus = new KhoaHocBUS();
        KhoaHocBUS _khoahocBUS = new KhoaHocBUS();
        List<KhoaHocDTO> lskhoahoc = new List<KhoaHocDTO>();
        int _chucnang = 0; //1- Them, 2-Sua

        public ForKhoaHoc()
        {
            InitializeComponent();
            dgv_khoahoc.AutoGenerateColumns = false;
            FormBorderStyle = FormBorderStyle.None;
            dgv_khoahoc.Anchor = AnchorStyles.None;
            dgv_khoahoc.AllowUserToAddRows = false;
            dgv_khoahoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_khoahoc.ReadOnly = true;
            dgv_khoahoc.MultiSelect = false;
            //txt_TenTK.Enabled = false;
            //txt_matkhau.Enabled = false;
            //ucLoaiTaiKhoan.Enabled = false;
            //txt_matkhau.UseSystemPasswordChar = true;

        }

        private void ForKhoaHoc_Load(object sender, EventArgs e)
        {
            
            loadkhoahoc();
        }

        private void loadkhoahoc()
        {

            lskhoahoc = new List<KhoaHocDTO>();
            lskhoahoc = _khoahocBUS.loadKhoaHocBUS();
            dgv_khoahoc.DataSource = lskhoahoc;
        }

        private void LoadKhoahoctheomakh()
        {
            if (txt_tim.Text == "")
            {
                loadkhoahoc();
            }
            else
            {
                //List<KhoaHocDTO> ls_kh = new List<KhoaHocDTO>();
              //  List<KhoaHocDTO> ls_kh = null;
                khchon = lskhoahoc.Find(o => o.MaKH == txt_tim.Text);
                if (khchon != null)
                {
                    dgv_khoahoc.DataSource = null;
                    dgv_khoahoc.DataSource = lskhoahoc.FindAll(o => o.MaKH == txt_tim.Text);
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }           
        }
       
        private void refreshkh()
        {
            lskhoahoc = khbus.loadKhoaHocBUS();
            dgv_khoahoc.DataSource = lskhoahoc;
        }
        private void BindingChiTiet()
        {
            if (khchon != null)
            {
                txt_makh.Text = khchon.MaKH;
                txt_tenkh.Text = khchon.TenKH;
                txt_maphong.Text = khchon.MaPhong;
                txt_hocphi.Text = khchon.HocPhi.ToString();
                txt_Mota.Text = khchon.MoTa;
                dtp_ngaybatdau.Value = khchon.Ngaybatdau;
                txt_macahoc.Text = khchon.MaCa;


            }
            else
            {
                txt_makh.Text = string.Empty;
                txt_tenkh.Text = string.Empty;
                txt_maphong.Text = string.Empty;
                txt_hocphi.Text = string.Empty;
                txt_Mota.Text = string.Empty;
                dtp_ngaybatdau.Value = DateTime.Now;
                txt_macahoc.Text = string.Empty;
            }
        }
        private void GetDataChiTiet()
        {
            if (khchon == null)
            {
                khchon = new KhoaHocDTO();
            }
            txt_makh.Text = khchon.MaKH;
            txt_tenkh.Text = khchon.TenKH;
            txt_maphong.Text = khchon.MaPhong;
            txt_hocphi.Text = khchon.HocPhi.ToString();
            txt_Mota.Text = khchon.MoTa;
            dtp_ngaybatdau.Value = khchon.Ngaybatdau;
            txt_macahoc.Text = khchon.MaCa;
        }

        private void dgv_khoahoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_khoahoc.SelectedRows.Count > 0)
            {
                khchon = (KhoaHocDTO)dgv_khoahoc.SelectedRows[0].DataBoundItem;
            }
            else
            {
                khchon = null;
            }

            BindingChiTiet();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_makh.Enabled = true;
            txt_tenkh.Enabled = true;
            txt_Mota.Enabled = true;
            txt_hocphi.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            dgv_khoahoc.ClearSelection();
            _chucnang = 1;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_makh.Enabled = false;
            txt_tenkh.Enabled = true;
            txt_Mota.Enabled = true;
            txt_hocphi.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = false;
            dgv_khoahoc.ClearSelection();
            _chucnang = 2;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (khchon != null)
            {
                GetDataChiTiet();
                if (khbus.delete_khoahocBUS(khchon) != 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    refreshkh();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa !");
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_makh.Enabled = false;
            txt_tenkh.Enabled = false;
            txt_Mota.Enabled = false;
            txt_hocphi.Enabled = false;
            btn_them.Enabled = true;
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
                    if (txt_makh.Text.Trim() == "" || txt_tenkh.Text.Trim() == "" || txt_Mota.Text.Trim() == ""||txt_hocphi.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _khoahocBUS = new KhoaHocBUS();
                        int r = _khoahocBUS.insert_khoahocBUS(txt_makh.Text, txt_tenkh.Text, txt_Mota.Text,double.Parse(txt_hocphi.Text)) ;
                        if (r > 0)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadkhoahoc();
                            txt_makh.Enabled = false;
                            txt_tenkh.Enabled = false;
                            txt_Mota.Enabled = false;
                            txt_hocphi.Enabled = false;
                        }
                        else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                    #endregion
                case 2:
                    #region Update khóa học
                    if (txt_makh.Text.Trim() == "" || txt_tenkh.Text.Trim() == "" || txt_Mota.Text.Trim() == "" || txt_hocphi.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int r = _khoahocBUS.update_khoahocBUS(txt_makh.Text, txt_tenkh.Text, txt_Mota.Text, double.Parse(txt_hocphi.ToString()));
                        if (r > 0)
                        {
                            MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadkhoahoc();
                            txt_makh.Enabled = false;
                            txt_tenkh.Enabled = false;
                            txt_Mota.Enabled = false;
                            txt_hocphi.Enabled = false;
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
            LoadKhoahoctheomakh();
           
        }


    }
}
