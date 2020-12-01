<%@ Page Title="Person" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="Homework12.Person" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:GridView ID="PersonGridView" runat="server"></asp:GridView>
</asp:Content>
