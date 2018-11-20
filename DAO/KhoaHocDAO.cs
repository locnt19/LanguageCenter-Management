using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class KhoaHocDAO
    {
        public List<KhoaHocDTO> loadKhoaHocDAO()
        {
            List<KhoaHocDTO> lst_KhoaHoc = new List<KhoaHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From KhoaHoc Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                KhoaHocDTO item = new KhoaHocDTO();
                item.MaKH = sdr["MaKH"].ToString();
                item.TenKH = sdr["TenKH"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                item.HocPhi = double.Parse(sdr["HocPhi"].ToString());
                item.STT = int.Parse(sdr["STT"].ToString());
                lst_KhoaHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_KhoaHoc;
        }

        public int get_HocPhi(string MaKH)
        {
            int HocPhi = 0;
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select HocPhi From KhoaHoc Where MaKH = @MaKH and STT=1";
            SqlParameter par = new SqlParameter("@MaKH", MaKH);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par,conn);
            if (sdr.Read())
            {
                HocPhi = int.Parse(sdr["HocPhi"].ToString());
            }
            sdr.Close();
            conn.Close();
            return HocPhi;
        }
    }
}
