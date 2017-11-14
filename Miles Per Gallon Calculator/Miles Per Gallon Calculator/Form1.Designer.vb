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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.txtGallonsOfGasThatCanBeHeld = New System.Windows.Forms.TextBox()
        Me.txtNumberOfMilesThatCanBeDriven = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons of gas the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "car can hold:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can be driven on a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "full tank:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Miles per gallon"
        '
        'btnCalculateMPG
        '
        Me.btnCalculateMPG.Location = New System.Drawing.Point(41, 270)
        Me.btnCalculateMPG.Name = "btnCalculateMPG"
        Me.btnCalculateMPG.Size = New System.Drawing.Size(86, 34)
        Me.btnCalculateMPG.TabIndex = 3
        Me.btnCalculateMPG.Text = "Calculate MPG"
        Me.btnCalculateMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(198, 270)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(355, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMPG
        '
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMPG.Location = New System.Drawing.Point(198, 191)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(143, 26)
        Me.lblMPG.TabIndex = 6
        '
        'txtGallonsOfGasThatCanBeHeld
        '
        Me.txtGallonsOfGasThatCanBeHeld.Location = New System.Drawing.Point(198, 43)
        Me.txtGallonsOfGasThatCanBeHeld.Name = "txtGallonsOfGasThatCanBeHeld"
        Me.txtGallonsOfGasThatCanBeHeld.Size = New System.Drawing.Size(143, 20)
        Me.txtGallonsOfGasThatCanBeHeld.TabIndex = 7
        '
        'txtNumberOfMilesThatCanBeDriven
        '
        Me.txtNumberOfMilesThatCanBeDriven.Location = New System.Drawing.Point(198, 127)
        Me.txtNumberOfMilesThatCanBeDriven.Name = "txtNumberOfMilesThatCanBeDriven"
        Me.txtNumberOfMilesThatCanBeDriven.Size = New System.Drawing.Size(143, 20)
        Me.txtNumberOfMilesThatCanBeDriven.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 338)
        Me.Controls.Add(Me.txtNumberOfMilesThatCanBeDriven)
        Me.Controls.Add(Me.txtGallonsOfGasThatCanBeHeld)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateMPG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateMPG As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMPG As System.Windows.Forms.Label
    Friend WithEvents txtGallonsOfGasThatCanBeHeld As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfMilesThatCanBeDriven As System.Windows.Forms.TextBox

End Class
