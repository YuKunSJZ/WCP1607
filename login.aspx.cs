using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HourseRentSystem.Model;
using HourseRentSystem.BLL;


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btn_Login_Click(object sender, EventArgs e)
    {
        /*建立模型,获取管理员信息*/
        Admin admin = new Admin();
        admin.setUsername(this.UserName.Text);
        admin.setPassword(this.Password.Text);
        /*建立业务逻辑层对象,并执行验证*/
        AdminBLL adminBll = new AdminBLL();
        if (adminBll.CheckLogin(admin))
        {
            Session["username"] = admin.getUsername();
            Response.Redirect("main.aspx");
        }
        else
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "<script>alert('" + adminBll.getErrMessage() + "');</script>", false); 
            return;
        }
    }
}
