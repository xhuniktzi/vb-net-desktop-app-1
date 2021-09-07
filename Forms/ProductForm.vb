Public Class ProductForm
    Private ReadOnly _viewModel As ProductMainViewModel
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _viewModel = New ProductMainViewModel(New ProductRepository())
    End Sub
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        _viewModel.LoadProducts()
        BindingSourceProducts.DataSource = _viewModel.Products
        LstBoxListProducts.DataSource = BindingSourceProducts
        LstBoxListProducts.DisplayMember = "ProductName"
        If TxtBoxProductCode.DataBindings.Count > 0 Then
            BindingSourceProducts.ResetBindings(False)
        Else
            TxtBoxProductCode.DataBindings.Add("Text", BindingSourceProducts, "ProductCode")
            TxtBoxProductName.DataBindings.Add("Text", BindingSourceProducts, "ProductName", False, DataSourceUpdateMode.OnPropertyChanged)
            TxtBoxProductDesc.DataBindings.Add("Text", BindingSourceProducts, "ProductDescription")
            NumBoxProductPrice.DataBindings.Add("Value", BindingSourceProducts, "ProductPrice")
            NumBoxProductMinQuantity.DataBindings.Add("Value", BindingSourceProducts, "ProductMinQuantity")
        End If
    End Sub

    Private Sub BtnRefreshListProducts_Click(sender As Object, e As EventArgs) Handles BtnRefreshListProducts.Click

        LoadData()
    End Sub

    Private Sub BtnUpdateProduct_Click(sender As Object, e As EventArgs) Handles BtnUpdateProduct.Click
        Dim prodViewModel As ProductViewModel = BindingSourceProducts.Current
        prodViewModel.Save()
        LoadData()
    End Sub

    Private Sub BtnDeleteProduct_Click(sender As Object, e As EventArgs) Handles BtnDeleteProduct.Click
        Dim prodViewModel As ProductViewModel = BindingSourceProducts.Current
        prodViewModel.Delete()
        LoadData()
    End Sub

    Private Sub TxtBoxProductCode_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductCode.TextChanged
        If String.IsNullOrEmpty(TxtBoxProductCode.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductCode.Text) Then
            BtnUpdateProduct.Enabled = False
        Else
            BtnUpdateProduct.Enabled = True
        End If
    End Sub
End Class