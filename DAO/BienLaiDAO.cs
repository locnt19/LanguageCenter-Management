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
        public List<BienLaiDTO> tim_BienlaiDAO(string key)
        {
            List<BienLaiDTO> lst_Bienlai = new List<BienLaiDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "SELECT BL.MaBienLai, BL.MaHV, HV.HoTen as HoTenHV, CT.KhoaHoc, CT.HocPhi, BL.TongThanhToan, BL.NguoiLap, NV.HoTen as HoTenNV, BL.NgayLap FROM HocVien HV, NhanVien NV, BienLai BL, ChiTietBienLai CT WHERE BL.MaBienLai = CT.MaBienLai AND BL.MaHV = HV.MaHV AND BL.NguoiLap = NV.MaNV AND ( BL.MaBienLai like '%" + key + "%' OR HV.HoTen like '%" + key + "%' OR NV.HoTen like '%" + key + "%')";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                BienLaiDTO item = new BienLaiDTO();
                item.MaBienLai = sdr["MaBienLai"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.HoTenHV = sdr["HoTenHV"].ToString();
                item.MaKH = sdr["KhoaHoc"].ToString();
                item.HocPhi = int.Parse(sdr["HocPhi"].ToString());
                item.TongThanhToan = int.Parse(sdr["TongThanhToan"].ToString());
                item.NguoiLap = sdr["NguoiLap"].ToString();
                item.HoTenNV = sdr["HoTenNV"].ToString();
                item.NgayLap = DateTime.Parse(sdr["NgayLap"].ToString());
                lst_Bienlai.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_Bienlai;
        }
        public List<BienLaiDTO> load_BienLaiDAO()
        {
            List<BienLaiDTO> lst_Bienlai = new List<BienLaiDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "SELECT BL.MaBienLai, BL.MaHV, HV.HoTen as HoTenHV, CT.KhoaHoc, CT.HocPhi, BL.TongThanhToan, BL.NguoiLap, NV.HoTen as HoTenNV, BL.NgayLap FROM HocVien HV, NhanVien NV, BienLai BL, ChiTietBienLai CT WHERE BL.MaBienLai = CT.MaBienLai AND BL.MaHV = HV.MaHV AND BL.NguoiLap = NV.MaNV";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                BienLaiDTO item = new BienLaiDTO();
                item.MaBienLai = sdr["MaBienLai"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.HoTenHV = sdr["HoTenHV"].ToString();
                item.MaKH = sdr["KhoaHoc"].ToString();
                item.HocPhi = int.Parse(sdr["HocPhi"].ToString());
                item.TongThanhToan = int.Parse(sdr["TongThanhToan"].ToString());
                item.NguoiLap = sdr["NguoiLap"].ToString();
                item.HoTenNV = sdr["HoTenNV"].ToString();
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

        public int insert_ChiTietBienLaiDAO(string MaBienLai, string KhoaHoc, double HocPhi)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES(@MaBienLai, @KhoaHoc, @HocPhi)";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaBienLai", MaBienLai);
            pars[1] = new SqlParameter("@KhoaHoc", KhoaHoc);
            pars[2] = new SqlParameter("@HocPhi", HocPhi);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(pars);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
    }
}
