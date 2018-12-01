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
        public List<NhanVienDTO> tim_NhanvienDAO(string MaNV)
        {
            List<NhanVienDTO> lst_Phong = new List<NhanVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "SELECT * FROM NhanVien where MaNV LIKE N'%{0}%'";
            //SqlParameter par = new SqlParameter("@MaNV", MaNV);
            //SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(string.Format(query, MaNV), conn);
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
                lst_Phong.Add(nv);
            }
            sdr.Close();
            conn.Close();
            return lst_Phong;
        }
        public int insert_NhanvienDAO(string MaNV, string HoTen, int GioiTinh,DateTime NgaySinh, string Email, string SDT, string DiaChi, string ChucVu, DateTime NgayVaoLam, double Luong, double HeSoLuong)
        {
            string insert = "insert into NHANVIEN values (@MaNV,NULL,@HoTen,@GioiTinh,@NgaySinh,@Email,@SDT,@DiaChi,@ChucVu,@NgayVaoLam,@Luong,@HeSoLuong,1)";
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@MaNV", MaNV);
            //para[1] = new SqlParameter("@TenTK", TenTK);
            para[1] = new SqlParameter("@HoTen", HoTen);
            para[2] = new SqlParameter("@GioiTinh",GioiTinh);
            para[3] = new SqlParameter("@NgaySinh",NgaySinh.ToString("yyyy/MM/dd"));
            para[4] = new SqlParameter("@Email", Email);
            para[5] = new SqlParameter("@Sdt", SDT);
            para[6] = new SqlParameter("@DiaChi", DiaChi);
            para[7] = new SqlParameter("@ChucVu",ChucVu);
            para[8] = new SqlParameter("@NgayVaoLam",NgayVaoLam.ToString("yyyy/MM/dd"));
            para[9] = new SqlParameter("@Luong", Luong);
            para[10] = new SqlParameter("@HeSoLuong", HeSoLuong);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanInsert(insert, para, conn);
            conn.Close();
            return ketqua;           
        }

        public int update_NhanvienDAO(NhanVienDTO nvdto)
        {
            string update = "update NHANVIEN set HoTen=@HoTen,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,Email=@Email,Sdt=@Sdt,DiaChi=@DiaChi,ChucVu=@ChucVu,NgayVaoLam=@NgayVaoLam,Luong=@Luong,HeSoLuong=@HeSoLuong where MaNV=@MaNV";
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@MaNV", nvdto.MaNV);
            para[1] = new SqlParameter("@HoTen", nvdto.HoTen);
            para[2] = new SqlParameter("@GioiTinh", nvdto.GioiTinh);
            para[3] = new SqlParameter("@NgaySinh", nvdto.NgaySinh.ToString("yyyy/MM/dd"));
            para[4] = new SqlParameter("@Email", nvdto.Email);
            para[5] = new SqlParameter("@Sdt", nvdto.SDT);
            para[6] = new SqlParameter("@DiaChi", nvdto.DiaChi);
            para[7] = new SqlParameter("@ChucVu", nvdto.ChucVu);
            para[8] = new SqlParameter("@NgayVaoLam", nvdto.NgayVaoLam.ToString("yyyy/MM/dd"));
            para[9] = new SqlParameter("@Luong", nvdto.Luong);
            para[10] = new SqlParameter("@HeSoLuong", nvdto.HeSoLuong);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanUpdate(update, para, conn);
            conn.Close();
            return ketqua;
        }
        public int delete_NhanvienDAO(NhanVienDTO nvdto)
        {
            string delete = "Update NHANVIEN set STT = 0 where MaNV=@MaNV";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MaNV", nvdto.MaNV);
            SqlConnection conn = DataProvider.TaoKetNoi();
            int ketqua = DataProvider.TruyVanUpdate(delete, para, conn);
            conn.Close();
            return ketqua;
        }
    }
}
