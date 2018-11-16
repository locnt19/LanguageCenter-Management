using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LopHocBUS
    {
        LopHocDAO _lh = new LopHocDAO();

        public List<ChiTietLopHocDTO> get_LopHocBUS(string MaLop)
        {
            return _lh.get_LopHocDAO(MaLop);
        }

        public List<ChiTietLopHocDTO> tim_LopHocBUS(string HoTen)
        {
            return _lh.tim_LopHocDAO(HoTen);
        }

        public int nhap_DiemBUS(string MaHV, string MaLop, double Nghe, double Noi, double Doc, double Viet)
        {
            return _lh.nhap_DiemDAO(MaHV, MaLop, Nghe, Noi, Doc, Viet);
        }

        public int diem_DanhBUS(string MaHV, string MaLop, int SoNgayVang)
        {
            return _lh.diem_DanhDAO(MaHV, MaLop, SoNgayVang);
        }
    }
}
