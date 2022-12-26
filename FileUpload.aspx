<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="WebApplication1.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            &nbsp;
            <asp:Button ID="btnUpload" runat="server" Text="Upload File"
                OnClick="btnUpload_Click" />
            <br />
            <asp:Label ID="lblMessage" Font-Bold="true" runat="server">
            </asp:Label>
        </div>

    </form>
</body>
</html>
