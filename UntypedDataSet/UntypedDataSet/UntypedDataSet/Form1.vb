Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DataSet1.Tables("Categories")
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub FillDataSetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillDataSetButton.Click
        Dim newRow As DataRow = DataSet1.Tables("Categories").NewRow()
        newRow.Item("CategoryName") = "Beverages"
        DataSet1.Tables("Categories").Rows.Add(newRow)

        Dim newRow2 As DataRow = DataSet1.Tables("Categories").NewRow()
        newRow2.Item("CategoryName") = "Condiments"
        DataSet1.Tables("Categories").Rows.Add(newRow2)

        Dim newRow3 As DataRow = DataSet1.Tables("Categories").NewRow()
        newRow3.Item("CategoryName") = "Seafood"
        DataSet1.Tables("Categories").Rows.Add(newRow3)

        Dim newRow4 As DataRow = DataSet1.Tables("Products").NewRow
        newRow4.Item("CategoryID") = 1
        newRow4.Item("ProductName") = "Chai"
        DataSet1.Tables("Products").Rows.Add(newRow4)

        Dim newRow5 As DataRow = DataSet1.Tables("Products").NewRow
        newRow5.Item("CategoryID") = 2
        newRow5.Item("ProductName") = "Aniseed Syrup"
        DataSet1.Tables("Products").Rows.Add(newRow5)

        Dim newRow6 As DataRow = DataSet1.Tables("Products").NewRow
        newRow6.Item("CategoryID") = 3
        newRow6.Item("ProductName") = "Ikura"
        DataSet1.Tables("Products").Rows.Add(newRow6)

        Dim newRow7 As DataRow = DataSet1.Tables("Products").NewRow
        newRow7.Item("CategoryID") = 1
        newRow7.Item("ProductName") = "Chang"
        DataSet1.Tables("Products").Rows.Add(newRow7)

        Dim newRow8 As DataRow = DataSet1.Tables("Products").NewRow
        newRow8.Item("CategoryID") = 2
        newRow8.Item("ProductName") = "Chef Anton's Gumbo Mix"
        DataSet1.Tables("Products").Rows.Add(newRow8)

        Dim newRow9 As DataRow = DataSet1.Tables("Products").NewRow
        newRow9.Item("CategoryID") = 3
        newRow9.Item("ProductName") = "Boston Crab Meat"
        DataSet1.Tables("Products").Rows.Add(newRow9)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'Get the CategoryID of the selected row
        Dim Category As Integer = CInt(DataGridView1.SelectedRows(0).Cells("CategoryID").Value)

        'Get the underlying DataRow that is selected
        Dim rows() As DataRow = DataSet1.Tables("Categories").Select("CategoryID = " & Category)

        'Use the GetChildRows method to the navigate the relationship and return the related records
        Dim ProductList As String = ""
        For Each r As DataRow In rows(0).GetChildRows("CategoriesProducts")
            ProductList += r.Item("ProductName").ToString & Environment.NewLine
        Next

        'Display the products in a message box
        MessageBox.Show(ProductList)
    End Sub
End Class
