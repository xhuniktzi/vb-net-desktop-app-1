Public Interface IInvoiceRepository
    Function CreateInvoice(invoice As Invoice) As Invoice
    Function FilterInvoice(query As InvoiceQuery) As IEnumerable(Of InvoiceDetail)
End Interface
