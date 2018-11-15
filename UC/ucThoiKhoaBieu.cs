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
    public partial class ucThoiKhoaBieu : UserControl
    {
        public ucThoiKhoaBieu()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_ThoiKhoaBieu.SelectedValue = -1;
        }

        public string ThoiKhoaBieu
        {
            get;
            set;
        }

        private void ucThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            List<ThoiKhoaBieu> lst_ThoiKhoaBieu = new List<ThoiKhoaBieu>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From ThoiKhoaBieu Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                ThoiKhoaBieu item = new ThoiKhoaBieu();
                item.MaTKB = sdr["MaTKB"].ToString();
                item.STT = (int)sdr["STT"];
                lst_ThoiKhoaBieu.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_ThoiKhoaBieu.DataSource = lst_ThoiKhoaBieu;
            cbb_ThoiKhoaBieu.DisplayMember = "MaTKB";
            cbb_ThoiKhoaBieu.ValueMember = "MaTKB";
        }
    }
}
