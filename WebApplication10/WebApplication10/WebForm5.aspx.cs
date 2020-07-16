using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a= Convert.ToDouble(this.TextBox1.Text);
            double b= Convert.ToDouble(this.TextBox3.Text);
            string op = this.TextBox2.Text;
            Operation c = new Operation();
            switch(op)
            {
                case "+":
                    c = new add();
                    break;
                case "-":
                    c = new cut();
                    break;
                case "*":
                    c = new ride();
                    break;
                case "/":
                    c = new except();
                    break;

            }
            this.TextBox4.Text = c.ToString();
        }
    }
}