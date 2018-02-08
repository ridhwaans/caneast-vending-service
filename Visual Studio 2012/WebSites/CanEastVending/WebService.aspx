
<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    
    Protected Sub btnInvoke_Click(sender As Object, e As EventArgs)
        Dim myCanEastVendingWebServices As CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient = New CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient
        lblTimeSpanResult.Text = myCanEastVendingWebServices.findTimeSpan(txtInputStartDate.Text)
    End Sub

    Protected Sub btnInvokeTwo_Click(sender As Object, e As EventArgs)
        Dim myCanEastVendingWebServices As CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient = New CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient
        gvMachineInventory.DataSource = myCanEastVendingWebServices.viewCurrentInventory(ddlMachineIDs.SelectedItem.Value.ToString).Tables(0)
        gvMachineInventory.DataBind()
        'lbltest.Text = myCanEastVendingWebServices.viewCurrentInventory(ddlMachineIDs.SelectedItem.Value.ToString)
    End Sub

    Protected Sub btnInvokeThree_Click(sender As Object, e As EventArgs)
        Dim myCanEastVendingWebServices As CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient = New CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient
        lblDateShipped.Text = myCanEastVendingWebServices.checkDateShipped(txtOrderID.Text)
    End Sub

    Protected Sub ddlMachineIDs_SelectedIndexChanged(sender As Object, e As EventArgs)
        
    End Sub
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style18
        {
            height: 26px;
        }
        .auto-style19
        {
            height: 23px;
        }
        .auto-style20
        {
        }
        .auto-style21
        {
            height: 26px;
            width: 306px;
        }
        .auto-style22
        {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style20">
                <asp:Label ID="lblWebService" runat="server" style="font-size: x-large; font-weight: 700; text-decoration: underline; color: #CC0000;" Text="Web Services" Font-Size="X-Large" ForeColor="#0099FF"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style19" colspan="2">
                <strong>Find Time Span: </strong>Gets an input start date of a vending machine or customer contract and calculates the difference between the date and today&#39;s date to find since how long the contract was active.</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="lblInputContractStartDate" runat="server" Text="Machine contract start date"></asp:Label>
                <asp:TextBox ID="txtInputStartDate" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style18">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Button ID="btnInvokeOne" runat="server" OnClick="btnInvoke_Click" Text="Invoke" />
                <asp:Label ID="lblTimeSpanResult" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20" colspan="2">
                <strong>View Current Inventory: </strong>Outputs a datatable containing vending machine inventory information based on a MachineID input</td>
        </tr>
        <tr>
            <td class="auto-style19">
                <asp:Label ID="lblInputMachineID" runat="server" Text="Choose MachineID"></asp:Label>
                <asp:DropDownList ID="ddlMachineIDs" runat="server" DataSourceID="SqlDataSource1" DataTextField="MachineID" DataValueField="MachineID" OnSelectedIndexChanged="ddlMachineIDs_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT [MachineID] FROM [Machine]"></asp:SqlDataSource>
            </td>
            <td class="auto-style19">
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Button ID="btnInvokeTwo" runat="server" OnClick="btnInvokeTwo_Click" Text="Invoke" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:GridView ID="gvMachineInventory" runat="server">
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                <strong>Check Date Shipped: </strong>Returns the status and date when the order was shipped given an OrderID</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">
                <asp:Label ID="lblInputOrderID" runat="server" Text="Input OrderID"></asp:Label>
                <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style22">
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Button ID="btnInvokeThree" runat="server" OnClick="btnInvokeThree_Click" Text="Invoke" />
                <asp:Label ID="lblDateShipped" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Image ID="Image1" runat="server" Height="208px" ImageAlign="Middle" ImageUrl="~/images/vending_machine_line.PNG" Width="882px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

