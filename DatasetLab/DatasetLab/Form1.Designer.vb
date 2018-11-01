<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.SupplierID = New System.Data.DataColumn()
        Me.CompanyName = New System.Data.DataColumn()
        Me.DataTable2 = New System.Data.DataTable()
        Me.ProductID = New System.Data.DataColumn()
        Me.SupID = New System.Data.DataColumn()
        Me.ProductName = New System.Data.DataColumn()
        Me.UnitPrice = New System.Data.DataColumn()
        Me.UnitsInStock = New System.Data.DataColumn()
        Me.btnFillData = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Location = New System.Drawing.Point(37, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 373)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Relations.AddRange(New System.Data.DataRelation() {New System.Data.DataRelation("SuppliersProducts", "Suppliers", "Products", New String() {"SupplierID"}, New String() {"SupplierID"}, False)})
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.SupplierID, Me.CompanyName})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SupplierID"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.SupplierID}
        Me.DataTable1.TableName = "Suppliers"
        '
        'SupplierID
        '
        Me.SupplierID.AllowDBNull = False
        Me.SupplierID.AutoIncrement = True
        Me.SupplierID.AutoIncrementSeed = CType(1, Long)
        Me.SupplierID.ColumnName = "SupplierID"
        Me.SupplierID.DataType = GetType(Integer)
        '
        'CompanyName
        '
        Me.CompanyName.AllowDBNull = False
        Me.CompanyName.ColumnName = "CompanyName"
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.ProductID, Me.SupID, Me.ProductName, Me.UnitPrice, Me.UnitsInStock})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ProductID"}, True), New System.Data.ForeignKeyConstraint("Constraint2", "Suppliers", New String() {"SupplierID"}, New String() {"SupplierID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.ProductID}
        Me.DataTable2.TableName = "Products"
        '
        'ProductID
        '
        Me.ProductID.AllowDBNull = False
        Me.ProductID.AutoIncrement = True
        Me.ProductID.ColumnName = "ProductID"
        Me.ProductID.DataType = GetType(Integer)
        '
        'SupID
        '
        Me.SupID.AllowDBNull = False
        Me.SupID.ColumnName = "SupplierID"
        Me.SupID.DataType = GetType(Integer)
        '
        'ProductName
        '
        Me.ProductName.AllowDBNull = False
        Me.ProductName.ColumnName = "ProductName"
        '
        'UnitPrice
        '
        Me.UnitPrice.AllowDBNull = False
        Me.UnitPrice.ColumnName = "UnitPrice"
        Me.UnitPrice.DataType = GetType(Decimal)
        Me.UnitPrice.ReadOnly = True
        '
        'UnitsInStock
        '
        Me.UnitsInStock.AllowDBNull = False
        Me.UnitsInStock.ColumnName = "UnitsInStock"
        Me.UnitsInStock.DataType = GetType(Integer)
        '
        'btnFillData
        '
        Me.btnFillData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillData.Location = New System.Drawing.Point(301, 391)
        Me.btnFillData.Name = "btnFillData"
        Me.btnFillData.Size = New System.Drawing.Size(207, 46)
        Me.btnFillData.TabIndex = 1
        Me.btnFillData.Text = "Fill Dataset"
        Me.btnFillData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFillData)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Shobaki-Lab10"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents btnFillData As Button
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents SupplierID As DataColumn
    Friend WithEvents CompanyName As DataColumn
    Friend WithEvents DataTable2 As DataTable
    Friend WithEvents ProductID As DataColumn
    Friend WithEvents SupID As DataColumn
    Friend WithEvents ProductName As DataColumn
    Friend WithEvents UnitPrice As DataColumn
    Friend WithEvents UnitsInStock As DataColumn
End Class
