using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string fileName = this.FileUpload1.FileName;
            //fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + fileName;
            //string filePath= "images/" + fileName;//相对路径
            //string Path = Server.MapPath(filePath);//绝对路径


            //this.FileUpload1.SaveAs(Path);//上传




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