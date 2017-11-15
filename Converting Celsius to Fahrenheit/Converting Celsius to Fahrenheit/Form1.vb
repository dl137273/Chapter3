Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblFahrenheit As Double
        Dim dblCelcius As Double

        dblCelcius = CDbl(txtCelcius.Text)
        dblFahrenheit = (1.8 = dblCelcius + 32)
        lblFarenheit.Text = dblFahrenheit.ToString("n")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelcius.Text = ""
        lblFarenheit.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
