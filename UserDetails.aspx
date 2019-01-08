<%@ Page Title="Professional Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="UserDetails.aspx.cs" Inherits="SystemKnowledgeWebForms.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="SystemKnowledgeWebForms.Models.User" SelectMethod ="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.FirstName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                  
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                         <span><b>Last name:</b><br /><%#:Item.LastName %> </span>
                        <br />
                        <span><b>Email:</b>&nbsp;<%#: Item.Email %></span>
                        <br />
                        <span><b>Technologies:</b>&nbsp;<%#: Item.MyString(Item.AreasOfKnowledges) %></span>
                        <br />
                        <span><b>City:</b>&nbsp;<%#: Item.City %></span>
                        <br />
                        <span><b>User Number:</b>&nbsp;<%#:Item.UserID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>