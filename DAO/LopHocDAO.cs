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
        public List<LopHocDTO> get_LopHocDAO()
        {
            List<LopHocDTO> lst_LopHoc = new List<LopHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From LopHoc Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                LopHocDTO item = new LopHocDTO();
                item.MaLop = sdr["MaLop"].ToString();
                item.SiSo = (int)sdr["SiSo"];
                item.PhongHoc = sdr["PhongHoc"].ToString();
                item.ThoiKhoaBieu = sdr["ThoiKhoaBieu"].ToString();
                item.STT = (int)sdr["STT"];
                lst_LopHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_LopHoc;
        }
    }
}
