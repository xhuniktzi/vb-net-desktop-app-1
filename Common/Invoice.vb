Public Class Invoice
    Public Property Serial_Number As String
    Public Property Invoice_Number As Integer
    Public Property Client_Id As Integer
    Public Property Branch_Id As Integer
    Public Property Order_Date As String
    Public Property Product_Detail As IEnumerable(Of ProductDetailInvoice)
End Class
