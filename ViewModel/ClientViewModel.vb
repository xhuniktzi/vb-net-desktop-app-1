Imports System.ComponentModel

Public Class ClientViewModel
    Inherits ViewModelBase

    Private ReadOnly _client As Client
    Private ReadOnly _clientRepo As IClientRepository
    Public Sub New(client As Client, clientRepo As IClientRepository)
        _client = client
        _clientRepo = clientRepo
    End Sub

    Public Property ClientName() As String
        Get
            Return _client.Name
        End Get
        Set(ByVal value As String)
            If (_client.Name <> value) Then
                _client.Name = value
                RaisePropertyChanged(NameOf(ClientName))
            End If
        End Set
    End Property

    Public Property ClientNit() As String
        Get
            Return _client.Nit
        End Get
        Set(ByVal value As String)
            If (_client.Nit <> value) Then
                _client.Nit = value
                RaisePropertyChanged(NameOf(ClientNit))
            End If
        End Set
    End Property

    Public Property ClientPhoneNumber() As String
        Get
            Return _client.Phone_Number
        End Get
        Set(ByVal value As String)
            If (_client.Phone_Number <> value) Then
                _client.Phone_Number = value
                RaisePropertyChanged(NameOf(ClientPhoneNumber))
            End If
        End Set
    End Property

    Public Property ClientDirection() As String
        Get
            Return _client.Direction
        End Get
        Set(ByVal value As String)
            If (_client.Direction <> value) Then
                _client.Direction = value
                RaisePropertyChanged(NameOf(ClientDirection))
            End If
        End Set
    End Property

    Public Property ClientEMail() As String
        Get
            Return _client.E_Mail
        End Get
        Set(ByVal value As String)
            If (_client.E_Mail <> value) Then
                _client.E_Mail = value
                RaisePropertyChanged(NameOf(ClientEMail))
            End If
        End Set
    End Property


    Public Sub Save()
        _clientRepo.UpdateClient(_client.Client_Id, _client)
    End Sub

    Public Sub Delete()
        _clientRepo.DeleteClient(_client.Client_Id)
    End Sub

End Class

