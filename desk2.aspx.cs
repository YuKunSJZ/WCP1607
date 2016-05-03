using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using HourseRentSystem.DB;
using System.Data;

public partial class desk2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Write("<script>altert('请登录系统!');location.href='login.aspx';</script>");
        }
        else
        {
            DataBase db = new DataBase();
            StringBuilder sqlB=new StringBuilder();
            sqlB.AppendLine("SELECT * FROM ServerStatus;");
            Response.Write(sqlB.ToString());

            System.Data.DataSet DataRS = db.SQL2Rs(sqlB.ToString(),"ServerStatus");

            DataTable dt = DataRS.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                Response.Write("<tr>");
                for(int i = 0; i < dt.Columns.Count; i++)
                {
                    Response.Write("<td >");
                    Response.Write(dr[i].ToString());
                    Response.Write("</td>");
                }
                Response.Write("</tr>");
            }
            lblMessage.Text = "LalbelMessage";

            //Response.Write(DataRS.Tables[0].Columns[2].);
            //Response.Write(DataRS.Tables[0].Rows.Count);




        }


    }

    protected void btnCounter_OnClick(object sender,EventArgs e)
    {
        btnCounter.Text = "Clicked";
    }
}