Imports MySql.Data.MySqlClient
Public Class Form1
    Dim mysqlconnection As New MySqlConnection
    Dim adapter As New MySqlDataAdapter
    Dim datatable As New DataTable
    Dim command As New MySqlCommand
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If dbconnect() Then
            Dim sql As String
            sql = ("SELECT `Username`, `Password` FROM `admin` WHERE Username = '" & txtuname.Text & "' AND Password = '" & txtpassword.Text & "'")

            command.CommandText = sql
            command.Connection = dbconnection
            adapter.SelectCommand = command
            datatable.Clear()
            adapter.Fill(datatable)

            If datatable.Rows.Count = Nothing Then
                MsgBox("Invalid Username or Password")
            Else
                Form2.Show()
                Me.Hide()
            End If
            mysqlconnection.Close()
        End If


    End Sub
End Class
