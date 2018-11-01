Public Class Form1
    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged

    End Sub

    Private Sub btnGetCustomers_Click(sender As Object, e As EventArgs) Handles btnGetCustomers.Click
        Dim dsNorthwind1 As New dsNorthwind
        Dim taCustomers As New dsNorthwindTableAdapters.CustomersTableAdapter
        taCustomers.Fill(dsNorthwind1.Customers)
        For Each nwCustomer As dsNorthwind.CustomersRow In dsNorthwind1.Customers.Rows
            lstCustomers.Items.Add(nwCustomer.CompanyName)
        Next
    End Sub
End Class
