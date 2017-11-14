Public Class Form1

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim dblMPG As Double
        dblMPG = CDbl(txtNumberOfMilesThatCanBeDriven.Text) / CDbl(txtGallonsOfGasThatCanBeHeld.Text)
        lblMPG.Text = dblMPG

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMPG.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
