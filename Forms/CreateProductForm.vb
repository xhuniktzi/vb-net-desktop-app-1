Imports System.IO
Imports System.Net

Public Class CreateProductForm
    Private Sub BtnCreateProduct_Click(sender As Object, e As EventArgs) Handles BtnCreateProduct.Click
        Dim repo As IProductRepository = New ProductRepository()
        Dim product As Product = New Product()
        product.Code = TxtBoxProductCode.Text
        product.Name = TxtBoxProductName.Text
        product.Description = TxtBoxProductDesc.Text
        product.Price = NumBoxProductPrice.Value
        product.Min_Quantity = NumBoxProductMinQuantity.Value
        Try
            repo.CreateProduct(product)
            Dim res As DialogResult = MessageBox.Show("Operacion finalizada con exito", "OK", MessageBoxButtons.OK)
            If res = DialogResult.OK Then
                Close()
            End If
        Catch ex As WebException
            Dim reader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
            MessageBox.Show($"Error: {reader.ReadToEnd()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub TxtBoxProductCode_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductCode.TextChanged
        If String.IsNullOrEmpty(TxtBoxProductCode.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductCode.Text) Then
            BtnCreateProduct.Enabled = False
        Else
            BtnCreateProduct.Enabled = True
        End If
    End Sub
End Class