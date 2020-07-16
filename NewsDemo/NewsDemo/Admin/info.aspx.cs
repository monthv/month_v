using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsDemo.Admin
{
    public partial class info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsid = Request.QueryString["newsid"].ToString();
            this.Label1.Text = newsid;

        }
    }
}