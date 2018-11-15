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
    public partial class ucThongTinCoBan : UserControl
    {
        public ucThongTinCoBan()
        {
            InitializeComponent();
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
        }
        public void Clear()
        {
            txt_HoTen.Text = String.Empty;
            txt_DiaChi.Text = String.Empty;
            txt_Email.Text = String.Empty;
            txt_SDT.Text = String.Empty;
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;

        }
        public string HoTen
        {
            get { return txt_HoTen.Text; }
            set { txt_HoTen.Text = value; }
        }
        public string Email
        {
            get;
            set;
        }
        public string DiaChi
        {
            get;
            set;
        }
        public string SDT
        {
            get;
            set;
        }
        public DateTime NgaySinh
        {
            get;
            set;
        }
        public int GioiTinh
        {
            get
            {
                if (rdb_Nam.Checked) return 1;
                if(rdb_Nu.Checked) return 0;
                return -1;
            }
            set
            {
                if (value == 1) 
                    rdb_Nam.Checked = true;
                else
                {
                    if (value == 0)
                        rdb_Nu.Checked = true;
                    else
                    {
                        rdb_Nam.Checked = false;
                        rdb_Nu.Checked = false;
                    }
                }
                
            }
        }
    }
}
