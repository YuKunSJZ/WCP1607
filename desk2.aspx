<%@ Page Language="C#" AutoEventWireup="true" CodeFile="desk2.aspx.cs" Inherits="desk2" %>



<!DOCTYPE html>


<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>���ݳ�����Ϣ����ϵͳ - ����</title>
<link href="css/desk.css" rel="stylesheet" type="text/css"> 
</head>

<body>
<table align=center width="90%" border="0" cellspacing="0" cellpadding="0" height="100%">
      <tr>
        <td valign="top">
         <font color='red'><br />dest2.aspx���ݳ�����Ϣ����ϵͳ</font><br/>
        </td>     
      </tr>

    </table>
    <form runat="server">
        <tr>
            <td>��ǩ</td>
        </tr>
        <asp:Label id="lblMessage" runat="server" Text="123"></asp:Label>
        <asp:Button text="Uncliked" onclick="btnCounter_OnClick" id="btnCounter" runat="server" width="80"/>
    </form>
</body>
</html>
