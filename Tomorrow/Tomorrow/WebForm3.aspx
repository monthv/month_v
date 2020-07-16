<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Tomorrow.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="jquery-3.4.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#TextBox1").blur(function () {
                var vv = $("#TextBox1").text();
                $.ajax({
                    url: "/love.ashx?+vv",
                    cache: false,
                    dataType: 'text',
                    success: function (data) {
                        if (data == 1)
                            $("#Label1").text("正确");
                        else (data == 0)
                            $("#Label1").text("错误");
                    }
                });

            });
        });
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
