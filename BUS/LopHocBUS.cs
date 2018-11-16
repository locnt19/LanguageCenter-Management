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
    }
}
