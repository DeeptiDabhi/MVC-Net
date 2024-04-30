<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 389px;
        }
        .auto-style2 {
            margin-left: 50px;
        }
        .auto-style3 {
            margin-left: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style2">
        </asp:GridView>
        <br />
        <br />
        <div class="auto-style3">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <br />
        <br />
    </form>
</body>
</html>
