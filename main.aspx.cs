using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {  
            Response.Write("<script>alert('请登录系统!');location.href='login.aspx';</script>");
            return;
        }
    }
}
