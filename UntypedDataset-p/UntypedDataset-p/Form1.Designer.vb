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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataTable1 = New System.Data.DataTable()
        Me.categoryid = New System.Data.DataColumn()
        Me.categoryname = New System.Data.DataColumn()
        Me.btnfillData = New System.Windows.Forms.Button()
        Me.DataTable2 = New System.Data.DataTable()
        Me.productid = New System.Data.DataColumn()
        Me.ProductName = New System.Data.DataColumn()
        Me.catid = New System.Data.DataColumn()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Relations.AddRange(New System.Data.DataRelation() {New System.Data.DataRelation("categoriesProducts", "categories", "Products", New String() {"categoryid"}, New String() {"CategoryID"}, False)})
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(61, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(582, 330)
        Me.DataGridView1.TabIndex = 0
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.categoryid, Me.categoryname})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"categoryid"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.categoryid}
        Me.DataTable1.TableName = "categories"
        '
        'categoryid
        '
        Me.categoryid.AllowDBNull = False
        Me.categoryid.AutoIncrement = True
        Me.categoryid.ColumnName = "categoryid"
        Me.categoryid.DataType = GetType(Integer)
        '
        'categoryname
        '
        Me.categoryname.AllowDBNull = False
        Me.categoryname.ColumnName = "categoryname"
        '
        'btnfillData
        '
        Me.btnfillData.Location = New System.Drawing.Point(440, 348)
        Me.btnfillData.Name = "btnfillData"
        Me.btnfillData.Size = New System.Drawing.Size(203, 44)
        Me.btnfillData.TabIndex = 1
        Me.btnfillData.Text = "Fill Dataset"
        Me.btnfillData.UseVisualStyleBackColor = True
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.productid, Me.ProductName, Me.catid})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"productid"}, True), New System.Data.ForeignKeyConstraint("Constraint2", "categories", New String() {"categoryid"}, New String() {"CategoryID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.productid}
        Me.DataTable2.TableName = "Products"
        '
        'productid
        '
        Me.productid.AllowDBNull = False
        Me.productid.AutoIncrement = True
        Me.productid.ColumnName = "productid"
        Me.productid.DataType = GetType(Integer)
        '
        'ProductName
        '
        Me.ProductName.AllowDBNull = False
        Me.ProductName.ColumnName = "ProductName"
        '
        'catid
        '
        Me.catid.AllowDBNull = False
        Me.catid.ColumnName = "CategoryID"
        Me.catid.DataType = GetType(Integer)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnfillData)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents categoryid As DataColumn
    Friend WithEvents categoryname As DataColumn
    Friend WithEvents btnfillData As Button
    Friend WithEvents DataTable2 As DataTable
    Friend WithEvents productid As DataColumn
    Friend WithEvents ProductName As DataColumn
    Friend WithEvents catid As DataColumn
End Class
