Imports vb_net_desktop_app_1.Extensions
Imports Newtonsoft.Json
Public Class SelectClientForm
    Private Property _clientRepo As IClientRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _clientRepo = New ClientRepository()
    End Sub

    Private Sub BtnSearchClient_Click(sender As Object, e As EventArgs) Handles BtnSearchClient.Click
        Try
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
        Catch ex As Exception
            MessageBox.Show("Error: Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSelectClient_Click(sender As Object, e As EventArgs) Handles BtnSelectClient.Click
        If ClientBindingSource.Current Is Nothing Then
            MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As CreateInvoice = CType(Owner, CreateInvoice)
            frm.CurrentClient = ClientBindingSource.Current
            frm.TxtBoxClientName.Text = ClientBindingSource.Current.Name
            frm.TxtBoxClientNit.Text = ClientBindingSource.Current.Nit
            Me.Close()
        End If
    End Sub

    Private Sub BtnSearchClientByName_Click(sender As Object, e As EventArgs) Handles BtnSearchClientByName.Click
        Try
            ClientBindingSource.Clear()
            For Each product In _clientRepo.FindClientByName(TxtBoxClientName.Text)
                ClientBindingSource.Add(product)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSearchClientByNit_Click(sender As Object, e As EventArgs) Handles BtnSearchClientByNit.Click
        Try
            ClientBindingSource.Clear()
            For Each product In _clientRepo.FindClientByNit(TxtBoxClientNit.Text)
                ClientBindingSource.Add(product)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class