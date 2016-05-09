<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListUsers.aspx.cs" Inherits="OABase_ListUsers"  Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Ա���б�</title>
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
		    <td height="21"> <img src="../images/ico/ico08.gif" alt=""/><strong>Ա���б�</strong>
		    <script type="text/javascript">writeSpaces(105);</script>
		    <img src="../images/print.jpg" title="��ӡ"  style="cursor:hand;" alt="" onclick="preview();"> </td>
		  </tr>
		</table>
  	</div>
	
	<div id="content"> 
	  <form id="Form1"  method="post" runat="server" name="form1"> 
		<table width="98%" border="1" cellspacing="1" cellpadding="2" align="center"  style="margin:0px;"> 
	 		<tr>
				<td colspan="9">  
				    ��������:
				    <asp:DropDownList ID="leixing" runat="server">
				        <asp:ListItem Text="����" Value="" />
				        <asp:ListItem Text="����" Value="����" />
				        <asp:ListItem Text="������" Value="������" />
				    </asp:DropDownList>
	  				С��:
	  				<asp:TextBox ID="xiaoqu" runat="server" Width="60px"></asp:TextBox>
	  				�۸�����:
	  				<asp:TextBox ID="lowprice" runat="server" Width="30px"></asp:TextBox>&nbsp;
	  				��&nbsp;<asp:TextBox ID="highprice" Width="30px" runat="server" />
	  				<asp:Button ID="Btn_Query" runat="server" onclick="Btn_Query_Click" Text="��ѯ" />
	 			 
				</td>
  			</tr>
  		</table>
  		<!--startprint--> 
		<table width="98%" border="1" cellspacing="1" cellpadding="2" align="center" style="margin:0px;"> 
  			 <tr class="a1" style="color:#ffffff;font-size:12px;">
   				        <th height="30">�û���</th>
				        <th width="40px">����</th>	
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
  			             ��<asp:Literal ID="CurrentPage" runat="server" />ҳ&nbsp;/&nbsp;��<asp:Literal ID="TotalPage" runat="server" />ҳ 
  			              &nbsp;&nbsp;&nbsp;&nbsp;
  			                <asp:Button ID="firstBtn" runat="server" Text="��ҳ" onclick="firstBtn_Click" />
  			                <asp:Button ID="prevBtn" runat="server" Text="��ҳ" onclick="prevBtn_Click" />
  			                <asp:Button ID="nextBtn" runat="server" Text="��ҳ" onclick="nextBtn_Click" />
  			                <asp:Button ID="lastBtn" runat="server" Text="ĩҳ" onclick="lastBtn_Click" />
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
