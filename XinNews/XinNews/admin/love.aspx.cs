using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Dal;
using Helper;

namespace XinNews.admin
{
    public partial class love : System.Web.UI.Page
    {
        UserDal look = new UserDal();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string newsID = Request.QueryString["NewsID"].ToString();
            if (!IsPostBack)
            {
                NewsLove news = new NewsLove();
                this.TextBox1.Text = look.Keep(newsID).Rows[0]["NewsID"].ToString();
                this.TextBox2.Text = look.Keep(newsID).Rows[0]["NewsTitle"].ToString();
                this.TextBox3.Text = look.Keep(newsID).Rows[0]["NewsWriter"].ToString();
                this.TextBox4.Text = look.Keep(newsID).Rows[0]["NewsContent"].ToString();
                SqlHelper db = new SqlHelper();
                
                UserDal wowo = new UserDal();
                //int opop = wowo.Ceen(news);
                //if (opop != 0)
                //{
                //    this.Label1.Text = "修改成功";
                //}
                //else
                //{
                //    this.Label1.Text = "修改失败";
                //}


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //NewsLove news = new NewsLove();
            //news.ID = this.TextBox1.Text;
            //news.Title = this.TextBox2.Text;
            //news.Writer = this.TextBox3.Text;
            //news.Content = this.TextBox4.Text;
            //string newsID = Request.QueryString["NewsID"].ToString();
            



            
        }
    }
}