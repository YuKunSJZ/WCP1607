<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head> 
<title>石家庄筑企软件</title>
<link href="css/style.css" rel="stylesheet" type="text/css" /> 
<script src="js/treemenu.js" language="JavaScript" type="text/javascript"></script> 
<script src="opennew/Dialog.js" language="javascript" type="text/javascript"></script>
 </head>

<body> 

<div id="container">
	<div id="banner"><img src="images/TopTitle.gif" alt="TopTitle"/></div>
	<div id="globallink">
		<ul>
			<li><a href="#" onclick="javascript:ShowTreeNode(1);">员工管理</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(2);">工作管理</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(3);">部门管理</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(4);">资产管理</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(5);">权限管理</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(6);">系统管理</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(7);">联系我们</a></li>
		</ul>
		<br />
	</div>
	
	<div id="left">
		<div id="MenuTitle"> <img src="images/menu.jpg" alt="menu" /></div>
		<div id="NavMenu"> <script language="JavaScript" type="text/javascript"> WriteTreeInfo();</script></div>
	</div>	
 
	<div id="main">
	 <iframe id="frame1" src="desk2.aspx" name="OfficeMain" width="100%" height="100%" scrolling="no" marginwidth=0 marginheight=0 frameborder=0 vspace=0 hspace=0 >
	 </iframe>
	</div>
	
	<div id="footer">
		<p>ICP:010033234 QQ:741346664 手机:13739795066 &copy;版权所有 <a href="#" target="_blank">石家庄筑企软件</a></p>
	</div>
</div>
</body>
</html>
