<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head> 
<title>ʯ��ׯ�������</title>
<link href="css/style.css" rel="stylesheet" type="text/css" /> 
<script src="js/treemenu.js" language="JavaScript" type="text/javascript"></script> 
<script src="opennew/Dialog.js" language="javascript" type="text/javascript"></script>
 </head>

<body> 

<div id="container">
	<div id="banner"><img src="images/TopTitle.gif" alt="TopTitle"/></div>
	<div id="globallink">
		<ul>
			<li><a href="#" onclick="javascript:ShowTreeNode(1);">Ա������</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(2);">��������</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(3);">���Ź���</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(4);">�ʲ�����</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(5);">Ȩ�޹���</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(6);">ϵͳ����</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(7);">��ϵ����</a></li>
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
		<p>ICP:010033234 QQ:741346664 �ֻ�:13739795066 &copy;��Ȩ���� <a href="#" target="_blank">ʯ��ׯ�������</a></p>
	</div>
</div>
</body>
</html>
