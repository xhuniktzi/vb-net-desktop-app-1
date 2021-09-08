<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateClientForm
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnCreateClient = New System.Windows.Forms.Button()
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
        Me.PnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.Orange
        Me.PnlTitle.Controls.Add(Me.LblTitle)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(481, 66)
        Me.PnlTitle.TabIndex = 1
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(41, 9)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(375, 42)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Crear Nuevo Cliente"
        '
        'BtnCreateClient
        '
        Me.BtnCreateClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCreateClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCreateClient.FlatAppearance.BorderSize = 0
        Me.BtnCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreateClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateClient.ForeColor = System.Drawing.Color.White
        Me.BtnCreateClient.Location = New System.Drawing.Point(398, 263)
        Me.BtnCreateClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCreateClient.Name = "BtnCreateClient"
        Me.BtnCreateClient.Size = New System.Drawing.Size(68, 35)
        Me.BtnCreateClient.TabIndex = 32
        Me.BtnCreateClient.Text = "Crear"
        Me.BtnCreateClient.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Correo electronico:"
        '
        'TxtBoxClientEMail
        '
        Me.TxtBoxClientEMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientEMail.Location = New System.Drawing.Point(190, 227)
        Me.TxtBoxClientEMail.Name = "TxtBoxClientEMail"
        Me.TxtBoxClientEMail.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientEMail.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Dirección:"
        '
        'TxtBoxClientDirection
        '
        Me.TxtBoxClientDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientDirection.Location = New System.Drawing.Point(190, 189)
        Me.TxtBoxClientDirection.Name = "TxtBoxClientDirection"
        Me.TxtBoxClientDirection.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientDirection.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Numero de telefono:"
        '
        'TxtBoxClientPhone
        '
        Me.TxtBoxClientPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientPhone.Location = New System.Drawing.Point(190, 150)
        Me.TxtBoxClientPhone.Name = "TxtBoxClientPhone"
        Me.TxtBoxClientPhone.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientPhone.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nit:"
        '
        'TxtBoxClientName
        '
        Me.TxtBoxClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientName.Location = New System.Drawing.Point(190, 75)
        Me.TxtBoxClientName.Name = "TxtBoxClientName"
        Me.TxtBoxClientName.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientName.TabIndex = 35
        '
        'TxtBoxClientNit
        '
        Me.TxtBoxClientNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxClientNit.Location = New System.Drawing.Point(190, 111)
        Me.TxtBoxClientNit.Name = "TxtBoxClientNit"
        Me.TxtBoxClientNit.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxClientNit.TabIndex = 36
        '
        'CreateClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 312)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBoxClientEMail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBoxClientDirection)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxClientPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBoxClientName)
        Me.Controls.Add(Me.TxtBoxClientNit)
        Me.Controls.Add(Me.BtnCreateClient)
        Me.Controls.Add(Me.PnlTitle)
        Me.Name = "CreateClientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateClientForm"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnCreateClient As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxClientEMail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxClientDirection As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxClientPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxClientName As TextBox
    Friend WithEvents TxtBoxClientNit As TextBox
End Class
