Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the current time from the system and display it.
        lblTodaysDate.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal       ' Room charges total
        Dim decAddCharges As Decimal        ' Additional charges
        Dim decSubtotal As Decimal          ' Subtotal
        Dim decTax As Decimal               ' Tax
        Dim decTotal As Decimal             ' Total of all charges
        Dim decTAX_RATE As Decimal = 0.08D  ' Tax rate

        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightCharge.Text)
            lblRoomChangesAnswer.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMisc.Text)
            lbladditionalChangesAnswer.Text = decAddCharges.ToString("c")

        Catch ex As Exception

        End Try
    End Sub
End Class
