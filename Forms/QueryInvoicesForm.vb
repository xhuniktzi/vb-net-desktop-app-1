Public Class QueryInvoicesForm
    Private Property _invoiceRepo As IInvoiceRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _invoiceRepo = New InvoiceRepository()
    End Sub

    Private Sub BtnQuery_Click(sender As Object, e As EventArgs) Handles BtnQuery.Click
        Dim query As InvoiceQuery = New InvoiceQuery()
        query.Start_Date = DateTimeStart.Value.ToString()
    End Sub
End Class