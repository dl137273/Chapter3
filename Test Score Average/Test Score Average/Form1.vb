Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAverage As Decimal
        lblAverage = CDec((txtScore1.Text) + CDec(txtScore2.Text) + CDec(txtScore3.Text) + CDec(txtScore4.Text) + CDec(txtScore5.Text)) / 5

        lblAverage.Text = decAverage
    End Sub
End Class
