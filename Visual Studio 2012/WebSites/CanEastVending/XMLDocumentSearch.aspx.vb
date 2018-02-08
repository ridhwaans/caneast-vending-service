Imports System.Xml
Imports System.Data

Partial Class XMLDocumentSearch
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'Dim dsMachinesInOperation = New DataSet
            'dsMachinesInOperation.ReadXml(MapPath("MachinesInOperation.xml"))

            'ddlMachineID.DataSource = dsMachinesInOperation
            'ddlMachineID.DataValueField = "MachineID"
            'ddlMachineID.DataTextField = "MachineID"
            'ddlMachineID.DataBind()
        End If
        
    End Sub

    Sub selectMachineID(sender As Object, e As EventArgs)
        ddlCity.SelectedIndex = 0
        txtProductItem.Text = ""
        If ddlMachineID.SelectedValue = "(Show All)" Then
            xmlMachinesInOperationDataSource.XPath = "/MachinesInOperation/ActiveMachine"
        Else
            xmlMachinesInOperationDataSource.XPath = "/MachinesInOperation/ActiveMachine[MachineInfo/MachineID ='" + ddlMachineID.SelectedValue.ToString + "']"
        End If

        printResult()
    End Sub


    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If ddlCity.SelectedValue = "(Show All)" Then
            If (String.IsNullOrEmpty(txtProductItem.Text.Trim)) Then
                xmlMachinesInOperationDataSource.XPath = "/MachinesInOperation/ActiveMachine"
            Else
                xmlMachinesInOperationDataSource.XPath = "/MachinesInOperation/ActiveMachine[Items/Item = '" + txtProductItem.Text + "']"
            End If
        Else
            If (String.IsNullOrEmpty(txtProductItem.Text.Trim)) Then
                xmlMachinesInOperationDataSource.XPath = "/MachinesInOperation/ActiveMachine[MachineInfo/City ='" + ddlCity.SelectedValue.ToString + "']"
            Else
                xmlMachinesInOperationDataSource.XPath = "/MachinesInOperation/ActiveMachine[MachineInfo/City ='" + ddlCity.SelectedValue.ToString + "' and Items/Item = '" + txtProductItem.Text + "']"
            End If
        End If
        printResult()
    End Sub

    Sub printResult()
        lblResults.Text = "XPath performed: " + xmlMachinesInOperationDataSource.XPath.ToString
        MachinesInOperationTreeView.DataBind()

        Select Case (MachinesInOperationTreeView.Nodes.Count)
            Case 0
                lblResults.Text = lblResults.Text + "<br>" + "No active machines found for the given selection. Suggestions: Try searching for a different city location or product item"
            Case Else
                lblResults.Text = lblResults.Text + "<br>" + MachinesInOperationTreeView.Nodes.Count.ToString + " result(s) found for Active Machines in Operation"
        End Select



    End Sub

    Protected Sub ddlCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCity.SelectedIndexChanged
        ddlMachineID.SelectedIndex = 0
    End Sub

    Protected Sub txtProductItem_TextChanged(sender As Object, e As EventArgs) Handles txtProductItem.TextChanged
        ddlMachineID.SelectedIndex = 0
    End Sub
End Class

'Dim reader As XmlReader = XmlReader.Create("MachinesInOperation.xml")
'Dim schemaSet As System.Xml.Schema.XmlSchemaSet = New System.Xml.Schema.XmlSchemaSet()
'Dim schema As System.Xml.Schema.XmlSchemaInference = New System.Xml.Schema.XmlSchemaInference()

'schemaSet = schema.InferSchema(reader)

'For Each s As System.Xml.Schema.XmlSchema In schemaSet.Schemas()
'    s.Write(Console.Out)
'Next

'Dim xmlMachinesInOperationDoc As XmlDocument = New XmlDocument
'xmlMachinesInOperationDoc.Load(Server.MapPath("\MachinesInOperation.xml"))

'Dim docRoot As XmlElement = xmlMachinesInOperationDoc.DocumentElement
'Dim nodeMachineID As XmlNodeList = docRoot.SelectNodes("//ActiveMachine[@*]") 'MachineID =" + ddlMachineID.SelectedValue.ToString + "]") './ActiveMachine/MachineInfo[@City='Toronto'] '//ancestor-or-self::ActiveMachine/MachineInfo[@City='Toronto']
'For Each node In nodeMachineID
'    Response.Write(node.InnerXml)
'Next



'Dim nodeMachineID As XmlNodeList = docRoot.SelectNodes("ancestor-or-self::/ActiveMachine[@MachineID=" + txtMachineID.Text + "]")
'Dim nodeMachineID As XmlNodeList = docRoot.SelectNodes("/MachinesInOperation/ActiveMachine[Items/Item='" & txtMachineID.Text & "']") './ActiveMachine/MachineInfo[City='Toronto']
'lblOutput.Text = "ancestor-or-self::ActiveMachine[@MachineID=" + txtMachineID.Text + "]"

'xmlMachinesInOperationDataSource.XPath = "//ActiveMachine[@MachineID =" + ddlMachineID.SelectedValue.ToString + "]"
'Response.

'xmlMachinesInOperation.Visible = False
'xmlFilteredMachinesInOperation.DocumentSource = xmlMachinesInOperationDataSource.ToString
'xmlFilteredMachinesInOperation.DataBind()

'Response.Write(nodeMachineID.OuterXml)

'Dim nodeMachineID As XmlNode = docRoot.SelectSingleNode("./ActiveMachine[@MachineID=" + txtMachineID.Text + "]")
'Dim nodeListLocation As XmlNodeList = docRoot.SelectNodes("./ActiveMachine/MachineInfo[@City='Oshawa']")

'For Each node In nodeListLocation
'Response.Write(node.InnerXml)
'Next
'Response.Write(nodeMachineID.OuterXml)

'Dim xmlMachinesInOperationSearchResult As XmlDocument = New XmlDocument
'xmlMachinesInOperationSearchResult.DocumentElement.AppendChild(docRoot)
'For Each node As System.Xml.XmlNode In nodeListLocation
'    xmlMachinesInOperationSearchResult.DocumentElement.AppendChild(xmlMachinesInOperationSearchResult.ImportNode(node, True))
'Next
'xmlMachinesInOperationSearchResult.LoadXml(nodeMachineID.OuterXml)
'xmlMachinesInOperationSearchResult.Save("xmlMachinesInOperationSearchResult.xml")

'Dim xsltMachinesInOperationSearchResult As Xsl.XslCompiledTransform = New Xsl.XslCompiledTransform
'xsltMachinesInOperationSearchResult.Load(Server.MapPath("\MachinesInOperation.xslt"))
'xsltMachinesInOperationSearchResult.Transform("xmlMachinesInOperationSearchResult.xml", "books.html")

'Dim root As XmlElement = DirectCast(xmlMachinesInOperationDoc.AppendChild(xmlMachinesInOperationDoc.CreateElement("root")), XmlElement)
'For Each child As XmlElement In nodeListLocation
'    root.AppendChild(xmlMachinesInOperationDoc.ImportNode(child, True))
'Next
'Response.Write(root.InnerXml)


