using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UC
{
    public partial class ucLoaiTaiKhoan : UserControl
    {
        public ucLoaiTaiKhoan()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_LoaiTK.SelectedValue = -1;
        }

        public string LoaiTK
        {
            get { return this.cbb_LoaiTK.SelectedValue.ToString(); }
            set { this.cbb_LoaiTK.SelectedValue = value; }
        }

        private void ucLoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            List<LoaiTaiKhoan> lst_LoaiTK = new List<LoaiTaiKhoan>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From LoaiTaiKhoan Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                LoaiTaiKhoan item = new LoaiTaiKhoan();
                item.MaLoai = sdr["MaLoai"].ToString();
                item.TenLoai = sdr["TenLoai"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                item.STT = (int)sdr["STT"];
                lst_LoaiTK.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_LoaiTK.DataSource = lst_LoaiTK;
            cbb_LoaiTK.ValueMember = "MaLoai";
            cbb_LoaiTK.DisplayMember = "TenLoai";
        }
    }
}
