Public Interface IBranchRepository
    Function GetAllBranches() As IEnumerable(Of Branch)
    Function FindBranchById(id As Integer) As Branch
    Function FindBranchByName(name As String) As IEnumerable(Of Branch)
End Interface
