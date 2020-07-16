 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Tomorrow.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="jquery-3.4.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#vv").blur(function () {
                var v = $("#vv").val();
                $.ajax({
                    url: "/love.ashx?xv=" + v,
                    cache: false,
                    dataType: 'text',
                    success: function (data) {
                        if (data == 1)
                            $("#xx").text("正确");
                        else (data == 0)
                            $("#xx").text("错误");
                    }
                });

            });
        });
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text"  id="vv"/><label id="xx">1111</label>
        </div>
    </form>
</body>
</html>
