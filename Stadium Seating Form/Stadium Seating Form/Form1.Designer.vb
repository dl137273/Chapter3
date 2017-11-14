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
        Me.gbTickets = New System.Windows.Forms.GroupBox()
        Me.gbRevenue = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.gbTickets.SuspendLayout()
        Me.gbRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTickets
        '
        Me.gbTickets.Controls.Add(Me.txtClassC)
        Me.gbTickets.Controls.Add(Me.txtClassB)
        Me.gbTickets.Controls.Add(Me.txtClassA)
        Me.gbTickets.Controls.Add(Me.Label7)
        Me.gbTickets.Controls.Add(Me.Label6)
        Me.gbTickets.Controls.Add(Me.Label1)
        Me.gbTickets.Controls.Add(Me.Label3)
        Me.gbTickets.Location = New System.Drawing.Point(32, 26)
        Me.gbTickets.Name = "gbTickets"
        Me.gbTickets.Size = New System.Drawing.Size(237, 245)
        Me.gbTickets.TabIndex = 0
        Me.gbTickets.TabStop = False
        Me.gbTickets.Text = "Tickets Sold"
        '
        'gbRevenue
        '
        Me.gbRevenue.Controls.Add(Me.lblTotal)
        Me.gbRevenue.Controls.Add(Me.lblClassC)
        Me.gbRevenue.Controls.Add(Me.lblClassB)
        Me.gbRevenue.Controls.Add(Me.lblClassA)
        Me.gbRevenue.Controls.Add(Me.Label8)
        Me.gbRevenue.Controls.Add(Me.Label5)
        Me.gbRevenue.Controls.Add(Me.Label4)
        Me.gbRevenue.Controls.Add(Me.Label2)
        Me.gbRevenue.Location = New System.Drawing.Point(314, 26)
        Me.gbRevenue.Name = "gbRevenue"
        Me.gbRevenue.Size = New System.Drawing.Size(237, 245)
        Me.gbRevenue.TabIndex = 1
        Me.gbRevenue.TabStop = False
        Me.gbRevenue.Text = "Revenue Generated"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(47, 322)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(123, 38)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(245, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 38)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(416, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of tickets sold" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for each class of seats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Class A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class A:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class B:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Class C:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Class B:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Class C:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Revenue:"
        '
        'lblClassA
        '
        Me.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA.Location = New System.Drawing.Point(95, 41)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(115, 23)
        Me.lblClassA.TabIndex = 7
        '
        'lblClassB
        '
        Me.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB.Location = New System.Drawing.Point(95, 92)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(115, 23)
        Me.lblClassB.TabIndex = 10
        '
        'lblClassC
        '
        Me.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC.Location = New System.Drawing.Point(95, 139)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(115, 23)
        Me.lblClassC.TabIndex = 11
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(95, 192)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(115, 23)
        Me.lblTotal.TabIndex = 12
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(84, 90)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(113, 20)
        Me.txtClassA.TabIndex = 4
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(84, 137)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(113, 20)
        Me.txtClassB.TabIndex = 7
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(84, 190)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(113, 20)
        Me.txtClassC.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 387)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbRevenue)
        Me.Controls.Add(Me.gbTickets)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.gbTickets.ResumeLayout(False)
        Me.gbTickets.PerformLayout()
        Me.gbRevenue.ResumeLayout(False)
        Me.gbRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTickets As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassC As System.Windows.Forms.TextBox
    Friend WithEvents txtClassB As System.Windows.Forms.TextBox
    Friend WithEvents txtClassA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbRevenue As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblClassC As System.Windows.Forms.Label
    Friend WithEvents lblClassB As System.Windows.Forms.Label
    Friend WithEvents lblClassA As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
