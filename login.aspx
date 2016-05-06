<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/login.css" rel="stylesheet" type="text/css" />
    <title>系统登录</title>
</head>
<body>
    <div id="container">
        <!--
        <div id="banner">
            <img src="images/TopTitle.gif" alt="首页" /></div>
        -->
        <div id="LoginPanel">
            <div id="Title">
                <img src="images/login.jpg" width="100%" alt="首页" /></div>
            <div id="Content">
                <form method="post" name="form1" runat="server">
                <p>
                    用户:
                    <asp:TextBox ID="UserName" runat="server" CssClass="text"></asp:TextBox></p>
                <p>
                    密码:
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="text"></asp:TextBox></p>
                <p>
                    <asp:Button ID="Btn_Login" runat="server" CssClass="btn" Text="登录" OnClick="Btn_Login_Click" />
                </p>
                </form>
            </div>
        </div>
        <div id="footer">
            <p>
                QQ:731346664 手机:13739795066 &copy;版权所有</p>
        </div>
    </div>
</body>
</html>
