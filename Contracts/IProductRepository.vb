
Public Interface IProductRepository
    Function GetAllProducts() As IEnumerable(Of Product)
    Function CreateProduct(product As Product) As Product
    Sub UpdateProduct(code As String, product As Product)
    Sub DeleteProduct(code As String)
    Function FindProductByCode(code As String) As Product
    Function FindProductByName(name As String) As IEnumerable(Of Product)
End Interface
