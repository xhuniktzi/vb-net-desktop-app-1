<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateProductForm
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
        Me.TxtBoxProductCode = New System.Windows.Forms.TextBox()
        Me.TxtBoxProductName = New System.Windows.Forms.TextBox()
        Me.TxtBoxProductDesc = New System.Windows.Forms.TextBox()
        Me.NumBoxProductPrice = New System.Windows.Forms.NumericUpDown()
        Me.NumBoxProductMinQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCreateProduct = New System.Windows.Forms.Button()
        Me.PnlTitle.SuspendLayout()
        CType(Me.NumBoxProductPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBoxProductMinQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.Controls.Add(Me.LblTitle)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(496, 53)
        Me.PnlTitle.TabIndex = 0
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(12, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(324, 33)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Crear Nuevo Producto"
        '
        'TxtBoxProductCode
        '
        Me.TxtBoxProductCode.Location = New System.Drawing.Point(187, 68)
        Me.TxtBoxProductCode.Name = "TxtBoxProductCode"
        Me.TxtBoxProductCode.Size = New System.Drawing.Size(120, 20)
        Me.TxtBoxProductCode.TabIndex = 16
        '
        'TxtBoxProductName
        '
        Me.TxtBoxProductName.Location = New System.Drawing.Point(187, 99)
        Me.TxtBoxProductName.Name = "TxtBoxProductName"
        Me.TxtBoxProductName.Size = New System.Drawing.Size(276, 20)
        Me.TxtBoxProductName.TabIndex = 17
        '
        'TxtBoxProductDesc
        '
        Me.TxtBoxProductDesc.Location = New System.Drawing.Point(187, 128)
        Me.TxtBoxProductDesc.Name = "TxtBoxProductDesc"
        Me.TxtBoxProductDesc.Size = New System.Drawing.Size(276, 20)
        Me.TxtBoxProductDesc.TabIndex = 18
        '
        'NumBoxProductPrice
        '
        Me.NumBoxProductPrice.DecimalPlaces = 2
        Me.NumBoxProductPrice.Location = New System.Drawing.Point(187, 156)
        Me.NumBoxProductPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumBoxProductPrice.Name = "NumBoxProductPrice"
        Me.NumBoxProductPrice.Size = New System.Drawing.Size(120, 20)
        Me.NumBoxProductPrice.TabIndex = 19
        '
        'NumBoxProductMinQuantity
        '
        Me.NumBoxProductMinQuantity.Location = New System.Drawing.Point(187, 184)
        Me.NumBoxProductMinQuantity.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumBoxProductMinQuantity.Name = "NumBoxProductMinQuantity"
        Me.NumBoxProductMinQuantity.Size = New System.Drawing.Size(120, 20)
        Me.NumBoxProductMinQuantity.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cantidad Minima:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo:"
        '
        'BtnCreateProduct
        '
        Me.BtnCreateProduct.Enabled = False
        Me.BtnCreateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateProduct.Location = New System.Drawing.Point(409, 221)
        Me.BtnCreateProduct.Name = "BtnCreateProduct"
        Me.BtnCreateProduct.Size = New System.Drawing.Size(75, 28)
        Me.BtnCreateProduct.TabIndex = 21
        Me.BtnCreateProduct.Text = "Crear"
        Me.BtnCreateProduct.UseVisualStyleBackColor = True
        '
        'CreateProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 261)
        Me.Controls.Add(Me.BtnCreateProduct)
        Me.Controls.Add(Me.TxtBoxProductCode)
        Me.Controls.Add(Me.TxtBoxProductName)
        Me.Controls.Add(Me.TxtBoxProductDesc)
        Me.Controls.Add(Me.NumBoxProductPrice)
        Me.Controls.Add(Me.NumBoxProductMinQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlTitle)
        Me.Name = "CreateProductForm"
        Me.Text = "CreateProductForm"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.NumBoxProductPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBoxProductMinQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtBoxProductCode As TextBox
    Friend WithEvents TxtBoxProductName As TextBox
    Friend WithEvents TxtBoxProductDesc As TextBox
    Friend WithEvents NumBoxProductPrice As NumericUpDown
    Friend WithEvents NumBoxProductMinQuantity As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCreateProduct As Button
End Class
