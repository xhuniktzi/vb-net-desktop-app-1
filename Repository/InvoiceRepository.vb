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
        'Console.WriteLine(data)
        Dim res As String = ConnectDatabase.ExecPost($"{My.Settings.API}/invoices/getInvoice", data, "application/json")
        Return JsonConvert.DeserializeObject(Of List(Of InvoiceDetail))(res)
    End Function
End Class
