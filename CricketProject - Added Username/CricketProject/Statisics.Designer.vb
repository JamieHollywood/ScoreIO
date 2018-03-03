<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Statisics
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblHomeInTitle = New System.Windows.Forms.Label()
        Me.lblAwayInTitle = New System.Windows.Forms.Label()
        Me.lblHomeCapt = New System.Windows.Forms.Label()
        Me.lblAwayKeeper = New System.Windows.Forms.Label()
        Me.lblAwayCapt = New System.Windows.Forms.Label()
        Me.lblHomeKeeper = New System.Windows.Forms.Label()
        Me.HomeDataGrid = New System.Windows.Forms.DataGridView()
        Me.AwayDataGrid = New System.Windows.Forms.DataGridView()
        Me.lblHomeRunsAndWickets = New System.Windows.Forms.Label()
        Me.lblHomeOvers = New System.Windows.Forms.Label()
        Me.lblBat0H = New System.Windows.Forms.Label()
        Me.lblBat1H = New System.Windows.Forms.Label()
        Me.lblBat2H = New System.Windows.Forms.Label()
        Me.lblBowl0H = New System.Windows.Forms.Label()
        Me.lblBowl1H = New System.Windows.Forms.Label()
        Me.lblBowl2H = New System.Windows.Forms.Label()
        Me.lblBowl2A = New System.Windows.Forms.Label()
        Me.lblBowl1A = New System.Windows.Forms.Label()
        Me.lblBowl0A = New System.Windows.Forms.Label()
        Me.lblBat2A = New System.Windows.Forms.Label()
        Me.lblBat1A = New System.Windows.Forms.Label()
        Me.lblBat0A = New System.Windows.Forms.Label()
        Me.lblAwayOvers = New System.Windows.Forms.Label()
        Me.lblAwayRunsAndWickets = New System.Windows.Forms.Label()
        Me.btnShowGraphH = New System.Windows.Forms.Button()
        Me.btnShowGraphA = New System.Windows.Forms.Button()
        Me.btnShowBothGraphs = New System.Windows.Forms.Button()
        Me.btnEmailHomeCoach = New System.Windows.Forms.Button()
        Me.btnEmailAwayCoach = New System.Windows.Forms.Button()
        CType(Me.HomeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AwayDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHomeInTitle
        '
        Me.lblHomeInTitle.AutoSize = True
        Me.lblHomeInTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeInTitle.Location = New System.Drawing.Point(13, 13)
        Me.lblHomeInTitle.Name = "lblHomeInTitle"
        Me.lblHomeInTitle.Size = New System.Drawing.Size(203, 25)
        Me.lblHomeInTitle.TabIndex = 0
        Me.lblHomeInTitle.Text = "Home Team Innings"
        '
        'lblAwayInTitle
        '
        Me.lblAwayInTitle.AutoSize = True
        Me.lblAwayInTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayInTitle.Location = New System.Drawing.Point(12, 300)
        Me.lblAwayInTitle.Name = "lblAwayInTitle"
        Me.lblAwayInTitle.Size = New System.Drawing.Size(199, 25)
        Me.lblAwayInTitle.TabIndex = 1
        Me.lblAwayInTitle.Text = "Away Team Innings"
        '
        'lblHomeCapt
        '
        Me.lblHomeCapt.AutoSize = True
        Me.lblHomeCapt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeCapt.Location = New System.Drawing.Point(335, 18)
        Me.lblHomeCapt.Name = "lblHomeCapt"
        Me.lblHomeCapt.Size = New System.Drawing.Size(76, 20)
        Me.lblHomeCapt.TabIndex = 2
        Me.lblHomeCapt.Text = "Captain : "
        '
        'lblAwayKeeper
        '
        Me.lblAwayKeeper.AutoSize = True
        Me.lblAwayKeeper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayKeeper.Location = New System.Drawing.Point(558, 304)
        Me.lblAwayKeeper.Name = "lblAwayKeeper"
        Me.lblAwayKeeper.Size = New System.Drawing.Size(72, 20)
        Me.lblAwayKeeper.TabIndex = 3
        Me.lblAwayKeeper.Text = "Keeper : "
        '
        'lblAwayCapt
        '
        Me.lblAwayCapt.AutoSize = True
        Me.lblAwayCapt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayCapt.Location = New System.Drawing.Point(335, 304)
        Me.lblAwayCapt.Name = "lblAwayCapt"
        Me.lblAwayCapt.Size = New System.Drawing.Size(76, 20)
        Me.lblAwayCapt.TabIndex = 4
        Me.lblAwayCapt.Text = "Captain : "
        '
        'lblHomeKeeper
        '
        Me.lblHomeKeeper.AutoSize = True
        Me.lblHomeKeeper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeKeeper.Location = New System.Drawing.Point(558, 18)
        Me.lblHomeKeeper.Name = "lblHomeKeeper"
        Me.lblHomeKeeper.Size = New System.Drawing.Size(72, 20)
        Me.lblHomeKeeper.TabIndex = 5
        Me.lblHomeKeeper.Text = "Keeper : "
        '
        'HomeDataGrid
        '
        Me.HomeDataGrid.AllowUserToAddRows = False
        Me.HomeDataGrid.AllowUserToDeleteRows = False
        Me.HomeDataGrid.AllowUserToOrderColumns = True
        Me.HomeDataGrid.AllowUserToResizeColumns = False
        Me.HomeDataGrid.AllowUserToResizeRows = False
        Me.HomeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HomeDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.HomeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HomeDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.HomeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HomeDataGrid.GridColor = System.Drawing.Color.Black
        Me.HomeDataGrid.Location = New System.Drawing.Point(18, 54)
        Me.HomeDataGrid.Name = "HomeDataGrid"
        Me.HomeDataGrid.ReadOnly = True
        Me.HomeDataGrid.Size = New System.Drawing.Size(720, 207)
        Me.HomeDataGrid.TabIndex = 6
        '
        'AwayDataGrid
        '
        Me.AwayDataGrid.AllowUserToAddRows = False
        Me.AwayDataGrid.AllowUserToDeleteRows = False
        Me.AwayDataGrid.AllowUserToOrderColumns = True
        Me.AwayDataGrid.AllowUserToResizeColumns = False
        Me.AwayDataGrid.AllowUserToResizeRows = False
        Me.AwayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AwayDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.AwayDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AwayDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AwayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AwayDataGrid.GridColor = System.Drawing.Color.Black
        Me.AwayDataGrid.Location = New System.Drawing.Point(17, 343)
        Me.AwayDataGrid.Name = "AwayDataGrid"
        Me.AwayDataGrid.ReadOnly = True
        Me.AwayDataGrid.Size = New System.Drawing.Size(720, 207)
        Me.AwayDataGrid.TabIndex = 7
        '
        'lblHomeRunsAndWickets
        '
        Me.lblHomeRunsAndWickets.AutoSize = True
        Me.lblHomeRunsAndWickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeRunsAndWickets.Location = New System.Drawing.Point(931, 18)
        Me.lblHomeRunsAndWickets.Name = "lblHomeRunsAndWickets"
        Me.lblHomeRunsAndWickets.Size = New System.Drawing.Size(129, 20)
        Me.lblHomeRunsAndWickets.TabIndex = 8
        Me.lblHomeRunsAndWickets.Text = "Runs / Wickets"
        Me.lblHomeRunsAndWickets.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHomeOvers
        '
        Me.lblHomeOvers.AutoSize = True
        Me.lblHomeOvers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeOvers.Location = New System.Drawing.Point(1174, 18)
        Me.lblHomeOvers.Name = "lblHomeOvers"
        Me.lblHomeOvers.Size = New System.Drawing.Size(99, 20)
        Me.lblHomeOvers.TabIndex = 9
        Me.lblHomeOvers.Text = "Overs.Balls"
        Me.lblHomeOvers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBat0H
        '
        Me.lblBat0H.AutoSize = True
        Me.lblBat0H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat0H.Location = New System.Drawing.Point(962, 70)
        Me.lblBat0H.Name = "lblBat0H"
        Me.lblBat0H.Size = New System.Drawing.Size(52, 20)
        Me.lblBat0H.TabIndex = 10
        Me.lblBat0H.Text = "Bat 1"
        '
        'lblBat1H
        '
        Me.lblBat1H.AutoSize = True
        Me.lblBat1H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat1H.Location = New System.Drawing.Point(962, 108)
        Me.lblBat1H.Name = "lblBat1H"
        Me.lblBat1H.Size = New System.Drawing.Size(52, 20)
        Me.lblBat1H.TabIndex = 11
        Me.lblBat1H.Text = "Bat 2"
        '
        'lblBat2H
        '
        Me.lblBat2H.AutoSize = True
        Me.lblBat2H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat2H.Location = New System.Drawing.Point(962, 145)
        Me.lblBat2H.Name = "lblBat2H"
        Me.lblBat2H.Size = New System.Drawing.Size(52, 20)
        Me.lblBat2H.TabIndex = 12
        Me.lblBat2H.Text = "Bat 3"
        '
        'lblBowl0H
        '
        Me.lblBowl0H.AutoSize = True
        Me.lblBowl0H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBowl0H.Location = New System.Drawing.Point(1191, 70)
        Me.lblBowl0H.Name = "lblBowl0H"
        Me.lblBowl0H.Size = New System.Drawing.Size(62, 20)
        Me.lblBowl0H.TabIndex = 13
        Me.lblBowl0H.Text = "Bowl 1"
        '
        'lblBowl1H
        '
        Me.lblBowl1H.AutoSize = True
        Me.lblBowl1H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBowl1H.Location = New System.Drawing.Point(1191, 108)
        Me.lblBowl1H.Name = "lblBowl1H"
        Me.lblBowl1H.Size = New System.Drawing.Size(62, 20)
        Me.lblBowl1H.TabIndex = 14
        Me.lblBowl1H.Text = "Bowl 2"
        '
        'lblBowl2H
        '
        Me.lblBowl2H.AutoSize = True
        Me.lblBowl2H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBowl2H.Location = New System.Drawing.Point(1191, 145)
        Me.lblBowl2H.Name = "lblBowl2H"
        Me.lblBowl2H.Size = New System.Drawing.Size(62, 20)
        Me.lblBowl2H.TabIndex = 15
        Me.lblBowl2H.Text = "Bowl 3"
        '
        'lblBowl2A
        '
        Me.lblBowl2A.AutoSize = True
        Me.lblBowl2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBowl2A.Location = New System.Drawing.Point(1191, 431)
        Me.lblBowl2A.Name = "lblBowl2A"
        Me.lblBowl2A.Size = New System.Drawing.Size(62, 20)
        Me.lblBowl2A.TabIndex = 23
        Me.lblBowl2A.Text = "Bowl 3"
        '
        'lblBowl1A
        '
        Me.lblBowl1A.AutoSize = True
        Me.lblBowl1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBowl1A.Location = New System.Drawing.Point(1191, 394)
        Me.lblBowl1A.Name = "lblBowl1A"
        Me.lblBowl1A.Size = New System.Drawing.Size(62, 20)
        Me.lblBowl1A.TabIndex = 22
        Me.lblBowl1A.Text = "Bowl 2"
        '
        'lblBowl0A
        '
        Me.lblBowl0A.AutoSize = True
        Me.lblBowl0A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBowl0A.Location = New System.Drawing.Point(1191, 356)
        Me.lblBowl0A.Name = "lblBowl0A"
        Me.lblBowl0A.Size = New System.Drawing.Size(62, 20)
        Me.lblBowl0A.TabIndex = 21
        Me.lblBowl0A.Text = "Bowl 1"
        '
        'lblBat2A
        '
        Me.lblBat2A.AutoSize = True
        Me.lblBat2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat2A.Location = New System.Drawing.Point(962, 431)
        Me.lblBat2A.Name = "lblBat2A"
        Me.lblBat2A.Size = New System.Drawing.Size(52, 20)
        Me.lblBat2A.TabIndex = 20
        Me.lblBat2A.Text = "Bat 3"
        '
        'lblBat1A
        '
        Me.lblBat1A.AutoSize = True
        Me.lblBat1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat1A.Location = New System.Drawing.Point(962, 394)
        Me.lblBat1A.Name = "lblBat1A"
        Me.lblBat1A.Size = New System.Drawing.Size(52, 20)
        Me.lblBat1A.TabIndex = 19
        Me.lblBat1A.Text = "Bat 2"
        '
        'lblBat0A
        '
        Me.lblBat0A.AutoSize = True
        Me.lblBat0A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat0A.Location = New System.Drawing.Point(962, 356)
        Me.lblBat0A.Name = "lblBat0A"
        Me.lblBat0A.Size = New System.Drawing.Size(52, 20)
        Me.lblBat0A.TabIndex = 18
        Me.lblBat0A.Text = "Bat 1"
        '
        'lblAwayOvers
        '
        Me.lblAwayOvers.AutoSize = True
        Me.lblAwayOvers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayOvers.Location = New System.Drawing.Point(1174, 304)
        Me.lblAwayOvers.Name = "lblAwayOvers"
        Me.lblAwayOvers.Size = New System.Drawing.Size(99, 20)
        Me.lblAwayOvers.TabIndex = 17
        Me.lblAwayOvers.Text = "Overs.Balls"
        '
        'lblAwayRunsAndWickets
        '
        Me.lblAwayRunsAndWickets.AutoSize = True
        Me.lblAwayRunsAndWickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayRunsAndWickets.Location = New System.Drawing.Point(931, 304)
        Me.lblAwayRunsAndWickets.Name = "lblAwayRunsAndWickets"
        Me.lblAwayRunsAndWickets.Size = New System.Drawing.Size(129, 20)
        Me.lblAwayRunsAndWickets.TabIndex = 16
        Me.lblAwayRunsAndWickets.Text = "Runs / Wickets"
        '
        'btnShowGraphH
        '
        Me.btnShowGraphH.Location = New System.Drawing.Point(760, 129)
        Me.btnShowGraphH.Name = "btnShowGraphH"
        Me.btnShowGraphH.Size = New System.Drawing.Size(112, 54)
        Me.btnShowGraphH.TabIndex = 24
        Me.btnShowGraphH.Text = "Show Graph"
        Me.btnShowGraphH.UseVisualStyleBackColor = True
        '
        'btnShowGraphA
        '
        Me.btnShowGraphA.Location = New System.Drawing.Point(760, 415)
        Me.btnShowGraphA.Name = "btnShowGraphA"
        Me.btnShowGraphA.Size = New System.Drawing.Size(112, 54)
        Me.btnShowGraphA.TabIndex = 25
        Me.btnShowGraphA.Text = "Show Graph"
        Me.btnShowGraphA.UseVisualStyleBackColor = True
        '
        'btnShowBothGraphs
        '
        Me.btnShowBothGraphs.Location = New System.Drawing.Point(760, 271)
        Me.btnShowBothGraphs.Name = "btnShowBothGraphs"
        Me.btnShowBothGraphs.Size = New System.Drawing.Size(112, 54)
        Me.btnShowBothGraphs.TabIndex = 29
        Me.btnShowBothGraphs.Text = "Show Graph"
        Me.btnShowBothGraphs.UseVisualStyleBackColor = True
        '
        'btnEmailHomeCoach
        '
        Me.btnEmailHomeCoach.Location = New System.Drawing.Point(1170, 567)
        Me.btnEmailHomeCoach.Name = "btnEmailHomeCoach"
        Me.btnEmailHomeCoach.Size = New System.Drawing.Size(103, 64)
        Me.btnEmailHomeCoach.TabIndex = 30
        Me.btnEmailHomeCoach.Text = "Email Scorecard to Home Coach"
        Me.btnEmailHomeCoach.UseVisualStyleBackColor = True
        '
        'btnEmailAwayCoach
        '
        Me.btnEmailAwayCoach.Location = New System.Drawing.Point(1302, 567)
        Me.btnEmailAwayCoach.Name = "btnEmailAwayCoach"
        Me.btnEmailAwayCoach.Size = New System.Drawing.Size(103, 64)
        Me.btnEmailAwayCoach.TabIndex = 31
        Me.btnEmailAwayCoach.Text = "Email Scorecard to Away Coach"
        Me.btnEmailAwayCoach.UseVisualStyleBackColor = True
        '
        'Statisics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1417, 659)
        Me.Controls.Add(Me.btnEmailAwayCoach)
        Me.Controls.Add(Me.btnEmailHomeCoach)
        Me.Controls.Add(Me.btnShowBothGraphs)
        Me.Controls.Add(Me.btnShowGraphA)
        Me.Controls.Add(Me.btnShowGraphH)
        Me.Controls.Add(Me.lblBowl2A)
        Me.Controls.Add(Me.lblBowl1A)
        Me.Controls.Add(Me.lblBowl0A)
        Me.Controls.Add(Me.lblBat2A)
        Me.Controls.Add(Me.lblBat1A)
        Me.Controls.Add(Me.lblBat0A)
        Me.Controls.Add(Me.lblAwayOvers)
        Me.Controls.Add(Me.lblAwayRunsAndWickets)
        Me.Controls.Add(Me.lblBowl2H)
        Me.Controls.Add(Me.lblBowl1H)
        Me.Controls.Add(Me.lblBowl0H)
        Me.Controls.Add(Me.lblBat2H)
        Me.Controls.Add(Me.lblBat1H)
        Me.Controls.Add(Me.lblBat0H)
        Me.Controls.Add(Me.lblHomeOvers)
        Me.Controls.Add(Me.lblHomeRunsAndWickets)
        Me.Controls.Add(Me.AwayDataGrid)
        Me.Controls.Add(Me.HomeDataGrid)
        Me.Controls.Add(Me.lblHomeKeeper)
        Me.Controls.Add(Me.lblAwayCapt)
        Me.Controls.Add(Me.lblAwayKeeper)
        Me.Controls.Add(Me.lblHomeCapt)
        Me.Controls.Add(Me.lblAwayInTitle)
        Me.Controls.Add(Me.lblHomeInTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Statisics"
        Me.ShowInTaskbar = False
        Me.Text = "Statisics"
        CType(Me.HomeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AwayDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHomeInTitle As Label
    Friend WithEvents lblAwayInTitle As Label
    Friend WithEvents lblHomeCapt As Label
    Friend WithEvents lblAwayKeeper As Label
    Friend WithEvents lblAwayCapt As Label
    Friend WithEvents lblHomeKeeper As Label
    Friend WithEvents HomeDataGrid As DataGridView
    Friend WithEvents AwayDataGrid As DataGridView
    Friend WithEvents lblHomeRunsAndWickets As Label
    Friend WithEvents lblHomeOvers As Label
    Friend WithEvents lblBat0H As Label
    Friend WithEvents lblBat1H As Label
    Friend WithEvents lblBat2H As Label
    Friend WithEvents lblBowl0H As Label
    Friend WithEvents lblBowl1H As Label
    Friend WithEvents lblBowl2H As Label
    Friend WithEvents lblBowl2A As Label
    Friend WithEvents lblBowl1A As Label
    Friend WithEvents lblBowl0A As Label
    Friend WithEvents lblBat2A As Label
    Friend WithEvents lblBat1A As Label
    Friend WithEvents lblBat0A As Label
    Friend WithEvents lblAwayOvers As Label
    Friend WithEvents lblAwayRunsAndWickets As Label
    Friend WithEvents btnShowGraphH As Button
    Friend WithEvents btnShowGraphA As Button
    Friend WithEvents btnShowBothGraphs As Button
    Friend WithEvents btnEmailHomeCoach As Button
    Friend WithEvents btnEmailAwayCoach As Button
End Class
