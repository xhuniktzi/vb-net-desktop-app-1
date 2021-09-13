Public Interface IBranchRepository
    Function GetAllBranches() As IEnumerable(Of Branch)
    Function FindBranchById(id As Integer) As Branch
End Interface
