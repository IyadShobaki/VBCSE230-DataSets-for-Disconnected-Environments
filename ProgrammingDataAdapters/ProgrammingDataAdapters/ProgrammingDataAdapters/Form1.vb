Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private NorthWindConnection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True")
    Private SqlDataAdapter1 As New SqlDataAdapter("SELECT * FROM Customers", NorthWindConnection)
    Private NorthWindDataSet As New DataSet("NorthWind")
    Private CustomersTable As New DataTable("Customers")

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NorthWindDataSet.Tables.Add(CustomersTable)

        SqlDataAdapter1.Fill(NorthWindDataSet.Tables("Customers"))

        DataGridView1.DataSource = NorthWindDataSet.Tables("Customers")

        Dim commands As New SqlCommandBuilder(SqlDataAdapter1)

    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        NorthWindDataSet.EndInit()
        SqlDataAdapter1.Update(NorthWindDataSet.Tables("Customers"))
    End Sub
End Class
