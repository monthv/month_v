<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication8.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            新闻标题：<asp:TextBox ID="txTitle" runat="server" Width="372px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            新闻出处：<asp:TextBox ID="txWriter" runat="server" Width="372px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            新闻内容：<asp:TextBox ID="txContent" runat="server" Height="425px" TextMode="MultiLine" Width="802px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="确 认" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
