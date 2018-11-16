using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class HocVienDAO
    {
        public int them_HocVienDAO(string MaHV, string HoTen, int GioiTinh, DateTime NgaySinh, string Email, string SDT, string DiaChi)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Insert Into HocVien (MaHV, HoTen, GioiTinh, NgaySinh, Email, SDT, DiaChi) Values (@MaHV, @HoTen, @GioiTinh, @NgaySinh, @Email, @SDT, @DiaChi)";
            SqlParameter[] pars = new SqlParameter[7];
            pars[0] = new SqlParameter("@MaHV", MaHV);
            pars[1] = new SqlParameter("@HoTen", HoTen);
            pars[2] = new SqlParameter("@GioiTinh", GioiTinh);
            pars[3] = new SqlParameter("@NgaySinh", NgaySinh.ToString("MM/dd/yyyy"));
            pars[4] = new SqlParameter("@Email", Email);
            pars[5] = new SqlParameter("@SDT", SDT);
            pars[6] = new SqlParameter("@DiaChi", DiaChi);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(pars);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }

        public int sua_HocVienDAO(string MaHV, string HoTen, int GioiTinh, DateTime NgaySinh, string Email, string SDT, string DiaChi)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Update HocVien set HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, Email=@Email, SDT=@SDT, DiaChi=@DiaChi where MaHV=@MaHV";
            SqlParameter[] pars = new SqlParameter[7];
            pars[0] = new SqlParameter("@MaHV", MaHV);
            pars[1] = new SqlParameter("@HoTen", HoTen);
            pars[2] = new SqlParameter("@GioiTinh", GioiTinh);
            pars[3] = new SqlParameter("@NgaySinh", NgaySinh.ToString("MM/dd/yyyy"));
            pars[4] = new SqlParameter("@Email", Email);
            pars[5] = new SqlParameter("@SDT", SDT);
            pars[6] = new SqlParameter("@DiaChi", DiaChi);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(pars);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }

        public int xoa_HocVienDAO(string MaHV)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "UPDATE HocVien SET STT=0 WHERE MaHV = @MaHV";
            SqlParameter par = new SqlParameter("@MaHV", MaHV);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(par);
            int kq = cmd.ExecuteNonQuery();
            return kq;
        }

        public List<HocVienDTO> get_HocVienDAO()
        {
            List<HocVienDTO> lst_HocVien = new List<HocVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From HocVien Where STT = 1";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while(sdr.Read())
            {
                HocVienDTO hv = new HocVienDTO();
                hv.MaHV = sdr["MaHV"].ToString();
                hv.HoTen = sdr["HoTen"].ToString();
                hv.GioiTinh = (int)sdr["GioiTinh"];
                hv.NgaySinh = (DateTime)sdr["NgaySinh"];
                hv.Email = sdr["Email"].ToString();
                hv.SDT = sdr["SDT"].ToString();
                hv.DiaChi = sdr["DiaChi"].ToString();
                hv.STT = (int)sdr["STT"];
                lst_HocVien.Add(hv);
            }
            sdr.Close();
            conn.Close();
            return lst_HocVien;
        }

        public List<HocVienDTO> tim_HocVienDAO(string HoTen)
        {
            List<HocVienDTO> lst_HocVien = new List<HocVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select * From HocVien HV Where HV.HoTen like '%" + HoTen + "%'";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                HocVienDTO hv = new HocVienDTO();
                hv.MaHV = sdr["MaHV"].ToString();
                hv.HoTen = sdr["HoTen"].ToString();
                hv.GioiTinh = (int)sdr["GioiTinh"];
                hv.NgaySinh = (DateTime)sdr["NgaySinh"];
                hv.Email = sdr["Email"].ToString();
                hv.SDT = sdr["SDT"].ToString();
                hv.DiaChi = sdr["DiaChi"].ToString();
                hv.STT = (int)sdr["STT"];
                lst_HocVien.Add(hv);
            }
            sdr.Close();
            conn.Close();
            return lst_HocVien;
        }
    }
}
