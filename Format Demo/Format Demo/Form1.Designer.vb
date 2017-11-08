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
        Me.lblEnterANumberOrDate = New System.Windows.Forms.Label()
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.btnCurrenctFormat = New System.Windows.Forms.Button()
        Me.btnExponentialFormat = New System.Windows.Forms.Button()
        Me.btnFixedPointFormat = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterANumberOrDate
        '
        Me.lblEnterANumberOrDate.AutoSize = True
        Me.lblEnterANumberOrDate.Location = New System.Drawing.Point(24, 30)
        Me.lblEnterANumberOrDate.Name = "lblEnterANumberOrDate"
        Me.lblEnterANumberOrDate.Size = New System.Drawing.Size(115, 13)
        Me.lblEnterANumberOrDate.TabIndex = 0
        Me.lblEnterANumberOrDate.Text = "Enter a number or date"
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Location = New System.Drawing.Point(24, 93)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(54, 13)
        Me.lblFormatted.TabIndex = 1
        Me.lblFormatted.Text = "Formatted"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.btnPercentFormat)
        Me.GroupBox1.Controls.Add(Me.btnCurrenctFormat)
        Me.GroupBox1.Controls.Add(Me.btnExponentialFormat)
        Me.GroupBox1.Controls.Add(Me.btnFixedPointFormat)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 177)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(261, 132)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(105, 23)
        Me.btnFullDateTime.TabIndex = 9
        Me.btnFullDateTime.Text = "Full Date/Time (F)"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(261, 103)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(105, 23)
        Me.btnLongTime.TabIndex = 8
        Me.btnLongTime.Text = "Long Time (T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(261, 74)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(105, 23)
        Me.btnShortTime.TabIndex = 7
        Me.btnShortTime.Text = "Short Time (t)"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(261, 45)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(105, 23)
        Me.btnLongDate.TabIndex = 6
        Me.btnLongDate.Text = "Long Date (D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(261, 16)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(105, 23)
        Me.btnShortDate.TabIndex = 5
        Me.btnShortDate.Text = "Short date (d)"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(3, 132)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(148, 25)
        Me.btnPercentFormat.TabIndex = 4
        Me.btnPercentFormat.Text = "Percent Format (p)"
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'btnCurrenctFormat
        '
        Me.btnCurrenctFormat.Location = New System.Drawing.Point(3, 103)
        Me.btnCurrenctFormat.Name = "btnCurrenctFormat"
        Me.btnCurrenctFormat.Size = New System.Drawing.Size(148, 23)
        Me.btnCurrenctFormat.TabIndex = 3
        Me.btnCurrenctFormat.Text = "Currency Format (c)"
        Me.btnCurrenctFormat.UseVisualStyleBackColor = True
        '
        'btnExponentialFormat
        '
        Me.btnExponentialFormat.Location = New System.Drawing.Point(3, 74)
        Me.btnExponentialFormat.Name = "btnExponentialFormat"
        Me.btnExponentialFormat.Size = New System.Drawing.Size(148, 23)
        Me.btnExponentialFormat.TabIndex = 2
        Me.btnExponentialFormat.Text = "Exponential format (e)"
        Me.btnExponentialFormat.UseVisualStyleBackColor = True
        '
        'btnFixedPointFormat
        '
        Me.btnFixedPointFormat.Location = New System.Drawing.Point(3, 45)
        Me.btnFixedPointFormat.Name = "btnFixedPointFormat"
        Me.btnFixedPointFormat.Size = New System.Drawing.Size(148, 23)
        Me.btnFixedPointFormat.TabIndex = 1
        Me.btnFixedPointFormat.Text = "Fixed-point format (f)"
        Me.btnFixedPointFormat.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(3, 16)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(148, 23)
        Me.btnNumberFormat.TabIndex = 0
        Me.btnNumberFormat.Text = "Number format (n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(207, 93)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(185, 26)
        Me.lblResult.TabIndex = 3
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(207, 30)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtUserEntry.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(510, 396)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.lblEnterANumberOrDate)
        Me.Name = "Form1"
        Me.Text = "Format Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterANumberOrDate As System.Windows.Forms.Label
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnCurrenctFormat As System.Windows.Forms.Button
    Friend WithEvents btnExponentialFormat As System.Windows.Forms.Button
    Friend WithEvents btnFixedPointFormat As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtUserEntry As System.Windows.Forms.TextBox

End Class
