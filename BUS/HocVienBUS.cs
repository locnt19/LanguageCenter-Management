using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HocVienBUS
    {

        HocVienDAO _hv = new HocVienDAO();

        public List<HocVienDTO> get_HocVienBUS()
        {
            return _hv.get_HocVienDAO();
        }

        public int them_HocVienBUS(string MaHV, string HoTen, int GioiTinh, DateTime NgaySinh, string Email, string SDT, string DiaChi)
        {
            return _hv.them_HocVienDAO(MaHV, HoTen, GioiTinh, NgaySinh, Email, SDT, DiaChi);
        }

        public int sua_HocVienBUS(string MaHV, string HoTen, int GioiTinh, DateTime NgaySinh, string Email, string SDT, string DiaChi)
        {
            return _hv.sua_HocVienDAO(MaHV, HoTen, GioiTinh, NgaySinh, Email, SDT, DiaChi);
        }

        public int xoa_HocVienBUS(string MaHV)
        {
            return _hv.xoa_HocVienDAO(MaHV);
        }
    }
}
