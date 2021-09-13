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
        If TxtBoxBranchID.Text.IsNotNullOrEmptyOrWhiteSpace() Then
            DataGridBranches.DataSource = _branchRepo.GetAllBranches()
        Else
            Dim id As Integer = TxtBoxBranchID.Text
            Dim res As List(Of Branch) = New List(Of Branch)
            res.Add(_branchRepo.FindBranchById(id))
            DataGridBranches.DataSource = res
        End If
    End Sub

    Private Sub BtnSelectBranch_Click(sender As Object, e As EventArgs) Handles BtnSelectBranch.Click
        Dim frm As CreateInvoice = CType(Owner, CreateInvoice)
        frm.IdCurrentBranch = DataGridBranches.CurrentRow.Cells(0).Value
        frm.TxtBoxBranchName.Text = DataGridBranches.CurrentRow.Cells(1).Value
        frm.TxtBoxBranchDirection.Text = DataGridBranches.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub
End Class