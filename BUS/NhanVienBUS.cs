using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO _nv = new NhanVienDAO();

        public NhanVienDTO DangNhapBUS(string TaiKhoan, string MatKhau)
        {
            return _nv.DangNhapDAO(TaiKhoan, MatKhau);
        }

        public List<NhanVienDTO> get_NhanVienBUS()
        {
            return _nv.get_NhanVienDAO();
        }
        public List<NhanVienDTO> tim_NhanVienBUS(string MaNV)
        {
            return _nv.tim_NhanvienDAO(MaNV);
        }
        public int add_NhanvienBUS(NhanVienDTO nvdto)
        {
            NhanVienDAO nvdao = new NhanVienDAO();
            return nvdao.insert_NhanvienDAO(nvdto);
        }
        public int update_NhanvienBUS(NhanVienDTO nvdto)
        {
            NhanVienDAO nvdao = new NhanVienDAO();
            return nvdao.update_NhanvienDAO(nvdto);
        }
        public int delete_NhanvienBUS(NhanVienDTO nvdto)
        {
            NhanVienDAO nvdao = new NhanVienDAO();
            return nvdao.delete_NhanvienDAO(nvdto);
        }
    }
}
