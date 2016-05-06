using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;


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
        else
        {
            data
            
        }

    }

}