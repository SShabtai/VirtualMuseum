<%@ Page Title="Art Items" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ItemDetails.aspx.cs" Inherits="VirtualMuseum.ItemDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="itemDetail" runat="server" ItemType="VirtualMuseum.Models.ArtItem" SelectMethod="GetItem" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ItemName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/<%#:Item.ImagePath %>" style="border: solid; height: 300px" alt="<%#:Item.ItemName %>" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left;">
                        <b>Description:</b><br />
                        <%#:Item.Description %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Art Item Number:</b>&nbsp;<%#:Item.ItemID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
