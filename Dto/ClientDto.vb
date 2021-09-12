Public Class ClientDto
    Private ReadOnly _client As Client

    Public Sub New(client As Client)
        _client = client
    End Sub

    Public ReadOnly ClientId As Integer = _client.Client_Id

    Public ReadOnly ClientName As String = _client.Name

    Public ReadOnly ClientNit As String = _client.Nit
End Class
