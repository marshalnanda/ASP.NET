<%@ Page Title="" Language="C#" MasterPageFile="~/master pages/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.master_pages.WebForm2" %>
<%@ MasterType VirtualPath="Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server">
</asp:GridView>
</asp:Content>
