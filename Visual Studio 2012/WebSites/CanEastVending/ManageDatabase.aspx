<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ManageDatabase.aspx.vb" Inherits="ManageDatabase" %>

<%--Page under construction. Only Customers relation is available for edits, adding or removing data--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style16
        {
            font-size: large;
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style16"><strong>Manage Database</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>View and edit CanEastVending table data</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlTables" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="Customer">Customers</asp:ListItem>
                    <asp:ListItem Value="Employee">Employees</asp:ListItem>
                    <asp:ListItem Value="Location">Locations</asp:ListItem>
                    <asp:ListItem Value="Machine">Machines</asp:ListItem>
                    <asp:ListItem Value="MachineInventory">MachineInventories</asp:ListItem>
                    <asp:ListItem>Orders</asp:ListItem>
                    <asp:ListItem Value="Product">Products</asp:ListItem>
                    <asp:ListItem>Rentals</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label1" runat="server" Text="Page under construction. Only Customers relation is available for edits, adding or removing data"></asp:Label>
                <br />
                <asp:SqlDataSource ID="dsTable" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" DeleteCommand="DELETE FROM [Customer] WHERE [CustomerID] = @CustomerID" InsertCommand="INSERT INTO [Customer] ([CustomerID], [CompanyName], [FirstName], [LastName], [Email], [Address], [City], [Province], [PostalCode], [PhoneNumber], [FaxNumber]) VALUES (@CustomerID, @CompanyName, @FirstName, @LastName, @Email, @Address, @City, @Province, @PostalCode, @PhoneNumber, @FaxNumber)" SelectCommand="SELECT * FROM [Customer]" UpdateCommand="UPDATE [Customer] SET [CompanyName] = @CompanyName, [FirstName] = @FirstName, [LastName] = @LastName, [Email] = @Email, [Address] = @Address, [City] = @City, [Province] = @Province, [PostalCode] = @PostalCode, [PhoneNumber] = @PhoneNumber, [FaxNumber] = @FaxNumber WHERE [CustomerID] = @CustomerID">
                    <DeleteParameters>
                        <asp:Parameter Name="CustomerID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="CustomerID" Type="Int32" />
                        <asp:Parameter Name="CompanyName" Type="String" />
                        <asp:Parameter Name="FirstName" Type="String" />
                        <asp:Parameter Name="LastName" Type="String" />
                        <asp:Parameter Name="Email" Type="String" />
                        <asp:Parameter Name="Address" Type="String" />
                        <asp:Parameter Name="City" Type="String" />
                        <asp:Parameter Name="Province" Type="String" />
                        <asp:Parameter Name="PostalCode" Type="String" />
                        <asp:Parameter Name="PhoneNumber" Type="String" />
                        <asp:Parameter Name="FaxNumber" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="CompanyName" Type="String" />
                        <asp:Parameter Name="FirstName" Type="String" />
                        <asp:Parameter Name="LastName" Type="String" />
                        <asp:Parameter Name="Email" Type="String" />
                        <asp:Parameter Name="Address" Type="String" />
                        <asp:Parameter Name="City" Type="String" />
                        <asp:Parameter Name="Province" Type="String" />
                        <asp:Parameter Name="PostalCode" Type="String" />
                        <asp:Parameter Name="PhoneNumber" Type="String" />
                        <asp:Parameter Name="FaxNumber" Type="String" />
                        <asp:Parameter Name="CustomerID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:FormView ID="fvTableData" runat="server" AllowPaging="True" DataKeyNames="CustomerID" DataSourceID="dsTable">
                    <EditItemTemplate>
                        CustomerID:
                        <asp:Label ID="CustomerIDLabel1" runat="server" Text='<%# Eval("CustomerID") %>' />
                        <br />
                        CompanyName:
                        <asp:TextBox ID="CompanyNameTextBox" runat="server" Text='<%# Bind("CompanyName") %>' />
                        <br />
                        FirstName:
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                        <br />
                        LastName:
                        <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                        <br />
                        Email:
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                        <br />
                        Address:
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                        <br />
                        City:
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                        <br />
                        Province:
                        <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                        <br />
                        PostalCode:
                        <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' />
                        <br />
                        PhoneNumber:
                        <asp:TextBox ID="PhoneNumberTextBox" runat="server" Text='<%# Bind("PhoneNumber") %>' />
                        <br />
                        FaxNumber:
                        <asp:TextBox ID="FaxNumberTextBox" runat="server" Text='<%# Bind("FaxNumber") %>' />
                        <br />
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        CustomerID:
                        <asp:TextBox ID="CustomerIDTextBox" runat="server" Text='<%# Bind("CustomerID") %>' />
                        <br />
                        CompanyName:
                        <asp:TextBox ID="CompanyNameTextBox" runat="server" Text='<%# Bind("CompanyName") %>' />
                        <br />
                        FirstName:
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                        <br />
                        LastName:
                        <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                        <br />
                        Email:
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                        <br />
                        Address:
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                        <br />
                        City:
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                        <br />
                        Province:
                        <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                        <br />
                        PostalCode:
                        <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' />
                        <br />
                        PhoneNumber:
                        <asp:TextBox ID="PhoneNumberTextBox" runat="server" Text='<%# Bind("PhoneNumber") %>' />
                        <br />
                        FaxNumber:
                        <asp:TextBox ID="FaxNumberTextBox" runat="server" Text='<%# Bind("FaxNumber") %>' />
                        <br />
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>CustomerID</td><td><asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' /></td>
                            </tr>
                            <tr>
                                <td>CompanyName</td><td><asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Bind("CompanyName")%>' /></td>
                            </tr>
                            <tr>
                                <td>FirstName</td><td><asp:Label ID="FirstNameLabel" runat="server" Text='<%# Bind("FirstName")%>' /></td>
                            </tr>
                            <tr>
                                <td>LastName</td><td><asp:Label ID="LastNameLabel" runat="server" Text='<%# Bind("LastName")%>' /></td>
                            </tr>
                            <tr>
                                <td>Email</td><td><asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email")%>' /></td>
                            </tr>
                            <tr>
                                <td>Address</td><td><asp:Label ID="AddressLabel" runat="server" Text='<%# Bind("Address")%>' /></td>
                            </tr>
                            <tr>
                                <td>City</td><td><asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City")%>' /></td>
                            </tr>
                            <tr>
                                <td>Province</td><td><asp:Label ID="ProvinceLabel" runat="server" Text='<%# Bind("Province")%>' /></td>
                            </tr>
                            <tr>
                                <td>PostalCode</td><td><asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Bind("PostalCode")%>' /></td>
                            </tr>
                            <tr>
                                <td>PhoneNumber</td><td><asp:Label ID="PhoneNumberLabel" runat="server" Text='<%# Bind("PhoneNumber")%>' /></td>
                            </tr>
                            <tr>
                                <td>FaxNumber</td><td><asp:Label ID="FaxNumberLabel" runat="server" Text='<%# Bind("FaxNumber")%>' /></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:FormView>
                <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

