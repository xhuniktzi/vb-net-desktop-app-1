Imports vb_net_desktop_app_1.Extensions

Public Class QuerySelectClient
    Private Property _clientRepo As IClientRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _clientRepo = New ClientRepository()
    End Sub

    'Private Sub BtnSearchClient_Click(sender As Object, e As EventArgs)
    '    Try
    '        ClientBindingSource.Clear()
    '        If TxtBoxClientID.Text.IsNotNullOrEmptyOrWhiteSpace() Then
    '            LoadAllResults()
    '        Else
    '            Dim id As Integer = TxtBoxClientID.Text

    '            Dim client As Client = _clientRepo.FindClientById(id)
    '            ClientBindingSource.Add(client)
    '        End If
    '    Catch ex As Exception
    '        ClientBindingSource.Clear()
    '        'MessageBox.Show("Error: Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub LoadAllResults()
        For Each client In _clientRepo.GetAllClients()
            ClientBindingSource.Add(client)
        Next
    End Sub

    Private Sub BtnSelectClient_Click(sender As Object, e As EventArgs) Handles BtnSelectClient.Click
        If ClientBindingSource.Current Is Nothing Then
            MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As QueryInvoicesForm = CType(Owner, QueryInvoicesForm)
            frm.CurrentClient = ClientBindingSource.Current
            frm.TxtBoxClient.Text = $"{ClientBindingSource.Current.Client_Id} - {ClientBindingSource.Current.Name} - {ClientBindingSource.Current.Nit}"
            Me.Close()
        End If
    End Sub

    Private Sub BtnSearchClientByName_Click(sender As Object, e As EventArgs) Handles BtnSearchClientByName.Click
        Try
            ClientBindingSource.Clear()
            If TxtBoxClientName.Text.IsNotNullOrEmptyOrWhiteSpace() Then
                LoadAllResults()
            Else
                For Each product In _clientRepo.FindClientByName(TxtBoxClientName.Text)
                    ClientBindingSource.Add(product)
                Next
            End If
        Catch ex As Exception
            ClientBindingSource.Clear()
            'MessageBox.Show("Error: Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSearchClientByNit_Click(sender As Object, e As EventArgs) Handles BtnSearchClientByNit.Click
        Try
            ClientBindingSource.Clear()
            If TxtBoxClientNit.Text.IsNotNullOrEmptyOrWhiteSpace() Then
                LoadAllResults()
            Else
                For Each product In _clientRepo.FindClientByNit(TxtBoxClientNit.Text)
                    ClientBindingSource.Add(product)
                Next
            End If
        Catch ex As Exception
            ClientBindingSource.Clear()
            'MessageBox.Show("Error: Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class