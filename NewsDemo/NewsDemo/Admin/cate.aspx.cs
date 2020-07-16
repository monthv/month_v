using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Model;
using System.Data;

namespace NewsDemo.Admin
{
    public partial class cate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserDAL userdal = new UserDAL();
                //DataSet ds = userdal.feek("1=1");
                this.Repeater1.DataSource = userdal.feek();
                this.Repeater1.DataBind();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Updata")
            {
                Response.Redirect("info.aspx?newsid=" + e.CommandArgument.ToString());
            }
            if (e.CommandName == "Del")
            {
               //BindData();
            }
        }
        public void jonjon()
        {
           
        }
    }
}