Public Class CreateClientForm
    Public Delegate Sub operar()
    Public cargar As operar
    Private Sub BtnCreateClient_Click(sender As Object, e As EventArgs) Handles BtnCreateClient.Click
        Dim repo As IClientRepository = New ClientRepository()
        Dim client As Client = New Client()
        client.Name = TxtBoxClientName.Text
        client.Nit = TxtBoxClientNit.Text
        client.Phone_Number = TxtBoxClientPhone.Text
        client.Direction = TxtBoxClientDirection.Text
        client.E_Mail = TxtBoxClientEMail.Text

        Try
            repo.CreateClient(client)
            Dim res As DialogResult = MessageBox.Show("Operacion finalizada con exito", "OK", MessageBoxButtons.OK)
            If res = DialogResult.OK Then
                cargar.Invoke()
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class