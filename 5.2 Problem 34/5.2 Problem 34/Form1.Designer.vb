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
        Me.components = New System.ComponentModel.Container()
        Me.txtOcc = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.txtTip = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblOcc = New System.Windows.Forms.Label()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.lblTip = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOcc
        '
        Me.txtOcc.Location = New System.Drawing.Point(124, 19)
        Me.txtOcc.Name = "txtOcc"
        Me.txtOcc.Size = New System.Drawing.Size(76, 20)
        Me.txtOcc.TabIndex = 0
        '
        'txtBill
        '
        Me.txtBill.Location = New System.Drawing.Point(124, 45)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(76, 20)
        Me.txtBill.TabIndex = 1
        '
        'txtTip
        '
        Me.txtTip.Location = New System.Drawing.Point(124, 71)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.Size = New System.Drawing.Size(76, 20)
        Me.txtTip.TabIndex = 2
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(15, 97)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(185, 20)
        Me.txtResult.TabIndex = 3
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(15, 125)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(185, 23)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Compute Tip"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblOcc
        '
        Me.lblOcc.AutoSize = True
        Me.lblOcc.Location = New System.Drawing.Point(12, 22)
        Me.lblOcc.Name = "lblOcc"
        Me.lblOcc.Size = New System.Drawing.Size(106, 13)
        Me.lblOcc.TabIndex = 5
        Me.lblOcc.Text = "Person's occupation:"
        '
        'lblBill
        '
        Me.lblBill.AutoSize = True
        Me.lblBill.Location = New System.Drawing.Point(12, 48)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(91, 13)
        Me.lblBill.TabIndex = 6
        Me.lblBill.Tag = ""
        Me.lblBill.Text = "Amount of the bill:"
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.Location = New System.Drawing.Point(12, 74)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(79, 13)
        Me.lblTip.TabIndex = 7
        Me.lblTip.Text = "Percentage tip:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 159)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lblBill)
        Me.Controls.Add(Me.lblOcc)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtTip)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.txtOcc)
        Me.Name = "Form1"
        Me.Text = "Gratuities"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOcc As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents txtBill As TextBox
    Friend WithEvents txtTip As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblOcc As Label
    Friend WithEvents lblBill As Label
    Friend WithEvents lblTip As Label
End Class
