Imports MySql.Data.MySqlClient



Public Class Form3
    Public Command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datatable As New DataTable
    Public datareader As MySqlDataReader
    Public connection As New MySqlConnection

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `employees`"
            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable
            DataGridView1.MultiSelect = True
        Else
            MsgBox("Error Occured")
        End If

        Try
            dbconnection.Open()
            Dim sql As String
            sql = "SELECT * FROM `products`"
            Command = New MySqlCommand(sql, dbconnection)
            datareader = Command.ExecuteReader
            While datareader.Read
                Dim name = datareader.GetString("Name")
                comproid1.Items.Add(name)
            End While

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Try
            If (MessageBox.Show("Confirm if you want to exit", "Employee Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Form2.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label7.Click

    End Sub

    Private Sub btnReset1_Click(sender As Object, e As EventArgs) Handles btnReset1.Click
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
            MessageBox.Show(ex.Message, "Employee Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub btnSave1_Click(sender As Object, e As EventArgs)
        Dim Emp_ID, FirstName, LastName, NIC, Address, ContactNumber, Product_ID As String
        Emp_ID = txtempid1.Text
        FirstName = txtfname.Text
        LastName = txtlname.Text
        NIC = txtnic.Text
        Address = txtadrs.Text
        ContactNumber = txtcntno.Text
        Product_ID = comproid1.Text



        If FirstName = "" Then
            MsgBox("First Name cannot be empty")
        ElseIf NIC = "" Then
            MsgBox("NIC cannot be empty")
        ElseIf Product_ID = "" Then
            MsgBox("Product_ID cannot be empty")

        Else
            If dbconnect() Then

                Dim sql As String
                Dim result As Integer
                sql = "INSERT INTO `employees`(`Emp_ID`, `FirstName`, `LastName`, `NIC`, `Address`, `ContactNumber`, `Product_ID`) VALUES (@Emp_ID, @FirstName, @LastName, @NIC, @Address, @ContactNumber, @Product_ID);"
                Dim command As New MySqlCommand(sql, dbconnection)

                command.CommandText = sql
                command.Connection = dbconnection


                command.Parameters.AddWithValue("@Emp_ID", Emp_ID)
                command.Parameters.AddWithValue("@FirstName", FirstName)
                command.Parameters.AddWithValue("@LastName", LastName)
                command.Parameters.AddWithValue("@NIC", NIC)
                command.Parameters.AddWithValue("@Address", Address)
                command.Parameters.AddWithValue("@ContactNumber", ContactNumber)
                command.Parameters.AddWithValue("@Product_ID", Product_ID)



                result = command.ExecuteNonQuery()
                If result = 1 Then

                    MsgBox("Saved", vbOKOnly + vbInformation, "Success")
                    txtempid1.Text = ""
                    txtfname.Text = ""
                    txtlname.Text = ""
                    txtnic.Text = ""
                    txtadrs.Text = ""
                    txtcntno.Text = ""
                    comproid1.Text = ""
                    datatable.Rows.Clear()
                    datatable.Columns.Clear()
                    adapter.Fill(datatable)
                    DataGridView1.DataSource = datatable
                Else
                    MsgBox("Error Occured")
                End If
            End If
        End If




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick





    End Sub

    Private Sub btnUpdt1_Click(sender As Object, e As EventArgs) Handles DataGridView1.AllowUserToAddRowsChanged
        Dim Emp_ID, FirstName, LastName, NIC, Address, ContactNumber, Product_ID As String
        Emp_ID = txtempid1.Text
        FirstName = txtfname.Text
        LastName = txtlname.Text
        NIC = txtnic.Text
        Address = txtadrs.Text
        ContactNumber = txtcntno.Text
        Product_ID = comproid1.Text

        If FirstName = "" Then
            MsgBox("First Name cannot be empty")
        ElseIf NIC = "" Then
            MsgBox("NIC cannot be empty")
        ElseIf Product_ID = "" Then
            MsgBox("Product_ID cannot be empty")
        Else
            If dbconnect() Then
                Dim sql As String
                Dim result As Integer
                sql = "UPDATE `employees` SET `Emp_ID`=@Emp_ID,`FirstName`=@FirstName,`LastName`=@LastName,`NIC`=@NIC,`Address`=@Address,`ContactNumber`=@ContactNumber,`Product_ID`=@Product_ID WHERE `Emp_ID`=@Emp_ID"

                Dim command As New MySqlCommand(sql, dbconnection)

                command.CommandText = sql
                command.Connection = dbconnection

                command.Parameters.AddWithValue("@Emp_ID", Emp_ID)
                command.Parameters.AddWithValue("@FirstName", FirstName)
                command.Parameters.AddWithValue("@LastName", LastName)
                command.Parameters.AddWithValue("@NIC", NIC)
                command.Parameters.AddWithValue("@Address", Address)
                command.Parameters.AddWithValue("@ContactNumber", ContactNumber)
                command.Parameters.AddWithValue("@Product_ID", Product_ID)

                result = command.ExecuteNonQuery()
                If result = 1 Then
                    MsgBox("Updated", vbOKOnly + vbInformation, "Success")
                    txtempid1.Text = ""
                    txtfname.Text = ""
                    txtlname.Text = ""
                    txtnic.Text = ""
                    txtadrs.Text = ""
                    txtcntno.Text = ""
                    comproid1.Text = ""
                    datatable.Rows.Clear()
                    datatable.Columns.Clear()
                    adapter.Fill(datatable)
                    DataGridView1.DataSource = datatable
                Else
                    MsgBox("Error Occured")
                End If
            End If
        End If
    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        If dbconnect() Then
            Dim sql As String
            sql = ("SELECT * FROM `employees` WHERE Emp_ID = '" & txtsearch.Text & "'")

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



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtempid1.Text = DataGridView1.Item(0, i).Value
        txtfname.Text = DataGridView1.Item(1, i).Value
        txtlname.Text = DataGridView1.Item(2, i).Value
        txtnic.Text = DataGridView1.Item(3, i).Value
        txtadrs.Text = DataGridView1.Item(4, i).Value
        txtcntno.Text = DataGridView1.Item(5, i).Value
        comproid1.Text = DataGridView1.Item(6, i).Value
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        If dbconnect() Then
            Dim sql As String
            sql = "SELECT * FROM `employees`"
            Command.CommandText = sql
            Command.Connection = dbconnection
            adapter.SelectCommand = Command
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable
            DataGridView1.MultiSelect = True
        Else
            MsgBox("Error Occured")
        End If
    End Sub

    Private Sub txtempid1_BindingContextChanged(sender As Object, e As EventArgs) Handles txtempid1.BindingContextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Emp_ID, FirstName, LastName, NIC, Address, ContactNumber, Product_ID As String
        Emp_ID = txtempid1.Text
        FirstName = txtfname.Text
        LastName = txtlname.Text
        NIC = txtnic.Text
        Address = txtadrs.Text
        ContactNumber = txtcntno.Text
        Product_ID = comproid1.Text



        If FirstName = "" Then
            MsgBox("First Name cannot be empty")
        ElseIf NIC = "" Then
            MsgBox("NIC cannot be empty")
        ElseIf Product_ID = "" Then
            MsgBox("Product_ID cannot be empty")

        Else
            If dbconnect() Then

                Dim sql As String
                Dim result As Integer
                sql = "INSERT INTO `employees`(`Emp_ID`, `FirstName`, `LastName`, `NIC`, `Address`, `ContactNumber`, `Product_ID`) VALUES (@Emp_ID, @FirstName, @LastName, @NIC, @Address, @ContactNumber, @Product_ID);"
                Dim command As New MySqlCommand(sql, dbconnection)

                command.CommandText = sql
                command.Connection = dbconnection


                command.Parameters.AddWithValue("@Emp_ID", Emp_ID)
                command.Parameters.AddWithValue("@FirstName", FirstName)
                command.Parameters.AddWithValue("@LastName", LastName)
                command.Parameters.AddWithValue("@NIC", NIC)
                command.Parameters.AddWithValue("@Address", Address)
                command.Parameters.AddWithValue("@ContactNumber", ContactNumber)
                command.Parameters.AddWithValue("@Product_ID", Product_ID)



                result = command.ExecuteNonQuery()
                If result = 1 Then

                    MsgBox("Saved", vbOKOnly + vbInformation, "Success")
                    txtempid1.Text = ""
                    txtfname.Text = ""
                    txtlname.Text = ""
                    txtnic.Text = ""
                    txtadrs.Text = ""
                    txtcntno.Text = ""
                    comproid1.Text = ""
                    datatable.Rows.Clear()
                    datatable.Columns.Clear()
                    adapter.Fill(datatable)
                    DataGridView1.DataSource = datatable
                Else
                    MsgBox("Error Occured")
                End If
            End If
        End If
    End Sub

    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click
        Dim Emp_ID, FirstName, LastName, NIC, Address, ContactNumber, Product_ID As String
        Emp_ID = txtempid1.Text
        FirstName = txtfname.Text
        LastName = txtlname.Text
        NIC = txtnic.Text
        Address = txtadrs.Text
        ContactNumber = txtcntno.Text
        Product_ID = comproid1.Text

        If FirstName = "" Then
            MsgBox("First Name cannot be empty")
        ElseIf NIC = "" Then
            MsgBox("NIC cannot be empty")
        ElseIf Product_ID = "" Then
            MsgBox("Product_ID cannot be empty")
        Else
            If dbconnect() Then
                Dim sql As String
                Dim result As Integer
                sql = "UPDATE `employees` SET `Emp_ID`=@Emp_ID,`FirstName`=@FirstName,`LastName`=@LastName,`NIC`=@NIC,`Address`=@Address,`ContactNumber`=@ContactNumber,`Product_ID`=@Product_ID WHERE `Emp_ID`=@Emp_ID"

                Dim command As New MySqlCommand(sql, dbconnection)

                command.CommandText = sql
                command.Connection = dbconnection

                command.Parameters.AddWithValue("@Emp_ID", Emp_ID)
                command.Parameters.AddWithValue("@FirstName", FirstName)
                command.Parameters.AddWithValue("@LastName", LastName)
                command.Parameters.AddWithValue("@NIC", NIC)
                command.Parameters.AddWithValue("@Address", Address)
                command.Parameters.AddWithValue("@ContactNumber", ContactNumber)
                command.Parameters.AddWithValue("@Product_ID", Product_ID)

                result = command.ExecuteNonQuery()
                If result = 1 Then
                    MsgBox("Updated", vbOKOnly + vbInformation, "Success")
                    txtempid1.Text = ""
                    txtfname.Text = ""
                    txtlname.Text = ""
                    txtnic.Text = ""
                    txtadrs.Text = ""
                    txtcntno.Text = ""
                    comproid1.Text = ""
                    datatable.Rows.Clear()
                    datatable.Columns.Clear()
                    adapter.Fill(datatable)
                    DataGridView1.DataSource = datatable
                Else
                    MsgBox("Error Occured")
                End If
            End If
        End If

    End Sub

    Private Sub txtadrs_TextChanged(sender As Object, e As EventArgs) Handles txtadrs.TextChanged

    End Sub

    Private Sub txtcntno_TextChanged(sender As Object, e As EventArgs) Handles txtcntno.TextChanged
        If txtcntno.Text.Length > 10 Then
            MsgBox("Invalid Contact Number")
        End If
    End Sub

    Private Sub comproid1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comproid1.SelectedIndexChanged

    End Sub

    Private Sub comproid1_Click(sender As Object, e As EventArgs) Handles comproid1.Click
        If txtcntno.Text.Length = 10 Then
        Else
            MsgBox("Invalid Contact Number")
        End If
    End Sub

    Private Sub btnDlt1_Click(sender As Object, e As EventArgs) Handles btnDlt1.Click
        If dbconnect() Then
            Dim Emp_ID, sql As String

            sql = ("DELETE FROM `employees` WHERE Emp_ID = '" & txtempid1.Text & "'")

            Command.Connection = dbconnection
            Command.CommandText = sql
            Command.Parameters.AddWithValue("@Emp_ID", Emp_ID)

            MsgBox("Deleted", vbOKOnly + vbInformation, "Success")
            If DataGridView1.SelectedRows.Count > 0 Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            Else
                MessageBox.Show("You must select a row")
            End If


            txtempid1.Text = ""
            txtfname.Text = ""
            txtlname.Text = ""
            txtnic.Text = ""
            txtadrs.Text = ""
            txtcntno.Text = ""
            comproid1.Text = ""


            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable

        End If
    End Sub
End Class