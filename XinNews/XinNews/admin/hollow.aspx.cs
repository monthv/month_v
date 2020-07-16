using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Helper;
using Dal;

namespace XinNews.admin
{
    public partial class hollow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {               
            if (!IsPostBack)
            {

                SqlHelper db = new SqlHelper();
                string sql = "select* from newstwo";


                //this.GridView1.DataSource = db;
                //this.GridView1.DataBind();
               
                this.DropDownList1.DataSource = db.Zxzx(sql);


                //this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataValueField = "NewsID";
                this.DropDownList1.DataTextField = "NewsColumn";


                this.DropDownList1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string newsID = e.CommandArgument.ToString();
            if (e.CommandName == "Up")
            {
                Response.Redirect("love.aspx?NewsID=" + newsID);
            }

            if (e.CommandName == "Del")
            {
                //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
                //conn.Open();
                SqlHelper db = new SqlHelper();
                UserDal wowo = new UserDal();
                
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                //conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = this.DropDownList1.SelectedValue;
            string sql = "select* from newsthree where NewsID='" + id + "'";
            
            SqlHelper db = new SqlHelper();
            this.DropDownList1.DataSource = db.Zen(sql);
            //this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}