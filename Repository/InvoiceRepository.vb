Imports Newtonsoft.Json
Imports vb_net_desktop_app_1

Public Class InvoiceRepository
    Implements IInvoiceRepository

    Public Function CreateInvoice(invoice As Invoice) As Invoice Implements IInvoiceRepository.CreateInvoice
        Dim data As String = JsonConvert.SerializeObject(invoice)
        Dim res As String = ConnectDatabase.ExecPost($"{My.Settings.API}/invoices", data, "application/json")
        Return JsonConvert.DeserializeObject(Of Invoice)(res)
    End Function
End Class
