<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Tomorrow.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>          
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
         <div>          
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
         <div>          
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
             <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
             <br />
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                 <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                 <Columns>
                     <asp:BoundField DataField="TrainCode" HeaderText="车次" />
                     <asp:BoundField DataField="FirstStation" HeaderText="始发站" />
                     <asp:BoundField DataField="LastStation" HeaderText="终点站" />
                     <asp:BoundField DataField="StartTime" HeaderText="发车时间" />
                     <asp:BoundField DataField="ArriveStation" HeaderText="到达站" />
                     <asp:BoundField DataField="ArriveTime" HeaderText="到达时间" />
                     <asp:BoundField DataField="KM" HeaderText="km" />
                     <asp:BoundField DataField="UseDate" HeaderText="历时" />
                 </Columns>
                 <EditRowStyle BackColor="#999999" />
                 <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#E9E7E2" />
                 <SortedAscendingHeaderStyle BackColor="#506C8C" />
                 <SortedDescendingCellStyle BackColor="#FFFDF8" />
                 <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

             </asp:GridView>
        </div>
    </form>
</body>
</html>
