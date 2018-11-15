using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public NhanVienDTO DangNhapDAO(string TaiKhoan, string MatKhau)
        {
            NhanVienDTO nv = new NhanVienDTO();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From NhanVien NV, TaiKhoan TK Where TK.TenTK = @TaiKhoan AND TK.MatKhau = @MatKhau AND TK.STT=1 AND TK.TenTK = NV.TenTK";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@TaiKhoan", TaiKhoan);
            pars[1] = new SqlParameter("@MatKhau", MatKhau);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, pars, conn);
            while (sdr.Read())
            {
                nv.MaNV = sdr["MaNV"].ToString();
                nv.HoTen = sdr["HoTen"].ToString();
                nv.GioiTinh = (int)sdr["GioiTinh"];
                nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                nv.Email = sdr["Email"].ToString();
                nv.ChucVu = sdr["ChucVu"].ToString();
                nv.TenTK = sdr["TenTK"].ToString();
                nv.Luong = double.Parse(sdr["Luong"].ToString());
                nv.HeSoLuong = double.Parse(sdr["HeSoLuong"].ToString());
                nv.NgayVaoLam = (DateTime)sdr["NgayVaoLam"];
                nv.DiaChi = sdr["DiaChi"].ToString();
                nv.STT = (int)sdr["STT"];
            }
            sdr.Close();
            conn.Close();
            return nv;
        }

        public List<NhanVienDTO> get_NhanVienDAO()
        {
            List<NhanVienDTO> lst_NhanVien = new List<NhanVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From NhanVien Where STT = 1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = sdr["MaNV"].ToString();
                nv.HoTen = sdr["HoTen"].ToString();
                nv.GioiTinh = (int)sdr["GioiTinh"];
                nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                nv.Email = sdr["Email"].ToString();
                nv.SDT = sdr["SDT"].ToString();
                nv.ChucVu = sdr["ChucVu"].ToString();
                nv.TenTK = sdr["TenTK"].ToString();
                nv.Luong = double.Parse(sdr["Luong"].ToString());
                nv.HeSoLuong = double.Parse(sdr["HeSoLuong"].ToString());
                nv.NgayVaoLam = (DateTime)sdr["NgayVaoLam"];
                nv.DiaChi = sdr["DiaChi"].ToString();
                nv.STT = (int)sdr["STT"];
                lst_NhanVien.Add(nv);
            }
            sdr.Close();
            conn.Close();
            return lst_NhanVien;
        }
    }
}
