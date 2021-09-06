Imports System.Collections.ObjectModel

Public Class ProductMainViewModel
    Inherits ViewModelBase

    Private ReadOnly _productRepo As IProductRepository

    Public Sub New(productRepo As IProductRepository)
        _productRepo = productRepo
    End Sub

    Public Products As ObservableCollection(Of ProductViewModel) = New ObservableCollection(Of ProductViewModel)()
    Public IsProductSelected As Boolean = SelectedProduct IsNot Nothing

    Private _selectedProduct As ProductViewModel
    Public Property SelectedProduct() As ProductViewModel
        Get
            Return _selectedProduct
        End Get
        Set(ByVal value As ProductViewModel)
            If _selectedProduct IsNot value Then
                _selectedProduct = value
                RaisePropertyChanged(NameOf(SelectedProduct))
                RaisePropertyChanged(NameOf(IsProductSelected))
            End If
        End Set
    End Property

    Public Sub LoadProducts()
        Dim listProducts As IEnumerable(Of Product) = _productRepo.GetAllProducts()
        Products.Clear()

        For Each p In listProducts
            Products.Add(New ProductViewModel(p, _productRepo))
        Next
    End Sub
End Class
