
Partial Class CanEastVendingView
    Inherits System.Web.UI.Page

    Protected Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Response.Redirect("CanEastVendingViews.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Request.QueryString("lblView") <> Nothing Then
            lblView.Text = Request.QueryString("lblView")
        End If

        dsView.SelectCommand = "SELECT * FROM " + lblView.Text

        gvView.DataSource = dsView
        gvView.DataBind()

        Select Case lblView.Text
            Case "ActiveMachinesInOperation"
                lblView.Text = "Active Machines In Operation"
                lblViewDescription.Text = "Lists machine and customer information about all the CanEastVending machines in operation and being rented by customers in various locations across the provinces"
            Case "CustRentals"
                lblView.Text = "Customer Rentals"
                lblViewDescription.Text = "Shows name and ID information of all Canadian custoemrs who have a rental contract for a vending machine"
            Case "EmployeesDeliveredPepsi"
                lblView.Text = "Employees Delivered Pepsi"
                lblViewDescription.Text = "This view shows CanEastVending employees who carry out orders for delivering and restocking Pepsi soft drink products"
            Case "EmployeesWhoHaveDeliveredInOshawa"
                lblView.Text = "Oshawa Delivery Employees"
                lblViewDescription.Text = "This view shows information about CanEastEmployees employees responsible for restock orders and deliveries to customers and vending machine locations in the Oshawa area"
            Case "HighCapacityMachinesInStorage"
                lblView.Text = "High Capacity Machines In Storage"
                lblViewDescription.Text = "This view lists information about active CanEastVending machines which are currently holding a large capacity of available products (more than 50 items)"
            Case "LessThanAverageDrinkPrice"
                lblView.Text = "Less Than Average Drink Prices"
                lblViewDescription.Text = "Displays product information about all food and drinks products whose selling price is less than the average drink product price"
            Case "LowInventoryMachines"
                lblView.Text = "Low Inventory Machines"
                lblViewDescription.Text = "This view lists all the customer vending machines in operation which are running low on their products inventory (less than half) and need to be restocked soon"
            Case "RemainingProductQuantity"
                lblView.Text = "Remaining Product Quantities"
                lblViewDescription.Text = "This view returns the number of units remaining of each food & drink product item on sale"
            Case "RentedMachineLocations"
                lblView.Text = "Rented Machine Locations"
                lblViewDescription.Text = "This view contains ID information and geographic locations of each of the vending machines being rented"
            Case "TorontoOttawaRentedMachines"
                lblView.Text = "Machines Rented in Toronto & Oshawa"
                lblViewDescription.Text = "Shows the list of CanEastVending machines rented in the Toronto and Oshawa areas"
            Case Else
                lblView.Text = "No view selected"
                lblViewDescription.Text = ""
        End Select


        

    End Sub
End Class
