using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Dal
{
    public class UserDal
    {
        SqlHelper db = new SqlHelper();
        public int Login(News news)
        {
            string sql = "select count(*) from newsone where UserName='"+news.TxUser+"' and UserPwd='" + news.TxUser + "' ";
            int num = db.Count(sql);
            return num;
        }
        public int NewsAdd(NewsLove newslove)
        {
            string sql = "insert into newsthree(NewsID,NewsTitle,NewsWriter,NewsContent) values ('" + newslove.ID+ "','" + newslove.Title+ "','" + newslove.Writer + "','" + newslove.Content+ "')";
            int cool = db.Add(sql);
            return cool;
        }
        public DataTable Keep(string newsID)
        {
            string sql = "select * from newsthree where newsID='" + newsID + "'";
            DataTable dt = db.Zen(sql);
            return dt;
        }
        public int Ceen(NewsLove newslove, string newsID)
        {
            string sql = "update newsthree set NewsID='" + newslove.ID+ "',NewsTitle='" + newslove.Title + "',NewsWriter='" + newslove.Writer+ "',NewsContent='" + newslove.Content+ "' where NewsID='" + newsID + "'";
            int vivo = db.Add(sql);
            return vivo;
        }
        public int Xoxo(string newsID)
        {
            string sql = "delete from newsthree where NewsID='" + newsID + "'";
            int num = db.Add(sql);
            return num;
        }
    }
}
