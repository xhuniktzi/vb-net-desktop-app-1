Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text

Public Class ProductRepository
    Implements IProductRepository

    Public Sub DeleteProduct(code As String) Implements IProductRepository.DeleteProduct
        ConnectDatabase.ExeceDelete($"http://localhost:5000/products/{code}")
    End Sub

    Public Sub UpdateProduct(code As String, product As Product) Implements IProductRepository.UpdateProduct
        Dim data As String = JsonConvert.SerializeObject(product)
        ConnectDatabase.ExecPut($"http://localhost:5000/products/{code}", data, "application/json")
    End Sub

    Public Function CreateProduct(product As Product) As Product Implements IProductRepository.CreateProduct
        Dim data As String = JsonConvert.SerializeObject(product)
        Dim res As String = ConnectDatabase.ExecPost("http://localhost:5000/products", data, "application/json")
        Return JsonConvert.DeserializeObject(Of Product)(res)
    End Function

    Public Function GetAllProducts() As IEnumerable(Of Product) Implements IProductRepository.GetAllProducts
        Dim res As String = ConnectDatabase.ExecGet("http://localhost:5000/products")
        Return JsonConvert.DeserializeObject(Of List(Of Product))(res)
    End Function
End Class
