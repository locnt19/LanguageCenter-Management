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
    public partial class ucPhongHoc : UserControl
    {
        public ucPhongHoc()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_PhongHoc.SelectedValue = -1;
        }

        public string PhongHoc
        {
            get { return this.cbb_PhongHoc.SelectedValue.ToString(); }
            set { this.cbb_PhongHoc.SelectedValue = value; }
        }

        private void ucPhongHoc_Load(object sender, EventArgs e)
        {
            List<PhongHoc> lst_PhongHoc = new List<PhongHoc>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From Phong Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                PhongHoc item = new PhongHoc();
                item.MaPhong = sdr["MaPhong"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                item.STT = (int)sdr["STT"];
                lst_PhongHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            cbb_PhongHoc.DataSource = lst_PhongHoc;
            cbb_PhongHoc.ValueMember = "MaPhong";
            cbb_PhongHoc.DisplayMember = "MoTa";
        }
    }
}
