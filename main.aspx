<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head> 
<title>���ݳ������ϵͳ</title>
<link href="css/style.css" rel="stylesheet" type="text/css" /> 
<script src="js/treemenu.js" language="JavaScript"></script> 
<script src="opennew/Dialog.js" language="javascript"></script>
 </head>

<body> 

<div id="container">
	<div id="banner"><img src="images/TopTitle.gif" /></div>
	<div id="globallink">
		<ul>
			<li><a href="#" onclick="javascript:ShowTreeNode(1);">���ݹ���</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(2);">��ס����</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(3);">�������</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(4);">��ѹ���</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(5);">ˮ�ѹ���</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(6);">����ͳ��</a></li>
			<li><a href="#" onclick="javascript:ShowTreeNode(7);">ϵͳ����</a></li>
		</ul>
		<br />
	</div>
	
	<div id="left">
		<div id="MenuTitle"> <img src="images/menu.jpg" /></div>
		<div id="NavMenu"> <script language=JavaScript> WriteTreeInfo();</script></div>
	</div>	
 
	<div id="main">
	 <iframe id="frame1" src="desk2.aspx" name="OfficeMain" width="100%" height="100%" scrolling="no" marginwidth=0 marginheight=0 frameborder=0 vspace=0 hspace=0 >
	 </iframe>
	</div>
	
	<div id="footer">
		<p>xxx��� QQ:xxxxxxxxxx��xxx �ֻ�:xxx &copy;��Ȩ���� <a href="http://www.51aspx.com" target="_blank">xxx�����</a></p>
	</div>
</div>
</body>
</html>
