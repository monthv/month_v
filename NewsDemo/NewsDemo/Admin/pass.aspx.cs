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
    public partial class pass :Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = Session["UserName"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string qwpwd = this.TextBox1.Text;
            string zxpwd = this.TextBox2.Text;
            string mnpwd = this.TextBox3.Text;
            UserNews steel = new UserNews();
            steel.Qwpassword = qwpwd;
            steel.Zxpassword = zxpwd;
            steel.Mnpassword = mnpwd;
            UserDAL Fire = new UserDAL();
            string  num = Fire.Alter(steel).ToString();
            
            if(steel.Qwpassword!=num)
            {
                
                this.Label2.Text = "旧密码错误";
                Response.Redirect("pass.aspx");
                return;
            }
            else
            {
                if (steel.Zxpassword == steel.Mnpassword)
                {                    
                    this.Label1.Text = "修改成功";
                }
                else
                {
                    this.Label1.Text = "修改失败";
                    return;
                }
                

            }
            
           
              
        }
    }
}