Imports Newtonsoft.Json
Public Class ProductRepository
    Implements IProductRepository

    Public Sub DeleteProduct(code As String) Implements IProductRepository.DeleteProduct
        ConnectDatabase.ExeceDelete($"{My.Settings.API}/products/{code}")
    End Sub

    Public Sub UpdateProduct(code As String, product As Product) Implements IProductRepository.UpdateProduct
        Dim data As String = JsonConvert.SerializeObject(product)
        ConnectDatabase.ExecPut($"{My.Settings.API}/products/{code}", data, "application/json")
    End Sub

    Public Function CreateProduct(product As Product) As Product Implements IProductRepository.CreateProduct
        Dim data As String = JsonConvert.SerializeObject(product)
        Dim res As String = ConnectDatabase.ExecPost($"{My.Settings.API}/products", data, "application/json")
        Return JsonConvert.DeserializeObject(Of Product)(res)
    End Function

    Public Function FindProductByCode(code As String) As Product Implements IProductRepository.FindProductByCode
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/products/{code}")
        Return JsonConvert.DeserializeObject(Of Product)(res)
    End Function

    Public Function FindProductByName(name As String) As IEnumerable(Of Product) Implements IProductRepository.FindProductByName
        Console.WriteLine($"{My.Settings.API}/products/findByName/{Uri.EscapeDataString(name)}")
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/products/findByName/{Uri.EscapeDataString(name)}")
        Return JsonConvert.DeserializeObject(Of List(Of Product))(res)
    End Function

    Public Function GetAllProducts() As IEnumerable(Of Product) Implements IProductRepository.GetAllProducts
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/products")
        Return JsonConvert.DeserializeObject(Of List(Of Product))(res)
    End Function
End Class
