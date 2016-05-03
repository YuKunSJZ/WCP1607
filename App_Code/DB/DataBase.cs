using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using MySql.Data.MySqlClient;

/// <summary>
/// DataBase 的摘要说明
/// </summary>
/// 

namespace HourseRentSystem.DB
{
    public class DataBase
    {
       
        //私有变量，数据库连接
        protected MySqlConnection Connection;
        protected string ConnectionString;

		//构造函数
		public DataBase()
		{
            //ConnectionString = ConfigurationManager.ConnectionStrings["MySQLconnection"].ConnectionString;
            MySqlConnectionStringBuilder MyDBConnectionString = new MySqlConnectionStringBuilder();
            MyDBConnectionString.Server = "localhost";
            MyDBConnectionString.Port = 3306;
            MyDBConnectionString.UserID = "root";
            MyDBConnectionString.Password = "yukun123";
            MyDBConnectionString.DefaultCommandTimeout = 30;
            MyDBConnectionString.ConnectionTimeout = 10;
            MyDBConnectionString.Database = "WrokFlow";

            ConnectionString = MyDBConnectionString.GetConnectionString(true);


        }
		
		//保护方法，打开数据库连接
		private void Open()
		{
		  //判断数据库连接是否存在
			if (Connection == null)
			{
			  //不存在，新建并打开
				Connection = new MySqlConnection (ConnectionString);
				Connection.Open();
			}
			else
			{
			  //存在，判断是否处于关闭状态
			  if (Connection.State.Equals(ConnectionState.Closed))
				  Connection.Open();    //连接处于关闭状态，重新打开
			}
		}

		//公有方法，关闭数据库连接
		public void Close() 
		{
			if (Connection.State.Equals(ConnectionState.Open))
			{
				Connection.Close();     //连接处于打开状态，关闭连接
			}
		}

        /// <summary>
		/// 析构函数，释放非托管资源
		/// </summary>
		~DataBase()
		{
			try
			{
				if (Connection != null)
					Connection.Close();
			}
			catch{}
			try
			{
				Dispose();
			}
			catch{}
		}

		//公有方法，释放资源
		public void Dispose()
		{
			if (Connection != null)		// 确保连接被关闭
			{
				Connection.Dispose();
				Connection = null;
			}
		}

        //公有方法，根据Sql语句，返回是否查询到记录
        public bool GetRecord(string XSqlString)
        {
            Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(XSqlString, Connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            Close();

            if (dataset.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //公有方法，返回Sql语句获得的数据值
        //SqlString的格式：select count(*) from XXX where ...
        //                 select max(XXX) from YYY where ...
        //public int GetRecordCount(string XSqlString)
        //{
        //    string SCount;

        //    Open();
        //    MySqlDataAdapter Cmd = new MySqlDataAdapter(XSqlString, Connection);
        //    SCount = Cmd.ExecuteScalar().ToString().Trim();
        //    if (SCount == "")
        //        SCount = "0";
        //    Close();
        //    return Convert.ToInt32(SCount);
        //}

        //公有方法，查询数据
        //输入：
        //			查询条件sql语句
        //输出：
        //			将执行结果以DataSet返回    
        public DataSet GetDataSet(string queryString)
        {
            Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, Connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            Close();
            return dataset;
        }

        public DataSet SQL2Rs(string QueryString,String BaseTableName)
        {
            Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(QueryString, Connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, BaseTableName);
            Close();
            return dataset;
        }

        //公有方法，根据Sql语句，插入记录并返回生成的ID号
        //public int GetIDInsert(string XSqlString)
        //{
        //    int Count = -1;
        //    Open();
        //    MySqlDataAdapter cmd = new MySqlDataAdapter(XSqlString, Connection);
        //    Count = Convert.ToInt32(cmd.ExecuteScalar().ToString().Trim());
        //    Close();
        //    return Count;
        //}

        //执行插入，更新，删除等操作，返回受影响的记录行数
        public int InsertOrUpdate(string sqlString)
        {
            Open();
            MySqlCommand cmd = new MySqlCommand(sqlString, Connection);
            int effectCount = -1;
            try
            {
                effectCount = cmd.ExecuteNonQuery();
            }
            finally
            {
                Close();
            }
            return effectCount; //返回受影响的行数
        }

        //执行一些互相联系需要一次成功的sql语句，要么就不执行
        public bool ExecuteSQL(String[] SqlStrings)
        {
            bool success = true;
            Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction trans = Connection.BeginTransaction(); //开始事务
            cmd.Connection = Connection;
            cmd.Transaction = trans;

            int i = 0;
            try
            {
                foreach (String str in SqlStrings)
                {
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    i++;
                }
                trans.Commit();
            }
            catch
            {
                success = false;
                Close();
                trans.Rollback();
            }
            finally
            {
                Close();
            }
            return success;
        }
    }
}
