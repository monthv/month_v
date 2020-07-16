using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NewsDemo
{
    public class Base:System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}