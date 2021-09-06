Public Class ProductForm

    Private _productRepo As IProductRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _productRepo = New ProductRepository()
    End Sub

    'Private Sub BtnRefreshProducts_Click(sender As Object, e As EventArgs) Handles BtnRefreshProducts.Click
    '    LoadProducts()
    'End Sub

    'Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    LoadProducts()
    'End Sub

    'Private Sub LoadProducts()
    '    ListBoxProducts.Items.Clear()
    '    Dim listProducts As IEnumerable(Of Product) = _productRepo.GetAllProducts()
    '    For Each product In listProducts
    '        ListBoxProducts.Items.Add($"{product.Code}: {product.Name}")
    '    Next
    'End Sub

    'Private Sub ListBoxProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProducts.SelectedIndexChanged
    '    Dim product As Product = _productRepo.GetProduct("P-490")
    '    TextBoxProductCode.Text = product.Code
    '    TextBoxProductName.Text = product.Name
    '    TextBoxProductDesc.Text = product.Description
    '    TextBoxProductPrice.Text = product.Price
    '    TextBoxProductMinQuantity.Text = product.Min_Quantity
    'End Sub
End Class
