﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GreetingCardMaker_verion6.aspx.cs" Inherits="WebApplication1.CE_136_Chinmay_Vadgama.GreetingCardMaker_verion6" %>

<!DOCTYPE html>
<html>
<head runat="server">
<title>Greeting Card Maker</title>
</head>
<body>
<form runat="server">
<div>
<!-- Here are the controls: -->
Choose a background color:<br />
<asp:DropDownList ID="lstBackColor" runat="server" Width="194px"
Height="22px"/><br /><br />
Choose a font:<br />
<asp:DropDownList ID="lstFontName" runat="server" Width="194px"
Height="22px" /><br /><br />
Specify a numeric font size:<br />
<asp:TextBox ID="txtFontSize" runat="server" /><br /><br />
Choose a border style:<br />
<asp:RadioButtonList ID="lstBorder" runat="server" Width="177px"
Height="59px" /><br /><br />
<asp:CheckBox ID="chkPicture" runat="server"
Text="Add the Default Picture"></asp:CheckBox><br /><br />
Enter the greeting text below:<br />
<asp:TextBox ID="txtGreeting" runat="server" Width="240px" Height="85px"
Textmode="MultiLine" /><br /><br />
<asp:Button ID="cmdUpdate"  runat="server" Width="71px" Height="24px" Text="Update" PostBackUrl="greetingcard.aspx" />
</div>
</form>
</body>
</html>