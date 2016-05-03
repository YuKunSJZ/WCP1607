using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HourseRentSystem.Model;
using HourseRentSystem.BLL;

public partial class hourse_hourse_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Write("<script>alert('请登录系统!');top.location.href='../login.aspx';</script>");
            return;
        }
    }
    protected void Btn_Add_Click(object sender, EventArgs e)
    {
        /*建立数据模型*/
        Hourse hourse = new Hourse(); 
        try
        {
            /*取得房屋信息*/
            hourse.setZujin(Convert.ToSingle(this.zujin.Text));
            hourse.setHuxing(this.huxing.Text);
            hourse.setMianji(Convert.ToSingle(this.mianji.Text));
            hourse.setZhuangxiu(this.zhuangxiu.Text);
            hourse.setLeixing(this.leixing.Text);
            hourse.setLouceng(this.louceng.Text);
            hourse.setQuyu(this.quyu.Text);
            hourse.setXiaoqu(this.xiaoqu.Text);
            hourse.setDizhi(this.dizhi.Text);
            hourse.setChuangFlag(this.chuangFlag.Checked ? 1 : 0);
            hourse.setDianhuaFlag(this.dianhuaFlag.Checked ? 1 : 0);
            hourse.setDianshiFlag(this.dianshiFlag.Checked ? 1 : 0);
            hourse.setKongtiaoFlag(this.kongtiaoFlag.Checked ? 1 : 0);
            hourse.setBingxiangFlag(this.bingxiangFlag.Checked ? 1 : 0);
            hourse.setReshuiqiFlag(this.reshuiqiFlag.Checked ? 1 : 0);
            hourse.setXiyijiFlag(this.xiyijiFlag.Checked ? 1 : 0);
            hourse.setKuandaiFlag(this.kuandaiFlag.Checked ? 1 : 0);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('你的输入数据有误!');</script>");
            return;
        }

        /*建立业务层对象，实现房屋信息的添加*/
        HourseBLL hourseBll = new HourseBLL();
        if (hourseBll.AddHourse(hourse))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('房屋信息登记成功!');location.href='hourse_add.aspx';</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('" + hourseBll.getErrMessage() + "');</script>");
        }

    }
}
