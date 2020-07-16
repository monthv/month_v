<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication10.WebForm21" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        新闻编号：<asp:TextBox ID="TextBox1" runat="server" Width="482px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        新闻标题：<asp:TextBox ID="TextBox2" runat="server" Width="482px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        新闻出处：<asp:TextBox ID="TextBox3" runat="server" Width="482px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        新闻内容：<asp:TextBox ID="TextBox4" runat="server" Height="160px" TextMode="MultiLine" Width="482px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
