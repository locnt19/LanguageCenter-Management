using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BienLaiDTO
    {
        public string MaBienLai { get; set; }
        public string MaHV { get; set; }
        public string HoTenHV { get; set; }
        public string MaKH { get; set; }
        public double HocPhi { get; set; }
        public double TongThanhToan { get; set; }
        public string NguoiLap { get; set; }
        public string HoTenNV { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
