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
            string query = "Select * From KhoaHoc kh,ChiTietKhoaHoc ct Where kh.STT=1 and kh.MaKH=ct.MaKH";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                KhoaHocDTO item = new KhoaHocDTO();
                item.MaKH = sdr["MaKH"].ToString();
                item.MaPhong = sdr["MaPhong"].ToString();
                item.TenKH = sdr["TenKH"].ToString();
                item.MaCa = sdr["MaCa"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                item.HocPhi = double.Parse(sdr["HocPhi"].ToString());                
                item.Ngaybatdau = DateTime.Parse(sdr["Ngaybatdau"].ToString());
                item.STT = int.Parse(sdr["STT"].ToString());
                lst_KhoaHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_KhoaHoc;
        }
        public List<KhoaHocDTO> TimKhoaHocDAO(string MaKH)
        {
            List<KhoaHocDTO> lst_KhoaHoc = new List<KhoaHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From KhoaHoc Where MaKH=@MaKH";
            SqlParameter par = new SqlParameter("@MaKH", MaKH);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query,par, conn);
            while (sdr.Read())
            {
                KhoaHocDTO item = new KhoaHocDTO();
                item.MaKH = sdr["MaKH"].ToString();
                item.MaPhong = sdr["MaPhong"].ToString();
                item.TenKH = sdr["TenKH"].ToString();
                item.MaCa = sdr["MaCa"].ToString();
                item.MoTa = sdr["MoTa"].ToString();
                item.HocPhi = double.Parse(sdr["HocPhi"].ToString());
                item.Ngaybatdau = DateTime.Parse(sdr["Ngaybatdau"].ToString());
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
        public int insert_KhoaHocDAO(string MaKH, string TenKH, string MoTa, double Hocphi)
        {
            string insert = "insert into KhoaHoc values (@MaKH,@TenKH,@MoTa,@Hocphi,1)";
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@MaKH", MaKH);
            para[1] = new SqlParameter("@TenKH", TenKH);
            para[2] = new SqlParameter("@MoTa", MoTa);
            para[3] = new SqlParameter("@Hocphi", Hocphi);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.executeinsert(insert, para, conn);
            conn.Close();
            return ketqua;
        }
        public int update_khoahocDAO(string MaKH, string TenKH, string MoTa, double Hocphi)
        {
            string update = "update KhoaHoc set MaKH=@MaKH, TenKH=@TenKH,MoTa=@MoTa,Hocphi=@Hocphi where MaKH=@MaKH";
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@MaKH", MaKH);
            para[1] = new SqlParameter("@TenKH", TenKH);
            para[2] = new SqlParameter("@MoTa", MoTa);
            para[2] = new SqlParameter("@Hocphi", Hocphi);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.executeupdate(update, para, conn);
            conn.Close();
            return ketqua;
        }
        public int delete_khoahocDAO(KhoaHocDTO khdto)
        {
            string delete = "Update KhoaHoc set STT = 0 where MaKH=@MaKH";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@TenTK", khdto.STT);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.executeupdate(delete, para, conn);
            conn.Close();
            return ketqua;
        }
    }
}
