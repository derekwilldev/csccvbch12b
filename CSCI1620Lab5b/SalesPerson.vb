' Project:          CSCI1620 Lab 12b - Salesperson Commission Calculator using inheritance
' Programmer:       Derek Will
' Date:             August 5, 2018
' Description:      Salesperson Class. Project calculates the commission of weekly sales for each salesperson that is input.



Public Class SalesPerson
	'Declare constants
	Const COMM_RATE_Decimal As Decimal = 0.15D
	Const BASE_PAY_Decimal As Decimal = 250D
	Const QUOTA_Decimal As Decimal = 1000D

	'Class variables for properties
	Private NameString As String
	Private weeklySalesDecimal, commissionDecimal As Decimal
	Private totalPayDecimal As Decimal
	Private Shared GRANDTOTALSALES, GRANDTOTALPAY, GRANDTOTALCOMMISSION As Decimal


	Sub New(ByVal NameInput As String, ByVal SalesInput As Decimal)
		'Create property names for object
		Name = NameInput
		Sales = SalesInput
		CalculatePay()
	End Sub

	'Properties
	Property Name() As String
		Get
			Return NameString
		End Get
		Set(value As String)
			NameString = value
		End Set
	End Property

	Property Sales() As Decimal
		Get
			Return weeklySalesDecimal
		End Get
		Set(value As Decimal)
			If value >= 0 Then
				weeklySalesDecimal = value
			End If
		End Set
	End Property

	ReadOnly Property Commission() As Decimal
		Get
			Return commissionDecimal
		End Get
	End Property

	ReadOnly Property Pay() As Decimal
		Get
			Return totalPayDecimal
		End Get
	End Property

	Shared ReadOnly Property TotalSales() As Decimal
		Get
			Return GRANDTOTALSALES
		End Get
	End Property

	Shared ReadOnly Property TotalPay() As Decimal
		Get
			Return GRANDTOTALPAY
		End Get
	End Property

	Shared ReadOnly Property TotalCommission() As Decimal
		Get
			Return GRANDTOTALCOMMISSION
		End Get
	End Property


	'Methods
	Private Sub CalculatePay()
		'Calculate pay
		commissionDecimal = CalculateCommission(weeklySalesDecimal)
		totalPayDecimal = BASE_PAY_Decimal + commissionDecimal


		'Increment totals
		GRANDTOTALSALES += weeklySalesDecimal
		GRANDTOTALPAY += totalPayDecimal
	End Sub

	'Calculate commission amount
	Private Function CalculateCommission(ByVal weeklySalesDecimal As Decimal) As Decimal
		Dim commissionAmountDecimal As Decimal

		If weeklySalesDecimal >= QUOTA_Decimal Then
			commissionAmountDecimal = weeklySalesDecimal * COMM_RATE_Decimal
			GRANDTOTALCOMMISSION += commissionAmountDecimal

			Return commissionAmountDecimal
		Else
			Return 0
		End If
	End Function
End Class
