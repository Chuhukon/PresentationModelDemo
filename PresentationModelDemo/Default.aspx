<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PresentationModelDemo._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        <h2><%= this.Model.DisplayTitle ? this.Model.Content.Title : string.Empty %></h2>
    </h2>
    <p>
        <%= this.Model.Content.ContentText %>
    </p>
    <p>
        <a href="<%= Model.Content.Link %>"><%= Model.Content.Link %></a>
    </p>
</asp:Content>
