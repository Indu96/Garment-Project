Imports MySql.Data.MySqlClient

Public Class Form4
    Public Command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datatable As New DataTable


    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        Try
            If (MessageBox.Show("Confirm if you want to exit", "Product Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Form2.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Product Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `products`"
            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            adapter.Fill(datatable)
            DataGridView2.DataSource = datatable
            DataGridView2.MultiSelect = True
        Else
            MsgBox("Error Occured")
        End If
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Dim Product_ID, Name, LaborerCost As String
        Product_ID = txtproid2.Text
        Name = txtName.Text
        LaborerCost = txtLabCost.Text


        If Name = "" Then
            MsgBox("Name cannot be empty")
        ElseIf LaborerCost = "" Then
            MsgBox("Laborer cost cannot be empty")
        Else

            If dbconnect() Then
                Dim sql As String
                Dim result As Integer
                sql = "INSERT INTO `products`(`Product_ID`, `Name`, `LaborerCost`) VALUES (@Product_ID, @Name, @LaborerCost);"
                Dim command As New MySqlCommand(sql, dbconnection)

                command.CommandText = sql
                command.Connection = dbconnection


                command.Parameters.AddWithValue("@Product_ID", Product_ID)
                command.Parameters.AddWithValue("@Name", Name)
                command.Parameters.AddWithValue("@LaborerCost", LaborerCost)



                result = command.ExecuteNonQuery()
                If result = 1 Then

                    MsgBox("Saved", vbOKOnly + vbInformation, "Success")
                    txtproid2.Text = ""
                    txtName.Text = ""
                    txtLabCost.Text = ""
                    datatable.Rows.Clear()
                    datatable.Columns.Clear()
                    adapter.Fill(datatable)
                    DataGridView2.DataSource = datatable

                    Form3.comproid1.Items.Add(Val("@Product_ID"))
                Else
                    MsgBox("Error Occured")
                End If
            End If
        End If
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Try
            For Each txt In Panel1.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
            For Each cbo In Panel1.Controls
                If TypeOf cbo Is ComboBox Then
                    cbo.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Product Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnUpdt2_Click(sender As Object, e As EventArgs) Handles btnUpdt2.Click
        Dim Product_ID, Name, LaborerCost As String
        Product_ID = txtproid2.Text
        Name = txtName.Text
        LaborerCost = txtLabCost.Text


        If dbconnect() Then
            Dim sql As String
            Dim result As Integer
            sql = "UPDATE `products` SET `Product_ID`=@Product_ID,`Name`=@Name,`LaborerCost`=@LaborerCost WHERE Product_ID = @Product_ID"
            Dim command As New MySqlCommand(sql, dbconnection)

            command.CommandText = sql
            command.Connection = dbconnection


            command.Parameters.AddWithValue("@Product_ID", Product_ID)
            command.Parameters.AddWithValue("@Name", Name)
            command.Parameters.AddWithValue("@LaborerCost", LaborerCost)



            result = command.ExecuteNonQuery()
            If result = 1 Then

                MsgBox("Updated", vbOKOnly + vbInformation, "Success")
                txtproid2.Text = ""
                txtName.Text = ""
                txtLabCost.Text = ""

                datatable.Rows.Clear()
                datatable.Columns.Clear()
                adapter.Fill(datatable)
                DataGridView2.DataSource = datatable
            Else
                MsgBox("Error Occured")
            End If
        End If
    End Sub

    Private Sub btnDlt2_Click(sender As Object, e As EventArgs) Handles btnDlt2.Click
        If dbconnect() Then
            Dim Product_ID, sql As String

            sql = ("DELETE FROM `products` WHERE Product_ID = '" & txtproid2.Text & "'")

            Command.Connection = dbconnection
            Command.CommandText = sql
            Command.Parameters.AddWithValue("@Product_ID", Product_ID)

            MsgBox("Deleted", vbOKOnly + vbInformation, "Success")
            If DataGridView2.SelectedRows.Count > 0 Then
                DataGridView2.Rows.Remove(DataGridView2.SelectedRows(0))
            Else
                MessageBox.Show("You must select a row")
            End If

            adapter.Fill(datatable)
            DataGridView2.DataSource = datatable

        End If
    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        If dbconnect() Then
            Dim sql As String
            sql = ("SELECT * FROM `products` WHERE Product_ID = '" & txtsearch2.Text & "'")

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

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh2.Click
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `products`"
            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            adapter.Fill(datatable)
            DataGridView2.DataSource = datatable
            DataGridView2.MultiSelect = True
        Else
            MsgBox("Error Occured")
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        txtproid2.Text = DataGridView2.Item(0, i).Value
        txtName.Text = DataGridView2.Item(1, i).Value
        txtLabCost.Text = DataGridView2.Item(2, i).Value


    End Sub

    Private Sub txtLabCost_Click(sender As Object, e As EventArgs) Handles txtLabCost.Click

    End Sub

    Private Sub txtproid2_TextChanged(sender As Object, e As EventArgs) Handles txtproid2.TextChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtLabCost_TextChanged(sender As Object, e As EventArgs) Handles txtLabCost.TextChanged

    End Sub
End Class