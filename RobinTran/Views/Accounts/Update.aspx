<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/_AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="RobinTran.Views.Accounts.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Email:
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Password:
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Confirm password:
            </td>
            <td>
                <asp:TextBox ID="txtConfirmation" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div>
        <asp:Button ID="btUpdate" runat="server" Text="Update" OnClick="btUpdate_Click" />
    </div>
</asp:Content>
