Public Class Register
    Private Sub ADDNEWSYSTEMUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWSYSTEMUSERToolStripMenuItem.Click
        register_1.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User1.Hide()
    End Sub

    Private Sub ADDNEWCUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWCUSTOMERToolStripMenuItem.Click
        Cutomer_Registration.Show()
        Me.Hide()
    End Sub

    Private Sub ADDNEWACCOUNTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWACCOUNTToolStripMenuItem.Click
        From.Show()
        Me.Hide()
    End Sub
End Class