
Partial Class Home
    Inherits System.Web.UI.Page

    Protected Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Response.Redirect("CanEastVendingView.aspx?lblView=" + ddlDBViewList.SelectedItem.Value)
    End Sub
End Class
