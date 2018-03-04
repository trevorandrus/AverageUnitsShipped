<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lbUnits As System.Windows.Forms.Label
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.lbDaysPassed = New System.Windows.Forms.Label()
        Me.tbPreviousValues = New System.Windows.Forms.TextBox()
        Me.enterToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.resetToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.exitToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.previousentriesToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.entryToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbAverage = New System.Windows.Forms.TextBox()
        lbUnits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbUnits
        '
        lbUnits.AutoSize = True
        lbUnits.Location = New System.Drawing.Point(111, 28)
        lbUnits.Name = "lbUnits"
        lbUnits.Size = New System.Drawing.Size(44, 17)
        lbUnits.TabIndex = 0
        lbUnits.Text = "Units:"
        lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbInput
        '
        Me.tbInput.AccessibleName = "tbInput"
        Me.tbInput.Location = New System.Drawing.Point(161, 28)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(100, 22)
        Me.tbInput.TabIndex = 1
        Me.enterToolTip.SetToolTip(Me.tbInput, "Type a number here to enter it")
        '
        'btnEnter
        '
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnter.Location = New System.Drawing.Point(-1, 310)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(89, 30)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "&Enter"
        Me.enterToolTip.SetToolTip(Me.btnEnter, "Click to save the enterd value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(161, 310)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 29)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.enterToolTip.SetToolTip(Me.btnReset, "Click to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExitForm
        '
        Me.btnExitForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExitForm.Location = New System.Drawing.Point(363, 310)
        Me.btnExitForm.Name = "btnExitForm"
        Me.btnExitForm.Size = New System.Drawing.Size(75, 30)
        Me.btnExitForm.TabIndex = 6
        Me.btnExitForm.Text = "E&xit"
        Me.enterToolTip.SetToolTip(Me.btnExitForm, "Click to exit the form")
        Me.btnExitForm.UseVisualStyleBackColor = True
        '
        'lbDaysPassed
        '
        Me.lbDaysPassed.AutoSize = True
        Me.lbDaysPassed.Location = New System.Drawing.Point(267, 28)
        Me.lbDaysPassed.Name = "lbDaysPassed"
        Me.lbDaysPassed.Size = New System.Drawing.Size(49, 17)
        Me.lbDaysPassed.TabIndex = 5
        Me.lbDaysPassed.Text = "Day: 1"
        Me.lbDaysPassed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbPreviousValues
        '
        Me.tbPreviousValues.Location = New System.Drawing.Point(114, 53)
        Me.tbPreviousValues.Multiline = True
        Me.tbPreviousValues.Name = "tbPreviousValues"
        Me.tbPreviousValues.ReadOnly = True
        Me.tbPreviousValues.Size = New System.Drawing.Size(186, 186)
        Me.tbPreviousValues.TabIndex = 2
        Me.enterToolTip.SetToolTip(Me.tbPreviousValues, "All previous numbers entered")
        '
        'tbAverage
        '
        Me.tbAverage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tbAverage.Location = New System.Drawing.Point(114, 246)
        Me.tbAverage.Name = "tbAverage"
        Me.tbAverage.ReadOnly = True
        Me.tbAverage.Size = New System.Drawing.Size(186, 22)
        Me.tbAverage.TabIndex = 3
        Me.tbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.enterToolTip.SetToolTip(Me.tbAverage, "Average of entered numbers for the week")
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(433, 338)
        Me.Controls.Add(Me.tbAverage)
        Me.Controls.Add(Me.tbPreviousValues)
        Me.Controls.Add(Me.lbDaysPassed)
        Me.Controls.Add(lbUnits)
        Me.Controls.Add(Me.btnExitForm)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbInput As TextBox
    Protected WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExitForm As Button
    Friend WithEvents lbDaysPassed As Label
    Friend WithEvents tbPreviousValues As TextBox
    Friend WithEvents enterToolTip As ToolTip
    Friend WithEvents resetToolTip As ToolTip
    Friend WithEvents exitToolTip As ToolTip
    Friend WithEvents previousentriesToolTip As ToolTip
    Friend WithEvents entryToolTip As ToolTip
    Friend WithEvents tbAverage As TextBox
End Class
