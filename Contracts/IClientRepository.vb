﻿Public Interface IClientRepository
    Function GetAllClients() As IEnumerable(Of Client)
    Function CreateClient(client As Client) As Client
    Sub UpdateClient(id As Integer, client As Client)
    Sub DeleteClient(id As Integer)
End Interface
