Imports MySql.Data.MySqlClient
Public Class Form10
    Private Sub btndbconnect_Click(sender As Object, e As EventArgs) Handles btndbconnect.Click
        If dbconnect() Then
            MsgBox("Connected")
        Else
            MsgBox("Error Occured")
        End If
    End Sub
End Class