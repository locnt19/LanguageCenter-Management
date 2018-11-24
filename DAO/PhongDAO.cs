using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhongDAO
    {
        public List<PhongDTO> get_PhongDAO(string MaPhong)
        {
            List<PhongDTO> lst_Phong = new List<PhongDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * from Phong where MaPhong= @MaPhong";
            SqlParameter par = new SqlParameter("@MaPhong", MaPhong);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
            while (sdr.Read())
            {
                PhongDTO item = new PhongDTO();
                item.MaPhong = sdr["MaPhong"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                lst_Phong.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_Phong;
        }
        public List<PhongDTO> Load_PhongDao()
        {
            List<PhongDTO> lst_Phong = new List<PhongDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * from Phong where STT=1 ";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                PhongDTO item = new PhongDTO();
                item.MaPhong = sdr["MaPhong"].ToString();
                item.MoTa = sdr["MoTa"].ToString();

                lst_Phong.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_Phong;
        }
        public int insert_PhongnDAO(PhongDTO phongdto)
        {
            string insert = "insert into PHONG values (@MaPhong,@MoTa,1)";
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@MaPhong", phongdto.MaPhong);
            para[1] = new SqlParameter("@MoTa", phongdto.MoTa);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanInsert(insert, para, conn);
            conn.Close();
            return ketqua;
        }
        public int update_PhongDAO(PhongDTO phongdto)
        {
            string update = "update PHONG set MoTa=@MoTa where MaPhong=@MaPhong";
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@MaPhong", phongdto.MaPhong);
            para[1] = new SqlParameter("@MoTa", phongdto.MoTa);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanUpdate(update, para, conn);
            conn.Close();
            return ketqua;
        }
        public int delete_PhongDAO(PhongDTO phongdto)
        {
            string delete = "Update PHONG set STT = 0 where MaPhong=@MaPhong";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MaPhong", phongdto.MaPhong);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanUpdate(delete, para, conn);
            conn.Close();
            return ketqua;
        }
    }
}
