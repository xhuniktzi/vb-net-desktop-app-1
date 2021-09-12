Public Class CreateInvoice
    Private Sub CreateInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

    Private Sub BtnSelectClient_Click(sender As Object, e As EventArgs) Handles BtnSelectClient.Click
        SelectClientForm.ShowDialog()
    End Sub
End Class