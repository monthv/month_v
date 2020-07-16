using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]==null)
            {
                Response.Redirect("WebForm3.aspx");
            }
            else
            {
                string name = Request.QueryString["name"].ToString();
                string age = Request.QueryString["age"].ToString();
                this.Label1.Text = name;
            }
            
        }
    }
}