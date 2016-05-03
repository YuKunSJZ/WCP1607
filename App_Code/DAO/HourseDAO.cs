using System;
using System.Collections.Generic;
using System.Web;

using HourseRentSystem.Model;
using HourseRentSystem.DB;
using System.Text;

namespace HourseRentSystem.DAO
{
    /// <summary>
    ///HourseDAO 的摘要说明:关于房屋信息处理的数据处理层
    /// </summary>
    public class HourseDAO
    {
        public HourseDAO()
        {
        }
        /*向数据库中登记房屋信息*/
        public bool AddHourse(Hourse hourse)
        {
            /*建立数据访问对象*/
            DataBase db = new DataBase();
            /*构造sql语句*/ 
            string sql = ""; 
            sql += "insert into [hourse] (zujin,huxing,mianji,zhuangxiu,leixing,louceng,quyu,xiaoqu,dizhi,";
            sql += "chuangFlag,dianhuaFlag,dianshiFlag,kongtiaoFlag,bingxiangFlag,reshuiqiFlag,xiyijiFlag,kuandaiFlag,";
            sql += "zhuangtai,kssj) values(";
            sql += hourse.getZujin() + ",";
            sql += SqlString.GetQuotedString(hourse.getHuxing()) + ",";
            sql += hourse.getMianji() + ",";
            sql += SqlString.GetQuotedString(hourse.getZhuangxiu()) + ",";
            sql += SqlString.GetQuotedString(hourse.getLeixing()) + ",";
            sql += SqlString.GetQuotedString(hourse.getLouceng()) + ",";
            sql += SqlString.GetQuotedString(hourse.getQuyu()) + ",";
            sql += SqlString.GetQuotedString(hourse.getXiaoqu()) + ",";
            sql += SqlString.GetQuotedString(hourse.getDizhi()) + ",";
            sql += hourse.getChuangFlag() + ",";
            sql += hourse.getDianhuaFlag() + ",";
            sql += hourse.getDianshiFlag() + ",";
            sql += hourse.getKongtiaoFlag() + ",";
            sql += hourse.getBingxiangFlag() + ",";
            sql += hourse.getReshuiqiFlag() + ",";
            sql += hourse.getXiyijiFlag() + ",";
            sql += hourse.getKuandaiFlag() + ",'未租',";
            sql += SqlString.GetQuotedString(Convert.ToDateTime("1970-1-1").ToShortDateString());
            sql += ")";
            /*调用数据访问层执行房屋信息的添加*/
            return db.InsertOrUpdate(sql) > 0;  
        }

         /*更新房屋信息*/
        public bool UpdateHourse(Hourse hourse)
        {
            /*建立数据层访问对象*/
            DataBase db = new DataBase();
            /*构建sql语句*/
            StringBuilder sb = new StringBuilder();
            sb.Append("update [hourse] set zujin=").Append(hourse.getZujin());
            sb.Append(",huxing=").Append(SqlString.GetQuotedString(hourse.getHuxing()));
            sb.Append(",mianji=").Append(hourse.getMianji());
            sb.Append(",zhuangxiu=").Append(SqlString.GetQuotedString(hourse.getZhuangxiu()));
            sb.Append(",leixing=").Append(SqlString.GetQuotedString(hourse.getLeixing()));
            sb.Append(",louceng=").Append(SqlString.GetQuotedString(hourse.getLouceng()));
            sb.Append(",quyu=").Append(SqlString.GetQuotedString(hourse.getQuyu()));
            sb.Append(",xiaoqu=").Append(SqlString.GetQuotedString(hourse.getXiaoqu()));
            sb.Append(",dizhi=").Append(SqlString.GetQuotedString(hourse.getDizhi()));
            sb.Append(",chuangFlag=").Append(hourse.getChuangFlag());
            sb.Append(",dianhuaFlag=").Append(hourse.getDianhuaFlag());
            sb.Append(",dianshiFlag=").Append(hourse.getDianshiFlag());
            sb.Append(",kongtiaoFlag=").Append(hourse.getKongtiaoFlag());
            sb.Append(",bingxiangFlag=").Append(hourse.getBingxiangFlag());
            sb.Append(",reshuiqiFlag=").Append(hourse.getReshuiqiFlag());
            sb.Append(",xiyijiFlag=").Append(hourse.getXiyijiFlag());
            sb.Append(",kuandaiFlag=").Append(hourse.getKuandaiFlag());
            sb.Append(" where hourseId=").Append(hourse.getHourseId()); 
            /*调用数据访问层执行房屋信息的更新*/
            return db.InsertOrUpdate(sb.ToString()) > 0;  
        }

