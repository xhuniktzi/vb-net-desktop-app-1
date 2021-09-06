Public Class ProductForm
    Private ReadOnly _viewModel As ProductMainViewModel
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _viewModel = New ProductMainViewModel(New ProductRepository())
    End Sub
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _viewModel.LoadProducts()
        BindingSourceProducts.DataSource = _viewModel.Products
        LstBoxListProducts.DataSource = BindingSourceProducts
        LstBoxListProducts.DisplayMember = "ProductName"

        TxtBoxProductCode.DataBindings.Add("Text", BindingSourceProducts, "ProductCode")
        TxtBoxProductName.DataBindings.Add("Text", BindingSourceProducts, "ProductName")
        TxtBoxProductDesc.DataBindings.Add("Text", BindingSourceProducts, "ProductDescription")
        NumBoxProductPrice.DataBindings.Add("Value", BindingSourceProducts, "ProductPrice")
        NumBoxProductMinQuantity.DataBindings.Add("Value", BindingSourceProducts, "ProductMinQuantity")
    End Sub
End Class