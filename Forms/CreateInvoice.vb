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
        'Dim pd As ProductDetailInvoice = New ProductDetailInvoice()
        'pd.Product_Id = 1
        'pd.Name = "Producto 1"
        'pd.Code = "AA"
        'pd.Quantity = 300
        'pd.Price = 30.0
        'pd.Total = pd.Quantity * pd.Price
        'ProductDetailInvoiceBindingSource.Add(pd)
    End Sub

End Class