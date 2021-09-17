Imports System.IO
Imports System.Net

Public Class CreateProductForm

    Public Delegate Sub operar()
    Public cargar As operar
    Private Sub BtnCreateProduct_Click(sender As Object, e As EventArgs) Handles BtnCreateProduct.Click
        Dim repo As IProductRepository = New ProductRepository()
        'Dim pdRepo As IProductDetailRepository = New ProductDetailRepository()
        Dim product As Product = New Product()
        product.Code = TxtBoxProductCode.Text
        product.Name = TxtBoxProductName.Text
        product.Description = TxtBoxProductDesc.Text
        product.Price = NumBoxProductPrice.Value
        product.Min_Quantity = NumBoxProductMinQuantity.Value
        Try
            repo.CreateProduct(product)
            'pdRepo.CreateProductInAllBranches(productRes)
            Dim res As DialogResult = MessageBox.Show("Operacion finalizada con exito", "OK", MessageBoxButtons.OK)
            If res = DialogResult.OK Then
                cargar.Invoke()
                ClearForm()
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        TxtBoxProductCode.Text = Nothing
        TxtBoxProductName.Text = Nothing
        TxtBoxProductDesc.Text = Nothing
        NumBoxProductPrice.Value = Nothing
        NumBoxProductMinQuantity.Value = Nothing
        BtnCreateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxProductCode_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductCode.TextChanged
        BtnCreateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxProductName_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductName.TextChanged
        BtnCreateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub NumBoxProductPrice_ValueChanged(sender As Object, e As EventArgs) Handles NumBoxProductPrice.ValueChanged
        BtnCreateProduct.Enabled = ValidateForm()
    End Sub

    Private Function ValidateForm() As Boolean
        Dim ValidationCode As Boolean = Not (String.IsNullOrEmpty(TxtBoxProductCode.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductCode.Text))
        Dim ValidationName As Boolean = Not (String.IsNullOrEmpty(TxtBoxProductName.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductName.Text))
        Dim ValidationDesc As Boolean = Not (String.IsNullOrEmpty(TxtBoxProductDesc.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductDesc.Text))
        Dim ValidationPrice As Boolean = NumBoxProductPrice.Value > 0
        Dim ValidationMinQuantity As Boolean = NumBoxProductMinQuantity.Value > 0
        Return ValidationCode And ValidationName And ValidationDesc And ValidationPrice And ValidationMinQuantity
    End Function

    Private Sub CreateProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnCreateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxProductDesc_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductDesc.TextChanged
        BtnCreateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub NumBoxProductMinQuantity_ValueChanged(sender As Object, e As EventArgs) Handles NumBoxProductMinQuantity.ValueChanged
        BtnCreateProduct.Enabled = ValidateForm()
    End Sub
End Class