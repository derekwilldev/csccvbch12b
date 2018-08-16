' Project:          CSCI1620 Lab 12b - Salesperson Commission Calculator using inheritance
' Programmer:       Derek Will
' Date:             August 5, 2018
' Description:      Main Form. Project calculates the commission of weekly sales for each salesperson that is input.


Public Class DJWfrmMain
	'Inherits BaseForm
	Private TheSalesPerson As SalesPerson

	Private Sub DJWfrmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		'Hide OK button
		OKButton.Visible = False
	End Sub

	Private Sub PayToolStrip_Click(ByVal sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
		Try
			TheSalesPerson = New SalesPerson(SalespersonNameTextBox.Text, Decimal.Parse(WeeklySalesTextBox.Text))

			'Pass weekly sales text input
			TotalPayTextBox.Text = TheSalesPerson.Pay.ToString("N2")
			If TheSalesPerson.Commission <> 0 Then
				CommissionTextBox.Text = TheSalesPerson.Commission.ToString("N2")
			Else
				CommissionTextBox.Text = ""
			End If

		Catch WeeklySalesException As FormatException
			'Handle input errors
			MessageBox.Show("Please enter the name and the sales amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

		Catch AnException As Exception
			' Handle any other exception
			MessageBox.Show("Error: " & AnException.Message)
		End Try
	End Sub


	Private Sub SummaryToolStrip_Click(ByVal sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
		'Declare variables
		Dim MessageString As String

		If SalesPerson.TotalPay > 0 Then
			'Display SummaryForm
			SummaryForm.ShowDialog()
		Else
			MessageString = "No sales data to summarize."
			MessageBox.Show(MessageString, "Total Commissions and Sales", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub


	Private Sub AboutToolStrip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
		'Display the AboutForm
		AboutForm.ShowDialog()
	End Sub


	Private Sub ClearToolStrip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClearToolStripMenuItem.Click
		'Clear form
		With SalespersonNameTextBox
			.Clear()
			.Focus()
		End With
		WeeklySalesTextBox.Clear()
		TotalPayTextBox.Clear()
		CommissionTextBox.Clear()
	End Sub


	Private Sub FontToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FontToolStripMenuItem.Click
		'Allow the user to select a new font for the summary totals
		With FontDialog1
			.Font = Label1.Font
			.ShowDialog()
			Label1.Font = .Font
			Label2.Font = .Font
			Label3.Font = .Font
			Label4.Font = .Font
		End With
	End Sub


	Private Sub ColorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ColorToolStripMenuItem.Click
		'Allow the user to select a new color for the summary totals
		With ColorDialog1
			.Color = Label1.ForeColor
			.ShowDialog()
			Label1.ForeColor = .Color
			Label2.ForeColor = .Color
			Label3.ForeColor = .Color
			Label4.ForeColor = .Color
		End With

		SalespersonNameTextBox.BackColor = SalespersonNameTextBox.BackColor
		WeeklySalesTextBox.BackColor = WeeklySalesTextBox.BackColor
		TotalPayTextBox.BackColor = TotalPayTextBox.BackColor
		CommissionTextBox.BackColor = CommissionTextBox.BackColor
	End Sub


	Private Sub ExitToolStrip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
		'Close the program
		Close()
	End Sub
End Class
