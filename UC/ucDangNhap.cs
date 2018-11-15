using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC
{
    public partial class ucDangNhap : UserControl
    {
        public ucDangNhap()
        {
            InitializeComponent();
            txt_MatKhau.UseSystemPasswordChar = true;
        }
        public string get_TaiKhoan
        {
            get { return txt_TaiKhoan.Text; }
        }
        public string get_MatKhau
        {
            get { return txt_MatKhau.Text; }
        }
    }
}
