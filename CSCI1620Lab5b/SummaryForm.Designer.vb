<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
	Inherits CSCI1620Lab5b.BaseForm

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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TotalSalesTextBox = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TotalCommissionTextBox = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(201, 111)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Total Sales"
		'
		'TotalSalesTextBox
		'
		Me.TotalSalesTextBox.Location = New System.Drawing.Point(304, 108)
		Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
		Me.TotalSalesTextBox.ReadOnly = True
		Me.TotalSalesTextBox.Size = New System.Drawing.Size(123, 20)
		Me.TotalSalesTextBox.TabIndex = 3
		Me.TotalSalesTextBox.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(209, 146)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(52, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Total Pay"
		'
		'TotalPayTextBox
		'
		Me.TotalPayTextBox.Location = New System.Drawing.Point(304, 143)
		Me.TotalPayTextBox.Name = "TotalPayTextBox"
		Me.TotalPayTextBox.ReadOnly = True
		Me.TotalPayTextBox.Size = New System.Drawing.Size(123, 20)
		Me.TotalPayTextBox.TabIndex = 5
		Me.TotalPayTextBox.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(172, 183)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(89, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Total Commission"
		'
		'TotalCommissionTextBox
		'
		Me.TotalCommissionTextBox.Location = New System.Drawing.Point(304, 180)
		Me.TotalCommissionTextBox.Name = "TotalCommissionTextBox"
		Me.TotalCommissionTextBox.ReadOnly = True
		Me.TotalCommissionTextBox.Size = New System.Drawing.Size(123, 20)
		Me.TotalCommissionTextBox.TabIndex = 7
		Me.TotalCommissionTextBox.TabStop = False
		'
		'SummaryForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(606, 295)
		Me.Controls.Add(Me.TotalCommissionTextBox)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TotalPayTextBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TotalSalesTextBox)
		Me.Controls.Add(Me.Label1)
		Me.Name = "SummaryForm"
		Me.Text = "SummaryForm"
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.TotalSalesTextBox, 0)
		Me.Controls.SetChildIndex(Me.Label2, 0)
		Me.Controls.SetChildIndex(Me.TotalPayTextBox, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.Controls.SetChildIndex(Me.TotalCommissionTextBox, 0)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents TotalSalesTextBox As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TotalPayTextBox As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TotalCommissionTextBox As TextBox
End Class
