<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalculateCharges = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHighlanderHotel = New System.Windows.Forms.Label()
        Me.gbRoomInformation = New System.Windows.Forms.GroupBox()
        Me.txtNightCharge = New System.Windows.Forms.TextBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblNightlyCharge = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.gbAdditionalCharges = New System.Windows.Forms.GroupBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTodaysDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblAdditionalCharges = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.lblRoomChangesAnswer = New System.Windows.Forms.Label()
        Me.gbTotalCharges = New System.Windows.Forms.GroupBox()
        Me.lbladditionalChangesAnswer = New System.Windows.Forms.Label()
        Me.lblSubtotalAnswer = New System.Windows.Forms.Label()
        Me.lblTotalChangesAnswer = New System.Windows.Forms.Label()
        Me.lblTaxAnswer = New System.Windows.Forms.Label()
        Me.txtTodaysDateAnswer = New System.Windows.Forms.TextBox()
        Me.txtTimeAnswer = New System.Windows.Forms.TextBox()
        Me.gbRoomInformation.SuspendLayout()
        Me.gbAdditionalCharges.SuspendLayout()
        Me.gbTotalCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculateCharges
        '
        Me.btnCalculateCharges.Location = New System.Drawing.Point(44, 406)
        Me.btnCalculateCharges.Name = "btnCalculateCharges"
        Me.btnCalculateCharges.Size = New System.Drawing.Size(112, 23)
        Me.btnCalculateCharges.TabIndex = 0
        Me.btnCalculateCharges.Text = "Caculate Charges"
        Me.btnCalculateCharges.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(219, 406)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHighlanderHotel
        '
        Me.lblHighlanderHotel.AutoSize = True
        Me.lblHighlanderHotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighlanderHotel.Location = New System.Drawing.Point(132, 9)
        Me.lblHighlanderHotel.Name = "lblHighlanderHotel"
        Me.lblHighlanderHotel.Size = New System.Drawing.Size(188, 25)
        Me.lblHighlanderHotel.TabIndex = 3
        Me.lblHighlanderHotel.Text = "Highlander Hotel"
        '
        'gbRoomInformation
        '
        Me.gbRoomInformation.Controls.Add(Me.txtNightCharge)
        Me.gbRoomInformation.Controls.Add(Me.txtNights)
        Me.gbRoomInformation.Controls.Add(Me.lblNightlyCharge)
        Me.gbRoomInformation.Controls.Add(Me.lblNights)
        Me.gbRoomInformation.Location = New System.Drawing.Point(28, 101)
        Me.gbRoomInformation.Name = "gbRoomInformation"
        Me.gbRoomInformation.Size = New System.Drawing.Size(200, 100)
        Me.gbRoomInformation.TabIndex = 9
        Me.gbRoomInformation.TabStop = False
        Me.gbRoomInformation.Text = "Room Information"
        '
        'txtNightCharge
        '
        Me.txtNightCharge.Location = New System.Drawing.Point(114, 59)
        Me.txtNightCharge.Name = "txtNightCharge"
        Me.txtNightCharge.Size = New System.Drawing.Size(80, 20)
        Me.txtNightCharge.TabIndex = 13
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(114, 25)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(80, 20)
        Me.txtNights.TabIndex = 12
        '
        'lblNightlyCharge
        '
        Me.lblNightlyCharge.AutoSize = True
        Me.lblNightlyCharge.Location = New System.Drawing.Point(38, 62)
        Me.lblNightlyCharge.Name = "lblNightlyCharge"
        Me.lblNightlyCharge.Size = New System.Drawing.Size(79, 13)
        Me.lblNightlyCharge.TabIndex = 1
        Me.lblNightlyCharge.Text = "Nightly Charge:"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Location = New System.Drawing.Point(68, 28)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(40, 13)
        Me.lblNights.TabIndex = 0
        Me.lblNights.Text = "Nights:"
        '
        'gbAdditionalCharges
        '
        Me.gbAdditionalCharges.Controls.Add(Me.txtMisc)
        Me.gbAdditionalCharges.Controls.Add(Me.txtTelephone)
        Me.gbAdditionalCharges.Controls.Add(Me.txtRoomService)
        Me.gbAdditionalCharges.Controls.Add(Me.Label10)
        Me.gbAdditionalCharges.Controls.Add(Me.Label9)
        Me.gbAdditionalCharges.Controls.Add(Me.Label8)
        Me.gbAdditionalCharges.Location = New System.Drawing.Point(251, 101)
        Me.gbAdditionalCharges.Name = "gbAdditionalCharges"
        Me.gbAdditionalCharges.Size = New System.Drawing.Size(200, 100)
        Me.gbAdditionalCharges.TabIndex = 10
        Me.gbAdditionalCharges.TabStop = False
        Me.gbAdditionalCharges.Text = "Additional Charges"
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(107, 72)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(68, 20)
        Me.txtMisc.TabIndex = 16
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(107, 42)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(68, 20)
        Me.txtTelephone.TabIndex = 15
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(107, 13)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(68, 20)
        Me.txtRoomService.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Misc:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Telephone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Room Service:"
        '
        'lblTodaysDate
        '
        Me.lblTodaysDate.AutoSize = True
        Me.lblTodaysDate.Location = New System.Drawing.Point(94, 48)
        Me.lblTodaysDate.Name = "lblTodaysDate"
        Me.lblTodaysDate.Size = New System.Drawing.Size(73, 13)
        Me.lblTodaysDate.TabIndex = 5
        Me.lblTodaysDate.Text = "Today's Date:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(134, 75)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Time:"
        '
        'lblAdditionalCharges
        '
        Me.lblAdditionalCharges.AutoSize = True
        Me.lblAdditionalCharges.Location = New System.Drawing.Point(95, 43)
        Me.lblAdditionalCharges.Name = "lblAdditionalCharges"
        Me.lblAdditionalCharges.Size = New System.Drawing.Size(98, 13)
        Me.lblAdditionalCharges.TabIndex = 5
        Me.lblAdditionalCharges.Text = "Additional Charges:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(147, 75)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.AutoSize = True
        Me.lblTotalCharges.Location = New System.Drawing.Point(117, 135)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(76, 13)
        Me.lblTotalCharges.TabIndex = 8
        Me.lblTotalCharges.Text = "Total Charges:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(168, 105)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 7
        Me.lblTax.Text = "Tax:"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.AutoSize = True
        Me.lblRoomCharges.Location = New System.Drawing.Point(113, 16)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(80, 13)
        Me.lblRoomCharges.TabIndex = 4
        Me.lblRoomCharges.Text = "Room Charges:"
        '
        'lblRoomChangesAnswer
        '
        Me.lblRoomChangesAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomChangesAnswer.Location = New System.Drawing.Point(202, 15)
        Me.lblRoomChangesAnswer.Name = "lblRoomChangesAnswer"
        Me.lblRoomChangesAnswer.Size = New System.Drawing.Size(88, 21)
        Me.lblRoomChangesAnswer.TabIndex = 9
        '
        'gbTotalCharges
        '
        Me.gbTotalCharges.Controls.Add(Me.lbladditionalChangesAnswer)
        Me.gbTotalCharges.Controls.Add(Me.lblSubtotalAnswer)
        Me.gbTotalCharges.Controls.Add(Me.lblTotalChangesAnswer)
        Me.gbTotalCharges.Controls.Add(Me.lblTaxAnswer)
        Me.gbTotalCharges.Controls.Add(Me.lblRoomChangesAnswer)
        Me.gbTotalCharges.Controls.Add(Me.lblRoomCharges)
        Me.gbTotalCharges.Controls.Add(Me.lblTax)
        Me.gbTotalCharges.Controls.Add(Me.lblTotalCharges)
        Me.gbTotalCharges.Controls.Add(Me.lblSubtotal)
        Me.gbTotalCharges.Controls.Add(Me.lblAdditionalCharges)
        Me.gbTotalCharges.Location = New System.Drawing.Point(69, 221)
        Me.gbTotalCharges.Name = "gbTotalCharges"
        Me.gbTotalCharges.Size = New System.Drawing.Size(332, 164)
        Me.gbTotalCharges.TabIndex = 9
        Me.gbTotalCharges.TabStop = False
        Me.gbTotalCharges.Text = "Total Charges"
        '
        'lbladditionalChangesAnswer
        '
        Me.lbladditionalChangesAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbladditionalChangesAnswer.Location = New System.Drawing.Point(202, 42)
        Me.lbladditionalChangesAnswer.Name = "lbladditionalChangesAnswer"
        Me.lbladditionalChangesAnswer.Size = New System.Drawing.Size(88, 21)
        Me.lbladditionalChangesAnswer.TabIndex = 13
        '
        'lblSubtotalAnswer
        '
        Me.lblSubtotalAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotalAnswer.Location = New System.Drawing.Point(202, 74)
        Me.lblSubtotalAnswer.Name = "lblSubtotalAnswer"
        Me.lblSubtotalAnswer.Size = New System.Drawing.Size(88, 21)
        Me.lblSubtotalAnswer.TabIndex = 12
        '
        'lblTotalChangesAnswer
        '
        Me.lblTotalChangesAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalChangesAnswer.Location = New System.Drawing.Point(202, 134)
        Me.lblTotalChangesAnswer.Name = "lblTotalChangesAnswer"
        Me.lblTotalChangesAnswer.Size = New System.Drawing.Size(88, 21)
        Me.lblTotalChangesAnswer.TabIndex = 11
        '
        'lblTaxAnswer
        '
        Me.lblTaxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxAnswer.Location = New System.Drawing.Point(202, 104)
        Me.lblTaxAnswer.Name = "lblTaxAnswer"
        Me.lblTaxAnswer.Size = New System.Drawing.Size(88, 21)
        Me.lblTaxAnswer.TabIndex = 10
        '
        'txtTodaysDateAnswer
        '
        Me.txtTodaysDateAnswer.Location = New System.Drawing.Point(173, 48)
        Me.txtTodaysDateAnswer.Name = "txtTodaysDateAnswer"
        Me.txtTodaysDateAnswer.Size = New System.Drawing.Size(238, 20)
        Me.txtTodaysDateAnswer.TabIndex = 14
        '
        'txtTimeAnswer
        '
        Me.txtTimeAnswer.Location = New System.Drawing.Point(173, 75)
        Me.txtTimeAnswer.Name = "txtTimeAnswer"
        Me.txtTimeAnswer.Size = New System.Drawing.Size(238, 20)
        Me.txtTimeAnswer.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 460)
        Me.Controls.Add(Me.txtTimeAnswer)
        Me.Controls.Add(Me.txtTodaysDateAnswer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTodaysDate)
        Me.Controls.Add(Me.gbAdditionalCharges)
        Me.Controls.Add(Me.gbRoomInformation)
        Me.Controls.Add(Me.gbTotalCharges)
        Me.Controls.Add(Me.lblHighlanderHotel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCharges)
        Me.Name = "Form1"
        Me.Text = "Room Charge Calculator"
        Me.gbRoomInformation.ResumeLayout(False)
        Me.gbRoomInformation.PerformLayout()
        Me.gbAdditionalCharges.ResumeLayout(False)
        Me.gbAdditionalCharges.PerformLayout()
        Me.gbTotalCharges.ResumeLayout(False)
        Me.gbTotalCharges.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculateCharges As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblHighlanderHotel As System.Windows.Forms.Label
    Friend WithEvents gbRoomInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblNightlyCharge As System.Windows.Forms.Label
    Friend WithEvents lblNights As System.Windows.Forms.Label
    Friend WithEvents gbAdditionalCharges As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNightCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents lblTodaysDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalCharges As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents lblRoomChangesAnswer As System.Windows.Forms.Label
    Friend WithEvents gbTotalCharges As System.Windows.Forms.GroupBox
    Friend WithEvents lbladditionalChangesAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalAnswer As System.Windows.Forms.Label
    Friend WithEvents lblTotalChangesAnswer As System.Windows.Forms.Label
    Friend WithEvents lblTaxAnswer As System.Windows.Forms.Label
    Friend WithEvents txtTodaysDateAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeAnswer As System.Windows.Forms.TextBox

End Class
