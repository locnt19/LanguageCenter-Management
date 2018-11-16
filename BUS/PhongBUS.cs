using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhongBUS
    {
        PhongDAO _phong = new PhongDAO();
        public List<PhongDTO> get_PhongBUS(string TenTK)
        {
            return _phong.get_PhongDAO(TenTK);
        }
        public List<PhongDTO> load_PhongBUS()
        {
            return _phong.Load_PhongDao();
        }
        public int add_PhongBUS(PhongDTO phongdto)
        {
            PhongDAO phongdao = new PhongDAO();
            return phongdao.insert_PhongnDAO(phongdto);
        }
        public int update_phongBUS(PhongDTO phongdto)
        {
            PhongDAO phongdao = new PhongDAO();
            return phongdao.update_PhongDAO(phongdto);
        }
        public int delete_PhongBUS(PhongDTO phongdto)
        {
            PhongDAO phongdao = new PhongDAO();
            return phongdao.delete_PhongDAO(phongdto);
        }
    }
}
