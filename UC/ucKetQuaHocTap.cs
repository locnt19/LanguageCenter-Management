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
    public partial class ucKetQuaHocTap : UserControl
    {
        public ucKetQuaHocTap()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_KetQuaHocTap.SelectedValue = -1;
        }

        public string MaKetQua
        {
            get { return this.cbb_KetQuaHocTap.SelectedValue.ToString(); }
            set { this.cbb_KetQuaHocTap.SelectedValue = value; }
        }

        private void ucKetQuaHocTap_Load(object sender, EventArgs e)
        {
            List<KetQuaHocTap> lst_KetQua = new List<KetQuaHocTap>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From KetQua Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                KetQuaHocTap item = new KetQuaHocTap();
                item.MaLop = sdr["MaLop"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.Nghe = double.Parse(sdr["Nghe"].ToString());
                item.Noi = double.Parse(sdr["Noi"].ToString());
                item.Doc = double.Parse(sdr["Doc"].ToString());
                item.Viet = double.Parse(sdr["Viet"].ToString());
                item.STT = int.Parse(sdr["STT"].ToString());
                lst_KetQua.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_KetQuaHocTap.DataSource = lst_KetQua;
            cbb_KetQuaHocTap.ValueMember = "MaLop";
            cbb_KetQuaHocTap.DisplayMember = "MaLop";
        }

    }
}
