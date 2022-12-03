
Imports MySql.Data.MySqlClient
Public Class Form6
    Public Command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datareader As MySqlDataReader
    Public datatable As New DataTable
    Public Connection As New MySqlConnection
    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        Try
            If (MessageBox.Show("Confirm if you want to exit", "Sales and Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Form2.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sales and Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `sales and inventory`"
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub btnClear4_Click(sender As Object, e As EventArgs) Handles btnClear4.Click
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
            MessageBox.Show(ex.Message, "Sales and Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub btnSearch4_Click(sender As Object, e As EventArgs) Handles btnSearch4.Click
        If dbconnect() Then
            Dim sql As String
            sql = ("SELECT * FROM `sales and inventory` WHERE Product_ID = '" & txtsearch4.Text & "'")

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

    Private Sub btnrefresh4_Click(sender As Object, e As EventArgs) Handles btnrefresh4.Click
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `sales and inventory`"
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

    Private Sub comproid3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comproid3.SelectedIndexChanged
        If dbconnect() Then
            Command.Connection = dbconnection
            Dim sql As String
            sql = ("SELECT `AvailableQuantity` FROM `sales and inventory` WHERE Product_ID = '" & comproid3.Text & "'")
            Command.CommandText = sql

            Dim datareader As MySqlDataReader = Command.ExecuteReader()

            If datareader.HasRows Then
                datareader.Read()
                txtAQty.Text = datareader.GetValue(0).ToString()
                dbconnection.Close()
                datareader.Dispose()
            Else
                MsgBox("Error")
            End If
        End If
    End Sub

    Private Sub comproid3_Click(sender As Object, e As EventArgs) Handles comproid3.Click

    End Sub

    Private Sub txtSale_TextChanged(sender As Object, e As EventArgs) Handles txtSale.TextChanged
        txtAQty.Text = (txtAQty.Text - txtSale.Text)
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        Dim dt, Product_ID, Sales, AvailableQuantity As String
        dt = dtp2.Value
        Product_ID = comproid3.Text
        Sales = txtSale.Text
        AvailableQuantity = txtAQty.Text


        If dbconnect() Then
            Dim sql As String

            Dim result As Integer
            sql = "INSERT INTO `sales and inventory`(`Date`, `Product_ID`, `Sales`, `AvailableQuantity`) VALUES (@Date, @Product_ID, @Sales, @AvailableQuantity)"
            Dim command As New MySqlCommand(sql, dbconnection)

            command.CommandText = sql

            command.Connection = dbconnection

            command.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            command.Parameters.AddWithValue("@Product_ID", Product_ID)
            command.Parameters.AddWithValue("@Sales", Sales)
            command.Parameters.AddWithValue("@AvailableQuantity", AvailableQuantity)


            result = command.ExecuteNonQuery()
            If result = 1 Then

                MsgBox("Saved", vbOKOnly + vbInformation, "Success")

                adapter.Fill(datatable)
                DataGridView4.DataSource = datatable



            Else
                MsgBox("Error Occured")
            End If
        End If
    End Sub
End Class