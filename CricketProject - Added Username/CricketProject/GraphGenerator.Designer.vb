<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphGenerator
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.oversXrunrate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.oversXrunrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'oversXrunrate
        '
        ChartArea1.Name = "ChartArea1"
        Me.oversXrunrate.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.oversXrunrate.Legends.Add(Legend1)
        Me.oversXrunrate.Location = New System.Drawing.Point(13, 13)
        Me.oversXrunrate.Name = "oversXrunrate"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Runs"
        Me.oversXrunrate.Series.Add(Series1)
        Me.oversXrunrate.Size = New System.Drawing.Size(728, 468)
        Me.oversXrunrate.TabIndex = 0
        Me.oversXrunrate.Text = "Chart1"
        '
        'GraphGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(753, 493)
        Me.Controls.Add(Me.oversXrunrate)
        Me.Name = "GraphGenerator"
        Me.Text = "GraphGenerator"
        CType(Me.oversXrunrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents oversXrunrate As DataVisualization.Charting.Chart
End Class