        /*根据房屋编号删除房屋信息*/
        public bool DeleteHourse(int hourseId)
        {
            /*建立数据层访问对象*/
            DataBase db = new DataBase();
            /*构建sql语句*/
            string sql = "delete from [hourse] where hourseId=" + hourseId;
            /*调用数据访问层执行房屋信息的更新*/
            return db.InsertOrUpdate(sql) > 0;  
        }

        /*根据房屋信息记录编号返回房屋信息实体对象*/
        public Hourse GetHourseById(int hourseId)
        {
            Hourse hourse = null;
            /*构造sql语句*/
            string sql = "select * from [hourse] where hourseId=" + hourseId;
            DataBase db = new DataBase();
            System.Data.DataSet ds = db.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                hourse = new Hourse();
                System.Data.DataRow dr = ds.Tables[0].Rows[0];
                hourse.setHourseId(hourseId);
                hourse.setZujin(Convert.ToSingle(dr["zujin"]));
                hourse.setHuxing(dr["huxing"].ToString());
                hourse.setMianji(Convert.ToSingle(dr["mianji"]));
                hourse.setZhuangxiu(dr["zhuangxiu"].ToString());
                hourse.setLeixing(dr["leixing"].ToString());
                hourse.setLouceng(dr["louceng"].ToString());
                hourse.setQuyu(dr["quyu"].ToString());
                hourse.setXiaoqu(dr["xiaoqu"].ToString());
                hourse.setDizhi(dr["dizhi"].ToString());
                hourse.setChuangFlag(Convert.ToInt32(dr["chuangFlag"]));
                hourse.setDianhuaFlag(Convert.ToInt32(dr["dianhuaFlag"]));
                hourse.setDianshiFlag(Convert.ToInt32(dr["dianshiFlag"]));
                hourse.setKongtiaoFlag(Convert.ToInt32(dr["kongtiaoFlag"]));
                hourse.setBingxiangFlag(Convert.ToInt32(dr["bingxiangFlag"]));
                hourse.setReshuiqiFlag(Convert.ToInt32(dr["reshuiqiFlag"]));
                hourse.setXiyijiFlag(Convert.ToInt32(dr["xiyijiFlag"]));
                hourse.setKuandaiFlag(Convert.ToInt32(dr["kuandaiFlag"]));
                hourse.setZhuangtai(dr["zhuangtai"].ToString());
                hourse.setKssj(Convert.ToDateTime(dr["kssj"]));
            } 
            return hourse;
        }
    


        /*根据类型，小区，起价，终止价查询房屋信息*/
        public System.Data.DataSet QueryHourseInfo(string leixing, string xiaoqu, string lowpriceString, string highpriceString)
        {
            /*根据查询条件构造sql语句*/
            string sql = "select * from [hourse] where 1=1";
            /*判断是否选择了类型，有3种情况：不选择，选择整租，选择非整租(一般就是单间了)*/
            if (leixing != "")
            {
                if (leixing == "整租")
                    sql += " and leixing = '整租' ";
                else
                    sql += " and leixing <> '整租'";
            }
            /*过滤小区关键字*/
            if (xiaoqu != "")
                sql += "and xiaoqu like '%" + xiaoqu + "%'";
            /*起始价*/
            float lowprice = 0.0f;
            /*终止价*/
            float highprice = 0.0f;
            try
            {
                lowprice = Convert.ToSingle(lowpriceString);
            } catch { }
            try
            {
                highprice = Convert.ToSingle(highpriceString);
            }catch {}
            if (lowprice != 0.0f)
                sql += " and zujin >= " + lowprice;
            if (highprice != 0.0f)
                sql += " and zujin <= " + highprice;

            /*建立数据层访问对象*/
            DataBase db = new DataBase();
            /*查询返回数据集*/
            return db.GetDataSet(sql); 

        }
    }

}
