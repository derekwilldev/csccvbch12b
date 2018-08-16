' Project:          CSCI1620 Lab 12b - Salesperson Commission Calculator using inheritance
' Programmer:       Derek Will
' Date:             August 5, 2018
' Description:      Summary Form. Project calculates the commission of weekly sales for each salesperson that is input.


Public Class SummaryForm
	'Inherits BaseForm

	Public Overrides Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
		'Override BaseForm method
		Hide()
	End Sub

	Private Sub SummaryForm_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
		'Display totals
		TotalSalesTextBox.Text = SalesPerson.TotalSales.ToString("C")
		TotalPayTextBox.Text = SalesPerson.TotalPay.ToString("C")
		TotalCommissionTextBox.Text = SalesPerson.TotalCommission.ToString("C")
	End Sub
End Class