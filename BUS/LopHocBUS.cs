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
        public List<LopHocDTO> get_LopHocBUS()
        {
            return _lh.get_LopHocDAO();
        }
    }
}
