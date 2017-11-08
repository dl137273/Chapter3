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
        Me.lblEnterYourFirstName = New System.Windows.Forms.Label()
        Me.lblEnterYourLastName = New System.Windows.Forms.Label()
        Me.lblThisIsYourFullName = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnShowName = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterYourFirstName
        '
        Me.lblEnterYourFirstName.AutoSize = True
        Me.lblEnterYourFirstName.Location = New System.Drawing.Point(48, 30)
        Me.lblEnterYourFirstName.Name = "lblEnterYourFirstName"
        Me.lblEnterYourFirstName.Size = New System.Drawing.Size(106, 13)
        Me.lblEnterYourFirstName.TabIndex = 0
        Me.lblEnterYourFirstName.Text = "Enter your first name:"
        '
        'lblEnterYourLastName
        '
        Me.lblEnterYourLastName.AutoSize = True
        Me.lblEnterYourLastName.Location = New System.Drawing.Point(48, 65)
        Me.lblEnterYourLastName.Name = "lblEnterYourLastName"
        Me.lblEnterYourLastName.Size = New System.Drawing.Size(106, 13)
        Me.lblEnterYourLastName.TabIndex = 1
        Me.lblEnterYourLastName.Text = "Enter your last name:"
        '
        'lblThisIsYourFullName
        '
        Me.lblThisIsYourFullName.AutoSize = True
        Me.lblThisIsYourFullName.Location = New System.Drawing.Point(48, 147)
        Me.lblThisIsYourFullName.Name = "lblThisIsYourFullName"
        Me.lblThisIsYourFullName.Size = New System.Drawing.Size(108, 13)
        Me.lblThisIsYourFullName.TabIndex = 2
        Me.lblThisIsYourFullName.Text = "This is your full name:"
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullName.Location = New System.Drawing.Point(186, 133)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(146, 27)
        Me.lblFullName.TabIndex = 3
        '
        'btnShowName
        '
        Me.btnShowName.Location = New System.Drawing.Point(26, 213)
        Me.btnShowName.Name = "btnShowName"
        Me.btnShowName.Size = New System.Drawing.Size(75, 23)
        Me.btnShowName.TabIndex = 4
        Me.btnShowName.Text = "Show Name"
        Me.btnShowName.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(208, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(208, 65)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 7
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(257, 213)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 324)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblThisIsYourFullName)
        Me.Controls.Add(Me.lblEnterYourLastName)
        Me.Controls.Add(Me.lblEnterYourFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterYourFirstName As System.Windows.Forms.Label
    Friend WithEvents lblEnterYourLastName As System.Windows.Forms.Label
    Friend WithEvents lblThisIsYourFullName As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents btnShowName As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button

End Class
