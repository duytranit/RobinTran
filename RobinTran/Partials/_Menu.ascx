<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="_Menu.ascx.cs" Inherits="RobinTran.MasterPage._Menu" %>
<div id="menu">
    <ul id="nav">
        <li id="home">
            <a href="<%= ResolveUrl("~/") %>">
                <%= rm.GetString("mnHome") %>
            </a>
        </li>
        <li id="who" class="activelink"><a href="http://www.free-css.com/">About</a></li>
        <li id="prod"><a href="http://www.free-css.com/">Product</a></li>
        <li>
            <asp:LinkButton ID="btSignIn" runat="server"
                data-target="#pnlModal"
                data-toggle="modal" OnClientClick="javascript:return false;"></asp:LinkButton>
        </li>
    </ul>
</div>
