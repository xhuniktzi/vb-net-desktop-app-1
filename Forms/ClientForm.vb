Imports System.Text.RegularExpressions

Public Class ClientForm
    Private ReadOnly _viewModel As ClientMainViewModel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _viewModel = New ClientMainViewModel(New ClientRepository())
    End Sub

    Private Sub LoadData()
        _viewModel.LoadClients()
        BindingSourceClients.DataSource = _viewModel.Clients
        LstBoxListClients.DataSource = BindingSourceClients
        LstBoxListClients.DisplayMember = "ClientName"
        If TxtBoxClientName.DataBindings.Count > 0 Then
            BindingSourceClients.ResetBindings(False)
        Else
            TxtBoxClientName.DataBindings.Add("Text", BindingSourceClients, "ClientName")
            TxtBoxClientNit.DataBindings.Add("Text", BindingSourceClients, "ClientNit")
            TxtBoxClientPhone.DataBindings.Add("Text", BindingSourceClients, "ClientPhoneNumber")
            TxtBoxClientDirection.DataBindings.Add("Text", BindingSourceClients, "ClientDirection")
            TxtBoxClientEMail.DataBindings.Add("Text", BindingSourceClients, "ClientEMail")
        End If
        BtnUpdateClient.Enabled = ValidateForm()
    End Sub

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub ClientForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

    Private Sub BtnRefreshListProducts_Click(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub BtnUpdateClient_Click(sender As Object, e As EventArgs) Handles BtnUpdateClient.Click
        Dim clViewModel As ClientViewModel = BindingSourceClients.Current
        Try
            clViewModel.Save()
            MessageBox.Show("Operacion finalizada con exito", "OK", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LoadData()
    End Sub

    Private Sub BtnDeleteClient_Click(sender As Object, e As EventArgs) Handles BtnDeleteClient.Click
        Dim clViewModel As ClientViewModel = BindingSourceClients.Current
        Try
            clViewModel.Delete()
            MessageBox.Show("Operacion finalizada con exito", "OK", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show($"Se ha producido un error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LoadData()
    End Sub

    Private Sub BtnCreateClient_Click(sender As Object, e As EventArgs) Handles BtnCreateClient.Click
        CreateClientForm.cargar = New CreateClientForm.operar(AddressOf LoadData)
        CreateClientForm.ShowDialog()
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
        BtnUpdateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientNit_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientNit.TextChanged
        BtnUpdateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientPhone.TextChanged
        BtnUpdateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientDirection_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientDirection.TextChanged
        BtnUpdateClient.Enabled = ValidateForm()
    End Sub

    Private Sub TxtBoxClientEMail_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxClientEMail.TextChanged
        BtnUpdateClient.Enabled = ValidateForm()
    End Sub

    Private Sub LstBoxListClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstBoxListClients.SelectedIndexChanged
        BtnUpdateClient.Enabled = ValidateForm()
    End Sub
End Class