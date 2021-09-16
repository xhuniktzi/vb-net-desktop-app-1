Imports Newtonsoft.Json
Imports vb_net_desktop_app_1

Public Class ProductDetailRepository
    Implements IProductDetailRepository

    Public Sub CreateProductInAllBranches(product As Product) Implements IProductDetailRepository.CreateProductInAllBranches
        Dim branchRepo As IBranchRepository = New BranchRepository()
        Dim branches As IEnumerable(Of Branch) = branchRepo.GetAllBranches()
        For Each branch In branches
            Dim pd As ProductDetail = New ProductDetail
            With pd
                .Product_Id = product.Product_Id
                .Branch_Id = branch.Branch_Id
                .Quantity = 0
            End With
            Dim data As String = JsonConvert.SerializeObject(pd)
            ConnectDatabase.ExecPost($"{My.Settings.API}/product-detail", data, "application/json")
        Next
    End Sub
End Class
