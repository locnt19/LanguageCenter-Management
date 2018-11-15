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
    public partial class ucKhoaHoc : UserControl
    {
        public ucKhoaHoc()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_KhoaHoc.SelectedValue = -1;
        }

        public string KhoaHoc
        {
            get;
            set;
        }

        private void ucKhoaHoc_Load(object sender, EventArgs e)
        {
            List<KhoaHoc> lst_KhoaHoc = new List<KhoaHoc>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From KhoaHoc Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                KhoaHoc item = new KhoaHoc();
                item.MaKH = sdr["MaKH"].ToString();
                item.TenKH = sdr["TenKH"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                item.HocPhi = double.Parse(sdr["HocPhi"].ToString());
                item.STT = int.Parse(sdr["STT"].ToString());
                lst_KhoaHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_KhoaHoc.DataSource = lst_KhoaHoc;
            cbb_KhoaHoc.ValueMember = "MaKH";
            cbb_KhoaHoc.DisplayMember = "TenKH";
        }
    }
}
