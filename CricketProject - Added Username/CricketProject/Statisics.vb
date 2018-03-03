Public Class Statisics
    Property TableName As String
    Private Sub Statisics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCaptAndKeeper()
        LoadTheme(Me)
        SetUpDataGridView(HomeDataGrid)
        PopulateDataGridView(Home, HomeDataGrid)
        SetUpDataGridView(AwayDataGrid)
        PopulateDataGridView(Away, AwayDataGrid)
        lblHomeRunsAndWickets.Text = HomeIn.total & " / " & HomeIn.wickets
        lblAwayRunsAndWickets.Text = AwayIn.total & " / " & AwayIn.wickets
        lblHomeOvers.Text = HomeIn.overs & " / " & HomeIn.balls Mod 6
        lblAwayOvers.Text = AwayIn.overs & " / " & AwayIn.balls Mod 6
        TableName = GetTableName(Home.name, Away.name)
        Scorecard(Home, HomeIn, "H")
        Scorecard(Away, AwayIn, "A")
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        RemoveAllPlayers(con, cmd)
        CreateNewGameTable()
        'AddPlayersIntoAllPlayers(Home, con, cmd)
        'AddPlayersIntoAllPlayers(Away, con, cmd)
        UpdateCareerStats(con, cmd, Home)
        InsertGameStats(Home, HomeIn)
        UpdateCareerStats(con, cmd, Away)
        InsertGameStats(Away, AwayIn)
        con.Close()
        AddResult(cmd, con)
        MessageBox.Show("Added ALL DATA AND IT DIDNT CRASH!!!!!")
    End Sub
    Function GetTableName(ByVal Team1Name As String, ByVal Team2Name As String)
        Return Team1Name.Replace(" ", "") + "vs" + Team2Name.Replace(" ", "")
    End Function
    Private Sub FillCaptAndKeeper()
        Dim homeCapt = From X In Home.Players Where X.capt = True Select X.name
        lblHomeCapt.Text &= homeCapt(0)
        Dim homeKeeper = From X In Home.Players Where X.keeper = True Select X.name
        lblHomeKeeper.Text &= homeKeeper(0)
        Dim awayCapt = From X In Away.Players Where X.capt = True Select X.name
        lblAwayCapt.Text &= awayCapt(0)
        Dim awayKeeper = From X In Away.Players Where X.keeper = True Select X.name
        lblAwayKeeper.Text &= awayKeeper(0)
    End Sub
    Private Sub SetUpDataGridView(ByRef GridView As DataGridView)
        Me.Controls.Add(GridView)
        GridView.ColumnCount = 9
        GridView.Name = "PlayerDataGridView"
        GridView.Columns(0).Name = "Order"
        GridView.Columns(1).Name = "Name"
        GridView.Columns(2).Name = "Runs"
        GridView.Columns(3).Name = "Wickets"
        GridView.Columns(4).Name = "Overs Bowled"
        GridView.Columns(5).Name = "Batting strike rate"
        GridView.Columns(6).Name = "Bowling strike rate"
        GridView.Columns(7).Name = "Runs scored off bowling"
        GridView.Columns(8).Name = "Maidens"
    End Sub
    Private Sub PopulateDataGridView(ByRef Team As TeamData, ByRef GridView As DataGridView)
        Dim row0() As String = {Team.Players(0).order + 1, Team.Players(0).name, Team.Players(0).iRuns, Team.Players(0).iWickets, Team.Players(0).oversBowled, Team.Players(0).strikeRate().ToString("N2"), Team.Players(0).iSR().ToString("N2"), Team.Players(0).iAgainst, Team.Players(0).iMaidens}
        Dim row1() As String = {Team.Players(1).order + 1, Team.Players(1).name, Team.Players(1).iRuns, Team.Players(1).iWickets, Team.Players(1).oversBowled, Team.Players(1).strikeRate().ToString("N2"), Team.Players(1).iSR().ToString("N2"), Team.Players(1).iAgainst, Team.Players(1).iMaidens}
        Dim row2() As String = {Team.Players(2).order + 1, Team.Players(2).name, Team.Players(2).iRuns, Team.Players(2).iWickets, Team.Players(2).oversBowled, Team.Players(2).strikeRate().ToString("N2"), Team.Players(2).iSR().ToString("N2"), Team.Players(2).iAgainst, Team.Players(2).iMaidens}
        Dim row3() As String = {Team.Players(3).order + 1, Team.Players(3).name, Team.Players(3).iRuns, Team.Players(3).iWickets, Team.Players(3).oversBowled, Team.Players(3).strikeRate().ToString("N2"), Team.Players(3).iSR().ToString("N2"), Team.Players(3).iAgainst, Team.Players(3).iMaidens}
        Dim row4() As String = {Team.Players(4).order + 1, Team.Players(4).name, Team.Players(4).iRuns, Team.Players(4).iWickets, Team.Players(4).oversBowled, Team.Players(4).strikeRate().ToString("N2"), Team.Players(4).iSR().ToString("N2"), Team.Players(4).iAgainst, Team.Players(4).iMaidens}
        Dim row5() As String = {Team.Players(5).order + 1, Team.Players(5).name, Team.Players(5).iRuns, Team.Players(5).iWickets, Team.Players(5).oversBowled, Team.Players(5).strikeRate().ToString("N2"), Team.Players(5).iSR().ToString("N2"), Team.Players(5).iAgainst, Team.Players(5).iMaidens}
        Dim row6() As String = {Team.Players(6).order + 1, Team.Players(6).name, Team.Players(6).iRuns, Team.Players(6).iWickets, Team.Players(6).oversBowled, Team.Players(6).strikeRate().ToString("N2"), Team.Players(6).iSR().ToString("N2"), Team.Players(6).iAgainst, Team.Players(6).iMaidens}
        Dim row7() As String = {Team.Players(7).order + 1, Team.Players(7).name, Team.Players(7).iRuns, Team.Players(7).iWickets, Team.Players(7).oversBowled, Team.Players(7).strikeRate().ToString("N2"), Team.Players(7).iSR().ToString("N2"), Team.Players(7).iAgainst, Team.Players(7).iMaidens}
        Dim row8() As String = {Team.Players(8).order + 1, Team.Players(8).name, Team.Players(8).iRuns, Team.Players(8).iWickets, Team.Players(8).oversBowled, Team.Players(8).strikeRate().ToString("N2"), Team.Players(8).iSR().ToString("N2"), Team.Players(8).iAgainst, Team.Players(8).iMaidens}
        Dim row9() As String = {Team.Players(9).order + 1, Team.Players(9).name, Team.Players(9).iRuns, Team.Players(9).iWickets, Team.Players(9).oversBowled, Team.Players(9).strikeRate().ToString("N2"), Team.Players(9).iSR().ToString("N2"), Team.Players(9).iAgainst, Team.Players(9).iMaidens}
        Dim row10() As String = {Team.Players(10).order + 1, Team.Players(10).name, Team.Players(10).iRuns, Team.Players(10).iWickets, Team.Players(10).oversBowled, Team.Players(10).strikeRate().ToString("N2"), Team.Players(10).iSR().ToString("N2"), Team.Players(10).iAgainst, Team.Players(10).iMaidens}
        GridView.Rows.Add(row0)
        GridView.Rows.Add(row1)
        GridView.Rows.Add(row2)
        GridView.Rows.Add(row3)
        GridView.Rows.Add(row4)
        GridView.Rows.Add(row5)
        GridView.Rows.Add(row6)
        GridView.Rows.Add(row7)
        GridView.Rows.Add(row8)
        GridView.Rows.Add(row9)
        GridView.Rows.Add(row10)
    End Sub
    Private Sub Scorecard(ByVal Team As TeamData, ByRef TeamIn As GameData, labelID As Char)
        Dim BestBat = From Player In Team.Players Select Player.name, Player.iRuns Order By iRuns Descending
        Dim BestBowl = From Player In Team.Players Where Player.oversBowled > 0 Select Player.name, Player.iWickets, Player.iAgainst Order By iAgainst Order By iWickets Descending
        For i As Int16 = 0 To 2 'DRY
            Dim lblBat = Me.Controls.Find("lblBat" & i & labelID, True)
            lblBat(0).Text = BestBat(i).name & " - " & BestBat(i).iRuns
            Dim lblBowl = Me.Controls.Find("lblBowl" & i & labelID, True)
            lblBowl(0).Text = BestBowl(i).name & " - " & BestBowl(i).iAgainst & " / " & BestBowl(i).iWickets
        Next
    End Sub

    Private Sub btnShowGraphH_Click(sender As Object, e As EventArgs) Handles btnShowGraphH.Click
        Dim Graph1 As New GraphGenerator(Home, HomeIn)
        Graph1.Show()
    End Sub
    Private Sub btnShowGraphA_Click(sender As Object, e As EventArgs) Handles btnShowGraphA.Click
        Dim Graph1 As New GraphGenerator(Away, AwayIn)
        Graph1.Show()
    End Sub

    Private Sub RemoveAllPlayers(ByVal con As OleDb.OleDbConnection, ByVal cmd As OleDb.OleDbCommand)
        'cmd.CommandText = "DELETE * FROM AllPlayerStats"
        'cmd.ExecuteNonQuery()
        cmd.CommandText = "DROP TABLE " & TableName
        cmd.ExecuteNonQuery()
    End Sub 'For Testing purposes only

    Sub CreateNewGameTable()
        Console.WriteLine("Entered Sub")
        FrickSQL.CreateNewGameTable(TableName)
        Console.WriteLine("Die")
    End Sub 'EVENTUALLY WORKS

    Sub AddPlayersIntoAllPlayers(ByVal Team As TeamData, ByVal con As OleDb.OleDbConnection, ByVal cmd As OleDb.OleDbCommand)
        For Each Player In Team.Players
            cmd.CommandText = "INSERT INTO AllPlayerStats (UserName, TeamPlayedFor) VALUES (@0, @1)"
            cmd.Parameters.AddWithValue("@0", Player.Username)
            cmd.Parameters.AddWithValue("@1", Team.name)

            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
        Console.WriteLine("Added all the new players to the AllPlayerStats table")
    End Sub

    Sub InsertGameStats(ByVal Team As TeamData, ByVal TeamIn As GameData)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        For Each Player In Team.Players
            cmd.CommandText = "INSERT INTO " & TableName & " Values(@PName, @TName, @BatOrder, @Capt, @WickKeep, @RunsSco, @BFaced, @HO, @Wickets, @RAgainst, @Maids, @Wides, @NBs, @OB)"
            cmd.Parameters.AddWithValue("@PName", Player.Username)
            cmd.Parameters.AddWithValue("@TName", Team.name)
            cmd.Parameters.AddWithValue("@BatOrder", Player.order + 1)
            cmd.Parameters.AddWithValue("@Capt", Player.capt)
            cmd.Parameters.AddWithValue("@WickKeep", Player.keeper)
            cmd.Parameters.AddWithValue("@RunsSco", Player.iRuns)
            cmd.Parameters.AddWithValue("@HO", Player.howOut)
            cmd.Parameters.AddWithValue("@Wickets", Player.iWickets)
            cmd.Parameters.AddWithValue("@RAgainst", Player.iAgainst)
            cmd.Parameters.AddWithValue("@Maids", Player.iMaidens + 1)
            cmd.Parameters.AddWithValue("@Wides", Player.iWides + 1)
            cmd.Parameters.AddWithValue("@NBs", Player.iNB + 1)
            cmd.Parameters.AddWithValue("@OB", Player.oversBowled)
            cmd.Parameters.AddWithValue("@BFaced", Player.bFaced)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next

        con.Close()
    End Sub

    Sub UpdateCareerStats(ByVal con As OleDb.OleDbConnection, ByVal cmd As OleDb.OleDbCommand, ByVal Team As TeamData)
        For Each Player In Team.Players
            cmd.CommandText = "UPDATE AllPlayerStats SET TotalRuns = TotalRuns + @PRuns, TotalTimesOut = TotalTimesOut + @IFPout, TotalWickets = TotalWickets + @PWick, TotalBallsFaced = TotalBallsFaced + @PFaced, TotalWides = TotalWides + @PWides, TotalNoBalls = TotalNoBalls + @PNB, TotalRunsAgainst = TotalRunsAgainst + @PAgainst, TotalMaidens = TotalMaidens + @PMaid, TotalOversBowled = TotalOversBowled + @POB WHERE UserName = @PUserName"
            cmd.Parameters.AddWithValue("@PRuns", Player.iRuns)
            cmd.Parameters.AddWithValue("@PWick", Player.iWickets)
            cmd.Parameters.AddWithValue("@PFaced", Player.bFaced)
            cmd.Parameters.AddWithValue("@PWides", Player.iWides)
            cmd.Parameters.AddWithValue("@PNB", Player.iNB)
            cmd.Parameters.AddWithValue("@PAgainst", Player.iAgainst)
            cmd.Parameters.AddWithValue("@PMaid", Player.iMaidens)
            cmd.Parameters.AddWithValue("@POB", Player.oversBowled)
            cmd.Parameters.AddWithValue("@PUserName", Player.Username)
            If Player.out = True Then
                cmd.Parameters.AddWithValue("@IFPout", True)
            Else
                cmd.Parameters.AddWithValue("@IFPout", False)
            End If
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
        MessageBox.Show("Updated Career Stats")
    End Sub 'Nah Machine BroKe
    Private Sub AddResult(ByRef cmd As OleDb.OleDbCommand, ByRef con As OleDb.OleDbConnection)
        con.Open()
        cmd.CommandText = "INSERT INTO Games (HomeTeamID, AwayTeamID, Victor)
                           VALUES(@HomeName, @AwayName, @Winner)"
        cmd.Parameters.AddWithValue("@HomeName", Home.name.Trim())
        cmd.Parameters.AddWithValue("@AwayName", Away.name.Trim())
        If HomeIn.won Then
            cmd.Parameters.AddWithValue("@Winner", Home.name)
        Else
            cmd.Parameters.AddWithValue("@Winner", Away.name)
        End If
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        con.Close()
    End Sub 'Adds each team and the winner of the game to the Games table

    Private Sub btnShowBothGraphs_Click(sender As Object, e As EventArgs) Handles btnShowBothGraphs.Click
        Dim ComplexGraph As New GraphGenerator(Home, HomeIn, Away, AwayIn)
        ComplexGraph.Show()
    End Sub 'Uses the 2nd initialiser in the GraphGenerator class to have multiple series on the same chart

    Private Sub Statisics_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub 'Ends to program when the form closes

    Private Sub SendCoachEmail(sender As Object, e As EventArgs) Handles btnEmailHomeCoach.Click, btnEmailAwayCoach.Click
        Dim Team As TeamData = If(sender.ToString().Contains("Home"), Home, Away)
        Dim EmailHandler As New EmailManager(Team.name)
        Dim EmailSent As Boolean = False
        Do
            Try
                EmailHandler.SendEmailTo(Team.CoachEmail)
                Console.WriteLine("Email Sent to Coach!")
                EmailSent = True
            Catch
                'Alternate email
                Team.CoachEmail = InputBox("Enter new emailAddress")
            End Try
        Loop Until EmailSent
    End Sub


End Class

