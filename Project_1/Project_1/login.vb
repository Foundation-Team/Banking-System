Public Class login
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        register_1.Show()
        register_1.Location = New Point(Me.Location.X, Me.Location.Y)
        Me.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "admin"
        TextBox2.Text = "admin"
        TextBox2.UseSystemPasswordChar = True
        Panel1.Visible = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As SqlClient.SqlDataReader
        Dim d As New DAOClass

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Enter Username")
            ErrorProvider1.SetError(TextBox2, "Enter Password")

        Else

            obj = d.getdata("Select Password from Bank_data where email = '" & TextBox1.Text & "'")
            If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
                Timer1.Start()
            Else
                If obj.Read() Then
                    If obj.Item(0) = TextBox2.Text Then
                        'User1.Show()
                    Else
                        ErrorProvider1.SetError(TextBox2, "Invalid Password")
                    End If
                Else
                    ErrorProvider1.SetError(TextBox1, "Invalid Username")

                End If
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False

        ElseIf TextBox2.UseSystemPasswordChar = False Then
            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim d As String
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 10
            d = Convert.ToString(ProgressBar1.Value)
            Label9.Text = d + "%"
        Else
            Timer1.Stop()
            Register.Show()
            Me.Close()

        End If



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Forget_password.Show()
    End Sub
End Class
