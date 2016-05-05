using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using HourseRentSystem.DB;

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

        DataBase db = new DataBase();
        StringBuilder sqlB=new StringBuilder();

        sqlB.Length = 0;
        sqlB.AppendLine("INSERT INTO `Users` (");
        sqlB.AppendLine("`UserID`                ");
        sqlB.AppendLine(",`Name`                 ");
        sqlB.AppendLine(",`UserName`             ");
        sqlB.AppendLine(",`RoleID`               ");
        sqlB.AppendLine(",`LocationID`           ");
        sqlB.AppendLine(",`Language`             ");
        sqlB.AppendLine(",`Email`                ");
        sqlB.AppendLine(",`Phone`                ");
        sqlB.AppendLine(",`Mobile`               ");
        sqlB.AppendLine(",`Fax`                  ");
        sqlB.AppendLine(",`Department`           ");
        sqlB.AppendLine(",`JobTitle`             ");
        sqlB.AppendLine(",`EmployeeNum`          ");
        sqlB.AppendLine(",`StartDate`            ");
        sqlB.AppendLine(",`City`                 ");
        sqlB.AppendLine(",`Password`             ");
        sqlB.AppendLine(",`PasswordExpireDate`   ");
        sqlB.AppendLine(",`LogonFailureCount`    ");
        sqlB.AppendLine(",`Profile`              ");
        sqlB.AppendLine(",`TimeUpdated`          ");
        sqlB.AppendLine(",`UpdatedBy`            ");
        sqlB.AppendLine(",`TimeCreated`          ");
        sqlB.AppendLine(",`CreatedBy`            ");
        sqlB.AppendLine(")                         ");
        sqlB.AppendLine("VALUES                    ");
        sqlB.AppendLine("(                         ");
        sqlB.AppendLine("default                        ");
        sqlB.AppendLine(",'" + Name+"'");
        sqlB.AppendLine(",'"+UserName+"'");
        sqlB.AppendLine(",1                        ");
        sqlB.AppendLine(",1                        ");
        sqlB.AppendLine(",'cn'                     ");
        sqlB.AppendLine(",'yukun@encom8.com'       ");
        sqlB.AppendLine(",'" + PhoneNumber + "'");
        sqlB.AppendLine(",'" + PhoneNumber + "'");
        sqlB.AppendLine(",'03228989977'            ");
        sqlB.AppendLine(",'" + Department + "'");
        sqlB.AppendLine(",'" + JobTitle + "'");
        sqlB.AppendLine(",'T201605050001'          ");
        sqlB.AppendLine(",now()                    ");
        sqlB.AppendLine(",'石家庄'                 ");
        sqlB.AppendLine(",'" + Password + "'");
        sqlB.AppendLine(",'2017-01-01'             ");
        sqlB.AppendLine(",0                        ");
        sqlB.AppendLine(",'I like Computer Scince' ");
        sqlB.AppendLine(",now()                    ");
        sqlB.AppendLine(",'yukun'                  ");
        sqlB.AppendLine(",now()                    ");
        sqlB.AppendLine(",'yukun'                  ");
        sqlB.AppendLine(")                         ");
        sqlB.AppendLine(";                         ");

        //db.ExecuteSQL(sqlB.ToString().Split(';'));
        try
        {
            db.InsertOrUpdate(sqlB.ToString());

        }
        catch (Exception myException)
        {
            Response.Write(myException.ToString());
            Response.Write(sqlB.ToString());
        }
        

    }
}