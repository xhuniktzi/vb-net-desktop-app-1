Imports System.IO
Imports System.Net

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
            TxtBoxProductName.DataBindings.Add("Text", BindingSourceProducts, "ProductName")
            TxtBoxProductDesc.DataBindings.Add("Text", BindingSourceProducts, "ProductDescription")
            NumBoxProductPrice.DataBindings.Add("Value", BindingSourceProducts, "ProductPrice")
            NumBoxProductMinQuantity.DataBindings.Add("Value", BindingSourceProducts, "ProductMinQuantity")
        End If
        BtnUpdateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub BtnRefreshListProducts_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub

    Private Sub BtnUpdateProduct_Click(sender As Object, e As EventArgs) Handles BtnUpdateProduct.Click
        Dim prodViewModel As ProductViewModel = BindingSourceProducts.Current
        Try
            prodViewModel.Save()
            MessageBox.Show("Operacion finalizada con exito", "OK", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show($"Se ha producido un error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LoadData()
    End Sub

    Private Sub BtnDeleteProduct_Click(sender As Object, e As EventArgs) Handles BtnDeleteProduct.Click
        Dim prodViewModel As ProductViewModel = BindingSourceProducts.Current
        Try
            prodViewModel.Delete()
            MessageBox.Show("Operacion finalizada con exito", "OK", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LoadData()
    End Sub

    Private Sub TxtBoxProductCode_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductCode.TextChanged
        BtnUpdateProduct.Enabled = ValidateForm()
    End Sub

    Private Function ValidateForm() As Boolean
        Dim ValidationCode As Boolean = Not (String.IsNullOrEmpty(TxtBoxProductCode.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductCode.Text))
        Dim ValidationName As Boolean = Not (String.IsNullOrEmpty(TxtBoxProductName.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductName.Text))
        Dim ValidationDesc As Boolean = Not (String.IsNullOrEmpty(TxtBoxProductDesc.Text) Or String.IsNullOrWhiteSpace(TxtBoxProductDesc.Text))
        Dim ValidationPrice As Boolean = NumBoxProductPrice.Value > 0
        Dim ValidationMinQuantity As Boolean = NumBoxProductMinQuantity.Value > 0
        Return ValidationCode And ValidationName And ValidationDesc And ValidationPrice And ValidationMinQuantity
    End Function

    Private Sub BtnCreateProduct_Click(sender As Object, e As EventArgs) Handles BtnCreateProduct.Click
        CreateProductForm.cargar = New CreateProductForm.operar(AddressOf LoadData)
        CreateProductForm.ShowDialog()
    End Sub

    Private Sub ProductForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

    Private Sub TxtBoxProductName_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductName.TextChanged
        BtnUpdateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxProductDesc_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxProductDesc.TextChanged
        BtnUpdateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub NumBoxProductPrice_ValueChanged(sender As Object, e As EventArgs) Handles NumBoxProductPrice.ValueChanged
        BtnUpdateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub NumBoxProductMinQuantity_ValueChanged(sender As Object, e As EventArgs) Handles NumBoxProductMinQuantity.ValueChanged
        BtnUpdateProduct.Enabled = ValidateForm()
    End Sub

    Private Sub LstBoxListProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstBoxListProducts.SelectedIndexChanged
        BtnUpdateProduct.Enabled = ValidateForm()
    End Sub
End Class