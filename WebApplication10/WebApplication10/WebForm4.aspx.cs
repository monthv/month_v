using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string NewsID = Request.QueryString["newsID"].ToString();
            if(!IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                conn.Open();
                string sql = "select*from newsthree where newsID='" + NewsID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dr= new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dr.Fill(ds, "newsthree");

                //SqlHelper db = new SqlHelper();

                DataTable dt = ds.Tables["newsthree"];
                
                this.TextBox1.Text = dt.Rows[0]["newsTitle"].ToString();
                this.TextBox2.Text = dt.Rows[0]["newsWriter"].ToString();
                this.TextBox3.Text = dt.Rows[0]["newsContent"].ToString();
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string NewsID = Request.QueryString["newsID"].ToString();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();
            string sql = "update newsthree set newsTitle='" + this.TextBox1.Text + "',newsWriter='" + this.TextBox2.Text + "',newsContent='" + this.TextBox3.Text + "' where newsID='" + NewsID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i != 0)
            {
                this.Label1.Text = "修改成功";
            }
            else
            {
                this.Label1.Text = "修改失败";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}