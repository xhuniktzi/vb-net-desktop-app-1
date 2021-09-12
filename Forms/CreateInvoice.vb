Public Class CreateInvoice
    Public Property IdCurrentClient As Integer
    Private Sub CreateInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

    Private Sub BtnSelectClient_Click(sender As Object, e As EventArgs) Handles BtnSelectClient.Click
        Dim frm As SelectClientForm = New SelectClientForm()
        AddOwnedForm(frm)
        frm.ShowDialog()
        'SelectClientForm.ShowDialog()
    End Sub
End Class