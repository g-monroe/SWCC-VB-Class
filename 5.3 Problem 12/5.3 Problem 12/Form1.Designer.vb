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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.txtWorked = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtResultPay = New System.Windows.Forms.TextBox()
        Me.lblWorked = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblResultPay = New System.Windows.Forms.Label()
        Me.lblOver = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 64)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(186, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Caclutate Hours and Pay"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(98, 38)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(100, 20)
        Me.txtPay.TabIndex = 1
        '
        'txtWorked
        '
        Me.txtWorked.Location = New System.Drawing.Point(98, 12)
        Me.txtWorked.Name = "txtWorked"
        Me.txtWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtWorked.TabIndex = 2
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(98, 93)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.ReadOnly = True
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 3
        '
        'txtResultPay
        '
        Me.txtResultPay.Location = New System.Drawing.Point(98, 119)
        Me.txtResultPay.Name = "txtResultPay"
        Me.txtResultPay.ReadOnly = True
        Me.txtResultPay.Size = New System.Drawing.Size(100, 20)
        Me.txtResultPay.TabIndex = 4
        '
        'lblWorked
        '
        Me.lblWorked.AutoSize = True
        Me.lblWorked.Location = New System.Drawing.Point(12, 15)
        Me.lblWorked.Name = "lblWorked"
        Me.lblWorked.Size = New System.Drawing.Size(76, 13)
        Me.lblWorked.TabIndex = 5
        Me.lblWorked.Text = "Hours worked:"
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Location = New System.Drawing.Point(32, 41)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(60, 13)
        Me.lblPay.TabIndex = 6
        Me.lblPay.Text = "Hourly pay:"
        '
        'lblResultPay
        '
        Me.lblResultPay.AutoSize = True
        Me.lblResultPay.Location = New System.Drawing.Point(28, 122)
        Me.lblResultPay.Name = "lblResultPay"
        Me.lblResultPay.Size = New System.Drawing.Size(65, 13)
        Me.lblResultPay.TabIndex = 8
        Me.lblResultPay.Text = "Weeks Pay:"
        '
        'lblOver
        '
        Me.lblOver.AutoSize = True
        Me.lblOver.Location = New System.Drawing.Point(9, 96)
        Me.lblOver.Name = "lblOver"
        Me.lblOver.Size = New System.Drawing.Size(87, 13)
        Me.lblOver.TabIndex = 7
        Me.lblOver.Text = "OverTime Hours:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 156)
        Me.Controls.Add(Me.lblResultPay)
        Me.Controls.Add(Me.lblOver)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblWorked)
        Me.Controls.Add(Me.txtResultPay)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtWorked)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Weekly Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPay As TextBox
    Friend WithEvents txtWorked As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtResultPay As TextBox
    Friend WithEvents lblWorked As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents lblResultPay As Label
    Friend WithEvents lblOver As Label
End Class
