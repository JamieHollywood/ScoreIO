Public Class TeamData 'Home Away
    Property name As String 'MainMenu
    Property batting As Boolean 'Toss
    Property TrackOvers As New List(Of Integer)
    Public Players(10) As PlayerData
    Property captain As String = Nothing 'Home/Away Entry
    Property keeper As String = Nothing 'Home/Away Entry
    Property CoachEmail As String
    Public Sub New()
        For i = 0 To 10
            Players(i) = New PlayerData
            Players(i).order = i
        Next
    End Sub
End Class
Public Class PlayerData
    'Player Stats
    Property order As Integer
    Property capt As Boolean 'Home/Away Entry
    Property SQLID As Integer
    Property keeper As Boolean 'Home/Away Entry
    Property name As String 'Home/Away Entry
    'Batting Stats
    Property iRuns As Integer 'PlayGame
    Property out As Boolean 'PlayGame
    Property howOut As String
    Property bFaced As Integer 'PlayGame
    Property Username As String
    Public Function strikeRate() As Double
        Return (Me.iRuns * 100) / Me.bFaced
    End Function
    'Bowling Stats
    Property iWickets As Integer 'PlayGame
    Property iAgainst As Integer 'PlayGame
    Property iMaidens As Integer 'PlayGame
    Property iWides As Integer 'PlayGame
    Property iNB As Integer 'PlayGame
    Property oversBowled As Integer 'PlayGame

    Public Function iEco() As Double 'PlayGame
        Return Me.iAgainst / Me.oversBowled
    End Function
    Public Function iSR() As Double 'PlayGame
        Return Me.iWickets / Me.oversBowled
    End Function
    Public Sub New()
        name = Nothing
        out = False
        howOut = "Not Out"
    End Sub
End Class
Public Class GameData 'HomeIN AwayIn

    Property overs As Integer 'PlayGame
    Property won As Boolean
    Property winCondition As Integer
    Property gOvers As Integer 'MainMenu
    Property wickets As Integer 'PlayGame
    Property RTB As Integer 'PlayGame
    Property total As Integer
    Property balls As Integer    'Extras
    Property wides As Integer 'PlayGame
    Property NB As Integer 'PlayGame
    Property byes As Integer 'PlayGame
    Property legByes As Integer 'PlayGame
    Public Function totalExtras() As Integer 'PlayGame
        Return Me.wides + Me.NB + Me.byes + Me.legByes
    End Function
    Public Function predictedTotal() As Integer 'PlayGame
        Return Me.runRate() * Me.gOvers
    End Function
    Public Function runRate() As Integer 'PlayGame
        Return Me.total / (Me.overs + (Me.balls Mod 6 * 1 / 6))
    End Function
    Property OPB As Integer 'Get from a main menu screen
    Public Sub New()
        overs = 0
        gOvers = Nothing
        RTB = 0
        total = 0
        wides = 0
        NB = 0
        byes = 0
        legByes = 0
        wickets = 0
        balls = 0
        OPB = Nothing
        won = False
    End Sub
End Class

Public Class Theme
    Property BackGround As Color = Color.DimGray
    Property ForeGround As Color = Color.Black
End Class