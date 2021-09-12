Public Class SelectClientForm
    Private Property _clientRepo As IClientRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _clientRepo = New ClientRepository()
    End Sub
    Private Sub SelectClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridClients.DataSource = _clientRepo.GetAllClients
        'DataGridClients.Columns("Phone_Number").Visible = False
        'DataGridClients.Columns("Direction").Visible = False
        'DataGridClients.Columns("E_Mail").Visible = False
        'DataGridClients.Columns("Client_Id").HeaderText = "ID"
        'DataGridClients.Columns("Client_Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DataGridClients.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DataGridClients.Columns("Nit").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub BtnSearchClient_Click(sender As Object, e As EventArgs) Handles BtnSearchClient.Click
    End Sub
End Class