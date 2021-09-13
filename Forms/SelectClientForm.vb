Imports vb_net_desktop_app_1.Extensions

Public Class SelectClientForm
    Private Property _clientRepo As IClientRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _clientRepo = New ClientRepository()
    End Sub

    Private Sub BtnSearchClient_Click(sender As Object, e As EventArgs) Handles BtnSearchClient.Click
        ClientBindingSource.Clear()
        If TxtBoxClientID.Text.IsNotNullOrEmptyOrWhiteSpace() Then
            For Each client In _clientRepo.GetAllClients()
                ClientBindingSource.Add(client)
            Next
        Else
            Dim id As Integer = TxtBoxClientID.Text
            Dim client As Client = _clientRepo.FindClientById(id)
            ClientBindingSource.Add(client)
        End If
    End Sub

    Private Sub BtnSelectClient_Click(sender As Object, e As EventArgs) Handles BtnSelectClient.Click
        Dim frm As CreateInvoice = CType(Owner, CreateInvoice)
        frm.CurrentClient = ClientBindingSource.Current
        frm.TxtBoxClientName.Text = ClientBindingSource.Current.Name
        frm.TxtBoxClientNit.Text = ClientBindingSource.Current.Nit
        Me.Close()
    End Sub
End Class