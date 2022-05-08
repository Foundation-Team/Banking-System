
Public Class change_password
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As SqlClient.SqlDataReader
        Dim d As New DAOClass

        obj = d.getdata("Select Password from Bank_data where email = '" & TextBox1.Text & "'")
        Try

            If obj.Read() = TextBox1.Text Then
                If TextBox2.Text = TextBox3.Text Then
                    d.adddata("update Bank_Data set Password = '" & TextBox3.Text & "',where password = '" & TextBox1.Text & "'")
                    MsgBox("Password Changed")


                Else
                    MsgBox("Confirm Password Is not matched")
                End If
            Else
                MsgBox("Old Password wrong")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class