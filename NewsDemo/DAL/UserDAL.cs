using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Helper;
using System.Data;


namespace DAL
{
    public class UserDAL
    {
        
        HelperSQL db = new HelperSQL(); 
        public int Login(UserNews news)
        {
            string sql = "select count(*) from seek where UserName='" + news.Username + "' and UserPwd='" + news.Userpwd + "' ";
            int num = db.Count(sql);
            return num;
        }
        public int Alter(UserNews news)
        {
            string sql = "select count(*) from seek where UserPwd='" + news.Userpwd + "'";
            int num = db.Count(sql);
            return num;
        }
        public int Ceen(UserNews news)
        {
            string sql = "update seek set NewsPwd='" + news.Userpwd + "' where NewsName='" + news.Username+ "'";
            int vivo = db.Add(sql);
            return vivo;
        }
        public DataTable feek()
        {
            string sql = "select * from access  ";
            DataTable num = db.Zen(sql);
            return num;
        }

        //public DataSet GetList(string strWhere)
        //{
            
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select * ");
        //    strSql.Append(" FROM access  ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    return DbHelperSQL.Query(strSql.ToString());
        //}
		
    }
}
