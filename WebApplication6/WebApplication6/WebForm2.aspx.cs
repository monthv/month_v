using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string newsID = Request.QueryString["newid"].ToString();
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                conn.Open();
                string sql = "select* from newsone where newsID='" + newsID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dr.Fill(ds, "newsone");


                DataTable dt = ds.Tables["newsone"];
                this.txTitle.Text = dt.Rows[0]["newsTitle"].ToString();
                this.txWriter.Text = dt.Rows[0]["newsWriter"].ToString();
                this.txContent.Text = dt.Rows[0]["newsContent"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string newsID = Request.QueryString["newid"].ToString();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();
            string sql = "updata newsone  set newsTitle='" + this.txTitle.Text + "'+ '" + this.txWriter.Text + "'+ '" + this.txContent.Text + "' where newsID=";

        }
    }
}