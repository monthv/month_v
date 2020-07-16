using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;


namespace NewsDemo.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string UserName = this.TextBox1.Text;
            string UserPwd = this.TextBox2.Text;
            UserNews user=new UserNews();
            user.Username = UserName;
            user.Userpwd = UserPwd;
            UserDAL Manager = new UserDAL();
            int num = Manager.Alter(user);
            if (num==0)
            {
                Response.Redirect("login.aspx");
            }
            else
            {

                Session["UserName"] = user.Username;
                Session["UserPwd"] = user.Userpwd;
                Response.Redirect("index.aspx");

            }




            //Session["UserName"] = this.TextBox1.Text;

            //Session["UserID"] = "16";
            //Response.Redirect("index.aspx");
        }
    }
}