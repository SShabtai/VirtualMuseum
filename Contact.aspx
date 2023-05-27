<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="VirtualMuseum.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact Page.</h3>
    <address style="font-family: 'Arial Black'; font-size: x-large; text-decoration: underline">
        Carmel Zvulun High-School<br />
        Kibutz Yagur, Israel<br />
        <abbr title="Phone">P:</abbr>
        04-9040065
    </address>

    <address>
        <strong>email:</strong>   <a href="mailto:office@carmelz.org">office@carmelz.org</a><br />
    </address>
</asp:Content>
