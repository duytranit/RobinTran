<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="_Menu.ascx.cs" Inherits="RobinTran.Partials.Admin._Menu" %>
<div id="menu">
    <ul id="nav">
        <li><a href="<%= ResolveUrl("~/Admin/Account") %>">Account</a></li>
        <li id="who" class="activelink"><a href="http://www.free-css.com/">About</a></li>
        <li id="prod"><a href="http://www.free-css.com/">Product</a></li>
        <li>
            <asp:LinkButton ID="btSignOut" runat="server" Text="Sign out" OnClick="btSignOut_Click"></asp:LinkButton>
        </li>
    </ul>
</div>