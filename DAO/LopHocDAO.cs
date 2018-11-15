using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LopHocDAO
    {
        public List<LopHocDTO> get_LopHocDAO(string MaLop)
        {
            List<LopHocDTO> lst_LopHoc = new List<LopHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select DD.MaLop, DD.MaHV, HV.HoTen, L.PhongHoc, L.MaTKB, DD.SoNgayVang From DiemDanh DD, Lop L, HocVien HV Where DD.MaLop = L.MaLop and DD.MaHV = HV.MaHV and L.MaLop = @MaLop";
            SqlParameter par = new SqlParameter("@MaLop", MaLop);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
            while (sdr.Read())
            {
                LopHocDTO item = new LopHocDTO();
                item.MaLop = sdr["MaLop"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.HoTen = sdr["HoTen"].ToString();
                item.PhongHoc = sdr["PhongHoc"].ToString();
                item.ThoiKhoaBieu = sdr["MaTKB"].ToString();
                item.SoNgayVang = int.Parse(sdr["SoNgayVang"].ToString());
                lst_LopHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_LopHoc;
        }
    }
}
