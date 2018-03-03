Public Class PopUpWicket
    Private howOut As String
    Private Sub PopUpWicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme(Me)
        howOut = Nothing
    End Sub
    Public Sub New(ByVal outPlayer As PlayerData)
        InitializeComponent()
        lblBatName.Text = outPlayer.name
        lblBatOrder.Text = outPlayer.order + 1
    End Sub

    Private Sub btnBowled_Click(sender As Object, e As EventArgs) Handles btnBowled.Click
        howOut = "Bowled"
        Me.Close()
    End Sub

    Private Sub btnCaught_Click(sender As Object, e As EventArgs) Handles btnCaught.Click
        howOut = "Caught"
        Me.Close()
    End Sub

    Private Sub btnLBW_Click(sender As Object, e As EventArgs) Handles btnLBW.Click
        howOut = "LBW"
        Me.Close()
    End Sub

    Private Sub btnCaughtBehind_Click(sender As Object, e As EventArgs) Handles btnCaughtBehind.Click
        howOut = "Caught Behind"
        Me.Close()
    End Sub

    Private Sub btnRanOut_Click(sender As Object, e As EventArgs) Handles btnRanOut.Click
        howOut = "Ran out"
        Me.Close()
    End Sub

    Private Sub btnRetired_Click(sender As Object, e As EventArgs) Handles btnRetired.Click
        howOut = "Retired"
        Me.Close()
    End Sub

    Private Sub btnStumped_Click(sender As Object, e As EventArgs) Handles btnStumped.Click
        howOut = "Stumped"
        Me.Close()
    End Sub

    Private Sub btnHitWicket_Click(sender As Object, e As EventArgs) Handles btnHitWicket.Click
        howOut = "Hit wicket"
        Me.Close()
    End Sub
    Public Function getHowOut() As String
        Return howOut
    End Function
End Class