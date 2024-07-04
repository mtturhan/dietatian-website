<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="secure_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yönetim Paneli Giriş Ekranı</title>
    <!-- Reset -->
    <link rel="stylesheet" type="text/css" href="style/reset.css" /> 
    <!-- Main Style File -->
    <link rel="stylesheet" type="text/css" href="style/root.css" /> 
    <!-- Grid Styles -->
    <link rel="stylesheet" type="text/css" href="style/grid.css" /> 
    <!-- Typography Elements -->
    <link rel="stylesheet" type="text/css" href="style/typography.css" /> 
    <!-- Jquery UI -->
    <link rel="stylesheet" type="text/css" href="style/jquery-ui.css" />
    <!-- Jquery Plugin Css Files Base -->
    <link rel="stylesheet" type="text/css" href="style/jquery-plugin-base.css" />
    
    <!--[if IE 7]>	  <link rel="stylesheet" type="text/css" href="style/ie7-style.css" />	<![endif]-->
    
    <!-- jquery base -->
	<script type="text/javascript" src="js/jquery.min.js"></script>
	<script type="text/javascript" src="js/jquery-ui-1.8.11.custom.min.js"></script>
    <!-- jquery plugins settings -->
	<script type="text/javascript" src="js/jquery-settings.js"></script>
    <!-- toggle -->
	<script type="text/javascript" src="js/toogle.js"></script>
    <!-- tipsy -->
	<script type="text/javascript" src="js/jquery.tipsy.js"></script>
    <!-- uniform -->
	<script type="text/javascript" src="js/jquery.uniform.min.js"></script>
    <!-- Jwysiwyg editor -->
	<script type="text/javascript" src="js/jquery.wysiwyg.js"></script>
    <!-- table shorter -->
	<script type="text/javascript" src="js/jquery.tablesorter.min.js"></script>
    <!-- raphael base and raphael charts -->
	<script type="text/javascript" src="js/raphael.js"></script>
	<script type="text/javascript" src="js/analytics.js"></script>
	<script type="text/javascript" src="js/popup.js"></script>
    <!-- fullcalendar -->
	<script type="text/javascript" src="js/fullcalendar.min.js"></script>
    <!-- prettyPhoto -->
	<script type="text/javascript" src="js/jquery.prettyPhoto.js"></script>
    <!-- Jquery.UI Base -->
	<script type="text/javascript" src="js/jquery.ui.core.js"></script>
	<script type="text/javascript" src="js/jquery.ui.mouse.js"></script>
	<script type="text/javascript" src="js/jquery.ui.widget.js"></script>
    <!-- Slider -->
	<script type="text/javascript" src="js/jquery.ui.slider.js"></script>
    <!-- Date Picker -->
	<script type="text/javascript" src="js/jquery.ui.datepicker.js"></script>
    <!-- Tabs -->
	<script type="text/javascript" src="js/jquery.ui.tabs.js"></script>
    <!-- Accordion -->
	<script type="text/javascript" src="js/jquery.ui.accordion.js"></script>
    <!-- Google Js Api / Chart and others -->
	<script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <!-- Date Tables -->
	<script type="text/javascript" src="js/jquery.dataTables.js"></script>
</head>
<body>
    <div class="loginform">
    	<div class="title"> </div>
        <div class="body">
       	    <form id="form2" runat="server">
          	<label class="log-lab">Kullanıcı Adı&nbsp; <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="*" Visible="False"></asp:Label>
                </label>
                <asp:TextBox ID="TextBox1" runat="server" class="login-input-user"></asp:TextBox>
          	<label class="log-lab">Şifre <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="*" Visible="False"></asp:Label>
                </label>
                &nbsp;<asp:TextBox ID="TextBox2" runat="server" class="login-input-pass" TextMode="Password"></asp:TextBox>
       	        <asp:Button ID="Button1" runat="server" Text="Giriş"  class="button" OnClick="Button1_Click"/>
            </form>
        </div>
    </div>
</body>
</html>
