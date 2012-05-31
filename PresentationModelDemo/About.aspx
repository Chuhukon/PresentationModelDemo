<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="PresentationModelDemo.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About Us
    </h2>
    <p>
        <asp:Label Text="Naam: " AssociatedControlID="txtName"></asp:Label> <asp:TextBox ID="txtName" runat="server" runat="server"></asp:TextBox><br />
        <asp:Label Text="Bericht: " AssociatedControlID="txtMessage"></asp:Label><br />
        <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" runat="server"></asp:TextBox>
        <asp:Button ID="submit" Text="Send" OnClick="submit_Click" runat="server" />
        <br />
        <br />
        <asp:Repeater ID="Messages" runat="server">
            <ItemTemplate>
                <h3><%# Eval("Name") %></h3>
                <%# Eval("MessageText") %>
            </ItemTemplate>
        </asp:Repeater>
    </p>
</asp:Content>
