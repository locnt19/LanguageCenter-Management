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
    public partial class ucLopHoc : UserControl
    {
        public ucLopHoc()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_LopHoc.SelectedValue = -1;
        }

        public string LopHoc
        {
            get;
            set;
        }

        private void ucLopHoc_Load(object sender, EventArgs e)
        {
            List<LopHoc> lst_LopHoc = new List<LopHoc>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From Lop Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                LopHoc item = new LopHoc();
                item.MaLop = sdr["MaLop"].ToString();
                item.MaTKB = sdr["MaTKB"].ToString();
                item.PhongHoc = sdr["PhongHoc"].ToString();
                item.STT = (int)sdr["STT"];
                lst_LopHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_LopHoc.DataSource = lst_LopHoc;
            cbb_LopHoc.DisplayMember = "MaLop";
            cbb_LopHoc.ValueMember = "MaLop";
        }
    }
}
