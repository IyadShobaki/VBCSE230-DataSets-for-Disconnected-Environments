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
        Me.DataSet1 = New System.Data.DataSet()
        Me.Categories = New System.Data.DataTable()
        Me.CategoryID = New System.Data.DataColumn()
        Me.CategoryName = New System.Data.DataColumn()
        Me.Products = New System.Data.DataTable()
        Me.ProductID = New System.Data.DataColumn()
        Me.ProductName = New System.Data.DataColumn()
        Me.CatID = New System.Data.DataColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FillDataSetButton = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Relations.AddRange(New System.Data.DataRelation() {New System.Data.DataRelation("CategoriesProducts", "Categories", "Products", New String() {"CategoryID"}, New String() {"CategoryID"}, False)})
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.Categories, Me.Products})
        '
        'Categories
        '
        Me.Categories.Columns.AddRange(New System.Data.DataColumn() {Me.CategoryID, Me.CategoryName})
        Me.Categories.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"CategoryID"}, True)})
        Me.Categories.PrimaryKey = New System.Data.DataColumn() {Me.CategoryID}
        Me.Categories.TableName = "Categories"
        '
        'CategoryID
        '
        Me.CategoryID.AllowDBNull = False
        Me.CategoryID.AutoIncrement = True
        Me.CategoryID.ColumnName = "CategoryID"
        Me.CategoryID.DataType = GetType(Integer)
        '
        'CategoryName
        '
        Me.CategoryName.AllowDBNull = False
        Me.CategoryName.ColumnName = "CategoryName"
        '
        'Products
        '
        Me.Products.Columns.AddRange(New System.Data.DataColumn() {Me.ProductID, Me.ProductName, Me.CatID})
        Me.Products.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ProductID"}, True), New System.Data.ForeignKeyConstraint("Constraint2", "Categories", New String() {"CategoryID"}, New String() {"CategoryID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)})
        Me.Products.PrimaryKey = New System.Data.DataColumn() {Me.ProductID}
        Me.Products.TableName = "Products"
        '
        'ProductID
        '
        Me.ProductID.AllowDBNull = False
        Me.ProductID.AutoIncrement = True
        Me.ProductID.ColumnName = "ProductID"
        Me.ProductID.DataType = GetType(Integer)
        '
        'ProductName
        '
        Me.ProductName.AllowDBNull = False
        Me.ProductName.ColumnName = "ProductName"
        '
        'CatID
        '
        Me.CatID.AllowDBNull = False
        Me.CatID.ColumnName = "CategoryID"
        Me.CatID.DataType = GetType(Integer)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 192)
        Me.DataGridView1.TabIndex = 0
        '
        'FillDataSetButton
        '
        Me.FillDataSetButton.Location = New System.Drawing.Point(13, 230)
        Me.FillDataSetButton.Name = "FillDataSetButton"
        Me.FillDataSetButton.Size = New System.Drawing.Size(75, 23)
        Me.FillDataSetButton.TabIndex = 1
        Me.FillDataSetButton.Text = "Fill DataSet"
        Me.FillDataSetButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 295)
        Me.Controls.Add(Me.FillDataSetButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Categories As System.Data.DataTable
    Friend WithEvents CategoryID As System.Data.DataColumn
    Friend WithEvents CategoryName As System.Data.DataColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FillDataSetButton As System.Windows.Forms.Button
    Friend WithEvents Products As System.Data.DataTable
    Friend WithEvents ProductID As System.Data.DataColumn
    Friend WithEvents ProductName As System.Data.DataColumn
    Friend WithEvents CatID As System.Data.DataColumn

End Class
