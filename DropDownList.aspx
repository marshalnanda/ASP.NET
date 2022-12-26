<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Text="Select Continent" Value="-1"></asp:ListItem>
    <asp:ListItem Text="Asia" Value="1"></asp:ListItem>
    <asp:ListItem Text="Europe" Value="2"></asp:ListItem>
    <asp:ListItem Text="Africa" Value="3"></asp:ListItem>
    <asp:ListItem Text="North America" Value="4"></asp:ListItem>
    <asp:ListItem Text="South America" Value="5"></asp:ListItem>
</asp:DropDownList>
<br /><br />
<asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        

    </form>
</body>
</html>
