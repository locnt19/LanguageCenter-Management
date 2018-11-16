using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LopHocDAO
    {
        public List<ChiTietLopHocDTO> get_LopHocDAO(string MaLop)
        {
            List<ChiTietLopHocDTO> lst_LopHoc = new List<ChiTietLopHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select DD.MaLop, DD.MaHV, HV.HoTen, L.PhongHoc, L.MaTKB, DD.SoNgayVang, KQ.Nghe, KQ.Noi, KQ.Doc, KQ.Viet From DiemDanh DD, Lop L, HocVien HV, KetQua KQ Where L.MaLop = @MaLop and DD.MaLop = L.MaLop and DD.MaHV = KQ.MaHV and KQ.MaHV = HV.MaHV and L.MaLop = KQ.MaLop";
            SqlParameter par = new SqlParameter("@MaLop", MaLop);
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, par, conn);
            while (sdr.Read())
            {
                ChiTietLopHocDTO item = new ChiTietLopHocDTO();
                item.MaLop = sdr["MaLop"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.HoTen = sdr["HoTen"].ToString();
                item.PhongHoc = sdr["PhongHoc"].ToString();
                item.MaTKB = sdr["MaTKB"].ToString();
                item.SoNgayVang = int.Parse(sdr["SoNgayVang"].ToString());
                item.Nghe = double.Parse(sdr["Nghe"].ToString());
                item.Noi = double.Parse(sdr["Noi"].ToString());
                item.Doc = double.Parse(sdr["Doc"].ToString());
                item.Viet = double.Parse(sdr["Viet"].ToString());
                lst_LopHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_LopHoc;
        }

        public List<ChiTietLopHocDTO> tim_LopHocDAO(string HoTen)
        {
            List<ChiTietLopHocDTO> lst_LopHoc = new List<ChiTietLopHocDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Select DD.MaLop, DD.MaHV, HV.HoTen, L.PhongHoc, L.MaTKB, DD.SoNgayVang, KQ.Nghe, KQ.Noi, KQ.Doc, KQ.Viet From DiemDanh DD, Lop L, HocVien HV, KetQua KQ Where HV.HoTen like '%" +HoTen+ "%' and DD.MaLop = L.MaLop and DD.MaHV = KQ.MaHV and KQ.MaHV = HV.MaHV and L.MaLop = KQ.MaLop";
            SqlDataReader sdr = DataProvider.ThucHienTruyVan(query, conn);
            while (sdr.Read())
            {
                ChiTietLopHocDTO item = new ChiTietLopHocDTO();
                item.MaLop = sdr["MaLop"].ToString();
                item.MaHV = sdr["MaHV"].ToString();
                item.HoTen = sdr["HoTen"].ToString();
                item.PhongHoc = sdr["PhongHoc"].ToString();
                item.MaTKB = sdr["MaTKB"].ToString();
                item.SoNgayVang = int.Parse(sdr["SoNgayVang"].ToString());
                item.Nghe = double.Parse(sdr["Nghe"].ToString());
                item.Noi = double.Parse(sdr["Noi"].ToString());
                item.Doc = double.Parse(sdr["Doc"].ToString());
                item.Viet = double.Parse(sdr["Viet"].ToString());
                lst_LopHoc.Add(item);
            }
            sdr.Close();
            conn.Close();
            return lst_LopHoc;
        }

        public int nhap_DiemDAO(string MaHV, string MaLop, double Nghe, double Noi, double Doc, double Viet)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Update KetQua Set Nghe=@Nghe, Noi=@Noi, Doc=@Doc, Viet=@Viet Where MaHV=@MaHV and MaLop=@MaLop";
            SqlParameter[] pars = new SqlParameter[6];
            pars[0] = new SqlParameter("@Nghe", Nghe);
            pars[1] = new SqlParameter("@Noi", Noi);
            pars[2] = new SqlParameter("@Doc", Doc);
            pars[3] = new SqlParameter("@Viet", Viet);
            pars[4] = new SqlParameter("@MaHV", MaHV);
            pars[5] = new SqlParameter("@MaLop", MaLop);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(pars);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public int diem_DanhDAO(string MaHV, string MaLop, int SoNgayVang)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string query = "Update DiemDanh Set SoNgayVang=@SoNgayVang Where MaHV=@MaHV and MaLop=@MaLop";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@SoNgayVang", SoNgayVang);
            pars[1] = new SqlParameter("@MaHV", MaHV);
            pars[2] = new SqlParameter("@MaLop", MaLop);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(pars);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}
