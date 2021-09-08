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
    End Sub

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub ClientForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

    Private Sub BtnRefreshListProducts_Click(sender As Object, e As EventArgs) Handles BtnRefreshListProducts.Click
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
            MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LoadData()
    End Sub
End Class