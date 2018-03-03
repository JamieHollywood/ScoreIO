Module FrickSQL
    Sub CreateNewGameTable(ByVal TableName As String)
        Dim Connection As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Connection.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = Connection
        Connection.Open()
        cmd.CommandText = "CREATE TABLE " & TableName.Trim() & "(PlayerUserName nvarchar(50) PRIMARY KEY, TeamName nvarchar(50), BattingOrder int, Capt Bit, WicketKeeper Bit, RunsScored int, HowOut nvarchar(50), Wickets int, RunsAgainst int, Maidens int, Wides int, NoBalls int, OversBowled int, BallsFaced int)"
        cmd.ExecuteNonQuery()
        Console.WriteLine("Executed")
        Console.WriteLine("Created Table " & TableName)
    End Sub


End Module
