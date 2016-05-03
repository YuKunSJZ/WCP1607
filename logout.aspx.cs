using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["username"] = null;
        Session.Abandon();
        Response.Write("<script>top.location.href='login.aspx';</script>");
    }
}
