<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Toss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toss))
        Me.lblTossTitle = New System.Windows.Forms.Label()
        Me.btnThrow = New System.Windows.Forms.Button()
        Me.lblTossResult = New System.Windows.Forms.Label()
        Me.btnHomeBatting = New System.Windows.Forms.Button()
        Me.btnAwayBatting = New System.Windows.Forms.Button()
        Me.lblWhosBatting = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTossTitle
        '
        Me.lblTossTitle.AutoSize = True
        Me.lblTossTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTossTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTossTitle.Location = New System.Drawing.Point(114, 9)
        Me.lblTossTitle.Name = "lblTossTitle"
        Me.lblTossTitle.Size = New System.Drawing.Size(171, 73)
        Me.lblTossTitle.TabIndex = 0
        Me.lblTossTitle.Text = "Toss"
        '
        'btnThrow
        '
        Me.btnThrow.BackColor = System.Drawing.Color.Transparent
        Me.btnThrow.Location = New System.Drawing.Point(115, 115)
        Me.btnThrow.Name = "btnThrow"
        Me.btnThrow.Size = New System.Drawing.Size(170, 65)
        Me.btnThrow.TabIndex = 1
        Me.btnThrow.Text = "Throw!"
        Me.btnThrow.UseVisualStyleBackColor = False
        '
        'lblTossResult
        '
        Me.lblTossResult.AutoSize = True
        Me.lblTossResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTossResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTossResult.Location = New System.Drawing.Point(120, 196)
        Me.lblTossResult.Name = "lblTossResult"
        Me.lblTossResult.Size = New System.Drawing.Size(160, 55)
        Me.lblTossResult.TabIndex = 2
        Me.lblTossResult.Text = "Result"
        '
        'btnHomeBatting
        '
        Me.btnHomeBatting.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeBatting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHomeBatting.Location = New System.Drawing.Point(15, 374)
        Me.btnHomeBatting.Name = "btnHomeBatting"
        Me.btnHomeBatting.Size = New System.Drawing.Size(100, 50)
        Me.btnHomeBatting.TabIndex = 5
        Me.btnHomeBatting.Text = "Home"
        Me.btnHomeBatting.UseVisualStyleBackColor = False
        '
        'btnAwayBatting
        '
        Me.btnAwayBatting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAwayBatting.Location = New System.Drawing.Point(272, 374)
        Me.btnAwayBatting.Name = "btnAwayBatting"
        Me.btnAwayBatting.Size = New System.Drawing.Size(100, 50)
        Me.btnAwayBatting.TabIndex = 6
        Me.btnAwayBatting.Text = "Away"
        Me.btnAwayBatting.UseVisualStyleBackColor = True
        '
        'lblWhosBatting
        '
        Me.lblWhosBatting.AutoSize = True
        Me.lblWhosBatting.BackColor = System.Drawing.Color.Transparent
        Me.lblWhosBatting.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhosBatting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWhosBatting.Location = New System.Drawing.Point(78, 291)
        Me.lblWhosBatting.Name = "lblWhosBatting"
        Me.lblWhosBatting.Size = New System.Drawing.Size(245, 39)
        Me.lblWhosBatting.TabIndex = 7
        Me.lblWhosBatting.Text = "Who's batting?"
        '
        'btnContinue
        '
        Me.btnContinue.BackgroundImage = CType(resources.GetObject("btnContinue.BackgroundImage"), System.Drawing.Image)
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnContinue.Location = New System.Drawing.Point(15, 465)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(356, 82)
        Me.btnContinue.TabIndex = 8
        Me.btnContinue.Text = "Continue to game"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'Toss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblWhosBatting)
        Me.Controls.Add(Me.btnAwayBatting)
        Me.Controls.Add(Me.btnHomeBatting)
        Me.Controls.Add(Me.lblTossResult)
        Me.Controls.Add(Me.btnThrow)
        Me.Controls.Add(Me.lblTossTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTossTitle As Label
    Friend WithEvents btnThrow As Button
    Friend WithEvents lblTossResult As Label
    Friend WithEvents btnHomeBatting As Button
    Friend WithEvents btnAwayBatting As Button
    Friend WithEvents lblWhosBatting As Label
    Friend WithEvents btnContinue As Button
End Class
