Imports vb_net_desktop_app_1.Extensions
Public Class QueryInvoicesForm
    Private Property _invoiceRepo As IInvoiceRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _invoiceRepo = New InvoiceRepository()
    End Sub

    Private Sub BtnQuery_Click(sender As Object, e As EventArgs) Handles BtnQuery.Click
        Try
            Dim query As InvoiceQuery = New InvoiceQuery()
            query.Start_Date = DateTimeStart.Value.ToString("yyyy-MM-dd")
            query.End_Date = DateTimeEnd.Value.ToString("yyyy-MM-dd")
            If Not TxtBoxSerialNumber.Text.IsNotNullOrEmptyOrWhiteSpace() Then
                query.Serial_Number = TxtBoxSerialNumber.Text
            End If
            If Not TxtBoxInvoiceNumber.Text.IsNotNullOrEmptyOrWhiteSpace() Then
                query.Invoice_Number = CType(TxtBoxInvoiceNumber.Text, Integer)
            End If
            'If Not NumBoxInvoiceNumber.Value = Nothing Then
            '    query.Invoice_Number = NumBoxInvoiceNumber.Value
            'End If

            Dim res = _invoiceRepo.FilterInvoice(query)
            InvoiceDetailBindingSource.Clear()
            For Each detail In res
                InvoiceDetailBindingSource.Add(detail)
            Next
        Catch ex As InvalidCastException
            MessageBox.Show("Numero de Factura invalido: ingrese un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class