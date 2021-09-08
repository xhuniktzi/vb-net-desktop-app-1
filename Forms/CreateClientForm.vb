Imports System.Text.RegularExpressions

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
                ClearForm()
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ClearForm()
        TxtBoxClientName.Text = Nothing
        TxtBoxClientNit.Text = Nothing
        TxtBoxClientPhone.Text = Nothing
        TxtBoxClientDirection.Text = Nothing
        TxtBoxClientEMail.Text = Nothing
        BtnCreateClient.Enabled = ValidateForm()
    End Sub

    Private Function ValidateForm() As Boolean
        Dim ValidationName As Boolean = Not (String.IsNullOrEmpty(TxtBoxClientName.Text) Or String.IsNullOrWhiteSpace(TxtBoxClientName.Text))
        Dim ValidationNit As Boolean = Not (String.IsNullOrEmpty(TxtBoxClientNit.Text) Or String.IsNullOrWhiteSpace(TxtBoxClientNit.Text))
        Dim ValidationNit2 As Boolean = Regex.IsMatch(TxtBoxClientNit.Text, "\d+-\d")
        Dim ValidationPhone As Boolean = Not (String.IsNullOrEmpty(TxtBoxClientPhone.Text) Or String.IsNullOrWhiteSpace(TxtBoxClientPhone.Text))
        Dim ValidationPhone2 As Boolean = Regex.IsMatch(TxtBoxClientPhone.Text, "\d+")
        Dim ValidationDirection As Boolean = Not (String.IsNullOrEmpty(TxtBoxClientDirection.Text) Or String.IsNullOrWhiteSpace(TxtBoxClientDirection.Text))
        Dim ValidationEmail As Boolean = Not (String.IsNullOrEmpty(TxtBoxClientEMail.Text) Or String.IsNullOrWhiteSpace(TxtBoxClientEMail.Text))
        Dim ValidationEmail2 As Boolean = Regex.IsMatch(TxtBoxClientEMail.Text, "\w@\w+\.\w+")
        Return ValidationName And ValidationNit And ValidationNit2 And ValidationPhone And ValidationPhone2 And ValidationDirection And ValidationEmail And ValidationEmail2
    End Function

    Private Sub TxtBoxClientName_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientName.TextChanged
        BtnCreateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientNit_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientNit.TextChanged
        BtnCreateClient.Enabled = ValidateForm()
    End Sub

    Private Sub CreateClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnCreateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientPhone.TextChanged
        BtnCreateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientDirection_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientDirection.TextChanged
        BtnCreateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientEMail_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientEMail.TextChanged
        BtnCreateClient.Enabled = ValidateForm()
    End Sub
End Class