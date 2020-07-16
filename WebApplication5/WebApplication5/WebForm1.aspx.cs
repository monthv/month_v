using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = this.TextBox1.Text;
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=book;User ID=sa;Pwd=123");
            conn.Open();
            Session["username"] = username;
            //Session["age"] = age;
            Response.Redirect("WebForm2.aspx?name="+username+"&age=18");
        }
    }
}