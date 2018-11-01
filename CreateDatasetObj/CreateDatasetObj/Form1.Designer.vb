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
        Me.btnGetCustomers = New System.Windows.Forms.Button()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGetCustomers
        '
        Me.btnGetCustomers.Location = New System.Drawing.Point(413, 390)
        Me.btnGetCustomers.Name = "btnGetCustomers"
        Me.btnGetCustomers.Size = New System.Drawing.Size(217, 48)
        Me.btnGetCustomers.TabIndex = 0
        Me.btnGetCustomers.Text = "Get Customers"
        Me.btnGetCustomers.UseVisualStyleBackColor = True
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 16
        Me.lstCustomers.Location = New System.Drawing.Point(12, 12)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(618, 372)
        Me.lstCustomers.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 450)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.btnGetCustomers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetCustomers As Button
    Friend WithEvents lstCustomers As ListBox
End Class
