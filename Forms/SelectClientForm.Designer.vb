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
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridClients = New System.Windows.Forms.DataGridView()
        Me.BtnSelectClient = New System.Windows.Forms.Button()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.TxtBoxClientID = New System.Windows.Forms.TextBox()
        Me.BtnSearchClient = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.DataGridClients, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClients.Location = New System.Drawing.Point(12, 156)
        Me.DataGridClients.Name = "DataGridClients"
        Me.DataGridClients.ReadOnly = True
        Me.DataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridClients.Size = New System.Drawing.Size(560, 193)
        Me.DataGridClients.TabIndex = 7
        '
        'BtnSelectClient
        '
        Me.BtnSelectClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectClient.FlatAppearance.BorderSize = 0
        Me.BtnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectClient.ForeColor = System.Drawing.Color.White
        Me.BtnSelectClient.Location = New System.Drawing.Point(460, 109)
        Me.BtnSelectClient.Name = "BtnSelectClient"
        Me.BtnSelectClient.Size = New System.Drawing.Size(112, 27)
        Me.BtnSelectClient.TabIndex = 8
        Me.BtnSelectClient.Text = "Seleccionar"
        Me.BtnSelectClient.UseVisualStyleBackColor = False
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.TxtBoxClientID)
        Me.GrpSearch.Controls.Add(Me.BtnSearchClient)
        Me.GrpSearch.Controls.Add(Me.Label1)
        Me.GrpSearch.Location = New System.Drawing.Point(13, 88)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(425, 62)
        Me.GrpSearch.TabIndex = 9
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Busqueda"
        '
        'TxtBoxClientID
        '
        Me.TxtBoxClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientID.Location = New System.Drawing.Point(138, 22)
        Me.TxtBoxClientID.Name = "TxtBoxClientID"
        Me.TxtBoxClientID.Size = New System.Drawing.Size(120, 26)
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
        Me.BtnSearchClient.Location = New System.Drawing.Point(285, 21)
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
        'SelectClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.BtnSelectClient)
        Me.Controls.Add(Me.DataGridClients)
        Me.Controls.Add(Me.PnlTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SelectClientForm"
        Me.Text = "SelectClientForm"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.DataGridClients, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
