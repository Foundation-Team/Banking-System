Public Class register_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            ErrorProvider1.SetError(TextBox1, "")
            If TextBox2.Text <> "" Then
                ErrorProvider1.SetError(TextBox2, "")
                If TextBox3.Text <> "" Then
                    ErrorProvider1.SetError(TextBox3, "")
                    If ComboBox2.Text <> "" Then
                        ErrorProvider1.SetError(ComboBox2, "")
                        If ComboBox1.Text <> "" Then
                            ErrorProvider1.SetError(ComboBox1, "")
                            If MaskedTextBox1.Text <> "" Then
                                ErrorProvider1.SetError(MaskedTextBox1, "")
                                If MaskedTextBox2.Text <> "" Then
                                    ErrorProvider1.SetError(MaskedTextBox2, "")
                                    If MaskedTextBox3.Text <> "" Then
                                        ErrorProvider1.SetError(MaskedTextBox3, "")
                                        If TextBox9.Text <> "" Then
                                            ErrorProvider1.SetError(TextBox9, "")
                                            If TextBox10.Text <> "" Then
                                                ErrorProvider1.SetError(TextBox10, "")
                                                If MaskedTextBox4.Text <> "" Then
                                                    ErrorProvider1.SetError(MaskedTextBox4, "")
                                                    If TextBox12.Text <> "" Then
                                                        ErrorProvider1.SetError(TextBox12, "")



                                                    Else
                                                        ErrorProvider1.SetError(TextBox12, "Enter Country")
                                                        TextBox12.Focus()
                                                    End If
                                                Else
                                                    ErrorProvider1.SetError(MaskedTextBox4, "Enter Pascal Code")
                                                    MaskedTextBox4.Focus()
                                                End If
                                            Else
                                                ErrorProvider1.SetError(TextBox10, "Enter City")
                                                TextBox10.Focus()
                                            End If
                                        Else
                                            ErrorProvider1.SetError(TextBox9, "Enter Address")
                                            TextBox9.Focus()
                                        End If
                                    Else
                                        ErrorProvider1.SetError(MaskedTextBox3, "Enter Password Confirm")
                                        MaskedTextBox3.Focus()
                                    End If
                                Else
                                    ErrorProvider1.SetError(MaskedTextBox2, "Enter Password")
                                    MaskedTextBox2.Focus()
                                End If
                            Else
                                ErrorProvider1.SetError(MaskedTextBox1, "Enter Birth Date")
                                MaskedTextBox1.Focus()
                            End If
                        Else
                            ErrorProvider1.SetError(ComboBox1, "Select Gender")
                            ComboBox1.Focus()
                        End If
                    Else
                        ErrorProvider1.SetError(ComboBox2, "Select Account Type")
                        ComboBox2.Focus()
                    End If
                Else
                    ErrorProvider1.SetError(TextBox3, "Enter Email I'd")
                    TextBox3.Focus()
                End If
            Else
                ErrorProvider1.SetError(TextBox2, "Enter Last Name")
                TextBox2.Focus()
            End If
        Else
            ErrorProvider1.SetError(TextBox1, "Enter First Name")
            TextBox1.Focus()
        End If
        '    Dim d As New DAOClass
        '    d.adddata("Insert into Bank_Data values('" & TextBox1.Text & " " & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & MaskedTextBox1.Text & "','" & MaskedTextBox2.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & MaskedTextBox3.Text & "','" & TextBox12.Text & "')")
    End Sub

    Private Sub register_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class