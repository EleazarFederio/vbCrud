Imports MySql.Data.MySqlClient

Public Class Form1
    Dim db As New DbConnect()
    Dim tempId As Int16 = 0

    Private Sub load()
        Dim query As String = "SELECT * FROM people"
        Dim adpt As New MySqlDataAdapter(query, db.con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        PeopleTable.DataSource = ds.Tables(0)
        db.con.Close()
        firstNameBox.Clear()
        lastNameBox.Clear()
        ageBox.Clear()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        db.connect()
        Dim cmd As New MySqlCommand
        db.con.Open()
        Dim query As String = "INSERT INTO `people` (`firstname`, `lastname`, `age`, `gender`) VALUES ('" & firstNameBox.Text & "', '" & lastNameBox.Text & "', " & ageBox.Text & ", '" & genderBox.Text & "' )"
        Try
            cmd = db.con.CreateCommand
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            load()
            db.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MessageBox.Show(query)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub PeopleTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PeopleTable.CellClick
        Dim row As DataGridViewRow = PeopleTable.CurrentRow
        Try
            firstNameBox.Text = row.Cells(1).Value.ToString()
            lastNameBox.Text = row.Cells(2).Value.ToString()
            ageBox.Text = row.Cells(3).Value.ToString()
            genderBox.Text = row.Cells(4).Value.ToString()
            tempId = row.Cells(0).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As MySqlCommand
        db.con.Open()
        Try
            Dim query As String
            query = "UPDATE `people` SET `firstname` = '" & firstNameBox.Text & "', `lastname` = '" & lastNameBox.Text & "', `age` = " & ageBox.Text & ", `gender` = '" & genderBox.Text & "' WHERE `id` = " & tempId & " ;"
            cmd = db.con.CreateCommand()
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            db.con.Close()
            load()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As MySqlCommand
        db.con.Open()
        Try
            Dim query As String = "DELETE FROM `people` WHERE `id` = " & tempId & "; "
            cmd = db.con.CreateCommand()
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            db.con.Close()
            load()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
