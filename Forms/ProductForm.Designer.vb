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
        Me.PnlRefreshBtn = New System.Windows.Forms.Panel()
        Me.BtnRefreshListProducts = New System.Windows.Forms.Button()
        Me.PnlProduct = New System.Windows.Forms.Panel()
        Me.BtnCreateProduct = New System.Windows.Forms.Button()
        Me.BtnUpdateProduct = New System.Windows.Forms.Button()
        Me.BtnDeleteProduct = New System.Windows.Forms.Button()
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
        Me.BindingSourceProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlTitle.SuspendLayout()
        Me.PnlProductList.SuspendLayout()
        Me.PnlRefreshBtn.SuspendLayout()
        Me.PnlProduct.SuspendLayout()
        CType(Me.NumBoxProductPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBoxProductMinQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.Controls.Add(Me.LblTitleProduct)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(704, 50)
        Me.PnlTitle.TabIndex = 0
        '
        'LblTitleProduct
        '
        Me.LblTitleProduct.AutoSize = True
        Me.LblTitleProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleProduct.Location = New System.Drawing.Point(12, 9)
        Me.LblTitleProduct.Name = "LblTitleProduct"
        Me.LblTitleProduct.Size = New System.Drawing.Size(308, 33)
        Me.LblTitleProduct.TabIndex = 0
        Me.LblTitleProduct.Text = "Control de Productos"
        '
        'PnlProductList
        '
        Me.PnlProductList.Controls.Add(Me.LstBoxListProducts)
        Me.PnlProductList.Controls.Add(Me.PnlRefreshBtn)
        Me.PnlProductList.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlProductList.Location = New System.Drawing.Point(0, 50)
        Me.PnlProductList.Name = "PnlProductList"
        Me.PnlProductList.Size = New System.Drawing.Size(256, 391)
        Me.PnlProductList.TabIndex = 1
        '
        'LstBoxListProducts
        '
        Me.LstBoxListProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBoxListProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxListProducts.FormattingEnabled = True
        Me.LstBoxListProducts.ItemHeight = 20
        Me.LstBoxListProducts.Location = New System.Drawing.Point(0, 50)
        Me.LstBoxListProducts.Name = "LstBoxListProducts"
        Me.LstBoxListProducts.Size = New System.Drawing.Size(256, 341)
        Me.LstBoxListProducts.TabIndex = 1
        '
        'PnlRefreshBtn
        '
        Me.PnlRefreshBtn.Controls.Add(Me.BtnRefreshListProducts)
        Me.PnlRefreshBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlRefreshBtn.Location = New System.Drawing.Point(0, 0)
        Me.PnlRefreshBtn.Name = "PnlRefreshBtn"
        Me.PnlRefreshBtn.Size = New System.Drawing.Size(256, 50)
        Me.PnlRefreshBtn.TabIndex = 0
        '
        'BtnRefreshListProducts
        '
        Me.BtnRefreshListProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefreshListProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshListProducts.Location = New System.Drawing.Point(50, 11)
        Me.BtnRefreshListProducts.Name = "BtnRefreshListProducts"
        Me.BtnRefreshListProducts.Size = New System.Drawing.Size(157, 28)
        Me.BtnRefreshListProducts.TabIndex = 0
        Me.BtnRefreshListProducts.Text = "Refrescar datos"
        Me.BtnRefreshListProducts.UseVisualStyleBackColor = True
        '
        'PnlProduct
        '
        Me.PnlProduct.Controls.Add(Me.BtnCreateProduct)
        Me.PnlProduct.Controls.Add(Me.BtnUpdateProduct)
        Me.PnlProduct.Controls.Add(Me.BtnDeleteProduct)
        Me.PnlProduct.Controls.Add(Me.TxtBoxProductCode)
        Me.PnlProduct.Controls.Add(Me.TxtBoxProductName)
        Me.PnlProduct.Controls.Add(Me.TxtBoxProductDesc)
        Me.PnlProduct.Controls.Add(Me.NumBoxProductPrice)
        Me.PnlProduct.Controls.Add(Me.NumBoxProductMinQuantity)
        Me.PnlProduct.Controls.Add(Me.Label5)
        Me.PnlProduct.Controls.Add(Me.Label4)
        Me.PnlProduct.Controls.Add(Me.Label3)
        Me.PnlProduct.Controls.Add(Me.Label2)
        Me.PnlProduct.Controls.Add(Me.Label1)
        Me.PnlProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlProduct.Location = New System.Drawing.Point(256, 50)
        Me.PnlProduct.Name = "PnlProduct"
        Me.PnlProduct.Size = New System.Drawing.Size(448, 391)
        Me.PnlProduct.TabIndex = 2
        '
        'BtnCreateProduct
        '
        Me.BtnCreateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateProduct.Location = New System.Drawing.Point(10, 352)
        Me.BtnCreateProduct.Name = "BtnCreateProduct"
        Me.BtnCreateProduct.Size = New System.Drawing.Size(66, 27)
        Me.BtnCreateProduct.TabIndex = 12
        Me.BtnCreateProduct.Text = "Crear"
        Me.BtnCreateProduct.UseVisualStyleBackColor = True
        '
        'BtnUpdateProduct
        '
        Me.BtnUpdateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateProduct.Location = New System.Drawing.Point(249, 352)
        Me.BtnUpdateProduct.Name = "BtnUpdateProduct"
        Me.BtnUpdateProduct.Size = New System.Drawing.Size(98, 27)
        Me.BtnUpdateProduct.TabIndex = 11
        Me.BtnUpdateProduct.Text = "Actualizar"
        Me.BtnUpdateProduct.UseVisualStyleBackColor = True
        '
        'BtnDeleteProduct
        '
        Me.BtnDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteProduct.Location = New System.Drawing.Point(353, 352)
        Me.BtnDeleteProduct.Name = "BtnDeleteProduct"
        Me.BtnDeleteProduct.Size = New System.Drawing.Size(83, 27)
        Me.BtnDeleteProduct.TabIndex = 10
        Me.BtnDeleteProduct.Text = "Eliminar"
        Me.BtnDeleteProduct.UseVisualStyleBackColor = True
        '
        'TxtBoxProductCode
        '
        Me.TxtBoxProductCode.Location = New System.Drawing.Point(160, 21)
        Me.TxtBoxProductCode.Name = "TxtBoxProductCode"
        Me.TxtBoxProductCode.Size = New System.Drawing.Size(120, 20)
        Me.TxtBoxProductCode.TabIndex = 5
        '
        'TxtBoxProductName
        '
        Me.TxtBoxProductName.Location = New System.Drawing.Point(160, 52)
        Me.TxtBoxProductName.Name = "TxtBoxProductName"
        Me.TxtBoxProductName.Size = New System.Drawing.Size(276, 20)
        Me.TxtBoxProductName.TabIndex = 6
        '
        'TxtBoxProductDesc
        '
        Me.TxtBoxProductDesc.Location = New System.Drawing.Point(160, 81)
        Me.TxtBoxProductDesc.Name = "TxtBoxProductDesc"
        Me.TxtBoxProductDesc.Size = New System.Drawing.Size(276, 20)
        Me.TxtBoxProductDesc.TabIndex = 7
        '
        'NumBoxProductPrice
        '
        Me.NumBoxProductPrice.DecimalPlaces = 2
        Me.NumBoxProductPrice.Location = New System.Drawing.Point(160, 109)
        Me.NumBoxProductPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumBoxProductPrice.Name = "NumBoxProductPrice"
        Me.NumBoxProductPrice.Size = New System.Drawing.Size(120, 20)
        Me.NumBoxProductPrice.TabIndex = 8
        '
        'NumBoxProductMinQuantity
        '
        Me.NumBoxProductMinQuantity.Location = New System.Drawing.Point(160, 137)
        Me.NumBoxProductMinQuantity.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumBoxProductMinQuantity.Name = "NumBoxProductMinQuantity"
        Me.NumBoxProductMinQuantity.Size = New System.Drawing.Size(120, 20)
        Me.NumBoxProductMinQuantity.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad Minima:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.PnlProduct)
        Me.Controls.Add(Me.PnlProductList)
        Me.Controls.Add(Me.PnlTitle)
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.PnlProductList.ResumeLayout(False)
        Me.PnlRefreshBtn.ResumeLayout(False)
        Me.PnlProduct.ResumeLayout(False)
        Me.PnlProduct.PerformLayout()
        CType(Me.NumBoxProductPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBoxProductMinQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents LblTitleProduct As Label
    Friend WithEvents PnlProductList As Panel
    Friend WithEvents LstBoxListProducts As ListBox
    Friend WithEvents PnlRefreshBtn As Panel
    Friend WithEvents BtnRefreshListProducts As Button
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
End Class
