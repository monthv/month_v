using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Tomorrow
{
    /// <summary>
    /// xv 的摘要说明
    /// </summary>
    public class xv : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string name = context.Request["UserName"].ToString();
            context.Response.ContentType = "text/plain";
            string vv = string.Empty;
            vv= context.Request["Method"];
            switch (vv)
            {
                case "Query":
                    vv =JsonConvert.SerializeObject(xvv());
                    break;
                case "Del":
                    vv= JsonConvert.SerializeObject(zxx());
                    break;
            }
            
           
            context.Response.Write(vv);
        }


        public DataTable xvv()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Melon;User ID=10;Pwd=10");
            conn.Open();
            string sql = "select * from Student";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "Student");
            DataTable dt = ds.Tables["Student"];
            return dt;
        }

        public int zxx()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Melon;User ID=10;Pwd=10");
            conn.Open();
            string sql = "delete from Student where StudentNO=StudentNO";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = (int)cmd.ExecuteNonQuery();
            conn.Close();
            return num;
        }








        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}