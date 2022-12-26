<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Techniques_to_send_data_from_one_webform_to_another.cookies.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
<table>
    <tr>
        <td colspan="2">
            <h1>
                This is WebForm1</h1>
        </td>
    </tr>
    <tr>
        <td>
            <b>Name</b>
        </td>
        <td>
            :<asp:TextBox ID="txtName" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <b>Email</b>
        </td>
        <td>
            :<asp:TextBox ID="txtEmail" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2"> 
            <asp:Button ID="btnSendData" runat="server" 
            Text="Go to WebForm2" onclick="btnSendData_Click" />
        </td>
    </tr>
</table>
</div>
    </form>
</body>
</html>
