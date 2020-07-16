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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                conn.Open();
                string sql = "select* from newstwo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dr.Fill(ds, "newstwo");
                
                
                
                DataTable dt = ds.Tables["newstwo"];

                
                this.DropDownList1.DataValueField = "newsID";
                this.DropDownList1.DataValueField = "newsColumn";

                this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataBind();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = this.DropDownList1.SelectedValue;
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();
            string sql = "select* from newsone where newsStyle='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "newsone");


            DataTable dt = ds.Tables["newsone"];
            
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Up")
                {

                Response.Redirect("WebForm2.aspx?newid='newsid'");

            }
            if (e.CommandName == "Del")
            {


            }
            if (e.CommandName == "Datailed")
            {


            }










        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}