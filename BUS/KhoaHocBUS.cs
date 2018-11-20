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
        public List<KhoaHocDTO> loadKhoaHocDAO()
        {
            return _kh.loadKhoaHocDAO();
        }
        public int get_HocPhi(string MaKH)
        {
            return _kh.get_HocPhi(MaKH);
        }
    }
}
