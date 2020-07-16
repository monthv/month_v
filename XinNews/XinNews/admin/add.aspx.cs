using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Dal;
using System.Data.SqlClient;
using System.Data;
using Helper;

namespace XinNews.admin
{
    public partial class add : System.Web.UI.Page
    {
        UserDal look = new UserDal();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NewsLove news = new NewsLove();
            news.ID = this.TextBox1.Text;
            news.Title = this.TextBox2.Text;
            news.Writer = this.TextBox3.Text;
            news.Content = this.TextBox4.Text;

            int spen = look.NewsAdd(news);
            if (spen == 1)
            {
                this.Label1.Text = "请选择新闻类型";

            }
            else
            {
                

                if (spen != 0)
                {
                    this.Label1.Text = "添加成功";
                }
                else
                {
                    this.Label1.Text = "添加失败";
                }




            }
        }
    }
}