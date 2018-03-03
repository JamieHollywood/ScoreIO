Imports System.Net.Mail
Imports System.Net
Imports System.Text.RegularExpressions

Public Class EmailManager
    Private SenderCredentials As New NetworkCredential("ScoreIO.Jamie@gmail.com", "VisualBasic")
    Property SMTPHandler As New SmtpClient()
    Property Reciever As String
    Property TeamName As String

    Public Sub New(ByVal CoachTeam As String)
        TeamName = CoachTeam
    End Sub

    Private Function GetMail(ByVal Reciever As String) As MailMessage
        Dim Mail As New MailMessage
        Mail.To.Add(Reciever)
        Mail.Subject = "Team Statistics Table - " & TeamName
        Mail.Body = "
                       Hello from the ScoreIO 'Team'
                       Attatched is all of our data about the players on your team "
        Mail.From = New MailAddress("scoreio.jamie@gmail.com")
        ' Mail.Attachments.Add() 'The Team's table from the DB
        Return Mail
    End Function

    Public Sub SendEmailTo(ByVal ReciverEmail As String)
        If isEmail(ReciverEmail) Then
            Reciever = ReciverEmail
            Dim Mail As MailMessage = GetMail(Reciever)
            ConfigureSMTP()
            Try
                SMTPHandler.Send(Mail)
            Catch
                MessageBox.Show("An Error occured. Please try again.")
            End Try
            MessageBox.Show("Email Send to " & Reciever)
        Else
            MessageBox.Show("Invalid Email Address Entered.")
        End If
    End Sub

    Private Sub ConfigureSMTP()
        SMTPHandler.Credentials = SenderCredentials
        SMTPHandler.Host = "smtp.gmail.com"
        SMTPHandler.Port = 587
        SMTPHandler.EnableSsl = True
        SMTPHandler.Timeout = 5
    End Sub

    Function isEmail(ByVal email As String) As Boolean
        Dim emailRegex As New Regex("^[A-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9](?:[A-Z0-9-]{0,61}[A-Z0-9])?(?:\.[A-Z0-9](?:[A-Z0-9-]{0,61}[A-Z0-9])?)*$")
        Return emailRegex.IsMatch(email.ToUpper())
    End Function


End Class
