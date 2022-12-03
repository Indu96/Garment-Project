Imports MySql.Data.MySqlClient
Public Class Form11
    Public Command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datatable As New DataTable
    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load, DataGridView4.Sorted
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `daily production and salary`"
            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            adapter.Fill(datatable)
            DataGridView4.DataSource = datatable

        Else
            MsgBox("Error Occured")
        End If
    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch5.Click
        If dbconnect() Then
            Dim sql As String
            sql = ("SELECT * FROM `daily production and salary` WHERE Emp_ID = '" & txtsearch5.Text & "'")

            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            datatable.Clear()
            adapter.Fill(datatable)

            If datatable.Rows.Count = Nothing Then
                MsgBox("Not Found")
            End If
        End If
    End Sub

    Private Sub btnrefresh5_Click(sender As Object, e As EventArgs) Handles btnrefresh5.Click
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `daily production and salary`"
            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            adapter.Fill(datatable)
            DataGridView4.DataSource = datatable
            DataGridView4.MultiSelect = True
        Else
            MsgBox("Error Occured")
        End If
    End Sub
End Class