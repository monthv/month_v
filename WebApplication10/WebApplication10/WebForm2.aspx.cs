using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string TextBox1 = this.TextBox1.Text;
            string TextBox2 = this.TextBox2.Text;
            string TextBox3 = this.TextBox3.Text;
            string TextBox4 = this.TextBox4.Text;

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=news;User ID=sa;Pwd=123");
            conn.Open();
            string sql = "insert into newsthree(newsID,newsTitle,newsWriter,newsContent) values ('" + this.TextBox1.Text + "','" + this.TextBox2.Text + "','" + this.TextBox3.Text + "','" + this.TextBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            string fileName = this.FileUpload1.FileName;
            if (fileName == "")
            {
                this.Label1.Text = "请选择要上传的图片";
            }
            else
            {
                string filetype = System.IO.Path.GetExtension(fileName).ToLower();
                string[] alltype = { ".jpg", ".gif", ".png", ".jpeg" };
                if (alltype.Contains(filetype))
                {
                    fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + fileName;
                    string filePath = "images/" + fileName;//相对路径//图片数据库入库路径
                    string Path = Server.MapPath(filePath);//绝对路径
                    this.FileUpload1.SaveAs(Path);
                    this.Image1.ImageUrl = filePath;
                }
                else
                {
                    this.Label1.Text = "图片格式不正确";
                }


               

            }
        }
    }
}