<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListUsers.aspx.cs" Inherits="OABase_ListUsers"  Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>员工列表</title>
<link href="../css/manage.css" rel="Stylesheet" type="text/css" />  
<script src="../opennew/alert.js" type="text/javascript"></script> 
<script src="../opennew/Dialog.js" type="text/javascript"></script> 
<script src="../js/ajax.js" type="text/javascript"></script> 
<script src="../js/util.js" type="text/javascript"></script> 
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" /> 
</head>
<body>
  <div id="container">  
	<div id="title">
  		<table width="98%" border="0" cellpadding="0" cellspacing="2" align="center">
		<tr> 
		    <td height="21"> <img src="../images/ico/ico08.gif" alt=""/><strong>员工列表</strong>
		    <script type="text/javascript">writeSpaces(105);</script>
		    <img src="../images/print.jpg" title="打印"  style="cursor:hand;" alt="" onclick="preview();"> </td>
		  </tr>
		</table>
  	</div>
	
	<div id="content"> 
	  <form id="Form1"  method="post" runat="server" name="form1"> 
		<table width="98%" border="1" cellspacing="1" cellpadding="2" align="center"  style="margin:0px;"> 
	 		<tr>
				<td colspan="9">  
				    出租类型:
				    <asp:DropDownList ID="leixing" runat="server">
				        <asp:ListItem Text="不限" Value="" />
				        <asp:ListItem Text="整租" Value="整租" />
				        <asp:ListItem Text="非整租" Value="非整租" />
				    </asp:DropDownList>
	  				小区:
	  				<asp:TextBox ID="xiaoqu" runat="server" Width="60px"></asp:TextBox>
	  				价格区间:
	  				<asp:TextBox ID="lowprice" runat="server" Width="30px"></asp:TextBox>&nbsp;
	  				到&nbsp;<asp:TextBox ID="highprice" Width="30px" runat="server" />
	  				<asp:Button ID="Btn_Query" runat="server" onclick="Btn_Query_Click" Text="查询" />
	 			 
				</td>
  			</tr>
  		</table>
  		<!--startprint--> 
		<table width="98%" border="1" cellspacing="1" cellpadding="2" align="center" style="margin:0px;"> 
  			 <tr class="a1" style="color:#ffffff;font-size:12px;">
   				        <th height="30">用户名</th>
				        <th width="40px">操作</th>	
  			        </tr>  
  			
  			<asp:Repeater ID="UserDataList" runat="server">
  			    <ItemTemplate>
  			     <tr> 
      			        <td><%#Eval("UserName") %> </td>
  			        </tr>
  			    </ItemTemplate>
  			</asp:Repeater>
  			 
  			        <tr>
  			            <td align="right" colspan="9">
  			             第<asp:Literal ID="CurrentPage" runat="server" />页&nbsp;/&nbsp;共<asp:Literal ID="TotalPage" runat="server" />页 
  			              &nbsp;&nbsp;&nbsp;&nbsp;
  			                <asp:Button ID="firstBtn" runat="server" Text="首页" onclick="firstBtn_Click" />
  			                <asp:Button ID="prevBtn" runat="server" Text="上页" onclick="prevBtn_Click" />
  			                <asp:Button ID="nextBtn" runat="server" Text="下页" onclick="nextBtn_Click" />
  			                <asp:Button ID="lastBtn" runat="server" Text="末页" onclick="lastBtn_Click" />
  			            </td>
  			        </tr> 
  			        <input type=button id="Ajax_Btn" style="display:none;" onclick="Ajax_GetHourse();" />
  			 
		</table> 
		<!--endprint-->
		</form> 
	</div>
</div>
</body>
</html>
