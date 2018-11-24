using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class DataProvider
    {
        //private static string ChuoiKetNoi = @"Data Source=.;Initial Catalog=QuanLyTrungTamNgoaiNgu;Integrated Security=True";
        private static string ChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTrungTamNgoaiNgu;Integrated Security=True";
        private static SqlDataAdapter adt = new SqlDataAdapter();
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
        public static int TruyVanInsert(string truyvan, SqlParameter[] par, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int rowsAffected;
            try
            {
                cmd.Parameters.AddRange(par);
                adt.InsertCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
            return rowsAffected;
        }

        public static int TruyVanUpdate(string truyvan, SqlParameter par, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int rowsAffected;
            cmd.Parameters.Add(par);
            rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected;
        }

        public static int TruyVanUpdate(string truyvan, SqlParameter[] par, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int rowsAffected;
            cmd.Parameters.AddRange(par);
            rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected;
        }
    }
}
