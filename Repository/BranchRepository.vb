Imports Newtonsoft.Json
Imports vb_net_desktop_app_1

Public Class BranchRepository
    Implements IBranchRepository

    Public Function FindBranchById(id As Integer) As Branch Implements IBranchRepository.FindBranchById
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/branches/{id}")
        Return JsonConvert.DeserializeObject(Of Branch)(res)
    End Function

    Public Function FindBranchByName(name As String) As IEnumerable(Of Branch) Implements IBranchRepository.FindBranchByName
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/branches/findByName/{name}")
        Return JsonConvert.DeserializeObject(Of List(Of Branch))(res)
    End Function

    Public Function GetAllBranches() As IEnumerable(Of Branch) Implements IBranchRepository.GetAllBranches
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/branches")
        Return JsonConvert.DeserializeObject(Of List(Of Branch))(res)
    End Function
End Class

