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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                //conn.Open();
                string sql = "select* from newstwo";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlDataAdapter dr = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //dr.Fill(ds, "newstwo");
                //conn.Close();


                //DataTable dt = ds.Tables["newstwo"];


                SqlHelper db = new SqlHelper();
                this.DropDownList1.DataSource = db.GetData(sql);


                //this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataValueField = "newsID";
                this.DropDownList1.DataTextField = "newsColumn";


                this.DropDownList1.DataBind();

            }


            }

            protected void Button1_Click(object sender, EventArgs e)
        {
            string id = this.DropDownList1.SelectedValue;
            //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            //conn.Open();
            string sql = "select* from newsthree where newsID='" + id + "'";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataAdapter dr = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //dr.Fill(ds, "newsthree");


            //DataTable dt = ds.Tables["newsthree"];
            SqlHelper db = new SqlHelper();
            this.DropDownList1.DataSource = db.GetData(sql);
            //this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
            //conn.Close();
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string NewsID = e.CommandArgument.ToString();
            if(e.CommandName=="Up")
            {
                Response.Redirect("WebForm4.aspx?newsID=" + NewsID);
            }

            if (e.CommandName == "Del")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                conn.Open();
                string sql = "delete from newsthree where newsID='" + NewsID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}