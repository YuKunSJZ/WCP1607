using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HourseRentSystem.BLL;
using HourseRentSystem.Model;

using System.Text;

public partial class hourse_GetHourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Response.Clear();
        Response.Buffer = true; 
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.ContentType = "text/plain";    

        int hourseId = Int32.Parse(Request.QueryString["hourseId"]);
        HourseBLL hourseBll = new HourseBLL();
        Hourse hourse = hourseBll.GetHourseById(hourseId);

        StringBuilder sb = new StringBuilder();
 
        /* 第一种方法：使用XML格式返回数据
        sb.AppendLine("<Hourse>");
        sb.AppendLine("<zujin>").Append(hourse.getZujin()).Append("</zujin>");
        sb.AppendLine("<huxing>").Append(hourse.getHuxing()).Append("</huxing>");
        sb.AppendLine("<mianji>").Append(hourse.getMianji()).Append("</mianji>");
        sb.AppendLine("<zhuangxiu>").Append(hourse.getZhuangxiu()).Append("</zhuangxiu>");
        sb.AppendLine("<leixing>").Append(hourse.getLeixing()).Append("</leixing>");
        sb.AppendLine("<louceng>").Append(hourse.getLouceng()).Append("</louceng>");
        sb.AppendLine("<quyu>").Append(hourse.getQuyu()).Append("</quyu>");
        sb.AppendLine("<xiaoqu>").Append(hourse.getXiaoqu()).Append("</xiaoqu>");
        sb.AppendLine("</Hourse>"); 
        */
        

        /*第2种方式:使用 JSON数据格式返回*/

        sb.Append("{zujin:").Append(hourse.getZujin());
        sb.Append(",huxing:'").Append(hourse.getHuxing());
        sb.Append("',mianji:").Append(hourse.getMianji());
        sb.Append(",zhuangxiu:'").Append(hourse.getZhuangxiu());
        sb.Append("',leixing:'").Append(hourse.getLeixing());
        sb.Append("',louceng:'").Append(hourse.getLouceng());
        sb.Append("',quyu:'").Append(hourse.getQuyu());
        sb.Append("',xiaoqu:'").Append(hourse.getXiaoqu()); 
        sb.Append("'}");

        string result = sb.ToString();
        Response.Write(result);
        Response.Flush();
        Response.End();

    }
}
