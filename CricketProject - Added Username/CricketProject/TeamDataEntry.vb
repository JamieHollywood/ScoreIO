Public Class TeamDataEntry
    Property Team As TeamData
    Property NewUsers As New List(Of PlayerData)
    Public Function GetTeam() As TeamData
        Return Team
    End Function
    Public Sub New(ByRef Team1 As TeamData)
        InitializeComponent()
        Me.Team = Team1
        Me.Show()
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click 'Submit button
        Dim names() As String = {"Jamie Haywood", "Clive Haywood", "Scott Haywood", "Luke Haywood", "Nicola Haywood", "Hazel Preston", "Iain Wood", "Adam Stokes", "Nathan Morgan", "Harry Smith", "David Ogden"}

        Dim errors As Integer = 0
        Dim captianselected As Boolean = False
        Dim keeperselected As Boolean = False
        For i As Int16 = 0 To 10 'DRY
            'Dim NameTextBox = Me.Controls.Find("Player" & i & "NameH", True)
            Team.Players(i).name = names(i)
        Next

        For i As Int16 = 0 To 10 'DRY
            Dim UsernameTextBox = Me.Controls.Find("Player" & i & "UserName", True)
            Team.Players(i).Username = UsernameTextBox(0).Text
        Next
        txtbxCaptainNumber.Text = "1"
        txtbxKeeperNumber.Text = "4"
        Try 'Attempt to store the captain and wicket keeper
            If Int(txtbxCaptainNumber.Text) >= 1 And Int(txtbxKeeperNumber.Text) >= 1 Then
                Team.Players(Int(txtbxCaptainNumber.Text) - 1).capt = True
                Team.captain = txtbxCaptainNumber.Text - 1
                Team.Players(Int(txtbxKeeperNumber.Text) - 1).keeper = True
                Team.keeper = txtbxKeeperNumber.Text - 1
            End If
        Catch
            MessageBox.Show("Please enter a value between 1-11", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbxKeeperNumber.Clear()
            txtbxCaptainNumber.Clear()
        End Try

        For Each Player In Team.Players
            'Cycles through each player and check's if they all have names.
            If Player.name = Nothing Then
                errors += 1
            End If
        Next

        If errors > 0 Then
            MessageBox.Show("Please make sure you have entered all the names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Outputs an error message to the user.
        End If

        Try 'Checks that the captain and wicket keeper have been stored correctly
            If Team.Players(txtbxCaptainNumber.Text - 1).capt Then
                captianselected = True
            End If
            If Team.Players(txtbxKeeperNumber.Text - 1).keeper Then
                keeperselected = True
            End If
        Catch
        End Try

        If errors = 0 And captianselected And keeperselected Then 'Checks that all validation checks are complete before returning
            Console.WriteLine("At this point errors has to equal 0")
            For Each Player In Team.Players
                If Player.Username = Nothing Then
                    'Assign them a username
                    Dim TempUserName As String = UsernameGenerator.GetUserName(Player.name)
                    UsernameGenerator.UpdateDataBase(TempUserName)
                    NewUsers.Add(Player)
                    Player.Username = TempUserName
                Else
                    If Not (UserNameValid(Player.Username, Player.name) And UserNameExistsInDB(Player.Username)) Then
                        errors += 1
                        Console.WriteLine(errors)
                    End If
                End If
            Next
            If errors = 0 Then
                Console.WriteLine("Errors = 0")
                CreateNewTeamTable(Team.name)
                AddValuesIntoNewTable(Team.name)
                AddNewUsers(NewUsers)
                Me.DialogResult = DialogResult.OK
                Me.Hide()
            End If
        Else 'If this fails, the players are revoked of their status of captain or wicket keeper and name
            For i = 0 To 10
                Team.Players(i).capt = False
                Team.Players(i).name = Nothing
                Team.Players(i).keeper = False
                Team.Players(i).Username = Nothing
            Next
        End If
    End Sub 'Split into different functions for validation
    Function UserNameValid(ByVal Username As String, ByRef PlayerName As String) As Boolean
        Dim Temp As String = Username
        Temp = Temp.Remove(Temp.Length - 1, 1)

        Dim ApproxUsername As String = PlayerName.Substring(0, 3).Trim() + PlayerName.Substring(PlayerName.IndexOf(" ") + 1, 3).Trim()

        Return Temp = ApproxUsername
    End Function
    Function UserNameExistsInDB(ByVal UserName As String) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT UserName FROM Users WHERE UserName = @UserName"
        cmd.Parameters.AddWithValue("@UserName", UserName)
        reader = cmd.ExecuteReader()
        If reader.HasRows() Then
            While reader.Read
                If reader(0) = UserName Then
                    cmd.Parameters.Clear()
                    con.Close()
                    Return True
                End If
            End While
        End If
        Return False
        cmd.Parameters.Clear()
        reader.Close()
        con.Close()
    End Function

    Private Sub TeamDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme(Me)
        Me.Show()
        TeamNameLabelH.Text = Team.name
        lblTitle.Text = Team.name & " Data Entry"
        'Adds in any saved values. Might not be relevant now navigation buttons have gone
        For i As Int16 = 0 To 10 'DRY
            Dim txtBox = Me.Controls.Find("Player" & i & "NameH", True)
            txtBox(0).Text = Team.Players(i).name
        Next
        If Team.captain IsNot Nothing Then
            txtbxCaptainNumber.Text = Team.captain + 1
        Else
            txtbxCaptainNumber.Text = Nothing
        End If
        If Team.captain IsNot Nothing Then
            txtbxKeeperNumber.Text = Team.keeper + 1
        Else
            txtbxKeeperNumber.Text = Nothing
        End If
    End Sub
    Sub CreateNewTeamTable(ByVal TeamName As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand

        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "CREATE TABLE " & TeamName & "(PlayerUserNames nvarchar(50),Name nvarchar(50),GamesPlayed int)"
        cmd.ExecuteNonQuery()
        Console.WriteLine("Created Table " & TeamName)
        con.Close()
    End Sub
    Sub AddValuesIntoNewTable(ByVal TeamTable As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        For Each Player In Team.Players

            cmd.CommandText = "INSERT INTO " & TeamTable & "(PlayerUserNames, Name)
                               Values (@0, @1)"
            cmd.Parameters.AddWithValue("@0", Player.Username)
            cmd.Parameters.AddWithValue("@1", Player.name)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
        Console.WriteLine("Added all players to table " & TeamTable)
        con.Close()
        UserNameIDMap(TeamTable)
    End Sub
    Sub UserNameIDMap(ByVal TeamTable As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT ID FROM Users WHERE UserName = @PlayerUserName"
        For Each Player In Team.Players
            cmd.Parameters.AddWithValue("@PlayerUserName", Player.Username)
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Player.SQLID = reader(0)
                End While
            End If
            cmd.Parameters.Clear()
            reader.Close()
        Next

        con.Close()
    End Sub
    Sub AddNewUsers(ByVal NewUsers As List(Of PlayerData))
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand

        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        For Each Player In NewUsers
            cmd.CommandText = "INSERT INTO AllPlayerStats (UserName, TeamPlayedFor) VALUES (@0, @1)"
            cmd.Parameters.AddWithValue("@0", Player.Username)
            cmd.Parameters.AddWithValue("@1", Team.name)

            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
        con.Close()
        Console.WriteLine("Added all the new players to the AllPlayerStats table")
    End Sub
End Class