Public Class CreateInvoice
    Public Property IdCurrentClient As Integer
    Public Property IdCurrentBranch As Integer

    Private Property lstProductDetail As List(Of Product) = New List(Of Product)
    Private Sub CreateInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

    Private Sub BtnSelectClient_Click(sender As Object, e As EventArgs) Handles BtnSelectClient.Click
        Dim frm As SelectClientForm = New SelectClientForm()
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub BtnSelectBranch_Click(sender As Object, e As EventArgs) Handles BtnSelectBranch.Click
        Dim frm As SelectBranchForm = New SelectBranchForm()
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles BtnAddProduct.Click

    End Sub
End Class