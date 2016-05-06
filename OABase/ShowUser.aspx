<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="OABase_AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>增加用户</title>
    <link href="../css/add_modify.css" rel="stylesheet" type="text/css" />
    <script src="../js/util.js" type="text/javascript"></script>
</head>
<body>
    <div id="container">
        <div id="title">
            <img src="../images/ADD.gif" />用户列表
        </div>
        <div id="content">
            <asp:DataGrid ID="UserDataGrid" runat="server" AutoGenerateColumns="false">

            </asp:DataGrid>
        </div>
    
    </div>

</body>
</html>
