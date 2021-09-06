Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class ProductRepository
    Implements IProductRepository
    Public Function GetAllProducts() As IEnumerable(Of Product) Implements IProductRepository.GetAllProducts
        Dim req As WebRequest = WebRequest.Create("http://localhost:5000/products")
        Dim res As WebResponse = req.GetResponse()
        Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
        Dim respuesta As String = reader.ReadToEnd()
        Return JsonConvert.DeserializeObject(Of List(Of Product))(respuesta)
    End Function

    Public Function GetProduct(code As String) As Product Implements IProductRepository.GetProduct
        Dim req As WebRequest = WebRequest.Create($"http://localhost:5000/products/{code}")
        Dim res As WebResponse = req.GetResponse()
        Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
        Dim respuesta As String = reader.ReadToEnd()
        Return JsonConvert.DeserializeObject(Of Product)(respuesta)
    End Function
End Class
