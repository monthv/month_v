using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tomorrow
{
    /// <summary>
    /// love 的摘要说明
    /// </summary>
    public class love : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string xx = string.Empty;
            xx = context.Request["xv"];
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Melon;User ID=10;Pwd=10");
            conn.Open();
            string sql = "select count(*) from zzvv where UserID='" + xx + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int vv = (int)cmd.ExecuteScalar();
                        
            context.Response.Write(vv);
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