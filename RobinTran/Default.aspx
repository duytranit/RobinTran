<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/_DefaultMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RobinTran.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <asp:Label ID="lblTest" runat="server"></asp:Label>
    <asp:Button ID="btVietname" runat="server" Text="Vietnamese" OnClick="btVietname_Click" />
</asp:Content>
