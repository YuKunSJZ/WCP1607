using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HourseRentSystem.BLL;

public partial class hourse_hourse_del : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Write("<script>alert('请登录系统!');top.location.href='../login.aspx';</script>");
            return;
        }

        /*取得要删除的房屋id*/
        int hourseId = Int32.Parse(Request.QueryString["hourseId"]);

        HourseBLL hourseBll = new HourseBLL();
        if(hourseBll.DeleteHourse(hourseId))
            Response.Write("<script>alert('删除成功!');location.href='hourse_manage.aspx';</script>");
        else
            Response.Write("<script>alert('" + hourseBll.getErrMessage() + "');location.href='hourse_manage.aspx';</script>");

    }
}
