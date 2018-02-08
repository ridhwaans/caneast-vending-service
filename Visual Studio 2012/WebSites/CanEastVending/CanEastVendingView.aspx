<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="CanEastVendingView.aspx.vb" Inherits="CanEastVendingView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style16
        {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style16">
                <asp:Label ID="lblView" runat="server" Text="Label" style="font-weight: 700; font-size: large; text-decoration: underline"></asp:Label>
            </td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblViewDescription" runat="server" Text="View Description"></asp:Label>
                <asp:GridView ID="gvView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnReturn" runat="server" Text="Return to view select" />
                <asp:SqlDataSource ID="dsView" runat="server"
                    ConnectionString ="Data Source=(LocalDB)\v11.0;AttachDbFilename=&quot;C:\Users\100425724\Documents\Visual Studio 2012\WebSites\CanEastVending\Database.mdf&quot;;Integrated Security=True;Connect Timeout=30"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

