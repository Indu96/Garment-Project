Imports MySql.Data.MySqlClient

Public Class Form2
    Public Command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datatable As New DataTable
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Form4.Show()
        Me.Hide()
    End Sub


    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnDailyPro_Click(sender As Object, e As EventArgs) Handles btnDailyPro.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Form6.Show()
        Me.Hide()
    End Sub

End Class