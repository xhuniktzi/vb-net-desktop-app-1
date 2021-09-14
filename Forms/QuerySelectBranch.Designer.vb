<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuerySelectBranch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.TxtBoxBranchID = New System.Windows.Forms.TextBox()
        Me.BtnSearchBranch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSelectBranch = New System.Windows.Forms.Button()
        Me.DataGridBranches = New System.Windows.Forms.DataGridView()
        Me.BranchIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpSearch.SuspendLayout()
        CType(Me.DataGridBranches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.TxtBoxBranchID)
        Me.GrpSearch.Controls.Add(Me.BtnSearchBranch)
        Me.GrpSearch.Controls.Add(Me.Label1)
        Me.GrpSearch.Location = New System.Drawing.Point(11, 97)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(425, 62)
        Me.GrpSearch.TabIndex = 17
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Busqueda"
        '
        'TxtBoxBranchID
        '
        Me.TxtBoxBranchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxBranchID.Location = New System.Drawing.Point(138, 22)
        Me.TxtBoxBranchID.Name = "TxtBoxBranchID"
        Me.TxtBoxBranchID.Size = New System.Drawing.Size(120, 26)
        Me.TxtBoxBranchID.TabIndex = 11
        '
        'BtnSearchBranch
        '
        Me.BtnSearchBranch.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSearchBranch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchBranch.FlatAppearance.BorderSize = 0
        Me.BtnSearchBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchBranch.ForeColor = System.Drawing.Color.White
        Me.BtnSearchBranch.Location = New System.Drawing.Point(285, 21)
        Me.BtnSearchBranch.Name = "BtnSearchBranch"
        Me.BtnSearchBranch.Size = New System.Drawing.Size(112, 27)
        Me.BtnSearchBranch.TabIndex = 10
        Me.BtnSearchBranch.Text = "Buscar"
        Me.BtnSearchBranch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por ID:"
        '
        'BtnSelectBranch
        '
        Me.BtnSelectBranch.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectBranch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectBranch.FlatAppearance.BorderSize = 0
        Me.BtnSelectBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectBranch.ForeColor = System.Drawing.Color.White
        Me.BtnSelectBranch.Location = New System.Drawing.Point(458, 118)
        Me.BtnSelectBranch.Name = "BtnSelectBranch"
        Me.BtnSelectBranch.Size = New System.Drawing.Size(112, 27)
        Me.BtnSelectBranch.TabIndex = 16
        Me.BtnSelectBranch.Text = "Seleccionar"
        Me.BtnSelectBranch.UseVisualStyleBackColor = False
        '
        'DataGridBranches
        '
        Me.DataGridBranches.AllowUserToAddRows = False
        Me.DataGridBranches.AllowUserToDeleteRows = False
        Me.DataGridBranches.AutoGenerateColumns = False
        Me.DataGridBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBranches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BranchIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DirectionDataGridViewTextBoxColumn})
        Me.DataGridBranches.DataSource = Me.BranchBindingSource
        Me.DataGridBranches.Location = New System.Drawing.Point(10, 165)
        Me.DataGridBranches.Name = "DataGridBranches"
        Me.DataGridBranches.ReadOnly = True
        Me.DataGridBranches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridBranches.Size = New System.Drawing.Size(560, 193)
        Me.DataGridBranches.TabIndex = 15
        '
        'BranchIdDataGridViewTextBoxColumn
        '
        Me.BranchIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BranchIdDataGridViewTextBoxColumn.DataPropertyName = "Branch_Id"
        Me.BranchIdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.BranchIdDataGridViewTextBoxColumn.Name = "BranchIdDataGridViewTextBoxColumn"
        Me.BranchIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.BranchIdDataGridViewTextBoxColumn.Width = 47
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DirectionDataGridViewTextBoxColumn
        '
        Me.DirectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DirectionDataGridViewTextBoxColumn.DataPropertyName = "Direction"
        Me.DirectionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirectionDataGridViewTextBoxColumn.Name = "DirectionDataGridViewTextBoxColumn"
        Me.DirectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DirectionDataGridViewTextBoxColumn.Width = 96
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataSource = GetType(vb_net_desktop_app_1.Branch)
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.Orange
        Me.PnlTitle.Controls.Add(Me.Label3)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(581, 80)
        Me.PnlTitle.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(495, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seleccionar Sucursal"
        '
        'QuerySelectBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 367)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.BtnSelectBranch)
        Me.Controls.Add(Me.DataGridBranches)
        Me.Controls.Add(Me.PnlTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "QuerySelectBranch"
        Me.Text = "QuerySelectBranch"
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        CType(Me.DataGridBranches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents TxtBoxBranchID As TextBox
    Friend WithEvents BtnSearchBranch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSelectBranch As Button
    Friend WithEvents DataGridBranches As DataGridView
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BranchIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchBindingSource As BindingSource
End Class
