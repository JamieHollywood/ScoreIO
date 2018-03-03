<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpExtras
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
        Me.btnWides = New System.Windows.Forms.Button()
        Me.btnNoBall = New System.Windows.Forms.Button()
        Me.btnBye = New System.Windows.Forms.Button()
        Me.btnLegBye = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxExtas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnWides
        '
        Me.btnWides.Location = New System.Drawing.Point(12, 12)
        Me.btnWides.Name = "btnWides"
        Me.btnWides.Size = New System.Drawing.Size(100, 100)
        Me.btnWides.TabIndex = 0
        Me.btnWides.Text = "Wide"
        Me.btnWides.UseVisualStyleBackColor = True
        '
        'btnNoBall
        '
        Me.btnNoBall.Location = New System.Drawing.Point(172, 12)
        Me.btnNoBall.Name = "btnNoBall"
        Me.btnNoBall.Size = New System.Drawing.Size(100, 100)
        Me.btnNoBall.TabIndex = 1
        Me.btnNoBall.Text = "No Ball"
        Me.btnNoBall.UseVisualStyleBackColor = True
        '
        'btnBye
        '
        Me.btnBye.Location = New System.Drawing.Point(12, 150)
        Me.btnBye.Name = "btnBye"
        Me.btnBye.Size = New System.Drawing.Size(100, 100)
        Me.btnBye.TabIndex = 2
        Me.btnBye.Text = "Bye"
        Me.btnBye.UseVisualStyleBackColor = True
        '
        'btnLegBye
        '
        Me.btnLegBye.Location = New System.Drawing.Point(172, 150)
        Me.btnLegBye.Name = "btnLegBye"
        Me.btnLegBye.Size = New System.Drawing.Size(100, 100)
        Me.btnLegBye.TabIndex = 3
        Me.btnLegBye.Text = "Leg Bye"
        Me.btnLegBye.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Runs:"
        '
        'txtboxExtas
        '
        Me.txtboxExtas.Location = New System.Drawing.Point(150, 121)
        Me.txtboxExtas.Name = "txtboxExtas"
        Me.txtboxExtas.Size = New System.Drawing.Size(48, 20)
        Me.txtboxExtas.TabIndex = 5
        '
        'PopUpExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtboxExtas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLegBye)
        Me.Controls.Add(Me.btnBye)
        Me.Controls.Add(Me.btnNoBall)
        Me.Controls.Add(Me.btnWides)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopUpExtras"
        Me.Text = "PopUpExtras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWides As Button
    Friend WithEvents btnNoBall As Button
    Friend WithEvents btnBye As Button
    Friend WithEvents btnLegBye As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxExtas As TextBox
End Class
