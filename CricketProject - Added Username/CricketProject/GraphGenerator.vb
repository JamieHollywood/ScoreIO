Public Class GraphGenerator
    Property Team As TeamData
    Property TeamIn As GameData
    Property Team2 As TeamData
    Property Team2In As GameData
    Private Sub GraphGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateGraph(Team, TeamIn)
        If Team2 IsNot Nothing And Team2In IsNot Nothing Then
            GenerateGraph(Team2, Team2In)
        End If
        LoadTheme(Me)
        Me.Text = Team.name
    End Sub
    Public Sub New(ByVal _Team As TeamData, ByVal _TeamIn As GameData) 'Used for a single series chart
        InitializeComponent()
        Me.Team = _Team
        Me.TeamIn = _TeamIn
    End Sub
    Public Sub New(ByVal _Team1 As TeamData, ByVal _Team1In As GameData, ByVal _Team2 As TeamData, ByVal _Team2In As GameData) ' Used for a double series chart
        InitializeComponent()
        Me.Team = _Team1
        Me.TeamIn = _Team1In
        Me.Team2 = _Team2
        Me.Team2In = _Team2In
    End Sub

    Private Sub GenerateGraph(ByVal Team As TeamData, TeamIn As GameData)
        Dim ID As String = Team.name
        'Setup graph
        oversXrunrate.Series.Add(ID)
        oversXrunrate.Series(ID).ChartType = DataVisualization.Charting.SeriesChartType.Line 'Makes the chart a line graph
        oversXrunrate.ChartAreas(0).AxisX.Minimum = 0
        oversXrunrate.Series(ID).MarkerStyle = DataVisualization.Charting.MarkerStyle.Cross 'Adds a cross at each new point on the graph
        oversXrunrate.Series(ID).MarkerSize = 10
        oversXrunrate.ChartAreas(0).AxisX.Title = "Overs"
        oversXrunrate.ChartAreas(0).AxisY.Title = "Total runs"
        oversXrunrate.Series(ID).Points.AddXY(0, 0) 'Sets the inital point on the graph the be (0,0) this is because at the start of the game the team will be on 0 runs
        TeamIn.gOvers = 20
        'Add each point to the graph
        Dim newOver As New Random
        Randomize()
        For x = 0 To TeamIn.gOvers - 1
            Try
                Team.TrackOvers.Add(newOver.Next(Team.TrackOvers(x - 1), Team.TrackOvers(x - 1) + 15))
            Catch ex As Exception
                Team.TrackOvers.Add(5)
            End Try
            oversXrunrate.Series(ID).Points.AddXY(x + 1, Team.TrackOvers(x))
        Next

    End Sub

End Class