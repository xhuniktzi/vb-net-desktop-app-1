<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectClientForm
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
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridClients = New System.Windows.Forms.DataGridView()
        Me.ClientIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSelectClient = New System.Windows.Forms.Button()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.TxtBoxClientName = New System.Windows.Forms.TextBox()
        Me.BtnSearchClientByName = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxClientID = New System.Windows.Forms.TextBox()
        Me.BtnSearchClient = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxClientNit = New System.Windows.Forms.TextBox()
        Me.BtnSearchClientByNit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.DataGridClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.Orange
        Me.PnlTitle.Controls.Add(Me.Label3)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(584, 80)
        Me.PnlTitle.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seleccionar Cliente"
        '
        'DataGridClients
        '
        Me.DataGridClients.AllowUserToAddRows = False
        Me.DataGridClients.AllowUserToDeleteRows = False
        Me.DataGridClients.AutoGenerateColumns = False
        Me.DataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.NitDataGridViewTextBoxColumn})
        Me.DataGridClients.DataSource = Me.ClientBindingSource
        Me.DataGridClients.Location = New System.Drawing.Point(12, 231)
        Me.DataGridClients.Name = "DataGridClients"
        Me.DataGridClients.ReadOnly = True
        Me.DataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridClients.Size = New System.Drawing.Size(560, 193)
        Me.DataGridClients.TabIndex = 7
        '
        'ClientIdDataGridViewTextBoxColumn
        '
        Me.ClientIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ClientIdDataGridViewTextBoxColumn.DataPropertyName = "Client_Id"
        Me.ClientIdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.ClientIdDataGridViewTextBoxColumn.Name = "ClientIdDataGridViewTextBoxColumn"
        Me.ClientIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientIdDataGridViewTextBoxColumn.Width = 47
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Nombre del Cliente"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NitDataGridViewTextBoxColumn
        '
        Me.NitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NitDataGridViewTextBoxColumn.DataPropertyName = "Nit"
        Me.NitDataGridViewTextBoxColumn.HeaderText = "Nit"
        Me.NitDataGridViewTextBoxColumn.Name = "NitDataGridViewTextBoxColumn"
        Me.NitDataGridViewTextBoxColumn.ReadOnly = True
        Me.NitDataGridViewTextBoxColumn.Width = 51
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataSource = GetType(vb_net_desktop_app_1.Client)
        '
        'BtnSelectClient
        '
        Me.BtnSelectClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectClient.FlatAppearance.BorderSize = 0
        Me.BtnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectClient.ForeColor = System.Drawing.Color.White
        Me.BtnSelectClient.Location = New System.Drawing.Point(460, 148)
        Me.BtnSelectClient.Name = "BtnSelectClient"
        Me.BtnSelectClient.Size = New System.Drawing.Size(112, 27)
        Me.BtnSelectClient.TabIndex = 8
        Me.BtnSelectClient.Text = "Seleccionar"
        Me.BtnSelectClient.UseVisualStyleBackColor = False
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.TxtBoxClientNit)
        Me.GrpSearch.Controls.Add(Me.BtnSearchClientByNit)
        Me.GrpSearch.Controls.Add(Me.Label4)
        Me.GrpSearch.Controls.Add(Me.TxtBoxClientName)
        Me.GrpSearch.Controls.Add(Me.BtnSearchClientByName)
        Me.GrpSearch.Controls.Add(Me.Label2)
        Me.GrpSearch.Controls.Add(Me.TxtBoxClientID)
        Me.GrpSearch.Controls.Add(Me.BtnSearchClient)
        Me.GrpSearch.Controls.Add(Me.Label1)
        Me.GrpSearch.Location = New System.Drawing.Point(13, 88)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(441, 137)
        Me.GrpSearch.TabIndex = 9
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Busqueda"
        '
        'TxtBoxClientName
        '
        Me.TxtBoxClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientName.Location = New System.Drawing.Point(173, 60)
        Me.TxtBoxClientName.Name = "TxtBoxClientName"
        Me.TxtBoxClientName.Size = New System.Drawing.Size(141, 26)
        Me.TxtBoxClientName.TabIndex = 14
        '
        'BtnSearchClientByName
        '
        Me.BtnSearchClientByName.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSearchClientByName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchClientByName.FlatAppearance.BorderSize = 0
        Me.BtnSearchClientByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchClientByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchClientByName.ForeColor = System.Drawing.Color.White
        Me.BtnSearchClientByName.Location = New System.Drawing.Point(320, 60)
        Me.BtnSearchClientByName.Name = "BtnSearchClientByName"
        Me.BtnSearchClientByName.Size = New System.Drawing.Size(112, 27)
        Me.BtnSearchClientByName.TabIndex = 13
        Me.BtnSearchClientByName.Text = "Buscar"
        Me.BtnSearchClientByName.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Buscar por Nombre:"
        '
        'TxtBoxClientID
        '
        Me.TxtBoxClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientID.Location = New System.Drawing.Point(173, 21)
        Me.TxtBoxClientID.Name = "TxtBoxClientID"
        Me.TxtBoxClientID.Size = New System.Drawing.Size(141, 26)
        Me.TxtBoxClientID.TabIndex = 11
        '
        'BtnSearchClient
        '
        Me.BtnSearchClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSearchClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchClient.FlatAppearance.BorderSize = 0
        Me.BtnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchClient.ForeColor = System.Drawing.Color.White
        Me.BtnSearchClient.Location = New System.Drawing.Point(320, 21)
        Me.BtnSearchClient.Name = "BtnSearchClient"
        Me.BtnSearchClient.Size = New System.Drawing.Size(112, 27)
        Me.BtnSearchClient.TabIndex = 10
        Me.BtnSearchClient.Text = "Buscar"
        Me.BtnSearchClient.UseVisualStyleBackColor = False
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
        'TxtBoxClientNit
        '
        Me.TxtBoxClientNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientNit.Location = New System.Drawing.Point(173, 99)
        Me.TxtBoxClientNit.Name = "TxtBoxClientNit"
        Me.TxtBoxClientNit.Size = New System.Drawing.Size(141, 26)
        Me.TxtBoxClientNit.TabIndex = 17
        '
        'BtnSearchClientByNit
        '
        Me.BtnSearchClientByNit.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSearchClientByNit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchClientByNit.FlatAppearance.BorderSize = 0
        Me.BtnSearchClientByNit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchClientByNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchClientByNit.ForeColor = System.Drawing.Color.White
        Me.BtnSearchClientByNit.Location = New System.Drawing.Point(320, 99)
        Me.BtnSearchClientByNit.Name = "BtnSearchClientByNit"
        Me.BtnSearchClientByNit.Size = New System.Drawing.Size(112, 27)
        Me.BtnSearchClientByNit.TabIndex = 16
        Me.BtnSearchClientByNit.Text = "Buscar"
        Me.BtnSearchClientByNit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Buscar por Nit:"
        '
        'SelectClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 437)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.BtnSelectClient)
        Me.Controls.Add(Me.DataGridClients)
        Me.Controls.Add(Me.PnlTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SelectClientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectClientForm"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.DataGridClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridClients As DataGridView
    Friend WithEvents BtnSelectClient As Button
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxClientID As TextBox
    Friend WithEvents BtnSearchClient As Button
    Friend WithEvents ClientIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents TxtBoxClientName As TextBox
    Friend WithEvents BtnSearchClientByName As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxClientNit As TextBox
    Friend WithEvents BtnSearchClientByNit As Button
    Friend WithEvents Label4 As Label
End Class
