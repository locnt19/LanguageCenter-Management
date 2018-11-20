using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FormTimHocVien : Form
    {
        public FormTimHocVien()
        {
            InitializeComponent();
            dgv_HocVien.AutoGenerateColumns = false;
            dgv_HocVien.AllowUserToAddRows = false;
            dgv_HocVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HocVien.ReadOnly = true;
            dgv_HocVien.MultiSelect = false;
            AcceptButton = btn_Tim;
        }

        HocVienBUS _hv = new HocVienBUS();
        List<HocVienDTO> lst_HocVien = new List<HocVienDTO>();
        HocVienDTO _hvDaChon = null;

        public HocVienDTO HocVienDaChon
        {
            get { return this._hvDaChon; }
            set { this._hvDaChon = value; }
        }

        private void FormTimHocVien_Load(object sender, EventArgs e)
        {
            lst_HocVien = _hv.get_HocVienBUS();
            dgv_HocVien.DataSource = lst_HocVien;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            lst_HocVien = _hv.tim_HocVienDAO(txt_Tim.Text);
            dgv_HocVien.DataSource = null;
            dgv_HocVien.DataSource = lst_HocVien;
        }

        private void dgv_HocVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn chọn học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                _hvDaChon = (HocVienDTO)dgv_HocVien.SelectedRows[0].DataBoundItem;
                this.Dispose();
            }
            else
            {
                _hvDaChon = null;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lst_HocVien = _hv.get_HocVienBUS();
            dgv_HocVien.DataSource = lst_HocVien;
        }
    }
}
