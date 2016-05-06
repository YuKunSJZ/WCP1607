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
            <img src="../images/ADD.gif" />增加用户
        </div>
        <div id="content">
            <form runat="server" name="form1">
                <p>
                    用户名：<asp:TextBox ID="yonghuming" CssClass="text" runat="server"></asp:TextBox>
                </p>
                <p>
                    设置密码：<asp:TextBox ID="mima" CssClass="text" TextMode="Password" runat="server"></asp:TextBox>
                </p>
                <br />
                <p>
                    姓名：<asp:TextBox ID="xingming" CssClass="text" runat="server"></asp:TextBox>
                </p>
                <p>
                    部门：<asp:TextBox ID="bumen" CssClass="text" runat="server"></asp:TextBox>
                </p>
                <p>
                    职务：<asp:TextBox ID="zhiwu" CssClass="text" runat="server"></asp:TextBox>
                </p>
                <p>
                    电话：<asp:TextBox ID="dianhua" CssClass="text" runat="server"></asp:TextBox>
                </p>

                <p>
                    <asp:Button id="UserAdd" CssClass="btn" runat="server" text="增加员工" OnClick="UserAdd_Click"/>
                </p>
            </form>
        </div>
    
    </div>

</body>
</html>
