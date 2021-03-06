﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hourse_modify.aspx.cs" Inherits="hourse_hourse_modify" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
  <head>  
    <title>修改房屋信息</title> 
 	<link href="../css/add_modify.css" rel="stylesheet" type="text/css"  />
 	<script src="../js/util.js" type="text/javascript"></script>
 </head> 
  <body>
  
  <div id="container">  
	<div id="title">
		<table width="100%" border="0" cellpadding="0" cellspacing="2" align="center">
		<tr> 
		    <td height="21"> <img src="../images/ico/ico29.gif" width="32" height="32" hspace="2" vspace="2" align="absmiddle"> <strong> 房屋信息修改 </font></td>
		  </tr>
		</table>
	</div>
	
	<div id="content">
		<form id="form1" runat="server">
		<p>
			租金:&nbsp;<asp:TextBox ID="zujin" CssClass="text" runat="server"></asp:TextBox>&nbsp;元/月
		    <script>		        writeSpaces(40);</script>
			户型:&nbsp;<asp:TextBox ID="huxing" CssClass="text" runat="server"></asp:TextBox>
		</p>
		<p>
			面积:&nbsp;<asp:TextBox ID="mianji" CssClass="text" runat="server"></asp:TextBox>&nbsp;M<sup>2</sup>
		    <script>		        writeSpaces(44);</script>
		    装修:&nbsp;<asp:TextBox ID="zhuangxiu" CssClass="text" runat="server"></asp:TextBox>
		</p>
		<p>
		    类型:&nbsp;<asp:TextBox ID="leixing" CssClass="text" runat="server"></asp:TextBox>
		    <script>		        writeSpaces(49);</script>
		    楼层:&nbsp;<asp:TextBox ID="louceng" CssClass="text" runat="server"></asp:TextBox>
		</p>
		<p>
		    区域:&nbsp;<asp:TextBox ID="quyu" CssClass="text" runat="server"></asp:TextBox>
		    <script>		        writeSpaces(49);</script>
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
		    <asp:Button ID="Btn_Modify" CssClass="btn" runat="server" Text="修改" 
                onclick="Btn_Modify_Click" /> 
		</p> 
		</form>
	</div>
</div>
    
  </body>
</html>
