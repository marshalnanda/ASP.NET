<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompareValidator.aspx.cs" Inherits="WebApplication1.ValidationControl.CompareValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <b>Password</b>
                </td>
                <td>:<asp:TextBox ID="txtPassword" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Retype Password</strong></td>
                <td>:<asp:TextBox ID="txtRetypePassword" runat="server"
                    Width="150px" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                        ErrorMessage="Password and Retype Password must match"
                        ControlToValidate="txtRetypePassword" ControlToCompare="txtPassword"
                        Type="String" Operator="Equal" ForeColor="Red">
                    </asp:CompareValidator>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:TextBox ID="txtDateofapplication" runat="server" Width="150px">
        </asp:TextBox>
        <asp:CompareValidator ID="CompareValidatorDateofbirth" runat="server"
            ErrorMessage="Date of application must be greater than 01/01/2012"
            ControlToValidate="txtDateofapplication" ValueToCompare="01/01/2012"
            Type="Date" Operator="GreaterThan" ForeColor="Red"
            SetFocusOnError="true"></asp:CompareValidator>
        <br />
        <br />
        <asp:TextBox ID="txtAge" runat="server" Width="150px"></asp:TextBox>

        <asp:CompareValidator ID="CompareValidatorAge" runat="server"
            ErrorMessage="Age must be a number" ControlToValidate="txtAge"
            Operator="DataTypeCheck" Type="Integer" ForeColor="Red"
            SetFocusOnError="true"></asp:CompareValidator>
    </form>
</body>
</html>
