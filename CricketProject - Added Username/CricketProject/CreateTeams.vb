Module Module1
    Public Home As New TeamData
    Public Away As New TeamData

    Public HomeIn As New GameData
    Public AwayIn As New GameData

    Public myTheme As Theme = New Theme

    Public Sub LoadTheme(ByRef form As Form)
        form.BackColor = myTheme.BackGround
        form.ForeColor = myTheme.ForeGround
    End Sub
End Module
