Module UsernameGenerator
    Function GetUserName(ByVal FullName As String) As String
        Dim UN As String
        Try
            UN = FullName.Substring(0, 3).Trim() + FullName.Substring(FullName.IndexOf(" ") + 1, 3).Trim()
            UN += OtherInstancesOfThisName(UN).ToString()
        Catch
            UN = FullName.Substring(0, 2).Trim() + FullName.Substring(FullName.IndexOf(" ") + 1, 2).Trim()
            UN += OtherInstancesOfThisName(UN).ToString()
        End Try
        Return UN
    End Function
    Function OtherInstancesOfThisName(ByVal section As String) As Integer
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT UserName FROM Users WHERE UserName LIKE '%' +  @UserName +  '%'"
        cmd.Parameters.AddWithValue("@UserName", section)
        reader = cmd.ExecuteReader()
        Dim count As Integer = 0
        If reader.HasRows() Then
            While reader.Read
                count += 1
            End While
        Else
            cmd.Parameters.Clear()
            con.Close()
            Return 0
        End If
        cmd.Parameters.Clear()
        con.Close()
        Return count
    End Function
    Sub UpdateDataBase(ByVal UserName As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "Provider=Microsoft.Ace.oledb.12.0;" & "Data Source=CricketPlayer.accdb"
        cmd.Connection = con
        con.Open()
        'Dim FirstName As String = Name.Split(" ")(0)
        'Dim LastName As String = Name.Split(" ")(1)
        cmd.CommandText = "INSERT INTO Users (UserName) VALUES (@0)"
        cmd.Parameters.AddWithValue("@0", UserName)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        Console.WriteLine("Database updated with username: " & UserName)
        con.Close()
    End Sub
End Module
