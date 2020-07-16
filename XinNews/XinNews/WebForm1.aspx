<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="XinNews.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">

        function qwq()
        {


        var flag = confirm("你好");
        if (flag == true)
            alert("你了")
        else
            alert("无敌")
           // var wowo = "cxcx,zxzx,xoxo,koko";
           // var vovo = wowo.split(",");
           // var count = 0;
           // for (var i = 0; i < vovo.length;i++) 
           //    {
           //       if (vovo[i].indexOf("1")!= -1)
           //      {                 
           //          count++;               
           //      }            
           //    }
           //   alert(count);
        }
       

        

        
    </script>
</head>
<body>
    <input onclick="qwq()" id="But" type="button" value="打开" />
    
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
