<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="CanEastVendingViews.aspx.vb" Inherits="Home" %>

<script runat="server">
    Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        ddlDBViewList.SelectedItem.Value = ddlDBViewList.Text
        If Page.IsPostBack() Then
            
        End If
    End Sub
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

.OuterTableStyle
{
    border: 1px solid #527a67;
    border-collapse:collapse;
    border-spacing: 0px;
    width:790px;
    margin-left:auto;
    margin-right:auto;
}

.OuterTableStyle
{
    border: 1px solid #527a67;
    border-collapse:collapse;
    border-spacing: 0px;
    width:790px;
    margin-left:auto;
    margin-right:auto;
}

        .style1
        {
            width: 100%;
        }
    
.HeaderCell
{
    background-image:url('http://localhost:58639/Homework3/images/Logo.gif');
    background-repeat:no-repeat;
    height:100px;
    width:790px;
    background-position:left;
}

.HeaderCell
{
    background-image:url('images/Logo2.gif');
    background-repeat:no-repeat;
    height:100px;
    width:790px;
    background-position:left;
}

.Separator0
{
    height:1px;
    width:790px;
    background-color:#426a57;
}

.Separator0
{
    height:1px;
    width:790px;
    background-color:#42606a;
}

.Separator1
{
    height:1px;
    width:790px;
    background-color:#afd5c5;
}

.Separator1
{
    height:1px;
    width:790px;
    background-color:#afccd5;
}

.Separator2
{
    height:1px;
    width:790px;
    background-color:#dbe6df;
}

.Separator2
{
    height:1px;
    width:790px;
    background-color:#dbe3e6;
}

.Seperator3
{
    height:2px;
    width:790px;
    background-color:#9dbaa8;
}

.Seperator3
{
    height:2px;
    width:790px;
    background-color:#9db2ba;
}

.EmptyCell
{
    background-color:#769c7e;
    width:120px;
    height:20px;
    margin-left:10px;
    margin-right:10px;
}

.EmptyCell
{
    background-color:#76929c;
    width:120px;
    height:20px;
    margin-left:10px;
    margin-right:10px;
}

.MenuCell
{
    background-color:#769c7e;
    width:100px;
    height:30px;
    margin-left:10px;
    margin-right:10px;
    text-align:center;
    }

.MenuCell
{
    background-color:#76929c;
    width:100px;
    height:30px;
    margin-left:10px;
    margin-right:10px;
    text-align:center;
    }

.Text
{
    text-align:justify;
    font-family:Arial;
    font-size:small;
    padding:20px;
    color:#2c4c40;
    background-image:url('images/BackColorFlipped.gif');
    background-repeat:repeat-x;
    background-position:bottom;
}

.Text
{
    text-align:justify;
    font-family:Arial;
    font-size:small;
    padding:20px;
    color:#2c4c40;
    background-image:url('images/BackColorFlipped2.gif');
    background-repeat:repeat-x;
    background-position:bottom;
}

.Footer
{
    background-color:#769c7e;
    height:25px;
    text-align:center;
    vertical-align:middle;
    color:#ffffff;
    font-family:Arial;
    font-size:10px;
    font-weight:bold;
}
    
.Footer
{
    background-color:#76929c;
    height:25px;
    text-align:center;
    vertical-align:middle;
    color:#ffffff;
    font-family:Arial;
    font-size:10px;
    font-weight:bold;
}
    .auto-style6
    {
        height: 7px;
    }
        .auto-style7
        {
            width: 146px;
        }
        .auto-style16
        {
            width: 176px;
            height: 52px;
            font-size: large;
            text-decoration: underline;
            color: #CC0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="auto-style16">
                <strong>Views</strong></td>
            <td>
                    &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lblSelect" runat="server" Text="Select an item to view:"></asp:Label>
            </td>
            <td>
                    <asp:DropDownList ID="ddlDBViewList" runat="server">
                        <asp:ListItem Value="ActiveMachinesInOperation">Active Machines In Operation</asp:ListItem>
                        <asp:ListItem Value="CustRentals">Customer Rentals</asp:ListItem>
                        <asp:ListItem Value="EmployeesDeliveredPepsi">Employees Delivered Pepsi</asp:ListItem>
                        <asp:ListItem Value="EmployeesWhoHaveDeliveredInOshawa">Oshawa Delivery Employees</asp:ListItem>
                        <asp:ListItem Value="HighCapacityMachinesInStorage">High Capacity Machines In Storage</asp:ListItem>
                        <asp:ListItem Value="LessThanAverageDrinkPrice">Less Than Average Drink Prices</asp:ListItem>
                        <asp:ListItem Value="LowInventoryMachines">Low Inventory Machines</asp:ListItem>
                        <asp:ListItem Value="RemainingProductQuantity">Remaining Product Quantities</asp:ListItem>
                        <asp:ListItem Value="RentedMachineLocations">Rented Machine Locations</asp:ListItem>
                        <asp:ListItem Value="TorontoOttawaRentedMachines">Toronto &amp; Ottawa Rented Machines</asp:ListItem>
                    </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Button ID="btnView" runat="server" Text="View" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Image ID="Image1" runat="server" Height="355px" ImageUrl="~/images/vmachine.jpg" Width="181px" />
            </td>
        </tr>
    </table>
</asp:Content>

