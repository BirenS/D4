<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Greeting_Card_Programs.Multiview.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:MultiView ID="MultiView1" runat="server" >
              
                <asp:View ID="View1" runat="server">
                    Choose a foreground (text) color:<br />
                    <asp:DropDownList ID="lstForeColor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ChangeFore" />
                    <br /><br />
                    Choose a background color:<br />
                    <asp:DropDownList ID="lstBackColor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ChangeBack" />
                </asp:View>
              
                <asp:View ID="View2" runat="server">
                    Choose a border style:<br />
                    <asp:RadioButtonList ID="lstBorder" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ChangeBorder" RepeatColumns="2" />
                    <br />
                    <asp:CheckBox ID="chkPicture" runat="server" AutoPostBack="True" OnCheckedChanged="Picture" Text="Add the Default Picture" />
                </asp:View>
 
                
                <asp:View ID="View3" runat="server">
                     Choose a font name:<br />
                     <asp:DropDownList ID="lstFontName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ChangeFont" />
                     <br /><br />
                     Specify a font size:<br />
                     <asp:TextBox ID="txtFontSize" runat="server" AutoPostBack="True" OnTextChanged="ChangeFontSize" />
                     <br /><br />
                     Enter the greeting text below:<br />
                     <asp:TextBox ID="txtGreeting" runat="server" AutoPostBack="True" OnTextChanged="ChangeText" TextMode="MultiLine" />
                     </asp:View>
              </asp:MultiView>
        <asp:Panel ID="pnlCard2" runat="server" Width="339px" Height="481px" HorizontalAlign="Center"
            style="POSITION: absolute; TOP: 26px; LEFT: 496px;">
            <br />&nbsp;
            <asp:Label ID="lblGreeting" runat="server" Width="256px"
            Height="150px" /><br /><br /><br />
            <asp:Image ID="imgDefault" runat="server" Width="212px"
            Height="160px" />
        </asp:Panel>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="View 1" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click2" Text="View 2" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click3" Text="View 3" />
       
    </form>
</body>
</html>
