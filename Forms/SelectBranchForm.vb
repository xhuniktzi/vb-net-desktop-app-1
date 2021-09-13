Imports vb_net_desktop_app_1.Extensions
Public Class SelectBranchForm

    Private Property _branchRepo As IBranchRepository
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _branchRepo = New BranchRepository()
    End Sub
    Private Sub BtnSearchBranch_Click(sender As Object, e As EventArgs) Handles BtnSearchBranch.Click
        BranchBindingSource.Clear()
        If TxtBoxBranchID.Text.IsNotNullOrEmptyOrWhiteSpace() Then
            For Each branch In _branchRepo.GetAllBranches()
                BranchBindingSource.Add(branch)
            Next

            'DataGridBranches.DataSource = _branchRepo.GetAllBranches()
        Else
            Dim id As Integer = TxtBoxBranchID.Text
            Dim branch As Branch = _branchRepo.FindBranchById(id)
            'Dim res As List(Of Branch) = New List(Of Branch)
            'res.Add()
            BranchBindingSource.Add(branch)
        End If
    End Sub

    Private Sub BtnSelectBranch_Click(sender As Object, e As EventArgs) Handles BtnSelectBranch.Click
        Dim frm As CreateInvoice = CType(Owner, CreateInvoice)
        frm.CurrentBranch = BranchBindingSource.Current
        frm.TxtBoxBranchName.Text = BranchBindingSource.Current.Name
        frm.TxtBoxBranchDirection.Text = BranchBindingSource.Current.Direction
        Me.Close()
    End Sub
End Class