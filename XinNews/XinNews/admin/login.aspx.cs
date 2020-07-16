using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

namespace XinNews.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string txname = this.TextBox1.Text;
            string txpwd = this.TextBox2.Text;
            News user = new News();
            user.TxUser = txname;
            user.TxPwd = txpwd;
            UserDal Manager = new UserDal();
            int num = Manager.Login(user);
            if (num == 0)
            {
                this.Label1.Text = "用户名或密码错误";
            }
            else
            {
                Session["UserName"] = user.TxUser;
                Session["UserPwd"] = user.TxPwd;
                Response.Redirect("index.aspx?");

            }
        }
    }
}