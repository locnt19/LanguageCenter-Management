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
    public partial class ucChucVu : UserControl
    {
        public ucChucVu()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_ChucVu.SelectedValue = -1;
        }

        public string ChucVu
        {
            get { return this.cbb_ChucVu.SelectedValue.ToString(); }
            set { this.cbb_ChucVu.SelectedValue = value; }
        }

        private void ucChucVu_Load(object sender, EventArgs e)
        {
            List<ChucVu> lst_ChucVu = new List<ChucVu>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From ChucVu Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                ChucVu item = new ChucVu();
                item.MaCV = sdr["MaCV"].ToString();
                item.TenCV = sdr["TenCV"].ToString();
                item.LuongCB = double.Parse(sdr["LuongCB"].ToString());
                item.STT = int.Parse(sdr["STT"].ToString());
                lst_ChucVu.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_ChucVu.DataSource = lst_ChucVu;
            cbb_ChucVu.ValueMember = "MaCV";
            cbb_ChucVu.DisplayMember = "TenCV";
        }
    }
}
