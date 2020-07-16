using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int pagesize = 2;//页面容量
        public static int pagecurrent = 1;//页码
        public static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack)
            {

                //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                //conn.Open();
                //string sql = "select* from newstwo";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlDataAdapter dr = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //dr.Fill(ds, "newstwo");
                //conn.Close();


                //DataTable dt = ds.Tables["newstwo"];

                //this.DropDownList1.DataSource = dt;
                //this.DropDownList1.DataValueField = "newsStyle";
                //this.DropDownList1.DataTextField = "newsColumn";


                //this.DropDownList1.DataBind();



                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                conn.Open();
                string sql = "select top " + pagesize + "*from newsone  where newsID not in (select top(" + pagesize + " * (" + pagecurrent + " - 1)) newsID from newsone) order by newsID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dr.Fill(ds, "newsone");


                DataTable dt = ds.Tables["newsone"];

                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
                


                string sqlCount = "select count(*) from newsone";
                cmd.Connection = conn;
                cmd.CommandText = sqlCount;
                count = (int)cmd.ExecuteScalar();

            }
            this.Label1.Text = pagecurrent.ToString();
           
            




        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //string id = this.DropDownList1.SelectedValue;
            //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            //conn.Open();
            //string sql = "select* from newsone where newsStyle='" + id + "'";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataAdapter dr = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //dr.Fill(ds, "newsone");
            

            //DataTable dt = ds.Tables["newsone"];

            //this.GridView1.DataSource = dt;
            //this.GridView1.DataBind();
            //conn.Close();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Up")
            {

                Response.Redirect("WebForm2.aspx?name=newsStyle");

            }
            if (e.CommandName == "Del")
            {


            }
            if (e.CommandName == "Datailed")
            {


            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            this.LinkButton4.Enabled = true;
            pagecurrent = pagecurrent + 1;
            this.Label1.Text = pagecurrent.ToString();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();
            string sql = "select top " + pagesize + "*from newsone  where newsID not in (select top(" + pagesize + " * (" + pagecurrent + " - 1)) newsID from newsone) order by newsID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "newsone");


            DataTable dt = ds.Tables["newsone"];

            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
            conn.Close();


            int page = 0;
            if (count % pagesize == 0)
                page = count / pagesize;
            else
                page = count / pagesize + 1;
            if (pagecurrent == page)
            {
                this.LinkButton4.Enabled = false;
            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            this.Label1.Text = pagecurrent.ToString();
            pagecurrent = pagecurrent - 1;
            this.LinkButton5.Enabled = true;
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();
            string sql = "select top " + pagesize + "*from newsone  where newsID not in (select top(" + pagesize + " * (" + pagecurrent + " - 1)) newsID from newsone) order by newsID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "newsone");


            DataTable dt = ds.Tables["newsone"];

            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
            conn.Close();
            if (pagecurrent == 1)
            {
                this.LinkButton5.Enabled = false;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}