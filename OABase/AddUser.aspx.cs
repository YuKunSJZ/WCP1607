using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using OABase;

public partial class OABase_AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Write("<script>alert('请登录系统!');top.location.href='../login.aspx';</script>");
            return;
        }

    }

    protected void UserAdd_Click(object sender, EventArgs e)
    {
        string UserName = this.yonghuming.Text;
        string Password = this.mima.Text;
        string Name = this.xingming.Text;
        string Department = this.bumen.Text;
        string JobTitle = this.zhiwu.Text;
        string PhoneNumber = this.dianhua.Text;

        UserDAO BC_User = new UserDAO();
        BC_User.InsertIntoUser(UserName, Password, Name, Department, JobTitle, PhoneNumber);
        Response.Redirect("ListUsers.aspx");
        
    }
}