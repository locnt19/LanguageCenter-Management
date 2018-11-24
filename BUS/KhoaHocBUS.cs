using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhoaHocBUS
    {
        KhoaHocDAO _kh = new KhoaHocDAO();

        public List<KhoaHocDTO> load_KhoaHocBUS()
        {
            return _kh.load_KhoaHocDAO();
        }

        public List<KhoaHocDTO> load_ChiTietKhoaHocBUS()
        {
            return _kh.load_ChiTietKhoaHocDAO();
        }

        public List<KhoaHocDTO> load_KhoaHocVaChiTietBUS()
        {
            return _kh.load_KhoaHocVaChiTietDAO();
        }

        public List<KhoaHocDTO> tim_KhoaHocBUS(string MaKH)
        {
            return _kh.get_KhoaHocDAO(MaKH);
        }

        public int get_HocPhi(string MaKH)
        {
            return _kh.get_HocPhi(MaKH);
        }

        public int insert_KhoaHocBUS(string MaKH, string TenKH, string MoTa, double Hocphi)
        {
            return _kh.insert_KhoaHocDAO(MaKH, TenKH, MoTa, Hocphi);
        }

        public int insert_ChiTietKhoaHocBUS(string MaKH, string MaPhong, string MaCa, DateTime NgayBatDau)
        {
            return _kh.insert_ChiTietKhoaHocDAO(MaKH, MaPhong, MaCa, NgayBatDau);
        }

        public int update_KhoaHocBUS(string MaKH, string TenKH, string MoTa, double Hocphi)
        {
            return _kh.update_KhoaHocDAO(MaKH, TenKH, MoTa, Hocphi);
        }

        public int update_ChiTietKhoaHocBUS(string MaKH, string MaPhong, string MaCa, DateTime NgayBatDau)
        {
            return _kh.update_ChiTietKhoaHocDAO(MaKH, MaPhong, MaCa, NgayBatDau);
        }

        public int delete_khoahocBUS(string MaKH)
        {
            return _kh.delete_KhoaHocDAO(MaKH);
        }
    }
}
