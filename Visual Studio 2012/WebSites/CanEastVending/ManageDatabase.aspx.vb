
Partial Class ManageDatabase
    Inherits System.Web.UI.Page

    'Page under construction. Only Customers relation is available for edits, adding or removing data

    Protected Sub ddlTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTables.SelectedIndexChanged

    End Sub

    Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        fvTableData.ChangeMode(FormViewMode.Edit)
        btnEdit.Enabled = False
    End Sub
End Class
