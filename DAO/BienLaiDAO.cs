using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class BienLaiDAO
    {
        public List<BienLaiDTO> get_BienlaiDAO(string MaBienLai)
        {
            List<BienLaiDTO> lst_TaiKhoan = new List<BienLaiDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * from BienLai where MaBienLai= @MaBienLai";
            SqlParameter par = new SqlParameter("@MaBienLai", MaBienLai);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
            while (sdr.Read())
            {
                BienLaiDTO item = new BienLaiDTO();
                item.MaBienLai = sdr["MaBienLai"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.TongThanhToan = int.Parse(sdr["TongThanhToan"].ToString());
                item.NguoiLap = sdr["NguoiLap"].ToString();
                item.NgayLap = (DateTime)sdr["NgayLap"];
                lst_TaiKhoan.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_TaiKhoan;
        }
        public List<BienLaiDTO> load_BienLaiDAO()
        {
            List<BienLaiDTO> lst_Bienlai = new List<BienLaiDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * from BienLai ";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                BienLaiDTO item = new BienLaiDTO();
                item.MaBienLai = sdr["MaBienLai"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.TongThanhToan = int.Parse(sdr["TongThanhToan"].ToString());
                item.NguoiLap = sdr["NguoiLap"].ToString();
                item.NgayLap = DateTime.Parse(sdr["NgayLap"].ToString());
                lst_Bienlai.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_Bienlai;
        }

        public int insert_BienLaiDAO(string MaBienLai, string MaHV, double TongThanhToan, string NguoiLap, DateTime NgayLap)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Insert Into BienLai (MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap) Values (@MaBienLai, @MaHV, @TongThanhToan, @NguoiLap, @NgayLap)";
            SqlParameter[] pars = new SqlParameter[5];
            pars[0] = new SqlParameter("@MaBienLai", MaBienLai);
            pars[1] = new SqlParameter("@MaHV", MaHV);
            pars[2] = new SqlParameter("@TongThanhToan", TongThanhToan);
            pars[3] = new SqlParameter("@NguoiLap", NguoiLap);
            pars[4] = new SqlParameter("@NgayLap", NgayLap.ToString("MM/dd/yyyy"));
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(pars);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
    }
}
