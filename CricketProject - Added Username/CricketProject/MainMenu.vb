Public Class MainMenu
    Private Checked As Boolean = False
    Private Sub AddNewTeam(ByRef Team As TeamData)
        Dim TeamEntry As New TeamDataEntry(Team)
        TeamEntry.Visible = False
        Me.Hide()
        Dim result = TeamEntry.ShowDialog()
        If result = DialogResult.OK Then
            Team = TeamEntry.GetTeam
        Else
            Me.Close()
        End If
    End Sub 'AddNewTeam will create a new instance of the TeamDataEntry class allowing the user to insert data about their team. It then used a function called GetTeam() to return the team.

    Private Sub Btn20Overs_Click(sender As Object, e As EventArgs) Handles btn20Overs.Click
        Checked = True
        HomeIn.gOvers = 20
        AwayIn.gOvers = 20
        HomeIn.OPB = 4
        AwayIn.OPB = 4
    End Sub 'Set overs:20

    Private Sub Btn45Overs_Click(sender As Object, e As EventArgs) Handles btn45Overs.Click
        Checked = True
        HomeIn.gOvers = 45
        AwayIn.gOvers = 45
        HomeIn.OPB = 10
        AwayIn.OPB = 10
    End Sub 'Set overs:45

    Private Sub Btn50Overs_Click(sender As Object, e As EventArgs) Handles btn50Overs.Click
        Checked = True
        HomeIn.gOvers = 50
        AwayIn.gOvers = 50
        HomeIn.OPB = 10
        AwayIn.OPB = 10
    End Sub  'Set overs:50

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme(Me)
        txtbxHomeName.Text = Home.name
        txtbxAwayName.Text = Away.name
        If HomeIn.gOvers <> Nothing And AwayIn.gOvers <> Nothing Then
            Checked = True
        Else
            Checked = False
        End If
    End Sub 'Load

    Private Sub SetTheme(sender As Object, e As EventArgs) Handles btnSetBack.Click
        Dim colourDlg As New ColorDialog()
        colourDlg.AllowFullOpen = True
        colourDlg.AnyColor = True
        colourDlg.SolidColorOnly = True

        If colourDlg.ShowDialog() = DialogResult.OK Then
            Me.BackColor = colourDlg.Color
            myTheme.BackGround = colourDlg.Color
        End If
    End Sub 'Background theme

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not Checked Or txtbxAwayName.Text = Nothing Or txtbxHomeName.Text = Nothing Then
            MessageBox.Show("Please enter the amount of overs and set a name for both teams", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Home.name = txtbxHomeName.Text
            Away.name = txtbxAwayName.Text
            AddNewTeam(Home)
            AddNewTeam(Away)
            Dim Tossform As New Toss
            Tossform.Show()
            Me.Hide()
        End If
    End Sub 'Submit

    Private Sub Preload(sender As Object, e As EventArgs) Handles btnPre.Click
        'Create 2 arrays of random names
        Dim namesH() As String
        namesH = {"Jamie", "Noah", "Liam", "Will", "Mason", "James", "Ben", "Jacob", "Mike", "Elijah", "Ethan"}
        Dim namesA() As String
        namesA = {"Josh", "Eli", "Dylan", "John", "Adam", "Iain", "Joe", "Ant", "Dec", "Leo", "Owen"}
        'Sets these names to each player for each time
        For i = 0 To 10
            Home.Players(i).name = namesH(i)
            Home.Players(i).Username = Home.Players(i).name.Substring(0, 3) + "Hom00"
            Away.Players(i).name = namesA(i)
            Away.Players(i).Username = Away.Players(i).name + "Awa00"
        Next
        'Sets a random player to be the captain and the wicketkeeper
        Randomize()
        Home.Players((Int(Rnd() * 11))).capt = True
        Home.Players((Int(Rnd() * 11))).keeper = True

        Away.Players((Int(Rnd() * 11))).capt = True
        Away.Players((Int(Rnd() * 11))).keeper = True

        HomeIn.gOvers = 20
        AwayIn.gOvers = 20
        Home.name = "LSS"
        Away.name = "LongItch"

        HomeIn.OPB = 4
        AwayIn.OPB = 4

        Home.batting = True
        Away.batting = False

        Dim Skip As New PlayGameV2(Home, HomeIn, Away, AwayIn, 1)
        Skip.Show()
        Me.Hide()
    End Sub 'PreLoad is a button that skins all of the data entry for both the home and away teams.

    Private Sub btnPre2_Click(sender As Object, e As EventArgs) Handles btnPre2.Click
        Randomize()
        Dim namesH() As String
        namesH = {"Fuck", "Noah", "Liam", "Will", "Mason", "James", "Ben", "Jacob", "Mike", "Elijah", "Ethan"}
        Dim namesA() As String
        namesA = {"Josh", "Eli", "Dylan", "John", "Adam", "Iain", "Joe", "Ant", "Dec", "Leo", "Owen"}
        For i = 0 To 10
            Home.Players(i).name = namesH(i)
            Home.Players(i).Username = Home.Players(i).name.Substring(0, 3) + "Hom00"
            Away.Players(i).name = namesA(i)
            Away.Players(i).Username = Away.Players(i).name.Substring(0, 3) + "Awa00"
        Next
        HomeIn.gOvers = 20
        AwayIn.gOvers = 20
        Home.name = "Team1"
        Away.name = "Team2"
        Home.batting = True
        Away.batting = False
        FillTeams(Home, HomeIn)
        FillTeams(Away, AwayIn)
        If HomeIn.total > AwayIn.total Then
            HomeIn.won = True
        Else
            AwayIn.won = True
        End If
        Dim Skip As New Statisics()
        Skip.Show()
        Me.Hide()
    End Sub 'PreLoad2 is used to skip the game and go straigh to the statistics page. This will 'simulate' a game of cricket badly but generates most of the data

    Private Sub FillTeams(ByRef Team As TeamData, ByRef TeamIn As GameData)
        Randomize()
        Team.Players((Int(Rnd() * 11))).capt = True
        Team.Players((Int(Rnd() * 11))).keeper = True
        TeamIn.gOvers = TeamIn.overs = 20
        TeamIn.balls = 6 * 20
        Team.CoachEmail = "scoreio.jamie@gmail.com"
        TeamIn.OPB = 4
        For i = 0 To 10
            Team.Players(i).iRuns = Int(Rnd() * 60)
            Team.Players(i).bFaced = Int(Team.Players(i).iRuns * 1.2 + 1)
            TeamIn.total += Team.Players(i).iRuns
            Team.Players(i).out = True
            Team.Players(i).howOut = "Not Out"
            If Not Team.Players(i).keeper Then
                Team.Players(i).oversBowled = Int(Rnd() * TeamIn.OPB)
            End If
            If Team.Players(i).oversBowled > 0 Then
                Team.Players(i).iAgainst = Int(Rnd() * 100)
                Team.Players(i).iWickets = Int(Rnd() * 3)
                Team.Players(i).iWides = Int(Rnd() * 6)
                Team.Players(i).iNB = Int(Rnd() * 6)
                Team.Players(i).iMaidens = Int(Rnd() * Team.Players(i).oversBowled)
                TeamIn.wickets += Team.Players(i).iWickets
            End If
        Next

    End Sub 'FillTeams is used to gernerate randoms numbers for runs ect.

End Class