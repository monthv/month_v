using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication10
{
    public class SqlHelper
    {
        public DataTable GetData(string sql)
        {
            SqlConnection conn =  new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "newsthree");
            DataTable dt = ds.Tables["newsthree"];
            return dt;
        }
    }
}