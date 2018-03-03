Public Class ScoreBoard
    Private Sub ScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme(Me)
    End Sub

    Public Sub New(ByRef BatTeam As TeamData, ByRef BatTeamIn As GameData, ByRef BowlTeam As TeamData, ByRef BowlTeamIn As GameData)
        InitializeComponent()
        lblTotalRuns.Text = BatTeamIn.total
        lblOvers.Text = BatTeamIn.overs & "." & BatTeamIn.balls Mod 6
        lblWickets.Text = BatTeamIn.wickets
        If BowlTeamIn.total <> Nothing Then
            lblTarget.Text = BowlTeamIn.total
        End If
    End Sub

    Private Sub ScoreBoard_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub
End Class