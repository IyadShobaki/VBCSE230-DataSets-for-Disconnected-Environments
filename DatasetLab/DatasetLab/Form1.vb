Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DataSet1.Tables("Products")
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub btnFillData_Click(sender As Object, e As EventArgs) Handles btnFillData.Click
        Dim newrow As DataRow = DataSet1.Tables("Suppliers").NewRow()
        newrow.Item("CompanyName") = "Exotic Liquids"
        DataSet1.Tables("Suppliers").Rows.Add(newrow)

        Dim newrow2 As DataRow = DataSet1.Tables("Suppliers").NewRow()
        newrow2.Item("CompanyName") = "New Orleans Cajun Delights"
        DataSet1.Tables("Suppliers").Rows.Add(newrow2)

        Dim newrow3 As DataRow = DataSet1.Tables("Suppliers").NewRow()
        newrow3.Item("CompanyName") = "Grandma Kelly's Homestead"
        DataSet1.Tables("Suppliers").Rows.Add(newrow3)

        Dim newrow4 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow4.Item("SupplierID") = 1
        newrow4.Item("ProductName") = "Chai"
        newrow4.Item("UnitPrice") = 18.0
        newrow4.Item("UnitsInStock") = 39
        DataSet1.Tables("Products").Rows.Add(newrow4)

        Dim newrow5 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow5.Item("SupplierID") = 1
        newrow5.Item("ProductName") = "Aniseed Syrup"
        newrow5.Item("UnitPrice") = 10.0
        newrow5.Item("UnitsInStock") = 13
        DataSet1.Tables("Products").Rows.Add(newrow5)

        Dim newrow6 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow6.Item("SupplierID") = 2
        newrow6.Item("ProductName") = "Chef Anton's Cajun Seasoning"
        newrow6.Item("UnitPrice") = 22.0
        newrow6.Item("UnitsInStock") = 53
        DataSet1.Tables("Products").Rows.Add(newrow6)

        Dim newrow7 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow7.Item("SupplierID") = 3
        newrow7.Item("ProductName") = "Grandma's Boysenberry Spread"
        newrow7.Item("UnitPrice") = 25.0
        newrow7.Item("UnitsInStock") = 120
        DataSet1.Tables("Products").Rows.Add(newrow7)

        Dim newrow8 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow8.Item("SupplierID") = 2
        newrow8.Item("ProductName") = "Chef Anton's Gumbo Mix"
        newrow8.Item("UnitPrice") = 21.35
        newrow8.Item("UnitsInStock") = 0
        DataSet1.Tables("Products").Rows.Add(newrow8)

        Dim newrow9 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow9.Item("SupplierID") = 3
        newrow9.Item("ProductName") = "Northwoods Cranberry Sauce"
        newrow9.Item("UnitPrice") = 40.0
        newrow9.Item("UnitsInStock") = 6
        DataSet1.Tables("Products").Rows.Add(newrow9)

    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim product As Integer = CInt(DataGridView1.SelectedRows(0).Cells("ProductID").Value)
        Dim rows() As DataRow = DataSet1.Tables("Products").Select("ProductID=" & product)
        Dim supplierlist As String = ""
        For Each r As DataRow In rows(0).GetParentRows("SuppliersProducts")
            supplierlist += r.Item("CompanyName").ToString & Environment.NewLine
        Next
        MessageBox.Show(supplierlist)
    End Sub
End Class
