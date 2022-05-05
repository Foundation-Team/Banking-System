Public Class Register
    Private Sub ADDNEWSYSTEMUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWSYSTEMUSERToolStripMenuItem.Click
        register_1.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User1.Hide()
    End Sub
End Class