Option Strict On
Option Explicit On

Imports ClassLib

Public Class frmStart
    Public Shared username As String
    Public Shared Password As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New ClassLib.frmLogin
        loginForm.ShowDialog()
        If (loginForm.isTrue()) Then
            Dim mainForm As New frmMain
            username = loginForm.usrName()
            Password = loginForm.passwd()
            frmMain.ShowDialog()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class