Public Class Form1

    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        Dim txtFullName As String

        txtFullName = txtFirstName.Text & " " & txtLastName.Text

        lblFullName.Text = txtFullName

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName.Text = String.Empty
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
