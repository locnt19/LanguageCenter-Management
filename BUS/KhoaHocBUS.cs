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
        public List<KhoaHocDTO> loadKhoaHocBUS()
        {
            return _kh.loadKhoaHocDAO();
        }
        public List<KhoaHocDTO> load_KhoaHocBUS()
        {
            return _kh.load_KhoaHocDAO();
        }
        public List<KhoaHocDTO> timkhoahoc(string MaKH)
        {
            return _kh.TimKhoaHocDAO(MaKH);
        }
        public int get_HocPhi(string MaKH)
        {
            return _kh.get_HocPhi(MaKH);
        }
        public int insert_khoahocBUS(string MaKH, string TenKH, string MoTa, double Hocphi, string MaPhong, string MaCa, DateTime NgayBatDau)
        {
            return 0;// _kh.insert_KhoaHocDAO(MaKH, TenKH, MoTa, Hocphi, MaPhong, MaCa, NgayBatDau);
        }
        public int update_khoahocBUS(string MaKH, string TenKH, string MoTa, double Hocphi)
        {
            return _kh.update_khoahocDAO(MaKH, TenKH, MoTa, Hocphi);
        }
        public int delete_khoahocBUS(KhoaHocDTO khdto)
        {
            return _kh.delete_khoahocDAO(khdto);
        }
    }
}
