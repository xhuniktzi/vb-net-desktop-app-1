﻿Imports Newtonsoft.Json
Imports vb_net_desktop_app_1

Public Class BranchRepository
    Implements IBranchRepository

    Public Function FindBranchById(id As Integer) As Branch Implements IBranchRepository.FindBranchById
        Dim res = ConnectDatabase.ExecGet($"{My.Settings.API}/branches/{id}")
        Return JsonConvert.DeserializeObject(Of Branch)(res)
    End Function

    Public Function GetAllBranches() As IEnumerable(Of Branch) Implements IBranchRepository.GetAllBranches
        Dim res = ConnectDatabase.ExecGet($"{My.Settings.API}/branches")
        Return JsonConvert.DeserializeObject(Of List(Of Branch))(res)
    End Function
End Class

