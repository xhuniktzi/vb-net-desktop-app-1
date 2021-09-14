﻿Imports vb_net_desktop_app_1.Extensions

Public Class QuerySelectClient
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
            Dim frm As QueryInvoicesForm = CType(Owner, QueryInvoicesForm)
            frm.CurrentClient = ClientBindingSource.Current
            frm.TxtBoxClient.Text = $"{ClientBindingSource.Current.Client_Id} - {ClientBindingSource.Current.Name} - {ClientBindingSource.Current.Nit}"
            Me.Close()
        End If
    End Sub
End Class