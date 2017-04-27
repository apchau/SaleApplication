Option Strict On
Option Explicit On

Imports ClassLib


Public Class frmInventory

    Private Sub DisplayInventory()
        ListBox1.Items.Clear()

        For Each inv In GetAllInventory()
            ListBox1.Items.Add(inv.ID & " -- " & inv.Name & " " & inv.Stock.ToString())
        Next

        If ListBox1.Items.Count > 0 Then
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteInventory()
        lblStatus.Text = "Saved to a file!"
    End Sub

    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim addInv As New frmAddInventory
        addInv.ShowDialog()
    End Sub

    Private Sub button4_Click_1(sender As Object, e As EventArgs) Handles button4.Click
        Close()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedIndex = -1 Then
            lblStatus.Text = "Please select an item to delete!"
        Else
            DelCustomer(ListBox1.SelectedItem.ToString())
            DisplayInventory()
            lblStatus.Text = "Item Deleted!"
        End If
    End Sub

    Private Sub frmInventory_Load() Handles MyBase.Load
        DisplayInventory()
    End Sub
End Class