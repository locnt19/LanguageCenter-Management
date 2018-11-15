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
    public partial class ucCaHoc : UserControl
    {
        public ucCaHoc()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_CaHoc.SelectedValue = -1;
        }

        public string CaHoc
        {
            get;
            set;
        }

        private void ucCaHoc_Load(object sender, EventArgs e)
        {
            List<CaHoc> lst_CaHoc = new List<CaHoc>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From CaHoc Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                CaHoc item = new CaHoc();
                item.MaCa = sdr["MaCa"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                item.STT = int.Parse(sdr["STT"].ToString());
                lst_CaHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_CaHoc.DataSource = lst_CaHoc;
            cbb_CaHoc.ValueMember = "MaCa";
            cbb_CaHoc.DisplayMember = "MoTa";
        }
    }
}
