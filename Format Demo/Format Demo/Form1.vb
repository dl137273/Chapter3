Public Class Form1

    Private Sub btnNumberFormat_Click(sender As Object, e As EventArgs) Handles btnNumberFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("n")
        lblResult.Text = strResult
    End Sub

    Private Sub btnFixedPointFormat_Click(sender As Object, e As EventArgs) Handles btnFixedPointFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("f")
        lblResult.Text = strResult
    End Sub

    Private Sub btnExponentialFormat_Click(sender As Object, e As EventArgs) Handles btnExponentialFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("e")
        lblResult.Text = strResult
    End Sub

    Private Sub btnCurrenctFormat_Click(sender As Object, e As EventArgs) Handles btnCurrenctFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("c")
        lblResult.Text = strResult
    End Sub

    Private Sub btnPercentFormat_Click(sender As Object, e As EventArgs) Handles btnPercentFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("p")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortDate_Click(sender As Object, e As EventArgs) Handles btnShortDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("d")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongDate_Click(sender As Object, e As EventArgs) Handles btnLongDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("D")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortTime_Click(sender As Object, e As EventArgs) Handles btnShortTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("t")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongTime_Click(sender As Object, e As EventArgs) Handles btnLongTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("T")
        lblResult.Text = strResult
    End Sub

    Private Sub btnFullDateTime_Click(sender As Object, e As EventArgs) Handles btnFullDateTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("F")
        lblResult.Text = strResult
    End Sub
End Class
