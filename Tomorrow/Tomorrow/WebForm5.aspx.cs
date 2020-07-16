using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tomorrow
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            qqonline.qqOnlineWebService vv = new qqonline.qqOnlineWebService();            
            string vo = vv.qqCheckOnline(this.TextBox1.Text);
            string aaa = "";
            switch(vo)
            {
                case "Y":
                    aaa = "在线";
                    break;
                case "N":
                    aaa = "离线";
                    break;
                case "E":
                    aaa = "有误";
                    break;
                case "A":
                    aaa = "商业用户验证失败";
                    break;
                case "V":
                    aaa = "免费用户超过数量";
                    break;
                default:
                    aaa = "no";
                    break;
            }
            this.Label1.Text = aaa;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Weather.WeatherWebService weather = new Weather.WeatherWebService();
            string[] tt = weather.getWeatherbyCityName(this.TextBox2.Text);
            string kar = string.Empty;
            string cc = tt[0];
            string ar = tt[1];
            string tr = tt[2];
            string te = tt[5];
            string ag = tt[6];
            kar = cc + ar + tr + te + ag;
            this.Label2.Text = kar;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Train.TrainTimeWebService train = new Train.TrainTimeWebService();
            string a = this.TextBox3.Text;
            DataSet ds = train.getStationAndTimeDataSetByLikeTrainCode(a, "");
            DataTable dt = ds.Tables[0];
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}