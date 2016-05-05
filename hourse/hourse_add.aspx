<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hourse_add.aspx.cs" Inherits="hourse_hourse_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
  <head> 
    <title>石家庄</title>  
    <link href="../css/add_modify.css" rel="stylesheet" type="text/css"  /> 
    <script src="../js/util.js" language="JavaScript" type="text/javascript"></script> 
  </head>
  
  <body> 
	
  <div id="container">
  	<div id="title">
  		<img src="../images/ADD.gif" />房屋信息录入 (带*号的为必填项)
  	</div>
  	<div id="content">
  		<form runat="server" name="form1"> 
		<p>
			租金:&nbsp;<asp:TextBox ID="zujin" CssClass="text" runat="server"></asp:TextBox>&nbsp;元/月
		    <script>writeSpaces(40);</script>
			户型:&nbsp;<asp:TextBox ID="huxing" CssClass="text" runat="server"></asp:TextBox>
		</p>
		<p>
			面积:&nbsp;<asp:TextBox ID="mianji" CssClass="text" runat="server"></asp:TextBox>&nbsp;M<sup>2</sup>
		    <script>writeSpaces(44);</script>
		    装修:&nbsp;<asp:TextBox ID="zhuangxiu" CssClass="text" runat="server"></asp:TextBox>
		</p>
		<p>
		    类型:&nbsp;<asp:TextBox ID="leixing" CssClass="text" runat="server"></asp:TextBox>
		    <script>writeSpaces(49);</script>
		    楼层:&nbsp;<asp:TextBox ID="louceng" CssClass="text" runat="server"></asp:TextBox>
		</p>
		<p>
		    区域:&nbsp;<asp:TextBox ID="quyu" CssClass="text" runat="server"></asp:TextBox>
		    <script>writeSpaces(49);</script>
		    小区:&nbsp;<asp:TextBox ID="xiaoqu" CssClass="text" runat="server"></asp:TextBox>
		</p>
		<p>
		    地址:&nbsp;<asp:TextBox ID="dizhi" CssClass="text" Width="520px" runat="server"></asp:TextBox>
		</p>
		<p> 
			房间配置:<br />
			<asp:CheckBox ID="chuangFlag" runat="server" Text="是否有床" />&nbsp;
			<asp:CheckBox ID="dianhuaFlag" runat="server" Text="是否有电话" />&nbsp;
			<asp:CheckBox ID="dianshiFlag" runat="server" Text="是否有电视" />&nbsp;
			<asp:CheckBox ID="kongtiaoFlag" runat="server" Text="是否有空调" /><br />
			<asp:CheckBox ID="bingxiangFlag" runat="server" Text="是否有冰箱" />&nbsp;
			<asp:CheckBox ID="reshuiqiFlag" runat="server" Text="是否有热水器" />&nbsp;
			<asp:CheckBox ID="xiyijiFlag" runat="server" Text="是否有洗衣机" />&nbsp;
			<asp:CheckBox ID="kuandaiFlag" runat="server" Text="是否有宽带" />
		</p>
		
		<p>
		    <asp:Button ID="Btn_Add" CssClass="btn" runat="server" Text="添加" 
                onclick="Btn_Add_Click" /> 
		</p> 
		
		</form>
  	</div>
  </div> 
			  
  </body>
</html>