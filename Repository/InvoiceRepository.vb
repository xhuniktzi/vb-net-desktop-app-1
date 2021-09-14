Imports Newtonsoft.Json

Public Class InvoiceRepository
    Implements IInvoiceRepository

    Public Function CreateInvoice(invoice As Invoice) As Invoice Implements IInvoiceRepository.CreateInvoice
        Dim data As String = JsonConvert.SerializeObject(invoice)
        Dim res As String = ConnectDatabase.ExecPost($"{My.Settings.API}/invoices", data, "application/json")
        Return JsonConvert.DeserializeObject(Of Invoice)(res)
    End Function

    Public Function FilterInvoice(query As InvoiceQuery) As IEnumerable(Of InvoiceDetail) Implements IInvoiceRepository.FilterInvoice
        Dim data As String = JsonConvert.SerializeObject(query)
        Dim res As String = ConnectDatabase.ExecPost($"{My.Settings.API}/getInvoice", data, "application/json")
        Return JsonConvert.DeserializeObject(Of InvoiceDetail)(res)
    End Function
End Class
