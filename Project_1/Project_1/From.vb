Imports System.Data.SqlClient

Public Class From
    Private Sub From_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim d As New DAOClass
        Dim obj As SqlDataReader

        obj = d.getdata("Select distinct(Name) from Bank_Data")

        'While obj.Read
        '    ComboBox1.Items.Add(obj.Item("Email"))
        'End While
    End Sub


End Class