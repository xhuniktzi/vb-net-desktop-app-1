<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.LblTitleProduct = New System.Windows.Forms.Label()
        Me.PnlProductList = New System.Windows.Forms.Panel()
        Me.LstBoxListProducts = New System.Windows.Forms.ListBox()
        Me.PnlProduct = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxProductCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxProductName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBoxProductDesc = New System.Windows.Forms.TextBox()
        Me.NumBoxProductMinQuantity = New System.Windows.Forms.NumericUpDown()
        Me.NumBoxProductPrice = New System.Windows.Forms.NumericUpDown()
        Me.BtnCreateProduct = New System.Windows.Forms.Button()
        Me.BtnUpdateProduct = New System.Windows.Forms.Button()
        Me.BtnDeleteProduct = New System.Windows.Forms.Button()
        Me.BindingSourceProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlTitle.SuspendLayout()
        Me.PnlProductList.SuspendLayout()
        Me.PnlProduct.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumBoxProductMinQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBoxProductPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.Orange
        Me.PnlTitle.Controls.Add(Me.LblTitleProduct)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(680, 80)
        Me.PnlTitle.TabIndex = 0
        '
        'LblTitleProduct
        '
        Me.LblTitleProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitleProduct.AutoSize = True
        Me.LblTitleProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleProduct.Location = New System.Drawing.Point(79, 9)
        Me.LblTitleProduct.Name = "LblTitleProduct"
        Me.LblTitleProduct.Size = New System.Drawing.Size(496, 55)
        Me.LblTitleProduct.TabIndex = 0
        Me.LblTitleProduct.Text = "Control de Productos"
        '
        'PnlProductList
        '
        Me.PnlProductList.Controls.Add(Me.LstBoxListProducts)
        Me.PnlProductList.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlProductList.Location = New System.Drawing.Point(0, 80)
        Me.PnlProductList.Name = "PnlProductList"
        Me.PnlProductList.Size = New System.Drawing.Size(228, 359)
        Me.PnlProductList.TabIndex = 1
        '
        'LstBoxListProducts
        '
        Me.LstBoxListProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstBoxListProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBoxListProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxListProducts.FormattingEnabled = True
        Me.LstBoxListProducts.ItemHeight = 20
        Me.LstBoxListProducts.Location = New System.Drawing.Point(0, 0)
        Me.LstBoxListProducts.Name = "LstBoxListProducts"
        Me.LstBoxListProducts.Size = New System.Drawing.Size(228, 359)
        Me.LstBoxListProducts.TabIndex = 1
        '
        'PnlProduct
        '
        Me.PnlProduct.Controls.Add(Me.Button1)
        Me.PnlProduct.Controls.Add(Me.GroupBox1)
        Me.PnlProduct.Controls.Add(Me.BtnCreateProduct)
        Me.PnlProduct.Controls.Add(Me.BtnUpdateProduct)
        Me.PnlProduct.Controls.Add(Me.BtnDeleteProduct)
        Me.PnlProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlProduct.Location = New System.Drawing.Point(228, 80)
        Me.PnlProduct.Name = "PnlProduct"
        Me.PnlProduct.Size = New System.Drawing.Size(452, 359)
        Me.PnlProduct.TabIndex = 2
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
        Me.Button1.Size = New System.Drawing.Size(161, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Refrescar datos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBoxProductCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtBoxProductName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBoxProductDesc)
        Me.GroupBox1.Controls.Add(Me.NumBoxProductMinQuantity)
        Me.GroupBox1.Controls.Add(Me.NumBoxProductPrice)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 310)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del producto"
        '
        'TxtBoxProductCode
        '
        Me.TxtBoxProductCode.Location = New System.Drawing.Point(160, 31)
        Me.TxtBoxProductCode.Name = "TxtBoxProductCode"
        Me.TxtBoxProductCode.Size = New System.Drawing.Size(120, 26)
        Me.TxtBoxProductCode.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio:"
        '
        'TxtBoxProductName
        '
        Me.TxtBoxProductName.Location = New System.Drawing.Point(160, 67)
        Me.TxtBoxProductName.Name = "TxtBoxProductName"
        Me.TxtBoxProductName.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxProductName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad Minima:"
        '
        'TxtBoxProductDesc
        '
        Me.TxtBoxProductDesc.Location = New System.Drawing.Point(160, 103)
        Me.TxtBoxProductDesc.Name = "TxtBoxProductDesc"
        Me.TxtBoxProductDesc.Size = New System.Drawing.Size(276, 26)
        Me.TxtBoxProductDesc.TabIndex = 7
        '
        'NumBoxProductMinQuantity
        '
        Me.NumBoxProductMinQuantity.Location = New System.Drawing.Point(160, 174)
        Me.NumBoxProductMinQuantity.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumBoxProductMinQuantity.Name = "NumBoxProductMinQuantity"
        Me.NumBoxProductMinQuantity.Size = New System.Drawing.Size(120, 26)
        Me.NumBoxProductMinQuantity.TabIndex = 9
        '
        'NumBoxProductPrice
        '
        Me.NumBoxProductPrice.DecimalPlaces = 2
        Me.NumBoxProductPrice.Location = New System.Drawing.Point(160, 139)
        Me.NumBoxProductPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumBoxProductPrice.Name = "NumBoxProductPrice"
        Me.NumBoxProductPrice.Size = New System.Drawing.Size(120, 26)
        Me.NumBoxProductPrice.TabIndex = 8
        '
        'BtnCreateProduct
        '
        Me.BtnCreateProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCreateProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCreateProduct.FlatAppearance.BorderSize = 0
        Me.BtnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateProduct.ForeColor = System.Drawing.Color.White
        Me.BtnCreateProduct.Location = New System.Drawing.Point(6, 316)
        Me.BtnCreateProduct.Name = "BtnCreateProduct"
        Me.BtnCreateProduct.Size = New System.Drawing.Size(66, 27)
        Me.BtnCreateProduct.TabIndex = 12
        Me.BtnCreateProduct.Text = "Crear"
        Me.BtnCreateProduct.UseVisualStyleBackColor = False
        '
        'BtnUpdateProduct
        '
        Me.BtnUpdateProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdateProduct.FlatAppearance.BorderSize = 0
        Me.BtnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateProduct.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateProduct.Location = New System.Drawing.Point(249, 316)
        Me.BtnUpdateProduct.Name = "BtnUpdateProduct"
        Me.BtnUpdateProduct.Size = New System.Drawing.Size(98, 27)
        Me.BtnUpdateProduct.TabIndex = 11
        Me.BtnUpdateProduct.Text = "Actualizar"
        Me.BtnUpdateProduct.UseVisualStyleBackColor = False
        '
        'BtnDeleteProduct
        '
        Me.BtnDeleteProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteProduct.FlatAppearance.BorderSize = 0
        Me.BtnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteProduct.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteProduct.Location = New System.Drawing.Point(353, 316)
        Me.BtnDeleteProduct.Name = "BtnDeleteProduct"
        Me.BtnDeleteProduct.Size = New System.Drawing.Size(83, 27)
        Me.BtnDeleteProduct.TabIndex = 10
        Me.BtnDeleteProduct.Text = "Eliminar"
        Me.BtnDeleteProduct.UseVisualStyleBackColor = False
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 439)
        Me.Controls.Add(Me.PnlProduct)
        Me.Controls.Add(Me.PnlProductList)
        Me.Controls.Add(Me.PnlTitle)
        Me.MaximizeBox = False
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.PnlProductList.ResumeLayout(False)
        Me.PnlProduct.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumBoxProductMinQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBoxProductPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents LblTitleProduct As Label
    Friend WithEvents PnlProductList As Panel
    Friend WithEvents LstBoxListProducts As ListBox
    Friend WithEvents PnlProduct As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxProductCode As TextBox
    Friend WithEvents TxtBoxProductName As TextBox
    Friend WithEvents TxtBoxProductDesc As TextBox
    Friend WithEvents NumBoxProductPrice As NumericUpDown
    Friend WithEvents NumBoxProductMinQuantity As NumericUpDown
    Friend WithEvents BindingSourceProducts As BindingSource
    Friend WithEvents BtnDeleteProduct As Button
    Friend WithEvents BtnUpdateProduct As Button
    Friend WithEvents BtnCreateProduct As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
End Class
