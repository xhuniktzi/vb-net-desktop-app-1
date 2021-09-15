Imports vb_net_desktop_app_1.Extensions

Public Class AddProductsForm
    'Public Delegate Sub AddProductDelegate()
    'Public AddProduct As AddProductDelegate
    Private Property _productRepo As IProductRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _productRepo = New ProductRepository()
    End Sub

    Private Sub BtnSearchProduct_Click(sender As Object, e As EventArgs) Handles BtnSearchProduct.Click
        Try
            ProductBindingSource.Clear()
            If TxtBoxProductCode.Text.IsNotNullOrEmptyOrWhiteSpace() Then
                For Each product In _productRepo.GetAllProducts()
                    ProductBindingSource.Add(product)
                Next
            Else
                Dim code As String = TxtBoxProductCode.Text
                Dim product As Product = _productRepo.FindProductByCode(code)
                ProductBindingSource.Add(product)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSelectProduct_Click(sender As Object, e As EventArgs) Handles BtnSelectProduct.Click
        If ProductBindingSource.Current Is Nothing Then
            MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not NumBoxProductQuantity.Value > 0 Then
            MessageBox.Show("Debe ingresar una cantidad mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As CreateInvoice = CType(Owner, CreateInvoice)
            Dim currentProduct As Product = ProductBindingSource.Current

            Dim pd As ProductDetailInvoice = New ProductDetailInvoice()
            pd.Product_Id = currentProduct.Product_Id
            pd.Code = currentProduct.Code
            pd.Name = currentProduct.Name
            pd.Quantity = NumBoxProductQuantity.Value
            pd.Price = currentProduct.Price
            pd.Total = pd.Quantity * pd.Price
            frm.AddProductToDetail(pd)
            'AddProduct.Invoke()
            Me.Close()
        End If
    End Sub

    Private Sub BtnSearchProductByName_Click(sender As Object, e As EventArgs) Handles BtnSearchProductByName.Click
        Try
            ProductBindingSource.Clear()
            For Each product In _productRepo.FindProductByName(TxtBoxProductName.Text)
                ProductBindingSource.Add(product)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class