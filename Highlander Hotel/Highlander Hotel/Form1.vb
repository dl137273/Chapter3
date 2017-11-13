Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the current time from the system and display it.
        lblTodaysDateAnswer.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTimeAnswer.Text = Now.ToString("T")
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
            lblRoomChargesAnswer.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMisc.Text)
            lbladditionalChargesAnswer.Text = decAddCharges.ToString("c")

            ' Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            ' Calculate and display the tax.
            decTax = decSubtotal * decTAX_RATE
            lblTaxAnswer.Text = decTax.ToString("c")

            ' Calculate and display the total changes.
            decTotal = decSubtotal + decTax
            lblTotalChargesAnswer.Text = decTotal.ToString("c")

            ' Change the colors for the total charges.
            lblTotalChargesAnswer.BackColor = Color.Blue
            lblTotalChargesAnswer.ForeColor = Color.White

        Catch
            ' Error Message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room info fields.
        txtNights.Clear()
        txtNightCharge.Clear()

        ' Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        ' Clear the decTotal fields.
        lblRoomChargesAnswer.Text = String.Empty
        lbladditionalChargesAnswer.Text = String.Empty
        lblSubtotalAnswer.Text = String.Empty
        lblTaxAnswer.Text = String.Empty
        lblTotalChargesAnswer.Text = String.Empty

        ' Get today's date from the operating system and display it.
        txtTodaysDateAnswer.Text = Now.ToString("D")

        ' Get the current time from the operating system and display it.
        txtTimeAnswer.Text = Now.ToString("T")

        ' Reset the lblTotalChargesAnswer control's colors.
        lblTotalChargesAnswer.BackColor = SystemColors.Control
        lblTotalChargesAnswer.ForeColor = SystemColors.ControlText

        ' Reset the focus to the first field.
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
