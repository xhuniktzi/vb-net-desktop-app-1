Imports System.Collections.ObjectModel

Public Class ClientMainViewModel
    Inherits ViewModelBase

    Private ReadOnly _clientRepo As IClientRepository

    Public Sub New(clientRepo As IClientRepository)
        _clientRepo = clientRepo
    End Sub

    Public Clients As ObservableCollection(Of ClientViewModel) = New ObservableCollection(Of ClientViewModel)()
    Public IsClientSelected As Boolean = SelectedClient IsNot Nothing

    Private _selectedClient As ClientViewModel
    Public Property SelectedClient() As ClientViewModel
        Get
            Return _selectedClient
        End Get
        Set(ByVal value As ClientViewModel)
            If _selectedClient IsNot value Then
                _selectedClient = value
                RaisePropertyChanged(NameOf(SelectedClient))
                RaisePropertyChanged(NameOf(IsClientSelected))
            End If
        End Set
    End Property

    Public Sub LoadClients()
        Dim listClients As IEnumerable(Of Client) = _clientRepo.GetAllClients()
        Clients.Clear()

        For Each p In listClients
            Clients.Add(New ClientViewModel(p, _clientRepo))
        Next
    End Sub
End Class
