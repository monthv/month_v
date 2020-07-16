using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                conn.Open();
                string sql = "select* from news1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dr.Fill(ds, "news1");


                DataTable dt = ds.Tables["news1"];
                this.DropDownList1.DataSource = dt;

                this.DropDownList1.DataValueField = "newsID";
                this.DropDownList1.DataValueField = "name";
                this.DropDownList1.DataBind();
            }
            
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string id = this.DropDownList1.SelectedValue;
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();
            string sql = "select* from news2 where newsID='"+id+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "news2");


            DataTable dt = ds.Tables["news2"];
            this.GridView1.DataBind();
        }
    }
}