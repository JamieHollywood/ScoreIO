<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreBoard
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
        Me.lblRunsHeader = New System.Windows.Forms.Label()
        Me.lblOversHeader = New System.Windows.Forms.Label()
        Me.lblWicketsHeader = New System.Windows.Forms.Label()
        Me.lblTargetHeader = New System.Windows.Forms.Label()
        Me.lblTotalRuns = New System.Windows.Forms.Label()
        Me.lblOvers = New System.Windows.Forms.Label()
        Me.lblWickets = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRunsHeader
        '
        Me.lblRunsHeader.AutoSize = True
        Me.lblRunsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunsHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblRunsHeader.Name = "lblRunsHeader"
        Me.lblRunsHeader.Size = New System.Drawing.Size(98, 37)
        Me.lblRunsHeader.TabIndex = 0
        Me.lblRunsHeader.Text = "Total:"
        '
        'lblOversHeader
        '
        Me.lblOversHeader.AutoSize = True
        Me.lblOversHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOversHeader.Location = New System.Drawing.Point(12, 109)
        Me.lblOversHeader.Name = "lblOversHeader"
        Me.lblOversHeader.Size = New System.Drawing.Size(110, 37)
        Me.lblOversHeader.TabIndex = 1
        Me.lblOversHeader.Text = "Overs:"
        '
        'lblWicketsHeader
        '
        Me.lblWicketsHeader.AutoSize = True
        Me.lblWicketsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWicketsHeader.Location = New System.Drawing.Point(12, 209)
        Me.lblWicketsHeader.Name = "lblWicketsHeader"
        Me.lblWicketsHeader.Size = New System.Drawing.Size(129, 37)
        Me.lblWicketsHeader.TabIndex = 2
        Me.lblWicketsHeader.Text = "Wickets"
        '
        'lblTargetHeader
        '
        Me.lblTargetHeader.AutoSize = True
        Me.lblTargetHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetHeader.Location = New System.Drawing.Point(12, 309)
        Me.lblTargetHeader.Name = "lblTargetHeader"
        Me.lblTargetHeader.Size = New System.Drawing.Size(119, 37)
        Me.lblTargetHeader.TabIndex = 3
        Me.lblTargetHeader.Text = "Target:"
        '
        'lblTotalRuns
        '
        Me.lblTotalRuns.AutoSize = True
        Me.lblTotalRuns.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRuns.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalRuns.Location = New System.Drawing.Point(222, 9)
        Me.lblTotalRuns.Name = "lblTotalRuns"
        Me.lblTotalRuns.Size = New System.Drawing.Size(35, 37)
        Me.lblTotalRuns.TabIndex = 4
        Me.lblTotalRuns.Text = "0"
        '
        'lblOvers
        '
        Me.lblOvers.AutoSize = True
        Me.lblOvers.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOvers.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblOvers.Location = New System.Drawing.Point(222, 109)
        Me.lblOvers.Name = "lblOvers"
        Me.lblOvers.Size = New System.Drawing.Size(35, 37)
        Me.lblOvers.TabIndex = 5
        Me.lblOvers.Text = "0"
        '
        'lblWickets
        '
        Me.lblWickets.AutoSize = True
        Me.lblWickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWickets.ForeColor = System.Drawing.Color.Red
        Me.lblWickets.Location = New System.Drawing.Point(222, 209)
        Me.lblWickets.Name = "lblWickets"
        Me.lblWickets.Size = New System.Drawing.Size(35, 37)
        Me.lblWickets.TabIndex = 6
        Me.lblWickets.Text = "0"
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarget.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblTarget.Location = New System.Drawing.Point(222, 309)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(35, 37)
        Me.lblTarget.TabIndex = 7
        Me.lblTarget.Text = "0"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 365)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(294, 16)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = "A breif snapshot of the current score in the game."
        '
        'ScoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(384, 387)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.lblWickets)
        Me.Controls.Add(Me.lblOvers)
        Me.Controls.Add(Me.lblTotalRuns)
        Me.Controls.Add(Me.lblTargetHeader)
        Me.Controls.Add(Me.lblWicketsHeader)
        Me.Controls.Add(Me.lblOversHeader)
        Me.Controls.Add(Me.lblRunsHeader)
        Me.Name = "ScoreBoard"
        Me.Text = "ScoreBoard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRunsHeader As Label
    Friend WithEvents lblOversHeader As Label
    Friend WithEvents lblWicketsHeader As Label
    Friend WithEvents lblTargetHeader As Label
    Friend WithEvents lblTotalRuns As Label
    Friend WithEvents lblOvers As Label
    Friend WithEvents lblWickets As Label
    Friend WithEvents lblTarget As Label
    Friend WithEvents lblInfo As Label
End Class
