using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class KetQuaDAO
    {
        public List<KetQuaDTO> get_KetQuaDAO()
        {
            List<KetQuaDTO> lst_KQ = new List<KetQuaDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select HV.MaHV, HV.HoTen, HV.LopHoc, CT.MaKetQua, CT.MaMonHoc, CT.MaKH, CT.Diem, CT.SoNgayNghi, KQ.STT From HocVien HV, KetQuaHocTap KQ, ChiTietKetQuaHocTap CT Where KQ.MaKetQua = CT.MaKetQua AND HV.MaKetQua=KQ.MaKetQua AND KQ.STT = 1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                KetQuaDTO item = new KetQuaDTO();
                item.MaHV = sdr["MaHV"].ToString();
                item.HoTen = sdr["HoTen"].ToString();
                item.LopHoc = sdr["LopHoc"].ToString();
                item.MaKetQua = sdr["MaKetQua"].ToString();
                item.MaMonHoc = sdr["MaMonHoc"].ToString();
                item.MaKH = sdr["MaKH"].ToString();
                item.Diem = (double)sdr["Diem"];
                item.SoNgayNghi = (int)sdr["SoNgayNghi"];
                item.STT = (int)sdr["STT"];
                lst_KQ.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_KQ;
        }
    }
}
