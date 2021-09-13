﻿Imports vb_net_desktop_app_1.Extensions

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
    End Sub

    Private Sub BtnSelectProduct_Click(sender As Object, e As EventArgs) Handles BtnSelectProduct.Click
        If Not NumBoxProductQuantity.Value > 0 Then
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
End Class