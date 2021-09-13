Imports vb_net_desktop_app_1.Extensions

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
        Dim frm As AddProductsForm = New AddProductsForm()
        'AddProductsForm.AddProduct = New AddProductsForm.AddProductDelegate(AddressOf AddProductToDetail)
        'AddProductsForm.ShowDialog()
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub BtnClearInvoice_Click(sender As Object, e As EventArgs) Handles BtnClearInvoice.Click
        CurrentClient = Nothing
        TxtBoxClientName.Text = ""
        TxtBoxClientNit.Text = ""

        CurrentBranch = Nothing
        TxtBoxBranchName.Text = ""
        TxtBoxBranchDirection.Text = ""

        TxtBoxInvoiceSerial.Text = ""
        NumBoxInvoiceNumber.Value = Nothing

        ProductDetailInvoiceBindingSource.Clear()
    End Sub

    Public Sub AddProductToDetail(product As ProductDetailInvoice)
        Dim duplicate = From e In ProductDetailInvoiceBindingSource
                        Where e.Product_Id = product.Product_Id
                        Select e.Product_Id

        If duplicate.Count > 0 Then
            MessageBox.Show($"Producto: {product.Name} Duplicado en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ProductDetailInvoiceBindingSource.Add(product)
        End If
    End Sub

    Private Sub BtnCreateInvoice_Click(sender As Object, e As EventArgs) Handles BtnCreateInvoice.Click
        If CurrentClient Is Nothing Then
            MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CurrentBranch Is Nothing Then
            MessageBox.Show("Debe seleccionar una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtBoxInvoiceSerial.Text.IsNotNullOrEmptyOrWhiteSpace() Then
            MessageBox.Show("Debe ingresar un numero de serie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ElseIf NumBoxInvoiceNumber.Value = Nothing Or NumBoxInvoiceNumber.Value = 0 Then
        ElseIf NumBoxInvoiceNumber.Value = Nothing Then
            MessageBox.Show("Debe ingresar un numero de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not ProductDetailInvoiceBindingSource.Count > 0 Then
            MessageBox.Show("Debe ingresar por lo menos un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim invoiceRepo As IInvoiceRepository = New InvoiceRepository()
                Dim invoice As Invoice = New Invoice()
                invoice.Serial_Number = TxtBoxInvoiceSerial.Text
                invoice.Invoice_Number = NumBoxInvoiceNumber.Value
                invoice.Client_Id = CurrentClient.Client_Id
                invoice.Branch_Id = CurrentBranch.Branch_Id
                invoice.Order_Date = Today.ToString("yyyy-MM-dd")
                invoice.Product_Detail = ProductDetailInvoiceBindingSource.List
                invoiceRepo.CreateInvoice(invoice)
            Catch ex As ApiConnectException
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnDeleteProduct_Click(sender As Object, e As EventArgs) Handles BtnDeleteProduct.Click
        ProductDetailInvoiceBindingSource.Remove(ProductDetailInvoiceBindingSource.Current)
    End Sub
End Class