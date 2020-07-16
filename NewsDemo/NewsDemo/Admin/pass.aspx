﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pass.aspx.cs" Inherits="NewsDemo.Admin.pass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
<meta name="renderer" content="webkit">
<title></title>
<link rel="stylesheet" href="css/pintuer.css">
<link rel="stylesheet" href="css/admin.css">
<script src="js/jquery.js"></script>
<script src="js/pintuer.js"></script>
</head>
<body>
    
   <div class="panel admin-panel">
  <div class="panel-head"><strong><span class="icon-key"></span> 修改会员密码</strong></div>
  <div class="body-content">
    <form id="form1" runat="server" method="post" class="form-x" action="">
      <div class="form-group">
        <div class="label">
          <label for="sitename">管理员帐号：</label>
        </div>
        <div class="field">
            <%--<label style="line-height:33px;">--%>
            <asp:Label ID="Label1" runat="server" Text="Label" style="line-height:33px;"></asp:Label>
          
          <%--</label>--%>
        </div>
      </div>      
      <div class="form-group">
        <div class="label">
          <label for="sitename">原始密码：</label>
        </div>
        <div class="field">
            <%--<input type="password" class="input w50" id="mpass" name="mpass" size="50" placeholder="请输入原始密码" data-validate="required:请输入原始密码" />--%>
            <asp:TextBox  runat="server" class="input w50" id="TextBox1" name="mpass" size="50" placeholder="请输入原始密码" data-validate="required:请输入原始密码"></asp:TextBox><asp:Label ID="Label2" runat="server" Text=""></asp:Label>  
        </div>
      </div>
            
      <div class="form-group">
        <div class="label">
          <label for="sitename">新密码：</label>
        </div>
        <div class="field">
            <%-- <input type="password" class="input w50" name="newpass" size="50" placeholder="请输入新密码" data-validate="required:请输入新密码,length#>=5:新密码不能小于5位" />    --%>     
            <asp:TextBox ID="TextBox2" runat="server" class="input w50" name="newpass" size="50" placeholder="请输入新密码" ></asp:TextBox>
        </div>
      </div>
      <div class="form-group">
        <div class="label">
          <label for="sitename">确认新密码：</label>
        </div>
        <div class="field">
            <asp:TextBox ID="TextBox3" runat="server" class="input w50" name="renewpass" size="50" placeholder="请再次输入新密码" ></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <%--<input type="password" class="input w50" name="renewpass" size="50" placeholder="请再次输入新密码" data-validate="required:请再次输入新密码,repeat#newpass:两次输入的密码不一致" />    --%>      
        </div>
      </div>
        
      <div class="form-group">
        <div class="label">
          <label></label>
        </div>
        <div class="field">
            <asp:Button ID="Button1" runat="server" Text="提交"  class="button bg-main icon-check-square-o" type="submit" OnClick="Button1_Click"/>
            <%--<button class="button bg-main icon-check-square-o" type="submit"> 提交</button>   --%>
        </div>
      </div>      
    </form>
  </div>
    
</body>
</html>
