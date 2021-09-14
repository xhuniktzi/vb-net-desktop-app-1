Imports vb_net_desktop_app_1.Extensions
Public Class QuerySelectProduct
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
        Else
            Dim frm As QueryInvoicesForm = CType(Owner, QueryInvoicesForm)
            frm.CurrentProduct = ProductBindingSource.Current
            frm.TxtBoxProduct.Text = $"{ProductBindingSource.Current.Code} - {ProductBindingSource.Current.Name}"
            'frm.TxtBoxBranchName.Text = ProductBindingSource.Current.Name
            'frm.TxtBoxBranchDirection.Text = ProductBindingSource.Current.Direction
            Me.Close()
        End If
    End Sub
End Class