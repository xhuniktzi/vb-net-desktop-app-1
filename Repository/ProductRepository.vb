Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text
Imports vb_net_desktop_app_1

Public Class ProductRepository
    Implements IProductRepository

    Public Sub DeleteProduct(code As String) Implements IProductRepository.DeleteProduct
        Dim req As WebRequest = WebRequest.Create($"http://localhost:5000/products/{code}")
        req.Method = "DELETE"
        req.GetResponse()
    End Sub

    Public Sub UpdateProduct(code As String, product As Product) Implements IProductRepository.UpdateProduct
        Dim req As WebRequest = WebRequest.Create($"http://localhost:5000/products/{code}")
        req.Method = "PUT"
        Dim data As String = JsonConvert.SerializeObject(product)
        Dim byteData As Byte() = Encoding.UTF8.GetBytes(data)
        req.ContentType = "application/json"
        req.ContentLength = byteData.Length
        Dim dataStream As Stream = req.GetRequestStream()
        dataStream.Write(byteData, 0, byteData.Length)
        dataStream.Close()

        Dim res As WebResponse = req.GetResponse()
        Dim resStream As Stream = res.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(resStream)
    End Sub

    Public Function CreateProduct(product As Product) As Product Implements IProductRepository.CreateProduct
        Dim req As WebRequest = WebRequest.Create($"http://localhost:5000/products")
        req.Method = "POST"
        Dim data As String = JsonConvert.SerializeObject(product)
        Dim byteData As Byte() = Encoding.UTF8.GetBytes(data)
        req.ContentType = "application/json"
        req.ContentLength = byteData.Length
        Dim dataStream As Stream = req.GetRequestStream()
        dataStream.Write(byteData, 0, byteData.Length)
        dataStream.Close()

        Dim res As WebResponse = req.GetResponse()
        Dim resStream As Stream = res.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(resStream)
        Return JsonConvert.DeserializeObject(Of Product)(reader.ReadToEnd())
    End Function

    Public Function GetAllProducts() As IEnumerable(Of Product) Implements IProductRepository.GetAllProducts
        Dim req As WebRequest = WebRequest.Create("http://localhost:5000/products")
        Dim res As WebResponse = req.GetResponse()
        Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
        Dim respuesta As String = reader.ReadToEnd()
        Return JsonConvert.DeserializeObject(Of List(Of Product))(respuesta)
    End Function
End Class
