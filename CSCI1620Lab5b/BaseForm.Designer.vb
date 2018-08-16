<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseForm
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
		Me.FormTemplateTitle = New System.Windows.Forms.Label()
		Me.OKButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'FormTemplateTitle
		'
		Me.FormTemplateTitle.AutoSize = True
		Me.FormTemplateTitle.BackColor = System.Drawing.SystemColors.ControlLight
		Me.FormTemplateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormTemplateTitle.ForeColor = System.Drawing.SystemColors.Highlight
		Me.FormTemplateTitle.Location = New System.Drawing.Point(169, 44)
		Me.FormTemplateTitle.Name = "FormTemplateTitle"
		Me.FormTemplateTitle.Size = New System.Drawing.Size(269, 24)
		Me.FormTemplateTitle.TabIndex = 0
		Me.FormTemplateTitle.Text = "Top Pay for Top Salespersons!"
		'
		'OKButton
		'
		Me.OKButton.Location = New System.Drawing.Point(266, 237)
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(75, 23)
		Me.OKButton.TabIndex = 1
		Me.OKButton.Text = "&OK"
		Me.OKButton.UseVisualStyleBackColor = True
		'
		'BaseForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(606, 295)
		Me.Controls.Add(Me.OKButton)
		Me.Controls.Add(Me.FormTemplateTitle)
		Me.Name = "BaseForm"
		Me.Text = "BaseForm"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents FormTemplateTitle As Label
	Friend WithEvents OKButton As Button
End Class
