<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controlling  caching through code.aspx.cs" Inherits="WebApplication1.Caching.Controlling__caching_through_code" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
    Server Time : 
    <asp:Label ID="Label1" runat="server" Font-Bold="true" ></asp:Label>
    <br /><br />
    Client Time:
    <b>
        <script type="text/javascript">
            document.write(Date());
        </script>
    </b>
</div>
    </form>
</body>
</html>
