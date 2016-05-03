using System;
using System.Collections.Generic;
using System.Web;

using HourseRentSystem.DB;
using HourseRentSystem.Model;


namespace HourseRentSystem.DAO
{
    /// <summary>
    ///AdminDAO 的摘要说明: 管理员信息处理数据层
    /// </summary>
    public class AdminDAO
    {
        public AdminDAO()
        {
             
        }

        /*查询帐号是否存在,存在返回true,不存在返回false*/
        public bool ExistUsername(string username)
        {
            DataBase db = new DataBase();
            string query_sql = "select * from Users where Username = " + SqlString.GetQuotedString(username);
            System.Data.DataSet ds = db.GetDataSet(query_sql);
            if (ds.Tables[0].Rows.Count == 0) 
                return false; 
            return true;
        }


        /*查询帐号密码是否都正确*/
        public bool CheckUser(Admin admin)
        {
            DataBase db = new DataBase();
            string query_sql = "select * from Users where Username = " + SqlString.GetQuotedString(admin.getUsername()) + " and `Password` = " + SqlString.GetQuotedString(admin.getPassword());
            System.Data.DataSet ds = db.GetDataSet(query_sql);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
    }

}
