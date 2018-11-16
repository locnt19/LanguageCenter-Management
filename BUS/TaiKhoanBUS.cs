using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO _tk = new TaiKhoanDAO();
        public List<TaiKhoanDTO> get_TaiKhoanBUS(string TenTK)
        {
            return _tk.get_TaiKhoanDAO(TenTK);
        }
        public List<TaiKhoanDTO> load_TaiKhoanBUS()
        {
            return _tk.load_TaiKhoanDAO();
        }
        public int add_TaiKhoanBUS(TaiKhoanDTO tkdto)
        {
            TaiKhoanDAO tkdao = new TaiKhoanDAO();
            return tkdao.insert_TaiKhoanDAO(tkdto);
        }
        public int update_TaiKhoanBUS(TaiKhoanDTO tkdto)
        {
            TaiKhoanDAO tkdao = new TaiKhoanDAO();
            return tkdao.update_MatKhauvaloaiTaiKhoanDAO(tkdto);
        }
        public int delete_TaiKhoanBUS(TaiKhoanDTO tkdto)
        {
            TaiKhoanDAO tkdao = new TaiKhoanDAO();
            return tkdao.delete_TaiKhoanDAO(tkdto);
        }

    }
}
