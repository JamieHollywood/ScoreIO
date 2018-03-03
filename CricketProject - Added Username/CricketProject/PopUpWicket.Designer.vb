<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopUpWicket
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
        Me.btnBowled = New System.Windows.Forms.Button()
        Me.btnCaught = New System.Windows.Forms.Button()
        Me.btnLBW = New System.Windows.Forms.Button()
        Me.btnCaughtBehind = New System.Windows.Forms.Button()
        Me.btnStumped = New System.Windows.Forms.Button()
        Me.btnHitWicket = New System.Windows.Forms.Button()
        Me.btnRanOut = New System.Windows.Forms.Button()
        Me.btnRetired = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBatName = New System.Windows.Forms.Label()
        Me.lblBatOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBowled
        '
        Me.btnBowled.Location = New System.Drawing.Point(15, 39)
        Me.btnBowled.Name = "btnBowled"
        Me.btnBowled.Size = New System.Drawing.Size(100, 100)
        Me.btnBowled.TabIndex = 1
        Me.btnBowled.Text = "Bowled"
        Me.btnBowled.UseVisualStyleBackColor = True
        '
        'btnCaught
        '
        Me.btnCaught.Location = New System.Drawing.Point(172, 39)
        Me.btnCaught.Name = "btnCaught"
        Me.btnCaught.Size = New System.Drawing.Size(100, 100)
        Me.btnCaught.TabIndex = 2
        Me.btnCaught.Text = "Caught"
        Me.btnCaught.UseVisualStyleBackColor = True
        '
        'btnLBW
        '
        Me.btnLBW.Location = New System.Drawing.Point(15, 178)
        Me.btnLBW.Name = "btnLBW"
        Me.btnLBW.Size = New System.Drawing.Size(100, 100)
        Me.btnLBW.TabIndex = 3
        Me.btnLBW.Text = "LBW"
        Me.btnLBW.UseVisualStyleBackColor = True
        '
        'btnCaughtBehind
        '
        Me.btnCaughtBehind.Location = New System.Drawing.Point(172, 178)
        Me.btnCaughtBehind.Name = "btnCaughtBehind"
        Me.btnCaughtBehind.Size = New System.Drawing.Size(100, 100)
        Me.btnCaughtBehind.TabIndex = 4
        Me.btnCaughtBehind.Text = "Caught Behind"
        Me.btnCaughtBehind.UseVisualStyleBackColor = True
        '
        'btnStumped
        '
        Me.btnStumped.Location = New System.Drawing.Point(12, 454)
        Me.btnStumped.Name = "btnStumped"
        Me.btnStumped.Size = New System.Drawing.Size(100, 100)
        Me.btnStumped.TabIndex = 5
        Me.btnStumped.Text = "Stumped"
        Me.btnStumped.UseVisualStyleBackColor = True
        '
        'btnHitWicket
        '
        Me.btnHitWicket.BackColor = System.Drawing.Color.Transparent
        Me.btnHitWicket.Location = New System.Drawing.Point(172, 454)
        Me.btnHitWicket.Name = "btnHitWicket"
        Me.btnHitWicket.Size = New System.Drawing.Size(100, 100)
        Me.btnHitWicket.TabIndex = 6
        Me.btnHitWicket.Text = "Hit Wicket"
        Me.btnHitWicket.UseVisualStyleBackColor = False
        '
        'btnRanOut
        '
        Me.btnRanOut.Location = New System.Drawing.Point(12, 320)
        Me.btnRanOut.Name = "btnRanOut"
        Me.btnRanOut.Size = New System.Drawing.Size(100, 100)
        Me.btnRanOut.TabIndex = 7
        Me.btnRanOut.Text = "Ran Out"
        Me.btnRanOut.UseVisualStyleBackColor = True
        '
        'btnRetired
        '
        Me.btnRetired.Location = New System.Drawing.Point(172, 320)
        Me.btnRetired.Name = "btnRetired"
        Me.btnRetired.Size = New System.Drawing.Size(100, 100)
        Me.btnRetired.TabIndex = 8
        Me.btnRetired.Text = "Retired"
        Me.btnRetired.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(56, 18)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Name: "
        '
        'lblBatName
        '
        Me.lblBatName.AutoSize = True
        Me.lblBatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatName.Location = New System.Drawing.Point(90, 9)
        Me.lblBatName.Name = "lblBatName"
        Me.lblBatName.Size = New System.Drawing.Size(133, 18)
        Me.lblBatName.TabIndex = 10
        Me.lblBatName.Text = "Batsman out name"
        '
        'lblBatOrder
        '
        Me.lblBatOrder.AutoSize = True
        Me.lblBatOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatOrder.Location = New System.Drawing.Point(252, 9)
        Me.lblBatOrder.Name = "lblBatOrder"
        Me.lblBatOrder.Size = New System.Drawing.Size(20, 18)
        Me.lblBatOrder.TabIndex = 11
        Me.lblBatOrder.Text = "**"
        '
        'PopUpWicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(284, 562)
        Me.Controls.Add(Me.lblBatOrder)
        Me.Controls.Add(Me.lblBatName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRetired)
        Me.Controls.Add(Me.btnRanOut)
        Me.Controls.Add(Me.btnHitWicket)
        Me.Controls.Add(Me.btnStumped)
        Me.Controls.Add(Me.btnCaughtBehind)
        Me.Controls.Add(Me.btnLBW)
        Me.Controls.Add(Me.btnCaught)
        Me.Controls.Add(Me.btnBowled)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopUpWicket"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PopUpWicket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBowled As Button
    Friend WithEvents btnCaught As Button
    Friend WithEvents btnLBW As Button
    Friend WithEvents btnCaughtBehind As Button
    Friend WithEvents btnStumped As Button
    Friend WithEvents btnHitWicket As Button
    Friend WithEvents btnRanOut As Button
    Friend WithEvents btnRetired As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblBatName As Label
    Friend WithEvents lblBatOrder As Label
End Class
