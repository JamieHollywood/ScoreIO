Public Class PlayGameV2
    Property BatTeam As TeamData
    Property BatTeamIn As GameData
    Property BowlTeam As TeamData
    Property BowlTeamIn As GameData
    Private LastIn As Integer = 1 'Stoes the order number of the last batsman to go onto the field. Deafult is 1 as 0 is the opener on strike and 1 is the opener not on strike
    Property bowler As Integer = -1 'Stores the order number for the bowler currently on the field
    Public OnField() As Integer = {0, 1} 'Stores the order numbers of both of the batsman on the field
    Property facing As Integer = 0 'Stores the order number of the batsman currenly on strike. Has the be either Onfield(0) or Onfield(1).
    Property PrevBowlers As New List(Of Integer) 'List of the bowlers that have bowled in overs order
    Property Innings As Integer
    Public Sub New(ByVal _BatTeam As TeamData, ByVal _BatTeamIn As GameData, ByVal _BowlTeam As TeamData, ByVal _BowlTeamIn As GameData, ByVal _Innings As Integer)
        'Creating all the variables used in the form
        BatTeam = _BatTeam
        BatTeamIn = _BatTeamIn
        BowlTeam = _BowlTeam
        BowlTeamIn = _BowlTeamIn
        Innings = _Innings
        Dim keeper As Integer = GetKeeper()
        Dim facing As Integer = 0
        OnField(0) = 0
        OnField(1) = 1
        InitializeComponent()
        BatTeam.batting = True
        BowlTeam.batting = False
    End Sub
    Private Sub PlayGameV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme(Me)
        LoadBowlers()
        UpdateForm(bowler)
    End Sub
    Private Function GetKeeper() As Integer
        Dim KeeperOrderNumber = From Player In BowlTeam.Players Where Player.keeper Select Player.order
        Return KeeperOrderNumber(0)
    End Function 'Returns the order # of the wicket keeper

    Private Sub UpdateForm(ByRef bowler As Integer)
        'Updates all of the relivant labels on the form
        lblBalls.Text = BatTeamIn.balls Mod 6
        lblOvers.Text = BatTeamIn.overs
        lblRunsTotal.Text = BatTeamIn.total
        lblBat1Name.Text = BatTeam.Players(OnField(0)).name
        lblBatNo1.Text = BatTeam.Players(OnField(0)).order + 1
        lblBat1Runs.Text = BatTeam.Players(OnField(0)).iRuns
        lblBat2Name.Text = BatTeam.Players(OnField(1)).name
        lblBatNo2.Text = BatTeam.Players(OnField(1)).order + 1
        lblBat2Runs.Text = BatTeam.Players(OnField(1)).iRuns
        lblWickets.Text = BatTeamIn.wickets
        lblRunsTotal.Text = BatTeamIn.total

        If BowlTeamIn.total <> Nothing Then
            lblFirstInningsScore.Text = BowlTeamIn.total
        End If

        If BatTeamIn.overs >= 1 Then
            lblPredictedTotal.Text = BatTeamIn.predictedTotal()
            lblRunRate.Text = BatTeamIn.runRate() 'Calculates and updates the RunRate of the team after each ball
        End If
        If bowler <> -1 Then
            lblBowlerRunsAgainst.Text = BowlTeam.Players(bowler).iAgainst
            lblBowlerWickets.Text = BowlTeam.Players(bowler).iWickets
        End If
    End Sub 'Updates all of the labels on the form

    Private Sub UpdateData(ByVal Bowler As Integer) 'Called after each ball. One feature of UpdateData() is that it assumes that the ball bowled in valid and will increment that value
        Dim over As New List(Of Integer)
        If ValidateData(Bowler) And Not EndOfInnings() Then
            BatTeamIn.balls += 1
            BatTeamIn.total += BatTeamIn.RTB
            BatTeam.Players(OnField(facing)).iRuns += BatTeamIn.RTB
            BowlTeam.Players(Bowler).iAgainst += BatTeamIn.RTB
            BatTeam.Players(OnField(facing)).bFaced += 1
            over.Add(BatTeamIn.RTB)

            If BatTeamIn.balls Mod 6 = 0 Then
                If DecideIfMaiden(over) Then
                    BowlTeam.Players(Bowler).iMaidens += 1
                End If
                BatTeam.TrackOvers.Add(BatTeamIn.total)
                'MessageBox.Show(BatTeam.TrackOvers(BatTeamIn.overs))
                PrevBowlers.Add(Bowler)

                BowlTeam.Players(Bowler).oversBowled += 1
                BatTeamIn.overs += 1
                ChangeStrike()
                NewBowler()
            End If

            UpdateForm(Bowler)
        ElseIf EndOfInnings() Then
            NewInnings()
        Else
            NewBowler()
        End If
        BatTeamIn.RTB = 0
    End Sub 'Updates variables and does all appropriate checks & calculations after each ball

    Private Function DecideIfMaiden(ByVal over As List(Of Integer)) As Boolean
        For Each ball In over
            If ball <> Nothing Then
                Return False
            End If
        Next
        Return True
    End Function 'Uses a list to check if all the values are 0 therefore its a maiden

    Private Sub NewGameForm()
        MessageBox.Show("End of innings. A new form will now open for the second innings.", "End of innings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim NextInnnigs As New PlayGameV2(BowlTeam, BowlTeamIn, BatTeam, BatTeamIn, 2)
        OnField(0) = 0
        OnField(1) = 1
        UpdateForm(bowler)
        NextInnnigs.Show()
        Me.Close()
    End Sub 'Opens a new instance of PlayGameV2
    Private Sub NewInnings()
        If Home.batting And Innings = 1 Then 'Need a way of seeing if this is the second form or second. Maybe add a property to the class as part of new
            Home = BatTeam
            HomeIn = BatTeamIn
            Away = BowlTeam
            AwayIn = BowlTeamIn
            Home.batting = False
            Away.batting = True
            NewGameForm()
        ElseIf Away.batting And Innings = 1 Then
            Away = BatTeam
            AwayIn = BatTeamIn
            Home = BowlTeam
            HomeIn = BowlTeamIn
            Home.batting = True
            Away.batting = False
            NewGameForm()

        ElseIf Innings = 2 Then
            CheckWin()
            If Home.batting = True Then
                Home = BatTeam
                HomeIn = BatTeamIn
                Away = BowlTeam
                AwayIn = BowlTeamIn
            Else
                Away = BatTeam
                AwayIn = BatTeamIn
                Home = BowlTeam
                HomeIn = BowlTeamIn
            End If
            OutputResult()
        End If
    End Sub 'Swaps batting and bowling teams. Also stores them in home / away depending on who bats first

    Private Function ValidateData(ByRef bowler As Integer) As Boolean
        If bowler = -1 Or BatTeamIn.RTB = -1 Or bowler > 10 Or BatTeamIn.wickets = 10 Then
            Return False
        End If
        Return True
    End Function 'Returns a value based on validtion checks 

    Private Sub CheckWin()
        'Only called at the end of the second innings
        If BatTeamIn.total + BatTeamIn.RTB > BowlTeamIn.total And BatTeamIn.overs <= BatTeamIn.gOvers Then 'If the chasing team scores more runs
            BatTeamIn.balls += 1
            BatTeamIn.total += BatTeamIn.RTB
            BatTeam.Players(OnField(facing)).iRuns += BatTeamIn.RTB
            BowlTeam.Players(bowler).iAgainst += BatTeamIn.RTB
            BatTeam.Players(OnField(facing)).bFaced += 1
            BatTeamIn.won = True
            BatTeamIn.winCondition = 1
        ElseIf BatTeamIn.wickets = 10 And BatTeamIn.total < BowlTeamIn.total Then 'If the bowling team gets 10 wickets before the batting team gets more runs
            BowlTeamIn.won = True
            BowlTeamIn.winCondition = 2
        ElseIf BatTeamIn.overs = BatTeamIn.gOvers And BatTeamIn.total < BowlTeamIn.total Then 'If the chasing team has reached the over limit and not scored as many runs as the bowling team
            BowlTeamIn.won = True
            BowlTeamIn.winCondition = 2
        End If
    End Sub

    Private Sub OutputResult()
        Dim WinTeam As TeamData
        Dim WinTeamIn As GameData
        Dim LoseTeam As TeamData
        Dim LoseTeamIn As GameData

        If HomeIn.won Then
            WinTeam = Home
            WinTeamIn = HomeIn
            LoseTeam = Away
            LoseTeamIn = AwayIn
        Else
            WinTeam = Away
            WinTeamIn = AwayIn
            LoseTeam = Home
            LoseTeamIn = HomeIn
        End If
        Dim WinOutout As String = ""
        Select Case WinTeamIn.winCondition
            Case 1
                WinOutout = (WinTeam.name + " Won by " + Convert.ToString(10 - WinTeamIn.wickets) + " wickets")
            Case 2
                WinOutout = (WinTeam.name + " Won by " + Convert.ToString(WinTeamIn.total - LoseTeamIn.total) + " runs")
        End Select

        MessageBox.Show(WinOutout, "Result of the game")
        Dim ShowStats As New Statisics
        ShowStats.Show()
        Me.Close()
    End Sub 'Returns a win condition and statement

    Private Function EndOfInnings() As Boolean
        ' Return (BatTeamIn.overs = BatTeamIn.gOvers) Or BatTeamIn.wickets = 10 Or (BatTeamIn.total > BowlTeamIn.total And BowlTeamIn.total <> Nothing
        If BatTeamIn.total + BatTeamIn.RTB > BowlTeamIn.total And BowlTeamIn.total <> Nothing Then
            Return True
        ElseIf (BatTeamIn.overs = BatTeamIn.gOvers) Or BatTeamIn.wickets = 10 Then
            Return True
        Else
            Return False
        End If
    End Function 'Checks if the batting innnings is over or not

    Private Sub LoadBowlers()
        listboxBowler.BeginUpdate()
        Dim PlayersInBox = From P In BowlTeam.Players 'Uses LINQ to seach through all the objects in Players() and return the name property of those who are not the wicket keeper.
                           Where Not P.keeper
                           Select P.name
        For Each PlayerName In PlayersInBox
            listboxBowler.Items.Add(PlayerName)
        Next
        listboxBowler.EndUpdate()
    End Sub 'Adds all of the players that can bowl into a list box

    Private Sub btnAddExtras_Click(sender As Object, e As EventArgs) Handles btnAddExtras.Click
        Dim ExtrasPopUP As New PopUpExtras
        ExtrasPopUP.ShowDialog()
        If ExtrasPopUP.GetExtrasToAdd() <> Nothing And ExtrasPopUP.GetTypeOfExtra() <> Nothing And bowler <> -1 Then 'Checks that the  public variables ExtrasToAdd and TypeOfError are not blank and that a bowler has been selected.
            Select Case ExtrasPopUP.GetTypeOfExtra() 'Uses a case statement with the public variable which is set in the PopUpExtras Class
                Case "Wide"
                    BowlTeam.Players(bowler).iWides += ExtrasPopUP.GetExtrasToAdd()
                    BatTeamIn.wides += ExtrasPopUP.GetExtrasToAdd()
                    BatTeamIn.total += ExtrasPopUP.GetExtrasToAdd()
                    UpdateForm(bowler)
                Case "No Ball"
                    BowlTeam.Players(bowler).iNB += ExtrasPopUP.GetExtrasToAdd()
                    BatTeamIn.NB += ExtrasPopUP.GetExtrasToAdd()
                    BatTeamIn.total += ExtrasPopUP.GetExtrasToAdd()
                    UpdateForm(bowler)
                Case "Bye"
                    BatTeamIn.byes += ExtrasPopUP.GetExtrasToAdd()
                    BatTeamIn.total += ExtrasPopUP.GetExtrasToAdd()
                    UpdateData(bowler)
                Case "Leg Bye"
                    BatTeamIn.legByes += ExtrasPopUP.GetExtrasToAdd()
                    BatTeamIn.total += ExtrasPopUP.GetExtrasToAdd()
                    UpdateData(bowler)
                Case Else
                    MessageBox.Show("Error, Please try again")
            End Select
        Else
            MessageBox.Show("Please make sure you have entered a bowler and an amount of runs (Deafult is not 1)")
        End If

    End Sub 'Handles adding extras to the score

    Private Sub btnConfirmBowl_Click(sender As Object, e As EventArgs) Handles btnConfirmBowl.Click
        Dim count As Integer
        Dim temp As Integer = -1
        count = listboxBowler.CheckedItems.Count
        If count <> 1 Then
            MessageBox.Show("Please only select 1 bowler", "Bowler error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearListBox()
        Else 'As we know there is only 1 bowler selected, we can retrieve this person's name form the listbox and find what their order number is.
            Dim itemChecked As Object
            'Stores the user bowler input
            For Each itemChecked In listboxBowler.CheckedItems
                For n = 0 To BowlTeam.Players.Count - 1
                    If BowlTeam.Players(n).name = itemChecked.ToString() Then
                        temp = BowlTeam.Players(n).order
                        listboxBowler.Enabled = False
                        btnConfirmBowl.Enabled = False
                    End If
                Next
            Next
        End If

        If ValidateNewBowler(temp) Then
            bowler = temp 'Assigns the bowler with the temparary store as it has passed all validation checks.
            lblBowlerRunsAgainst.Text = BowlTeam.Players(bowler).iAgainst
            lblBowlerWickets.Text = BowlTeam.Players(bowler).iWickets
            lblBowlerName.Text = BowlTeam.Players(bowler).name
        Else
            MessageBox.Show("You cannot enter the same bowler for consecutive overs", "Bowler Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewBowler()
        End If

    End Sub
    Private Function ValidateNewBowler(ByVal possibleBowler As Integer) As Boolean
        If BatTeamIn.overs > 0 Then '
            If BowlTeam.Players(possibleBowler).oversBowled >= BowlTeamIn.OPB Then
                Return False
            ElseIf possibleBowler = PrevBowlers(BatTeamIn.overs - 1) Then
                Return False
            End If
        Else
            Return True
        End If
        Return True
    End Function 'Checks if the new bowler choice is valid and returns a boolean value
    Private Sub NewBowler()
        bowler = -1
        listboxBowler.Enabled = True
        btnConfirmBowl.Enabled = True
        ClearListBox()
    End Sub 'Resets the bowler index and re-enables the listbox and button
    Private Sub ClearListBox()
        For n = 0 To BatTeam.Players.Count - 2 'Unchecks all of the options from the list box.
            listboxBowler.SetItemChecked(n, False)
        Next
    End Sub 'Unselects every member in the list box

    Private Sub ChangeStrike()
        If bowler <> -1 Then 'Makes the name of the batter on strike orange
            If facing = 0 Then
                facing = 1
                lblBat2Name.ForeColor = Color.Orange
                lblBat1Name.ForeColor = Color.Black
            Else
                facing = 0
                lblBat2Name.ForeColor = Color.Black
                lblBat1Name.ForeColor = Color.Orange
            End If
        End If
    End Sub 'Swaps the facing batsman

    Private Sub btnRuns(sender As Object, e As EventArgs) Handles btnRuns0.Click, btnRuns1.Click, btnRuns2.Click, btnRuns3.Click, btnRuns4.Click, btnRuns5.Click, btnRuns6.Click
        'Uses the final characther of the sender string to add that amount of runs to the batting team.
        Dim numberOfRuns As String = sender.ToString().Last
        Dim runsThisBall As Int16
        If numberOfRuns = "." Then
            runsThisBall = 0
        Else
            runsThisBall = Convert.ToInt32(numberOfRuns)
        End If
        BatTeamIn.RTB = runsThisBall
        UpdateData(bowler)
        If runsThisBall Mod 2 <> 0 Then 'Checks if the amount of runs is even or odd. If odd then the strike needs to change as the bastmen would've swapped ends.
            ChangeStrike()
        End If
    End Sub

    Private Sub BatOut(sender As Object, e As EventArgs) Handles btnBat1Out.Click, btnBat2Out.Click
        Dim outString As String = sender.ToString()(sender.ToString.Length - 5)
        Dim out As Integer = Convert.ToInt32(outString)
        out -= 1
        Dim HowOutPopUp As New PopUpWicket(BatTeam.Players(OnField(out)))
        HowOutPopUp.ShowDialog()

        If bowler = -1 Then
            MessageBox.Show("Please select a bowler before you begin entering data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf BatTeamIn.wickets < 10 Then
            If HowOutPopUp.getHowOut() = "Ran out" Then
                BatTeamIn.wickets += 1
                BowlTeam.Players(GetKeeper()).iWickets += 1
                BatTeam.Players(OnField(out)).out = True
                OnField(out) = LastIn + 1
                LastIn = OnField(out)
                BatTeamIn.RTB = 0
                UpdateData(bowler)
            ElseIf HowOutPopUp.getHowOut() = "Retired" Then
                OnField(out) = LastIn + 1
                LastIn = OnField(out)
                BatTeamIn.RTB = 0
                BatTeamIn.wickets += 1
                UpdateData(bowler)
            Else 'All the other options 
                BatTeamIn.wickets += 1
                BowlTeam.Players(bowler).iWickets += 1
                BatTeam.Players(OnField(out)).out = True
                OnField(out) = LastIn + 1
                LastIn = OnField(out)
                BatTeamIn.RTB = 0
                UpdateData(bowler)
            End If
        End If
    End Sub

    Private Sub btnScoreboard_Click(sender As Object, e As EventArgs) Handles btnScoreboard.Click
        Dim ScoreboardForm As New ScoreBoard(BatTeam, BatTeamIn, BowlTeam, BowlTeamIn)
        ScoreboardForm.Show()
    End Sub 'Opens up the scoreboad form
End Class
