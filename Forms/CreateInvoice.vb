Public Class CreateInvoice
    Public Property CurrentClient As Client
    Public Property CurrentBranch As Branch
    Private Property _lstProductDetail As List(Of ProductDetailInvoice)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _lstProductDetail = New List(Of ProductDetailInvoice)
    End Sub
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
        Dim frm As AddProductsForm = New AddProductsForm()
        'AddProductsForm.AddProduct = New AddProductsForm.AddProductDelegate(AddressOf AddProductToDetail)
        'AddProductsForm.ShowDialog()
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub BtnClearInvoice_Click(sender As Object, e As EventArgs) Handles BtnClearInvoice.Click
        CurrentClient = Nothing
        TxtBoxClientName.Text = ""
        TxtBoxClientNit.Text = ""

        CurrentBranch = Nothing
        TxtBoxBranchName.Text = ""
        TxtBoxBranchDirection.Text = ""
    End Sub

    Public Sub AddProductToDetail(product As ProductDetailInvoice)
        ProductDetailInvoiceBindingSource.Add(product)
    End Sub

End Class