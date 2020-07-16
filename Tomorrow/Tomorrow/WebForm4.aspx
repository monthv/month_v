<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Tomorrow.WebForm4" %>//把前台文件和后台文件绑定

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="jquery-3.4.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            //对像变成对像    反序列化
            //对像变成字符串    序列化
                $.ajax({
                    url: "/xv.ashx?Method=Query",
                    data: $("#form1").Serialize(),
                    cache: false,
                    type: "Post",
                    dataType: 'json',
                    success: function (data) {
                        if (data != "") {
                            var oHtml = "<table>";
                            oHtml += "<tr>";
                            oHtml += "<th>编号</th>";
                            oHtml += "<th>姓名</th>";
                            oHtml += "<th>年龄</th>";
                            oHtml += "<th>性别</th>";
                            oHtml += "<th>地址</th>";
                            oHtml += "<th>电话</th>";
                            oHtml += "<th>操作</th>";
                            oHtml += "</tr>";
                            for (var i = 0; i < data.length; i++) {
                                oHtml += "<tr>";
                                oHtml += "<td>" + data[i].StudentNO + "</td>";
                                oHtml += "<td>" + data[i].StudentName + "</td>";
                                oHtml += "<td>" + data[i].StudentAge + "</td>";
                                oHtml += "<td>" + data[i].StudentSex + "</td>";
                                oHtml += "<td>" + data[i].StudentProvince + "</td>";
                                oHtml += "<td>" + data[i].StudentPhone + "</td>";
                                oHtml += "<td><a href = '#' onclick ='Del(" + data[i].StudentNO + ")'>删除</a > </td>";
                                oHtml += "</tr>";
                            }
                            oHtml += "</table>";
                            $("#vv").html(oHtml);
                        }
                    }
                });
          

            });
       
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div id="vv"></div>
        </div>
    </form>
</body>
</html>
