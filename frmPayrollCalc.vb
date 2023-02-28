Imports System.ComponentModel.Design.Serialization

Public Class frmPayrollCalc
    Private Sub frmPayrollCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clears tax labels and income entry.
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all input and taxes & income results and puts focus on income entry.
        txtPayEntry.Focus()
        txtPayEntry.Clear()
        lblFICA.Text = ""
        lblFedTax.Text = ""
        lblStateTax.Text = ""
        lblNetIncome.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program
        Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'The tax rates as given
        Dim cdecFICA As Decimal = 0.0765D
        Dim cdecFed As Decimal = 0.22D
        Dim cdecState As Decimal = 0.04D

        'Determines if the income entered is a number
        If IsNumeric(txtPayEntry.Text) Then

            'Get the income as entered
            Dim strIncome As String = txtPayEntry.Text
            'Convert the income to decimal
            Dim decIncome = Convert.ToDecimal(strIncome)
            'Multiplies the correct percentage of the income for each tax and places it in the proper label
            Dim decFica As Decimal = decIncome * cdecFICA
            lblFICA.Text = decFica.ToString("C2")
            Dim decFederal As Decimal = decIncome * cdecFed
            lblFedTax.Text = decFederal.ToString("C2")
            Dim decState As Decimal = decIncome * cdecState
            lblStateTax.Text = decState.ToString("C2")
            'Deducts the taxes from the input income and diplays the take home pay (after taxes)
            Dim decNet As Decimal = decIncome - (decFica + decFederal + decState)
            lblNetIncome.Text = decNet.ToString("C2")
        Else
            'If the entry isn't a number, an error message will appear
            MsgBox("Please input a correct Income as a positive number",, "Illegal Income Entry")
        End If
    End Sub
End Class
