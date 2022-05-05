Public Class register_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New DAOClass
        d.adddata("Insert into Bank_Data values('" & TextBox1.Text & " " & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & MaskedTextBox1.Text & "','" & MaskedTextBox2.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & MaskedTextBox3.Text & "','" & TextBox12.Text & "')")
        MsgBox("Register Successfully")
        User1.Show()
        Me.Hide()
    End Sub

    Private Sub register_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class