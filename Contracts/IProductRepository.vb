
Public Interface IProductRepository
    Function GetAllProducts() As IEnumerable(Of Product)
    Function GetProduct(code As String) As Product

End Interface
