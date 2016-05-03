using System;
using System.Collections.Generic;
using System.Web;

using HourseRentSystem.Model;
using HourseRentSystem.DAO;

namespace HourseRentSystem.BLL
{
    /// <summary>
    ///AdminBll 的摘要说明:管理员信息处理的业务层
    /// </summary>
    public class AdminBLL
    {
        /*保存业务逻辑错误信息*/
        private string errMessage;
        public string getErrMessage() { return this.errMessage; }
        public AdminBLL()
        {
            this.errMessage = "";
        }

        /*验证用户登录信息*/
        public bool CheckLogin(Admin admin)
        {
            /*建立数据访问层对象*/
            AdminDAO adminDAO = new AdminDAO();
            /*首先验证用户名是否存在*/
            if (!adminDAO.ExistUsername(admin.getUsername()))
            {
                this.errMessage = "对不起，用户名不存在!";
                return false;
            }
            /*如果用户名存在再验证密码输入是否正确*/
            if (!adminDAO.CheckUser(admin))
            {
                this.errMessage = "对不起，密码错误!";
                return false;
            }
            return true;

        }
    }

}
