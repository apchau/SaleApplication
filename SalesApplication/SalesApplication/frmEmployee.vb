Public Class frmEmployee
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim AddEmployee As New frmAddEmployee
        AddEmployee.ShowDialog()
    End Sub

    Private Sub DisplayEmployees()
        ListBox1.Items.Clear()

        For Each emp In GetAllEmployees()
            ListBox1.Items.Add(emp.Staffid & " -- " & emp.FName & " " & emp.MInitial & " " & emp.LName)
        Next

        If ListBox1.Items.Count > 0 Then
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedIndex = -1 Then
            lblStatus.Text = "Please select an employee to delete!"
        Else
            DelEmployee(ListBox1.SelectedItem)
            DisplayEmployees()
        End If
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteEmployees()
        lblStatus.Text = "Saved to a file!"
    End Sub

    Private Sub frmEmployee_Load() Handles MyBase.Load
        DisplayEmployees()
    End Sub
End Class