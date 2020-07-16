using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
 
    public class HelperSQL
    {
        

        public int Count(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Melon;User ID=10;Pwd=10");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = (int)cmd.ExecuteScalar();
            conn.Close();
            return num;           
        }
        public int Add(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Melon;User ID=10;Pwd=10");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = (int)cmd.ExecuteNonQuery();
            conn.Close();
            return num;
        }
        public DataTable Zen(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Melon;User ID=10;Pwd=10");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "access");
            DataTable dt = ds.Tables["access"];
            return dt;
        }
    }
}
