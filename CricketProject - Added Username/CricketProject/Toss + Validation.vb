Public Class Toss
    Dim playable As Boolean = False
    Private Sub Toss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme(Me)
        DisplayResult("Waiting")
    End Sub
    Private Sub BtnThrow_Click(sender As Object, e As EventArgs) Handles btnThrow.Click 'Throw Button
        Dim HT As Integer = Math.Round(Rnd() * 2)
        If HT = 1 Then
            DisplayResult("Heads")
        Else
            DisplayResult("Tails")
        End If
    End Sub 'Uses a 50/50 throw to simulate a heads of tails coin flip
    Private Sub DisplayResult(ByVal result As String)
        lblTossResult.Text = result
        Dim rnd As New Random
        lblTossResult.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))

    End Sub 'Displays the resut of the coin flip
    Private Sub btnHomeBatting_Click(sender As Object, e As EventArgs) Handles btnHomeBatting.Click
        If Home.batting = True Or Away.batting = True Then
            MessageBox.Show("You have already selected a team that is batting.")
        Else
            Home.batting = True
            Away.batting = False
        End If
    End Sub 'Sets the home team as batting
    Private Sub btnAwayBatting_Click(sender As Object, e As EventArgs) Handles btnAwayBatting.Click
        If Home.batting = True Or Away.batting = True Then
            MessageBox.Show("You have already selected a team that is batting.")
        Else
            Home.batting = False
            Away.batting = True
        End If
    End Sub 'Sets the away team as batting
    Private Function CompleteValidation() As Boolean
        If Home.name = Nothing Or Away.name = Nothing Then
            MessageBox.Show("Error: Team Names")
            Return False
        ElseIf HomeIn.gOvers = Nothing Or AwayIn.gOvers = Nothing Then
            MessageBox.Show("Error: Total Overs")
            Return False
        ElseIf Home.captain = Nothing Or Away.captain = Nothing Or Home.keeper = Nothing Or Away.keeper = Nothing Then
            MessageBox.Show("Error: Captain or wicket keeper not set")
            Return False
        ElseIf Not (Home.batting Xor Away.batting) Then
            MessageBox.Show("Error: Both teams appear to be batting")
            Return False
        End If
        For i = 0 To 10
            If Home.Players(i).name = Nothing Or Away.Players(i).name = Nothing Then
                MessageBox.Show("Error: Player Names")
                Return False
            End If
        Next

        MessageBox.Show("ALl data entered correctly")
        Return True
    End Function 'Preforms checks on all user inputted data to make sure that it's valid
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If CompleteValidation() Then
            If Home.batting Then
                Dim FormNext As New PlayGameV2(Home, HomeIn, Away, AwayIn, 1)
                FormNext.Show()
                Me.Hide()
            Else
                Dim FormNext As New PlayGameV2(Away, AwayIn, Home, HomeIn, 1)
                FormNext.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class