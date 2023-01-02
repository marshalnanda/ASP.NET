<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.autocomplete.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.4.1.js" type="text/javascript"></script>
    <script src="Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <%--<link href="Styles/jquery-ui-1.10.3.custom.min.css" rel="stylesheet" type="text/css" />--%>
    <script type="text/javascript" language="javascript">
        $(function () {
            $('#<%= txtStudentName.ClientID %>').autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "StudentService.asmx/GetStudentNames",
                        data: "{ 'searchTerm': '" + request.term + "' }",
                        type: "POST",
                        dataType: "json",
                        contentType: "application/json;charset=utf-8",
                        success: function (data) {
                            response(data.d);
                        },
                        error: function (result) {
                            alert('There is a problem processing your request');
                        }
                    });
                },
                minLength: 0
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
        <asp:TextBox ID="txtStudentName" runat="server">
        </asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button"
            onclick="Button1_Click" />
        <br />
        <asp:GridView ID="gvStudents" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
