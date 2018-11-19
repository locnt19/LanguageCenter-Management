using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BienLaiBUS
    {
        BienLaiDAO _bl = new BienLaiDAO();
        public List<BienLaiDTO> get_BienlaiBUS(string MaBL)
        {
            return _bl.get_BienlaiDAO(MaBL);
        }
        public List<BienLaiDTO> load_BienLaiBUS()
        {
            return _bl.load_BienLaiDAO();
        }
        public int insert_BienLaiBUS(string MaBienLai, string MaHV, double TongThanhToan, string NguoiLap, DateTime NgayLap)
        {
            return _bl.insert_BienLaiDAO(MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap);
        }
    }
}
