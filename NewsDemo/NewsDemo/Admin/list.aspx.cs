using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsDemo.Admin
{
    public partial class list : Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = Session["UserName"].ToString();
        }
    }
}