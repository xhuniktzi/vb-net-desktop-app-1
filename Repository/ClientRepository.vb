Imports Newtonsoft.Json
Imports vb_net_desktop_app_1

Public Class ClientRepository
    Implements IClientRepository

    Public Sub DeleteClient(id As Integer) Implements IClientRepository.DeleteClient
        ConnectDatabase.ExeceDelete($"{My.Settings.API}/clients/{id}")
    End Sub

    Public Sub UpdateClient(id As Integer, client As Client) Implements IClientRepository.UpdateClient
        Dim data As String = JsonConvert.SerializeObject(client)
        ConnectDatabase.ExecPut($"{My.Settings.API}/clients/{id}", data, "application/json")
    End Sub

    Public Function CreateClient(client As Client) As Client Implements IClientRepository.CreateClient
        Dim data As String = JsonConvert.SerializeObject(client)
        Dim res As String = ConnectDatabase.ExecPost($"{My.Settings.API}/clients", data, "application/json")
        Return JsonConvert.DeserializeObject(Of Client)(res)
    End Function

    Public Function FindClientById(id As Integer) As Client Implements IClientRepository.FindClientById
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/clients/{id}")
        Return JsonConvert.DeserializeObject(Of Client)(res)
    End Function

    Public Function GetAllClients() As IEnumerable(Of Client) Implements IClientRepository.GetAllClients
        Dim res As String = ConnectDatabase.ExecGet($"{My.Settings.API}/clients")
        Return JsonConvert.DeserializeObject(Of List(Of Client))(res)
    End Function
End Class
