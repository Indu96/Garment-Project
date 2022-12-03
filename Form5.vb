Imports MySql.Data.MySqlClient

Public Class Form5
    Public Command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datareader As MySqlDataReader
    Public datatable As New DataTable

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        Try
            If (MessageBox.Show("Confirm if you want to exit", "Daily Production", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Form2.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Daily Production", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Dt, Emp_ID, Product_ID, LaborerCost, Quantity, SalaryAmount, AvailableQuantity As String
        Dt = Dtp1.Value
        Emp_ID = txtempid2.Text
        Product_ID = comproid2.Text
        LaborerCost = txtLabCost.Text
        Quantity = txtQty2.Text
        SalaryAmount = txtSA.Text
        AvailableQuantity = txtAQty3.Text


        If dbconnect() Then
            Dim sql As String
            sql = ("SELECT `Product_ID` FROM `employees` WHERE Emp_ID = '" & txtempid2.Text & "' AND Product_ID = '" & comproid2.Text & "'")

            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            datatable.Clear()
            adapter.Fill(datatable)

            If datatable.Rows.Count = Nothing Then
                MsgBox("Invalid entry Emp_ID or Product_ID")
            Else
                If dbconnect() Then
                    Dim bbc As String
                    bbc = ("SELECT `LaborerCost` FROM `products` WHERE Product_ID = '" & comproid2.Text & "' AND LaborerCost = '" & txtLabCost.Text & "'")

                    Command.CommandText = bbc
                    Command.Connection = dbconnection
                    adapter.SelectCommand = Command
                    datatable.Clear()
                    adapter.Fill(datatable)

                    If datatable.Rows.Count = Nothing Then
                        MsgBox("Invalid entry Product_ID or Laborer Cost")
                    Else
                        If dbconnect() Then
                            Dim abc As String
                            Dim result As Integer
                            abc = "INSERT INTO `daily production and salary`(`Date`, `Emp_ID`, `Product_ID`, `LaborerCost`, `Quantity`, `SalaryAmount`) VALUES (@Date, @Emp_ID, @Product_ID, @LaborerCost, @Quantity, @SalaryAmount);"
                            Dim command As New MySqlCommand(abc, dbconnection)
                            command.CommandText = abc

                            command.Connection = dbconnection

                            command.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                            command.Parameters.AddWithValue("@Emp_ID", Emp_ID)
                            command.Parameters.AddWithValue("@Product_ID", Product_ID)
                            command.Parameters.AddWithValue("@LaborerCost", LaborerCost)
                            command.Parameters.AddWithValue("@Quantity", Quantity)
                            command.Parameters.AddWithValue("@SalaryAmount", SalaryAmount)


                            result = command.ExecuteNonQuery()
                            If result = 1 Then
                                DataGridView3.Rows.Add(Dtp1.Value, txtempid2.Text, comproid2.Text, txtLabCost.Text, txtQty2.Text, txtSA.Text)
                                MsgBox("Saved", vbOKOnly + vbInformation, "Success")
                                txtempid2.Text = ""
                                comproid2.Text = ""
                                txtLabCost.Text = 0
                                txtQty2.Text = 0
                                txtSA.Text = 0
                            Else
                                MsgBox("Error Occured")
                            End If
                        End If

                        If dbconnect() Then
                            Dim aql As String
                            aql = ("UPDATE `sales and inventory` SET `AvailableQuantity`=@AvailableQuantity WHERE `Product_ID`=@Product_ID")
                            Dim command As New MySqlCommand(aql, dbconnection)
                            command.CommandText = aql

                            Command.Connection = dbconnection
                            Command.Parameters.AddWithValue("@AvailableQuantity", AvailableQuantity)
                        End If
                    End If
                    End If
                End If
            End If





    End Sub




    Private Sub txtQty2_TextChanged(sender As Object, e As EventArgs) Handles txtQty2.TextChanged
        txtSA.Text = (txtQty2.Text * txtLabCost.Text)

        Dim num1, num2 As Integer
        num1 = txtAQty3.Text
        num2 = txtQty2.Text
        txtAQty3.Text = (num1 + num2)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtLabCost.TextChanged, txtAQty3.TextChanged

    End Sub

    Private Sub btnUpdt3_Click(sender As Object, e As EventArgs) Handles btnUpdt3.Click
        Dim Dt, Emp_ID, Product_ID, LaborerCost, Quantity, SalaryAmount As String
        Dt = Dtp1.Value
        Emp_ID = txtempid2.Text
        Product_ID = comproid2.Text
        LaborerCost = txtLabCost.Text
        Quantity = txtQty2.Text
        SalaryAmount = txtSA.Text



        If dbconnect() Then
            Dim sql As String
            Dim result As Integer
            sql = "UPDATE `daily production and salary` SET `Date`= @Date,`Emp_ID`= @Emp_ID,`Product_ID`=@Product_ID,`LaborerCost`=@LaborerCost,`Quantity`=@Quantity,`SalaryAmount`=@SalaryAmount WHERE `Emp_ID`=@Emp_ID"
            Dim command As New MySqlCommand(sql, dbconnection)

            command.CommandText = sql
            command.Connection = dbconnection


            command.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            command.Parameters.AddWithValue("@Emp_ID", Emp_ID)
            command.Parameters.AddWithValue("@Product_ID", Product_ID)
            command.Parameters.AddWithValue("@LaborerCost", LaborerCost)
            command.Parameters.AddWithValue("@Quantity", Quantity)
            command.Parameters.AddWithValue("@SalaryAmount", SalaryAmount)



            result = command.ExecuteNonQuery()
            MsgBox("Updated", vbOKOnly + vbInformation, "Success")

            Dim rowIndex = DataGridView3.CurrentRow.Index
            DataGridView3.Rows(rowIndex).Cells(0).Value = Dtp1.Value
            DataGridView3.Rows(rowIndex).Cells(1).Value = txtempid2.Text
            DataGridView3.Rows(rowIndex).Cells(2).Value = comproid2.Text
            DataGridView3.Rows(rowIndex).Cells(3).Value = txtLabCost.Text
            DataGridView3.Rows(rowIndex).Cells(4).Value = txtQty2.Text
            DataGridView3.Rows(rowIndex).Cells(5).Value = txtSA.Text

            txtempid2.Text = ""
            comproid2.Text = ""
            txtLabCost.Text = 0
            txtQty2.Text = 0
            txtSA.Text = 0

        Else
            MsgBox("Error Occured")
        End If

    End Sub

    Private Sub Dtp1_ValueChanged(sender As Object, e As EventArgs) Handles Dtp1.ValueChanged, DataGridView3.Sorted

    End Sub

    Private Sub txtempid2_TextChanged(sender As Object, e As EventArgs) Handles txtempid2.TextChanged
        If txtempid2.Text.Length = 5 Then

            If dbconnect() Then
                Command.Connection = dbconnection
                Dim sql As String
                sql = ("SELECT `Product_ID` FROM `employees` WHERE Emp_ID = '" & txtempid2.Text & "'")
                Command.CommandText = sql

                Dim datareader As MySqlDataReader = Command.ExecuteReader()

                If datareader.HasRows Then
                    datareader.Read()
                    comproid2.Text = datareader.GetValue(0).ToString()
                    dbconnection.Close()
                    datareader.Dispose()
                Else
                    MsgBox("Error")
                End If
            End If

            If dbconnect() Then
                Command.Connection = dbconnection
                Dim sql As String
                sql = ("SELECT `LaborerCost` FROM `products` WHERE Product_ID = '" & comproid2.Text & "'")
                Command.CommandText = sql

                Dim datareader As MySqlDataReader = Command.ExecuteReader()

                If datareader.HasRows Then
                    datareader.Read()
                    txtLabCost.Text = datareader.GetValue(0).ToString()
                    dbconnection.Close()
                    datareader.Dispose()
                Else
                    MsgBox("Error")
                End If
            End If
            If dbconnect() Then
                Command.Connection = dbconnection
                Dim sql As String
                sql = ("SELECT `AvailableQuantity` FROM `sales and inventory` WHERE Product_ID = '" & comproid2.Text & "'")
                Command.CommandText = sql

                Dim datareader As MySqlDataReader = Command.ExecuteReader()

                If datareader.HasRows Then
                    datareader.Read()
                    txtAQty3.Text = datareader.GetValue(0).ToString()
                    dbconnection.Close()
                    datareader.Dispose()
                Else
                    MsgBox("Error")
                End If
            End If
        End If


    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click
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
            MessageBox.Show(ex.Message, "Daily Production", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch3.Click
        If dbconnect() Then
            Dim sql As String
            sql = ("SELECT * FROM `daily production and salary` WHERE Emp_ID OR Product_ID = '" & txtSearch3.Text & "'")

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

    Private Sub btnrefresh3_Click(sender As Object, e As EventArgs) Handles btnrefresh3.Click
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `daily production and salary`"
            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            adapter.Fill(datatable)
            DataGridView3.DataSource = datatable
            DataGridView3.MultiSelect = True
        Else
            MsgBox("Error Occured")
        End If
    End Sub

    Private Sub comproid2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comproid2.SelectedIndexChanged


    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim i As Integer
        i = DataGridView3.CurrentRow.Index
        Dtp1.Value = DataGridView3.Item(0, i).Value
        txtempid2.Text = DataGridView3.Item(1, i).Value
        comproid2.Text = DataGridView3.Item(2, i).Value
        txtLabCost.Text = DataGridView3.Item(3, i).Value
        txtQty2.Text = DataGridView3.Item(4, i).Value
        txtSA.Text = DataGridView3.Item(5, i).Value

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtSA_TextChanged(sender As Object, e As EventArgs) Handles txtSA.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Label10.Click

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Form11.Show()
        Me.Hide()
    End Sub


End Class