Option Strict On
Option Explicit On

Imports ClassLib

Public Class frmMain
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        frmEmployee.ShowDialog()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.ShowDialog()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        frmInventory.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmMain_Load() Handles MyBase.Load
        Label1.Font = New Font("Times New Roman", 32, FontStyle.Bold)
        Label1.Text = "Welcome " & frmStart.username & "!"
    End Sub
End Class