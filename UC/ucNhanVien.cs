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
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbb_NhanVien.SelectedValue = -1;
        }

        public string NhanVien
        {
            get { return this.cbb_NhanVien.SelectedValue.ToString(); }
            set { this.cbb_NhanVien.SelectedValue = value; }
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> lst_NhanVien = new List<NhanVien>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From NhanVien Where ChucVu = 'KT' and STT = 1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = sdr["MaNV"].ToString();
                nv.HoTen = sdr["HoTen"].ToString();
                nv.GioiTinh = (int)sdr["GioiTinh"];
                nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                nv.Email = sdr["Email"].ToString();
                nv.SDT = sdr["SDT"].ToString();
                nv.ChucVu = sdr["ChucVu"].ToString();
                nv.TenTK = sdr["TenTK"].ToString();
                nv.Luong = double.Parse(sdr["Luong"].ToString());
                nv.HeSoLuong = double.Parse(sdr["HeSoLuong"].ToString());
                nv.NgayVaoLam = (DateTime)sdr["NgayVaoLam"];
                nv.DiaChi = sdr["DiaChi"].ToString();
                nv.STT = (int)sdr["STT"];
                lst_NhanVien.Add(nv);
            }
            sdr.Close();
            conn.Close();
            cbb_NhanVien.DataSource = lst_NhanVien;
            cbb_NhanVien.DisplayMember = "HoTen";
            cbb_NhanVien.ValueMember = "MaNV";

        }
    }
}
