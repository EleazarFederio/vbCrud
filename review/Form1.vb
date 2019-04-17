Public Class Form1
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        MessageBox.Show(firstNameBox.Text & " " & lastNameBox.Text)
    End Sub
End Class
