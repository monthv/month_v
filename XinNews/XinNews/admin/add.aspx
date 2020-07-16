<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="XinNews.admin.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            新闻编号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            新闻标题：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            新闻来源：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            新闻内容：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="width: 50px" Text="添加" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
