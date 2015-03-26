<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/_AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RobinTran.Views.Accounts.Index" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>

    <telerik:RadGrid ID="RadGridAccountList" runat="server"
        DataSourceID="SqlDataSourceAccounts"
        AllowFilteringByColumn="True" AutoGenerateColumns="False"
        ShowFooter="true"
        OnItemDataBound="RadGridAccountList_ItemDataBound">
        <GroupingSettings CaseSensitive="false" />
        <MasterTableView>
            <Columns>
                <telerik:GridTemplateColumn UniqueName="TemplateColumn" HeaderText="No."
                    AllowFiltering="false" ShowFilterIcon="false">
                    <ItemTemplate>
                        <asp:Label ID="lblSequenceNumber" runat="server"></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                    <HeaderStyle Width="20px" HorizontalAlign="Center" />
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="Email" HeaderText="Email"
                    AllowSorting="true" ShowSortIcon="true"
                    ShowFilterIcon="false" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true"
                    FilterControlWidth="100%">
                    <HeaderStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridCheckBoxColumn DataField="Status" HeaderText="Status"
                    FilterControlAltText="Filter Status column"
                    UniqueName="Status">
                    <FilterTemplate>
                        <telerik:RadComboBox ID="rcbSearchStatus" Height="50px" Width="70px" EnableVirtualScrolling="true"
                            AppendDataBoundItems="true"
                            SelectedValue='<%# ((GridItem)Container).OwnerTableView.GetColumn("Status").CurrentFilterValue %>'
                            runat="server" OnClientSelectedIndexChanged="TitleIndexChanged_MenuStatus">
                            <Items>
                                <telerik:RadComboBoxItem Text="All" />
                                <telerik:RadComboBoxItem Text="Active" Value="True" />
                                <telerik:RadComboBoxItem Text="Disable" Value="False" />
                            </Items>
                        </telerik:RadComboBox>
                        <telerik:RadScriptBlock ID="RadScriptBlockSearchMenuStatus" runat="server">
                            <script type="text/javascript">
                                function TitleIndexChanged_MenuStatus(sender, args) {
                                    var tableView = $find("<%# ((GridItem)Container).OwnerTableView.ClientID %>");
                                    tableView.filter("Status", args.get_item().get_value(), "EqualTo");
                                        }
                            </script>
                        </telerik:RadScriptBlock>
                    </FilterTemplate>
                    <ItemStyle HorizontalAlign="Center"/>
                    <HeaderStyle HorizontalAlign="Center" Width="70px"/>
                </telerik:GridCheckBoxColumn>
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
    <asp:SqlDataSource ID="SqlDataSourceAccounts" runat="server"
        ConnectionString="<%$ ConnectionStrings:RobinTranConnectionString %>"
        SelectCommand="SELECT * FROM [Account]"></asp:SqlDataSource>
</asp:Content>
