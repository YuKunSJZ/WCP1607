using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HourseRentSystem.BLL;

public partial class hourse_hourse_manage : System.Web.UI.Page
{
    /*保存当前要显示的页码,初始化为1*/
    private static int curPage = 1;
    /*总的页数*/
    private int totalPage = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Write("<script>alert('请登录系统!');top.location.href='../login.aspx';</script>");
            return;
        }
        this.HourseDataListBind();
    } 

    /*绑定要显示的数据*/
    private void HourseDataListBind()
    {
        try
        {
            /*实例化分页数据源*/
            System.Web.UI.WebControls.PagedDataSource ps = new PagedDataSource();
            /*建立业务层对象，执行查询，将记录集绑定到分页数据源上*/
            HourseBLL hourseBll = new HourseBLL();
            ps.DataSource = hourseBll.QueryHourseInfo(this.leixing.SelectedValue, xiaoqu.Text, lowprice.Text, highprice.Text).Tables[0].DefaultView;
            ps.AllowPaging = true;
            ps.PageSize = 6;//每页显示几条记录
            ps.CurrentPageIndex = curPage-1;//设置当前页的索引(当前页码减1就是)
            this.firstBtn.Enabled = true;
            this.nextBtn.Enabled = true;
            this.prevBtn.Enabled = true;
            this.lastBtn.Enabled = true;
            totalPage = ps.PageCount;

            this.CurrentPage.Text = curPage.ToString();
            this.TotalPage.Text = totalPage.ToString();

            if (curPage == 1)//当是第一页是.上一页和首页的按钮不可用
            {
                this.prevBtn.Enabled = false;
                this.firstBtn.Enabled = false;
            }
            if (curPage == ps.PageCount)//当是最后一页时下一页和最后一页的按钮不可用
            {
                this.nextBtn.Enabled = false;
                this.lastBtn.Enabled = false;
            }
            this.hourseDataList.DataSource = ps;
            //this.hourseDataList.DataKeyField = "hourseId";
            this.hourseDataList.DataBind(); 

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    protected void Btn_Query_Click(object sender, EventArgs e)
    {
        curPage = 1;
        this.HourseDataListBind();
    }
    protected void firstBtn_Click(object sender, EventArgs e)
    {
        curPage = 1;
        this.HourseDataListBind();
    }
    protected void prevBtn_Click(object sender, EventArgs e)
    {
        curPage--;
        this.HourseDataListBind();
    }
    protected void nextBtn_Click(object sender, EventArgs e)
    {
        curPage++;
        this.HourseDataListBind();
    }
    protected void lastBtn_Click(object sender, EventArgs e)
    {
        curPage = totalPage;
        this.HourseDataListBind();
    }
}
