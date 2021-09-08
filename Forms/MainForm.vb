Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        ProductForm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnClients_Click(sender As Object, e As EventArgs) Handles BtnClients.Click
        ClientForm.Show()
        Me.Hide()
    End Sub
End Class