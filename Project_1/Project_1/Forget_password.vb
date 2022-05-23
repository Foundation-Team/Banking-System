Imports System.Net.Mail
Public Class Forget_password
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mail As New MailMessage()
        Dim smtp_server As New SmtpClient("smtp.gmail.com")
        mail.From = New MailAddress("dhruvp6230@gmail.com")
        mail.To.Add(TextBox1.Text)
        mail.Subject = "Forgot Password"
        Dim random1 As New Random
        Dim otp As Integer = random1.Next(10000, 999999)
        Dim body As String = "Your OTP IS " & otp & vbCrLf & vbCrLf & vbCrLf & "Dhurv Prajapati"
        mail.Body = body

        smtp_server.Port = 587
        smtp_server.Credentials = New System.Net.NetworkCredential("dhruvp6230@gmail.com", "Qwe$$8908")
        smtp_server.EnableSsl = True
        smtp_server.Send(mail)
        MsgBox("Mail Sended")
        Dim d As Integer = InputBox("Enter OTP", "OTP Varification")
        If d = otp Then
            Panel1.Visible = True
        Else
            MsgBox("OTP Encorrecct")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As New DAOClass
        If TextBox2.Text = TextBox3.Text Then
            d.adddata("update Bank_Data set Password = '" & TextBox3.Text & "',where email= '" & login.TextBox1.Text & "'")
            MsgBox("Password Changed")
            User1.Show()
            Me.Hide()
        Else
            MsgBox("Confirm Password Is not matched")
        End If
    End Sub

    Private Sub Forget_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub
End Class