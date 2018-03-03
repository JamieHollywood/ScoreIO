Public Class PopUpExtras
    Private TypeOfExtra As String
    Private ExtrasToAdd As Integer
    Property Valid As Boolean = False

    Private Sub PopUpExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxExtas.Text = Nothing
        LoadTheme(Me)
        TypeOfExtra = ""
        ExtrasToAdd = Nothing
    End Sub

    Private Sub txtboxExtas_TextChanged(sender As Object, e As EventArgs) Handles txtboxExtas.TextChanged
        Dim TEMP As Integer
        Try
            TEMP = txtboxExtas.Text
            Valid = True
        Catch ex As Exception
            Valid = False
        End Try

        Valid = (TEMP >= 0 And TEMP < 8)
    End Sub
    Private Sub btnWides_Click(sender As Object, e As EventArgs) Handles btnWides.Click
        TypeOfExtra = "Wide"
        If Valid Then
            ExtrasToAdd = txtboxExtas.Text
        End If
        Me.Close()
    End Sub

    Private Sub btnNoBall_Click(sender As Object, e As EventArgs) Handles btnNoBall.Click
        TypeOfExtra = "No Ball"
        If Valid Then
            ExtrasToAdd = txtboxExtas.Text
        End If
        Me.Close()
    End Sub

    Private Sub btnBye_Click(sender As Object, e As EventArgs) Handles btnBye.Click
        TypeOfExtra = "Bye"
        If Valid Then
            ExtrasToAdd = txtboxExtas.Text
        End If
        Me.Close()
    End Sub

    Private Sub btnLegBye_Click(sender As Object, e As EventArgs) Handles btnLegBye.Click
        TypeOfExtra = "Leg Bye"
        If Valid Then
            ExtrasToAdd = txtboxExtas.Text
        End If
        Me.Close()
    End Sub
    Public Function GetTypeOfExtra() As String
        Return TypeOfExtra
    End Function
    Public Function GetExtrasToAdd() As Integer
        Return ExtrasToAdd
    End Function
End Class