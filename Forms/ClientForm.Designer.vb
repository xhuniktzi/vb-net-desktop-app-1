<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
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
        Me.LblTitleClient = New System.Windows.Forms.Label()
        Me.PnlProductList = New System.Windows.Forms.Panel()
        Me.LstBoxListClients = New System.Windows.Forms.ListBox()
        Me.PnlClient = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBoxClientEMail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxClientDirection = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxClientPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxClientName = New System.Windows.Forms.TextBox()
        Me.TxtBoxClientNit = New System.Windows.Forms.TextBox()
        Me.BtnCreateClient = New System.Windows.Forms.Button()
        Me.BtnUpdateClient = New System.Windows.Forms.Button()
        Me.BtnDeleteClient = New System.Windows.Forms.Button()
        Me.BindingSourceClients = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlTitle.SuspendLayout()
        Me.PnlProductList.SuspendLayout()
        Me.PnlClient.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSourceClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.Orange
        Me.PnlTitle.Controls.Add(Me.LblTitleClient)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(719, 80)
        Me.PnlTitle.TabIndex = 1
        '
        'LblTitleClient
        '
        Me.LblTitleClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitleClient.AutoSize = True
        Me.LblTitleClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleClient.Location = New System.Drawing.Point(134, 9)
        Me.LblTitleClient.Name = "LblTitleClient"
        Me.LblTitleClient.Size = New System.Drawing.Size(451, 55)
        Me.LblTitleClient.TabIndex = 0
        Me.LblTitleClient.Text = "Control de Clientes"
        '
        'PnlProductList
        '
        Me.PnlProductList.Controls.Add(Me.LstBoxListClients)
        Me.PnlProductList.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlProductList.Location = New System.Drawing.Point(0, 80)
        Me.PnlProductList.Name = "PnlProductList"
        Me.PnlProductList.Size = New System.Drawing.Size(228, 357)
        Me.PnlProductList.TabIndex = 2
        '
        'LstBoxListClients
        '
        Me.LstBoxListClients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstBoxListClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBoxListClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxListClients.FormattingEnabled = True
        Me.LstBoxListClients.ItemHeight = 20
        Me.LstBoxListClients.Location = New System.Drawing.Point(0, 0)
        Me.LstBoxListClients.Name = "LstBoxListClients"
        Me.LstBoxListClients.Size = New System.Drawing.Size(228, 357)
        Me.LstBoxListClients.TabIndex = 1
        '
        'PnlClient
        '
        Me.PnlClient.BackColor = System.Drawing.Color.White
        Me.PnlClient.Controls.Add(Me.Button1)
        Me.PnlClient.Controls.Add(Me.GroupBox1)
        Me.PnlClient.Controls.Add(Me.BtnCreateClient)
        Me.PnlClient.Controls.Add(Me.BtnUpdateClient)
        Me.PnlClient.Controls.Add(Me.BtnDeleteClient)
        Me.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlClient.Location = New System.Drawing.Point(228, 80)
        Me.PnlClient.Name = "PnlClient"
        Me.PnlClient.Size = New System.Drawing.Size(491, 357)
        Me.PnlClient.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-206, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Refrescar datos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBoxClientEMail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtBoxClientDirection)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtBoxClientPhone)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtBoxClientName)
        Me.GroupBox1.Controls.Add(Me.TxtBoxClientNit)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 310)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Correo electronico:"
        '
        'TxtBoxClientEMail
        '
        Me.TxtBoxClientEMail.Location = New System.Drawing.Point(184, 182)
        Me.TxtBoxClientEMail.Name = "TxtBoxClientEMail"
        Me.TxtBoxClientEMail.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientEMail.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Dirección:"
        '
        'TxtBoxClientDirection
        '
        Me.TxtBoxClientDirection.Location = New System.Drawing.Point(184, 144)
        Me.TxtBoxClientDirection.Name = "TxtBoxClientDirection"
        Me.TxtBoxClientDirection.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientDirection.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Numero de telefono:"
        '
        'TxtBoxClientPhone
        '
        Me.TxtBoxClientPhone.Location = New System.Drawing.Point(184, 105)
        Me.TxtBoxClientPhone.Name = "TxtBoxClientPhone"
        Me.TxtBoxClientPhone.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientPhone.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nit:"
        '
        'TxtBoxClientName
        '
        Me.TxtBoxClientName.Location = New System.Drawing.Point(184, 30)
        Me.TxtBoxClientName.Name = "TxtBoxClientName"
        Me.TxtBoxClientName.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientName.TabIndex = 6
        '
        'TxtBoxClientNit
        '
        Me.TxtBoxClientNit.Location = New System.Drawing.Point(184, 66)
        Me.TxtBoxClientNit.Name = "TxtBoxClientNit"
        Me.TxtBoxClientNit.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientNit.TabIndex = 7
        '
        'BtnCreateClient
        '
        Me.BtnCreateClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCreateClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCreateClient.FlatAppearance.BorderSize = 0
        Me.BtnCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreateClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateClient.ForeColor = System.Drawing.Color.White
        Me.BtnCreateClient.Location = New System.Drawing.Point(6, 318)
        Me.BtnCreateClient.Name = "BtnCreateClient"
        Me.BtnCreateClient.Size = New System.Drawing.Size(66, 27)
        Me.BtnCreateClient.TabIndex = 12
        Me.BtnCreateClient.Text = "Crear"
        Me.BtnCreateClient.UseVisualStyleBackColor = False
        '
        'BtnUpdateClient
        '
        Me.BtnUpdateClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdateClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdateClient.FlatAppearance.BorderSize = 0
        Me.BtnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateClient.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateClient.Location = New System.Drawing.Point(294, 318)
        Me.BtnUpdateClient.Name = "BtnUpdateClient"
        Me.BtnUpdateClient.Size = New System.Drawing.Size(98, 27)
        Me.BtnUpdateClient.TabIndex = 11
        Me.BtnUpdateClient.Text = "Actualizar"
        Me.BtnUpdateClient.UseVisualStyleBackColor = False
        '
        'BtnDeleteClient
        '
        Me.BtnDeleteClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnDeleteClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteClient.FlatAppearance.BorderSize = 0
        Me.BtnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteClient.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteClient.Location = New System.Drawing.Point(398, 318)
        Me.BtnDeleteClient.Name = "BtnDeleteClient"
        Me.BtnDeleteClient.Size = New System.Drawing.Size(83, 27)
        Me.BtnDeleteClient.TabIndex = 10
        Me.BtnDeleteClient.Text = "Eliminar"
        Me.BtnDeleteClient.UseVisualStyleBackColor = False
        '
        'ClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 437)
        Me.Controls.Add(Me.PnlClient)
        Me.Controls.Add(Me.PnlProductList)
        Me.Controls.Add(Me.PnlTitle)
        Me.MaximizeBox = False
        Me.Name = "ClientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Clientes"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.PnlProductList.ResumeLayout(False)
        Me.PnlClient.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSourceClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents PnlProductList As Panel
    Friend WithEvents LstBoxListClients As ListBox
    Friend WithEvents PnlClient As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxClientName As TextBox
    Friend WithEvents TxtBoxClientNit As TextBox
    Friend WithEvents BtnCreateClient As Button
    Friend WithEvents BtnUpdateClient As Button
    Friend WithEvents BtnDeleteClient As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxClientPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxClientDirection As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxClientEMail As TextBox
    Friend WithEvents LblTitleClient As Label
    Friend WithEvents BindingSourceClients As BindingSource
End Class
