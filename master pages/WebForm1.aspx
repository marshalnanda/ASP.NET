<%@ Page Title="" Language="C#" MasterPageFile="~/master pages/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.master_pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <b>Type the text in the textbox that you want to display 
in Master Page TextBox and click Set Text Button</b>
<asp:TextBox ID="TextBox1" runat="server">
</asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Set Text" 
onclick="Button1_Click" />
</asp:Content>
