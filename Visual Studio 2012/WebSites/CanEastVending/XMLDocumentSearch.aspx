<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="XMLDocumentSearch.aspx.vb" Inherits="XMLDocumentSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style16
        {
            font-size: large;
            height: 24px;
        }
        .auto-style17
        {
            height: 24px;
        }
        .auto-style20
        {
            width: 317px;
        }
        .auto-style21
        {
            height: 10px;
            background-color: lightgray;
            font-size: x-large;
        }
        .auto-style22
        {
            height: 10px;
            background-color: lightgray;
            font-size: x-large;
        }
        .auto-style23
        {
            height: 10px;
            background-color: lightgray;
            width: 89px;
            font-size: large;
        }
        .auto-style25
        {
            height: 10px;
            background-color: lightgray;
            font-size: x-large;
        }
        .auto-style26
        {
            width: 317px;
            height: 23px;
        }
        .auto-style27
        {
            height: 23px;
        }
        .auto-style28
        {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" style="height: 243px">
        <tr>
            <td class="auto-style16" colspan="3"><strong style="text-decoration: underline; color: #990000;">XML Document Search</strong></td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style16" colspan="3">
                <p><a href="MachinesInOperation.xml" target="_blank">View XML file</a></p>
                <p><a href="MachinesInOperation.xsd" target="_blank">View XSD file</a></p>
                <p><a href="MachinesInOperation.xslt" target="_blank">View XSLT file</a></p>
            </td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="2">
                <asp:Label ID="lblTitle" runat="server" Text="Search for Active Machines In Operation" style="font-size: medium; font-weight: 700"></asp:Label>
            </td>
            <td class="auto-style25" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="lblMachineID" runat="server" style="font-size: medium" Text="MachineID:"></asp:Label>
            </td>
            <td class="auto-style22">
                <asp:DropDownList runat="server" id="ddlMachineID" AutoPostBack="True"
                              OnSelectedIndexChanged="selectMachineID">   
              <asp:ListItem Selected="True">(Show All)</asp:ListItem>                           
              <asp:ListItem>40001</asp:ListItem>
              <asp:ListItem>40002</asp:ListItem>
              <asp:ListItem>40004</asp:ListItem>
              <asp:ListItem>40005</asp:ListItem>
              <asp:ListItem>40007</asp:ListItem>
              <asp:ListItem>40009</asp:ListItem>
              <asp:ListItem>40010</asp:ListItem>
              <asp:ListItem>40011</asp:ListItem>
              <asp:ListItem>40012</asp:ListItem>
            </asp:DropDownList>
            </td>
            <td class="auto-style25" colspan="2">
            </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style28"><strong>OR</strong></span>&nbsp;</td>
            <td class="auto-style25" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="lblCity" runat="server" style="font-size: medium" Text="City Location:"></asp:Label>
            </td>
            <td class="auto-style22">
                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True">(Show All)</asp:ListItem>      
                    <asp:ListItem>Amherstburg</asp:ListItem>
                    <asp:ListItem>Kitchener</asp:ListItem>
                    <asp:ListItem>London</asp:ListItem>
                    <asp:ListItem>Montreal</asp:ListItem>
                    <asp:ListItem>Oshawa</asp:ListItem>
                    <asp:ListItem>Ottawa</asp:ListItem>
                    <asp:ListItem>Toronto</asp:ListItem>
                    <asp:ListItem>Windsor</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style25" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:Label ID="lblProduct" runat="server" style="font-size: medium" Text="Product Item:"></asp:Label>
            </td>
            <td class="auto-style22" colspan="3">
                <asp:TextBox ID="txtProductItem" runat="server" AutoPostBack="true"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="auto-style22" colspan="4">
                <asp:Button ID="btnSearch" runat="server" Text="Search" />
                <asp:Label ID="lblResults" runat="server" style="font-size: medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style22" colspan="4">
                <asp:XmlDataSource ID="xmlMachinesInOperationDataSource" runat="server" DataFile="~/MachinesInOperation.xml" XPath="/MachinesInOperation/ActiveMachine"></asp:XmlDataSource>
            </td>
        </tr>
        <tr>

        <td class="auto-style20" colspan="3">
          <asp:TreeView
            id="MachinesInOperationTreeView"
            runat="server"
            DataSourceID="xmlMachinesInOperationDataSource">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="CustomerID"    TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="CustomerName"   TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="MachineID"      TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="ModelName"        TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="Address"      TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="City"     TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="PostalCode"       TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="ContractStartDate" TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="ContractStartDate" TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="NextRestock" TextField="#InnerText" />
                <asp:TreeNodeBinding DataMember="Item" TextField="#InnerText" />
            </DataBindings>
            </asp:TreeView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26" colspan="3">
            </td>
            <td class="auto-style27"></td>
        </tr>
    </table>
</asp:Content>

