using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public List<TaiKhoanDTO> get_TaiKhoanDAO(string TenTK)
        {
            List<TaiKhoanDTO> lst_TaiKhoan = new List<TaiKhoanDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * from TaiKhoan where TenTK= @TenTK";
            SqlParameter par = new SqlParameter("@TenTK", TenTK);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
            while (sdr.Read())
            {
                TaiKhoanDTO item = new TaiKhoanDTO();
                item.TenTK = sdr["TenTK"].ToString();
                item.MatKhau = sdr["MatKhau"].ToString();
                item.LoaiTK = sdr["LoaiTK"].ToString();
                lst_TaiKhoan.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_TaiKhoan;
        }
        public List<TaiKhoanDTO> load_TaiKhoanDAO()
        {
            List<TaiKhoanDTO> lst_TaiKhoan = new List<TaiKhoanDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * from TaiKhoan where STT=1 ";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                TaiKhoanDTO item = new TaiKhoanDTO();
                item.TenTK = sdr["TenTK"].ToString();
                item.MatKhau = sdr["MatKhau"].ToString();
                item.LoaiTK = sdr["LoaiTK"].ToString();
                lst_TaiKhoan.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_TaiKhoan;
        }

        public int insert_TaiKhoanDAO(string TenTK, string MatKhau, string LoaiTK)
        {
            string insert = "insert into TAIKHOAN values (@TenTK,@MatKhau,@LoaiTK,1)";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@TenTK", TenTK);
            para[1] = new SqlParameter("@MatKhau", MatKhau);
            para[2] = new SqlParameter("@LoaiTK", LoaiTK);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.executeinsert(insert, para, conn);
            conn.Close();
            return ketqua;
        }
        public int insert_TaiKhoanDAO(TaiKhoanDTO tkdto)
        {
            string insert = "insert into TAIKHOAN values (@TenTK,@MatKhau,@LoaiTK,1)";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@TenTK", tkdto.TenTK);
            para[1] = new SqlParameter("@MatKhau", tkdto.MatKhau);
            para[2] = new SqlParameter("@LoaiTK", tkdto.LoaiTK);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.executeinsert(insert, para, conn);
            conn.Close();
            return ketqua;
        }
        public int update_MatKhauvaloaiTaiKhoanDAO(TaiKhoanDTO tkdto)
        {
            string update = "update TAIKHOAN set MatKhau=@MatKhau, LoaiTK=@LoaiTK where TenTK=@TenTK";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@TenTK", tkdto.TenTK);
            para[1] = new SqlParameter("@MatKhau", tkdto.MatKhau);
            para[2] = new SqlParameter("@LoaiTK", tkdto.LoaiTK);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.executeupdate(update, para, conn);
            conn.Close();
            return ketqua;
        }
        public int delete_TaiKhoanDAO(TaiKhoanDTO tkdto)
        {
            string delete = "Update TAIKHOAN set STT = 0 where TenTK=@TenTK";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@TenTK", tkdto.TenTK);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.executeupdate(delete, para, conn);
            conn.Close();
            return ketqua;
        }
    }
}
