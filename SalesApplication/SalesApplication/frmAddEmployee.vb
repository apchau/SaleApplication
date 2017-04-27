Option Strict On
Option Explicit On

Imports ClassLib

Public Class frmAddEmployee
    Dim dataChanged As Boolean

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        errProvider.Clear()

        For i As Integer = 0 To Controls.Count - 1 Step -1
            If TypeOf Controls(i) Is TextBox Then
                Dim txt As TextBox = CType(Controls(i), TextBox)

                If txt.Text = "" Then
                    errProvider.SetError(txt, txt.Tag.ToString & " is blank!")
                    txt.Focus()
                    Return
                End If

                If txt.Text.Contains(","c) Then
                    errProvider.SetError(txt, txt.Tag.ToString & " cannot contain comma")
                    txt.Focus()
                    Return
                End If

                If txt.Text.Contains("."c) Then
                    errProvider.SetError(txt, txt.Tag.ToString & " cannot contain period")
                    txt.Focus()
                    Return
                End If
            End If
        Next

        Dim newEmployee As New Employee(txtId.Text, txtFirstname.Text, txtId.Text, txtLastname.Text, txtStreet.Text, txtCity.Text, txtProvince.Text, txtCountry.Text, txtContactNo.Text)

        If AddEmployee(newEmployee) Then
            dataChanged = True
            lblStatus.Text = LastStatus
        End If
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If e.KeyChar = vbBack Then
            e.Handled = True
            Exit Sub
        End If
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Close()
    End Sub
End Class