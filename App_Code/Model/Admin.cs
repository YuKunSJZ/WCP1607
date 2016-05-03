using System;
using System.Collections.Generic;
using System.Web;

namespace HourseRentSystem.Model
{
    /// <summary>
    ///Admin 的摘要说明:映射数据库中的管理员信息表
    /// </summary>
    public class Admin
    {
        /*帐号*/
        private string username;
        /*密码*/
        private string passsword;
        
        /*默认构造函数*/
        public Admin()
        {
            this.username = "";
            this.passsword = "";
        }

        /*仿照java类代码书写set和get方法*/
        public void setUsername(string username) { this.username = username; }
        public string getUsername() { return this.username; }
        public void setPassword(string password) { this.passsword = password; }
        public string getPassword() { return this.passsword; }
    }

}
