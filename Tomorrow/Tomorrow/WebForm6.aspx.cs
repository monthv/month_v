using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Tomorrow
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        //Dictionary<string, List<Books>> dicBook = new Dictionary<string, List<Books>>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Books> list = new List<Books>();

        }
        public string GetHttp()
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "id=1&name=2&...";
            byte[] data = encoding.GetBytes(postData);
            // Prepare web request
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create("http://localhost:1126/TestHandler.ashx");

            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = data.Length;
            Stream newStream = myRequest.GetRequestStream();
            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();
            // Get response
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            return content;
        }

    }
}