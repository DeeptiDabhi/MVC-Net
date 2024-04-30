<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        Student Details :
        <br />
        <br />
        ID :&nbsp; <asp:TextBox ID="TextBox1" runat="server" Width="707px"></asp:TextBox>
        <br />
        <br />
        Name : <asp:TextBox ID="TextBox2" runat="server" Width="693px"></asp:TextBox>
        <br />
        <br />
        Date Of Birth :
        <asp:TextBox ID="TextBox3" runat="server" Width="649px"></asp:TextBox>
        <br />
        <br />
        Address :
        <asp:TextBox ID="TextBox4" runat="server" Width="676px"></asp:TextBox>
        <br />
        <br />
        Contact No :
        <asp:TextBox ID="TextBox5" runat="server" Width="655px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" />
        <br />
    </form>
</body>
</html>
