<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/_DefaultMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RobinTran.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <asp:Button ID="btnShowModal" runat="server" Text="Show Modal" CssClass="btn btn-primary btn-info" data-target="#pnlModal"
        data-toggle="modal" OnClientClick="javascript:return false;" />
</asp:Content>
