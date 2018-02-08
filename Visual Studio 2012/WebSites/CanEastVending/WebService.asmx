<%@ WebService Language="VB" Class="CanEastVendingWebServices"%>

Imports System
Imports System.Web.Services
Imports System.Data
Imports System.Data.SqlClient

'Three different functions for the three different web services. After the button click is invoked, the user input is checked for invalid input and parsed, error handling and validation is performed, and the output variable is returned
Public Class CanEastVendingWebServices : Inherits WebService
    <WebMethod(Description:="Gets an input start date of a vending machine or customer contract and calculates the difference between the date and today's date to find since how long the contract was active.")>
    Public Function findTimeSpan(ByVal input As String) As String
        Dim strOutput As String
        Dim inputDate As Date = New Date
        Dim format() = {"dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy"}
        
        If IsDate(input) Then
            inputDate = Date.ParseExact(input, format,
                System.Globalization.DateTimeFormatInfo.InvariantInfo,
                Globalization.DateTimeStyles.None)
            Dim span As TimeSpan = Date.Today - inputDate
            If (CInt(span.TotalDays.ToString) >= 0) Then
                strOutput = "Active for " + span.TotalDays.ToString + " Days"
            Else
                strOutput = (span.TotalDays * -1).ToString + " days in the future (invalid specified date)"
            End If
        Else
            strOutput = "Invalid date format. Valid formats: dd/MM/yyyy, d/M/yyyy,dd-MM-yyyy"
        End If
         
        Return strOutput
    End Function
    
    <WebMethod(Description:="Outputs a datatable containing vending machine inventory information based on a MachineID input")>
    Public Function viewCurrentInventory(ByVal strMachineID As String) As DataSet
        Using connection As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\100425724\Documents\Visual Studio 2012\Projects\CanEastVending\CanEastVending\Database.mdf"";Integrated Security=True;Connect Timeout=30")
            Dim command As New SqlCommand("SELECT M.ProductID, P.ProductName, M.Quantity FROM MachineInventory AS M, Product AS P WHERE M.ProductID = P.ProductID AND M.MachineID = " + strMachineID, connection)
            Try
                connection.Open()
            Catch exp As SqlException
                Throw New InvalidOperationException("Connection failed. Operation could not be completed", exp)
            End Try
            
            Dim adapter As New SqlDataAdapter
            adapter.SelectCommand = command
            
            'Dim table As New DataTable
            'adapter.Fill(table)
            
            Dim dsInventory As DataSet = New DataSet()
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
            adapter.Fill(dsInventory, "MachineInventory")
            
            connection.Close()
            Return dsInventory
        End Using
    End Function
    
    <WebMethod(Description:="Returns the status and date when the order was shipped given an OrderID")>
    Public Function checkDateShipped(ByVal strOrderID As String) As String
        
        If (String.IsNullOrEmpty(Trim(strOrderID)) = True) Then
            Return "Invalid OrderID. OrderIDs are 5-digit numbers that start with 5"
        ElseIf (IsNumeric(strOrderID)) Then
            Dim strShippedDate As String = ""
            Using connection As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\100425724\Documents\Visual Studio 2012\Projects\CanEastVending\CanEastVending\Database.mdf"";Integrated Security=True;Connect Timeout=30")
                Dim command As New SqlCommand("SELECT ShippedDate FROM Orders WHERE OrderID = " + strOrderID, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        strShippedDate = "Order " + Convert.ToString(strOrderID) + " shipped on " + Convert.ToString(reader(0))
                    End While
                    reader.Close()
                Catch exp As SqlException
                    Throw New InvalidOperationException("Connection failed. Operation could not be completed", exp)
                Finally
                    connection.Close()
                End Try
            End Using
            If String.IsNullOrEmpty(strShippedDate) = True Then
                strShippedDate = "Order " + Convert.ToString(strOrderID) + " not found. OrderIDs are 5-digit numbers that start with 5"
            End If
            Return strShippedDate
        Else
            Return "Invalid OrderID. OrderIDs are 5-digit numbers that start with 5"
        End If
    End Function
End Class