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
        If TxtBoxClientID.Text.IsNotNullOrEmptyOrWhiteSpace Then
            DataGridClients.DataSource = _clientRepo.GetAllClients()
        Else
            Dim id As Integer = TxtBoxClientID.Text
            Dim res As List(Of Client) = New List(Of Client)
            res.Add(_clientRepo.FindClientById(id))
            DataGridClients.DataSource = res
        End If
    End Sub

    Private Sub BtnSelectClient_Click(sender As Object, e As EventArgs) Handles BtnSelectClient.Click
        Dim frm As CreateInvoice = CType(Owner, CreateInvoice)
        frm.IdCurrentClient = DataGridClients.CurrentRow.Cells(0).Value
        frm.TxtBoxClientName.Text = DataGridClients.CurrentRow.Cells(1).Value
        frm.TxtBoxClientNit.Text = DataGridClients.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub
End Class