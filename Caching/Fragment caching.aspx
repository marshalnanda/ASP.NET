<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fragment caching.aspx.cs" Inherits="WebApplication1.Caching.Fragment_caching" %>

<%@ Register src="UCProductsControl.ascx" tagname="UCProductsControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
    <table style="border: 1px solid black">
        <tr>
            <td>
                Page content that changes
            </td>
        </tr>
        <tr>
            <td>
                <b>Page Server Time:
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </b>
            </td>
        </tr>
        <tr>
            <td>
                <b>Page Client Time:
                    <script type="text/javascript">
                        document.write(Date());
                    </script>
                </b>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:UCProductsControl ID="UCProductsControl1" runat="server" />  
                <br /><br />
            </td>
        </tr>
    </table>
</div>
    </form>
</body>
</html>
