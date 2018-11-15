using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KetQuaBUS
    {
        KetQuaDAO _kq = new KetQuaDAO();
        public List<KetQuaDTO> get_KetQuaBUS()
        {
            return _kq.get_KetQuaDAO();
        }
    }
}
