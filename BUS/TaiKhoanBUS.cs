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
        public int insert_TaiKhoanBUS(string TenTK, string MatKhau, string LoaiTK)
        {
            return _tk.insert_TaiKhoanDAO(TenTK, MatKhau, LoaiTK);
        }
        public int update_TaiKhoanBUS(string TenTK, string MatKhau, string LoaiTK)
        {
            return _tk.update_MatKhauvaloaiTaiKhoanDAO(TenTK, MatKhau, LoaiTK);
        }
        public int delete_TaiKhoanBUS(TaiKhoanDTO tkdto)
        {
            return _tk.delete_TaiKhoanDAO(tkdto);
        }

    }
}
