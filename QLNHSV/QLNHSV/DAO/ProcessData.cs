using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class ProcessData
    {
        static string sConnect = @"Data Source=(local);Initial Catalog=LocationServiceSystem;Integrated Security=True";
        public static DataTable LoadData(string sql)
        {
            SqlConnection conn = new SqlConnection(sConnect);

            SqlDataAdapter dbLocation = new SqlDataAdapter(sql, conn);

            DataTable tb = new DataTable();

            dbLocation.Fill(tb);

            return tb;
        }

        public static int Execute(string sql)
        {
            //Create Connection
            SqlConnection conn = new SqlConnection(sConnect);

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            var rs = comm.ExecuteNonQuery();

            conn.Close();

            return rs;
        }

        public static int ExecuteStore(string store, Dictionary<string, object> paras)
        {
            SqlConnection conn = new SqlConnection(sConnect);

            SqlCommand comm = new SqlCommand(store, conn);

            comm.CommandType = CommandType.StoredProcedure;

            foreach (var item in paras)
            {
                comm.Parameters.AddWithValue(item.Key, item.Value);
            }

            conn.Open();

             var rs = comm.ExecuteNonQuery();

            conn.Close();

            return rs;
        }
    }
}
