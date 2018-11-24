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
        public List<KhoaHocDTO> load_KhoaHocDAO()
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

        public List<KhoaHocDTO> load_KhoaHocVaChiTietDAO()
        {
            List<KhoaHocDTO> lst_KhoaHoc = new List<KhoaHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "select KH.MaKH, KH.TenKH, KH.MoTa, KH.HocPhi, CT.MaPhong, CT.MaCa, CT.NgayBatDau from KhoaHoc KH, ChiTietKhoaHoc CT where KH.MaKH = CT.MaKH";
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
                lst_KhoaHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_KhoaHoc;
        }

        public List<KhoaHocDTO> load_ChiTietKhoaHocDAO()
        {
            List<KhoaHocDTO> lst_KhoaHoc = new List<KhoaHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From ChiTietKhoaHoc Where STT=1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                KhoaHocDTO item = new KhoaHocDTO();
                item.MaKH = sdr["MaKH"].ToString();
                item.MaPhong = sdr["MaPhong"].ToString();
                item.MaCa = sdr["MaCa"].ToString();
                item.Ngaybatdau = DateTime.Parse(sdr["Ngaybatdau"].ToString());
                item.STT = int.Parse(sdr["STT"].ToString());
                lst_KhoaHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_KhoaHoc;
        }
        public List<KhoaHocDTO> get_KhoaHocDAO(string MaKH)
        {
            List<KhoaHocDTO> lst_KhoaHoc = new List<KhoaHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "select KH.MaKH, KH.TenKH, KH.MoTa, KH.HocPhi, CT.MaPhong, CT.MaCa, CT.NgayBatDau from KhoaHoc KH, ChiTietKhoaHoc CT where KH.MaKH = CT.MaKH AND KH.MaKH = @MaKH";
            SqlParameter par = new SqlParameter("@MaKH", MaKH);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
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
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
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
            string query = "insert into KhoaHoc values (@MaKH,@TenKH,@MoTa,@Hocphi,1)";
            SqlParameter[] par = new SqlParameter[4];
            par[0] = new SqlParameter("@MaKH", MaKH);
            par[1] = new SqlParameter("@TenKH", TenKH);
            par[2] = new SqlParameter("@MoTa", MoTa);
            par[3] = new SqlParameter("@Hocphi", Hocphi);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanInsert(query, par, conn);
            conn.Close();
            return ketqua;
        }

        public int insert_ChiTietKhoaHocDAO(string MaKH, string MaPhong, string MaCa, DateTime NgayBatDau)
        {
            string query = "insert into ChiTietKhoaHoc values (@MaKH,@MaPhong,@MaCa,@NgayBatDau,1)";
            SqlParameter[] par = new SqlParameter[4];
            par[0] = new SqlParameter("@MaKH", MaKH);
            par[1] = new SqlParameter("@MaPhong", MaPhong);
            par[2] = new SqlParameter("@MaCa", MaCa);
            par[3] = new SqlParameter("@NgayBatDau", NgayBatDau);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanInsert(query, par, conn);
            conn.Close();
            return ketqua;
        }

        public int update_KhoaHocDAO(string MaKH, string TenKH, string MoTa, double Hocphi)
        {
            string query = "update KhoaHoc set MaKH=@MaKH, TenKH=@TenKH,MoTa=@MoTa,Hocphi=@Hocphi where MaKH=@MaKH";
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@MaKH", MaKH);
            para[1] = new SqlParameter("@TenKH", TenKH);
            para[2] = new SqlParameter("@MoTa", MoTa);
            para[3] = new SqlParameter("@Hocphi", Hocphi);
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(para);
            int ketqua = cmd.ExecuteNonQuery();
            conn.Close();
            return ketqua;
        }

        public int update_ChiTietKhoaHocDAO(string MaKH, string MaPhong, string MaCa, DateTime NgayBatDau)
        {
            string query = "update ChiTietKhoaHoc set MaKH=@MaKH, MaPhong=@MaPhong, MaCa=@MaCa, NgayBatDau=@NgayBatDau where MaKH=@MaKH";
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@MaKH", MaKH);
            para[1] = new SqlParameter("@MaPhong", MaPhong);
            para[2] = new SqlParameter("@MaCa", MaCa);
            para[3] = new SqlParameter("@NgayBatDau", NgayBatDau);
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(para);
            int ketqua = cmd.ExecuteNonQuery();
            conn.Close();
            return ketqua;
        }

        public int delete_KhoaHocDAO(string MaKH)
        {
            string query = "Update KhoaHoc set STT = 0 where MaKH=@MaKH";
            SqlParameter par = new SqlParameter("@MaKH", MaKH);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanUpdate(query, par, conn);
            conn.Close();
            return ketqua;
        }
    }
}
