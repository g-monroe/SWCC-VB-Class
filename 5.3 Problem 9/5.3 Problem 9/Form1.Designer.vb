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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(100, 12)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 0
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(100, 38)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 1
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(100, 64)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(100, 20)
        Me.txtSal.TabIndex = 2
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 90)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(188, 20)
        Me.txtResult.TabIndex = 3
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 116)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(188, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display New Salary"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Location = New System.Drawing.Point(12, 67)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(74, 13)
        Me.lblSal.TabIndex = 5
        Me.lblSal.Text = "Current salary:"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(27, 41)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(59, 13)
        Me.lblLast.TabIndex = 6
        Me.lblLast.Text = "Last name:"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(28, 15)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(58, 13)
        Me.lblFirst.TabIndex = 7
        Me.lblFirst.Text = "First name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 147)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblSal)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtSal)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "Form1"
        Me.Text = "Pay Raise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtSal As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblSal As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblFirst As Label
End Class
