<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigating to a specific month and an year.aspx.cs" Inherits="WebApplication1.Navigating_to_a_specific_month_and_an_year" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
    Year :
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>&nbsp;
    Month:
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
        onselectedindexchanged="DropDownList2_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Get Selected Date" />
</div>
    </form>
</body>
</html>
