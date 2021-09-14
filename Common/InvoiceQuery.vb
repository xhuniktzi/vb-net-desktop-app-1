Public Class InvoiceQuery
    Public Property Start_Date As String
    Public Property End_Date As String
    Public Property Serial_Number As String = Nothing
    Public Property Invoice_Number As Nullable(Of Integer) = Nothing
    Public Property Client_Id As Nullable(Of Integer) = Nothing
    Public Property Product_Id As Nullable(Of Integer) = Nothing
    Public Property Branch_Id As Nullable(Of Integer) = Nothing
End Class
