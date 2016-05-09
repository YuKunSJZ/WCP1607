using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

using HourseRentSystem.DB;

public partial class OABase_ListUsers : System.Web.UI.Page
{
    private static int curPage = 1;
    private int totalPage = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"]== null)
        {
            Response.Write("<script>alter('请登录系统!');location.href='login.aspx';</script>");
            return;
        }

        Response.Write("用户列表显示");
        this.UserListBind();
        
    }

    private void UserListBind()
    {
        DataBase db = new DataBase();
        StringBuilder sqlB = new StringBuilder();
        sqlB.Length = 0;
        sqlB.AppendLine( "SELECT ");
        sqlB.AppendLine( "UserName");
        sqlB.AppendLine("FROM");
        sqlB.AppendLine("`Users`");

        DataSet sqlResults = db.GetDataSet(sqlB.ToString());
        
        try
        {
            System.Web.UI.WebControls.PagedDataSource ps = new System.Web.UI.WebControls.PagedDataSource();
            ps.DataSource = sqlResults.Tables[0].DefaultView;
            ps.AllowPaging = true;
            ps.PageSize = 10;
            ps.CurrentPageIndex = curPage - 1;
            this.firstBtn.Enabled = true;
            this.nextBtn.Enabled = true;
            this.prevBtn.Enabled = true;
            this.lastBtn.Enabled = true;
            totalPage = ps.PageCount;

            this.CurrentPage.Text = curPage.ToString();
            this.TotalPage.Text = totalPage.ToString();

            if (curPage == 1)
            {
                this.firstBtn.Enabled = false;
                this.prevBtn.Enabled = false;
            }
            if (curPage == ps.PageCount)
            {
                this.nextBtn.Enabled = false;
                this.lastBtn.Enabled = false;
            }

            this.UserDataList.DataSource = ps;
            this.UserDataList.DataBind();
        }
        catch (Exception ex)
        {
            throw new Exception ("sql failed:" + sqlB.ToString()+ex.ToString());
        }
    }
    protected void Btn_Query_Click(object sender, EventArgs e)
    {
        curPage = 1;
        this.UserListBind();
    }
    protected void firstBtn_Click(object sender, EventArgs e)
    {
        curPage = 1;
        this.UserListBind();
    }
    protected void prevBtn_Click(object sender, EventArgs e)
    {
        curPage--;
        this.UserListBind();
    }
    protected void nextBtn_Click(object sender, EventArgs e)
    {
        curPage++;
        this.UserListBind();
    }
    protected void lastBtn_Click(object sender, EventArgs e)
    {
        curPage = totalPage;
        this.UserListBind();
    }
}