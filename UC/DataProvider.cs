using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UC
{
    public class DataProvider
    {
        private static string ChuoiKetNoi = @"Data Source=.;Initial Catalog=QuanLyTrungTamNgoaiNgu;Integrated Security=True";

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            conn.Open();
            return conn;
        }

        public static SqlDataReader ThucHienTruyVan(string query, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            return cmd.ExecuteReader();
        }

        public static SqlDataReader ThucHienTruyVan(string query, SqlParameter par, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.Add(par);
            return cmd.ExecuteReader();
        }

        public static SqlDataReader ThucHienTruyVan(string query, SqlParameter[] pars, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddRange(pars);
            return cmd.ExecuteReader();
        }
    }
}
