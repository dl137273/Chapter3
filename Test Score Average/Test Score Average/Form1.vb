Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total, average As Double

        total = CDbl(txtScore1.Text) + CDbl(txtScore2.Text) + CDbl(txtScore3.Text) + CDbl(txtScore4.Text) + CDbl(txtScore5.Text)
        average = total / 5

        lblAverage.Text = average
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Text = ""
        txtScore2.Text = ""
        txtScore3.Text = ""
        txtScore4.Text = ""
        txtScore5.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
