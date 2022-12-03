Imports mysql.data.MySqlClient
Module db
    Const SERVER As String = "localhost"
    Public dbconnection As New MySqlConnection
    Public status As Boolean = False

    Public Function dbconnect() As Boolean
        Try
            dbconnection.ConnectionString = "server=" + SERVER + ";user=root; password=; database=m. m. garment db;"
            dbconnection.Open()
            If dbconnection.State = 1 Then
                status = True
            End If

        Catch ex As Exception
            ex.Message.ToString()
        End Try

        Return status
    End Function

End Module
