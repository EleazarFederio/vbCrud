Imports MySql.Data.MySqlClient
Public Class DbConnect
    Dim str As String = "server=localhost; uid=root; pwd=; database=mydata"
    Public con As New MySqlConnection(str)

    Public Sub connect()
        Try
            con.Open()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub load()

    End Sub

End Class
