Option Strict On
Option Explicit On

Imports ClassLib
Imports System.IO

Public Class frmCustomer
    Dim dataChanged As Boolean

    Private Sub DisplayCustomers()
        ListBox1.Items.Clear()

        For Each cust In GetAllCustomers()
            ListBox1.Items.Add(cust.Staffid & " -- " & cust.FName & " " & cust.MInitial & " " & cust.LName)
        Next

        If ListBox1.Items.Count > 0 Then
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteCustomers()
        lblStatus.Text = "Saved to a file!"
    End Sub

    Private Sub button4_Click_1(sender As Object, e As EventArgs) Handles button4.Click
        Close()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedIndex = -1 Then
            lblStatus.Text = "Please select a customer to delete!"
        Else
            DelCustomer(ListBox1.SelectedItem.ToString())
            DisplayCustomers()
            lblStatus.Text = "Customer Deleted!"
        End If
    End Sub

    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim addCustomer As New frmAddCustomer
        addCustomer.ShowDialog()
    End Sub

    Private Sub frmCustomer_Load() Handles MyBase.Load
        DisplayCustomers()
    End Sub
End Class