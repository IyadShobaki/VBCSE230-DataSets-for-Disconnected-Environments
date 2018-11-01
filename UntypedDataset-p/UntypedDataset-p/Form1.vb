Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DataSet1.Tables("Categories")
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnfillData_Click(sender As Object, e As EventArgs) Handles btnfillData.Click
        Dim newrow As DataRow = DataSet1.Tables("Categories").NewRow()
        newrow.Item("CategoryName") = "Beverages"
        DataSet1.Tables("Categories").Rows.Add(newrow)
        Dim newrow2 As DataRow = DataSet1.Tables("Categories").NewRow()
        newrow2.Item("CategoryName") = "Condiments"
        DataSet1.Tables("Categories").Rows.Add(newrow2)
        Dim newrow3 As DataRow = DataSet1.Tables("Categories").NewRow()
        newrow3.Item("CategoryName") = "SeaFood"
        DataSet1.Tables("Categories").Rows.Add(newrow3)

        Dim newrow4 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow4.Item("CategoryID") = 1
        newrow4.Item("Productname") = "Chai"
        DataSet1.Tables("Products").Rows.Add(newrow4)

        Dim newrow5 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow5.Item("CategoryID") = 2
        newrow5.Item("Productname") = "Aniseed Syrup"
        DataSet1.Tables("Products").Rows.Add(newrow5)

        Dim newrow6 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow6.Item("CategoryID") = 3
        newrow6.Item("Productname") = "Ikura"
        DataSet1.Tables("Products").Rows.Add(newrow6)

        Dim newrow7 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow7.Item("CategoryID") = 1
        newrow7.Item("Productname") = "Chang"
        DataSet1.Tables("Products").Rows.Add(newrow7)

        Dim newrow8 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow8.Item("CategoryID") = 2
        newrow8.Item("Productname") = "Chef Anton's Gumbo Mix"
        DataSet1.Tables("Products").Rows.Add(newrow8)

        Dim newrow9 As DataRow = DataSet1.Tables("Products").NewRow()
        newrow9.Item("CategoryID") = 3
        newrow9.Item("Productname") = "Boston Crab Meat"
        DataSet1.Tables("Products").Rows.Add(newrow9)

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim category As Integer = CInt(DataGridView1.SelectedRows(0).Cells("Categoryid").Value)
        Dim rows() As DataRow = DataSet1.Tables("Categories").Select("Categoryid=" & category)
        Dim productlist As String = ""
        For Each r As DataRow In rows(0).GetChildRows("categoriesproducts")
            productlist += r.Item("Productname").ToString & Environment.NewLine
        Next
        MessageBox.Show(productlist)
    End Sub
End Class
