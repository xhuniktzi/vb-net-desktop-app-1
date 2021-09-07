Imports System.ComponentModel

Public Class ProductViewModel
    Inherits ViewModelBase

    Private ReadOnly _product As Product
    Private ReadOnly _productRepo As IProductRepository
    Private ReadOnly _productCode As String
    Public Sub New(product As Product, productRepo As IProductRepository)
        _product = product
        _productRepo = productRepo
        _productCode = product.Code
    End Sub


    Public Property ProductCode() As String
        Get
            Return _product.Code
        End Get
        Set(ByVal value As String)
            If (_product.Code <> value) Then
                _product.Code = value
                RaisePropertyChanged(NameOf(ProductCode))
            End If
        End Set
    End Property


    Public Property ProductName() As String
        Get
            Return _product.Name
        End Get
        Set(ByVal value As String)
            If (_product.Name <> value) Then
                _product.Name = value
                RaisePropertyChanged(NameOf(ProductName))
            End If
        End Set
    End Property

    Public Property ProductDescription() As String
        Get
            Return _product.Description
        End Get
        Set(ByVal value As String)
            If (_product.Description <> value) Then
                _product.Description = value
                RaisePropertyChanged(NameOf(ProductDescription))
            End If
        End Set
    End Property

    Public Property ProductPrice() As Double
        Get
            Return _product.Price
        End Get
        Set(ByVal value As Double)
            If (_product.Price <> value) Then
                _product.Price = value
                RaisePropertyChanged(NameOf(ProductPrice))
            End If
        End Set
    End Property

    Public Property ProductMinQuantity() As Integer
        Get
            Return _product.Min_Quantity
        End Get
        Set(ByVal value As Integer)
            If (_product.Min_Quantity <> value) Then
                _product.Min_Quantity = value
                RaisePropertyChanged(NameOf(ProductMinQuantity))
            End If
        End Set
    End Property

    Public Sub Save()
        _productRepo.UpdateProduct(_productCode, _product)
    End Sub

    Public Sub Delete()
        _productRepo.DeleteProduct(_productCode)
    End Sub

End Class
