<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PnlProductList = New System.Windows.Forms.Panel()
        Me.BtnRefreshProducts = New System.Windows.Forms.Button()
        Me.ListBoxProducts = New System.Windows.Forms.ListBox()
        Me.PnlProduct = New System.Windows.Forms.Panel()
        Me.LblProductMinQuantity = New System.Windows.Forms.Label()
        Me.TextBoxProductMinQuantity = New System.Windows.Forms.TextBox()
        Me.LblProductPrice = New System.Windows.Forms.Label()
        Me.TextBoxProductPrice = New System.Windows.Forms.TextBox()
        Me.LblProductDesc = New System.Windows.Forms.Label()
        Me.TextBoxProductDesc = New System.Windows.Forms.TextBox()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.TextBoxProductName = New System.Windows.Forms.TextBox()
        Me.TextBoxProductCode = New System.Windows.Forms.TextBox()
        Me.LblProductCode = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCreateProduct = New System.Windows.Forms.Button()
        Me.BtnUpdateProduct = New System.Windows.Forms.Button()
        Me.BtnDeleteProduct = New System.Windows.Forms.Button()
        Me.PnlTitle.SuspendLayout()
        Me.PnlProductList.SuspendLayout()
        Me.PnlProduct.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.Controls.Add(Me.LblTitle)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(879, 93)
        Me.PnlTitle.TabIndex = 0
        '
        'LblTitle
        '
        Me.LblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(129, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(655, 73)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Control de Productos"
        '
        'PnlProductList
        '
        Me.PnlProductList.Controls.Add(Me.BtnRefreshProducts)
        Me.PnlProductList.Controls.Add(Me.ListBoxProducts)
        Me.PnlProductList.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlProductList.Location = New System.Drawing.Point(0, 93)
        Me.PnlProductList.Name = "PnlProductList"
        Me.PnlProductList.Size = New System.Drawing.Size(181, 318)
        Me.PnlProductList.TabIndex = 1
        '
        'BtnRefreshProducts
        '
        Me.BtnRefreshProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefreshProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshProducts.Location = New System.Drawing.Point(40, 20)
        Me.BtnRefreshProducts.Name = "BtnRefreshProducts"
        Me.BtnRefreshProducts.Size = New System.Drawing.Size(97, 30)
        Me.BtnRefreshProducts.TabIndex = 1
        Me.BtnRefreshProducts.Text = "Refrescar"
        Me.BtnRefreshProducts.UseVisualStyleBackColor = True
        '
        'ListBoxProducts
        '
        Me.ListBoxProducts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxProducts.FormattingEnabled = True
        Me.ListBoxProducts.ItemHeight = 20
        Me.ListBoxProducts.Location = New System.Drawing.Point(0, 74)
        Me.ListBoxProducts.Name = "ListBoxProducts"
        Me.ListBoxProducts.Size = New System.Drawing.Size(181, 244)
        Me.ListBoxProducts.TabIndex = 0
        '
        'PnlProduct
        '
        Me.PnlProduct.Controls.Add(Me.LblProductMinQuantity)
        Me.PnlProduct.Controls.Add(Me.TextBoxProductMinQuantity)
        Me.PnlProduct.Controls.Add(Me.LblProductPrice)
        Me.PnlProduct.Controls.Add(Me.TextBoxProductPrice)
        Me.PnlProduct.Controls.Add(Me.LblProductDesc)
        Me.PnlProduct.Controls.Add(Me.TextBoxProductDesc)
        Me.PnlProduct.Controls.Add(Me.LblProductName)
        Me.PnlProduct.Controls.Add(Me.TextBoxProductName)
        Me.PnlProduct.Controls.Add(Me.TextBoxProductCode)
        Me.PnlProduct.Controls.Add(Me.LblProductCode)
        Me.PnlProduct.Controls.Add(Me.Panel1)
        Me.PnlProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlProduct.Location = New System.Drawing.Point(181, 93)
        Me.PnlProduct.Name = "PnlProduct"
        Me.PnlProduct.Size = New System.Drawing.Size(698, 318)
        Me.PnlProduct.TabIndex = 2
        '
        'LblProductMinQuantity
        '
        Me.LblProductMinQuantity.AutoSize = True
        Me.LblProductMinQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductMinQuantity.Location = New System.Drawing.Point(3, 123)
        Me.LblProductMinQuantity.Name = "LblProductMinQuantity"
        Me.LblProductMinQuantity.Size = New System.Drawing.Size(127, 16)
        Me.LblProductMinQuantity.TabIndex = 10
        Me.LblProductMinQuantity.Text = "Cantidad Minima:"
        '
        'TextBoxProductMinQuantity
        '
        Me.TextBoxProductMinQuantity.Location = New System.Drawing.Point(132, 123)
        Me.TextBoxProductMinQuantity.Name = "TextBoxProductMinQuantity"
        Me.TextBoxProductMinQuantity.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxProductMinQuantity.TabIndex = 9
        '
        'LblProductPrice
        '
        Me.LblProductPrice.AutoSize = True
        Me.LblProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductPrice.Location = New System.Drawing.Point(3, 94)
        Me.LblProductPrice.Name = "LblProductPrice"
        Me.LblProductPrice.Size = New System.Drawing.Size(57, 16)
        Me.LblProductPrice.TabIndex = 8
        Me.LblProductPrice.Text = "Precio:"
        '
        'TextBoxProductPrice
        '
        Me.TextBoxProductPrice.Location = New System.Drawing.Point(132, 93)
        Me.TextBoxProductPrice.Name = "TextBoxProductPrice"
        Me.TextBoxProductPrice.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxProductPrice.TabIndex = 7
        '
        'LblProductDesc
        '
        Me.LblProductDesc.AutoSize = True
        Me.LblProductDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductDesc.Location = New System.Drawing.Point(3, 63)
        Me.LblProductDesc.Name = "LblProductDesc"
        Me.LblProductDesc.Size = New System.Drawing.Size(95, 16)
        Me.LblProductDesc.TabIndex = 6
        Me.LblProductDesc.Text = "Descripción:"
        '
        'TextBoxProductDesc
        '
        Me.TextBoxProductDesc.Location = New System.Drawing.Point(132, 62)
        Me.TextBoxProductDesc.Name = "TextBoxProductDesc"
        Me.TextBoxProductDesc.Size = New System.Drawing.Size(554, 20)
        Me.TextBoxProductDesc.TabIndex = 5
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductName.Location = New System.Drawing.Point(3, 34)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(67, 16)
        Me.LblProductName.TabIndex = 4
        Me.LblProductName.Text = "Nombre:"
        '
        'TextBoxProductName
        '
        Me.TextBoxProductName.Location = New System.Drawing.Point(132, 33)
        Me.TextBoxProductName.Name = "TextBoxProductName"
        Me.TextBoxProductName.Size = New System.Drawing.Size(554, 20)
        Me.TextBoxProductName.TabIndex = 3
        '
        'TextBoxProductCode
        '
        Me.TextBoxProductCode.Location = New System.Drawing.Point(132, 7)
        Me.TextBoxProductCode.Name = "TextBoxProductCode"
        Me.TextBoxProductCode.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxProductCode.TabIndex = 2
        '
        'LblProductCode
        '
        Me.LblProductCode.AutoSize = True
        Me.LblProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductCode.Location = New System.Drawing.Point(4, 8)
        Me.LblProductCode.Name = "LblProductCode"
        Me.LblProductCode.Size = New System.Drawing.Size(62, 16)
        Me.LblProductCode.TabIndex = 1
        Me.LblProductCode.Text = "Codigo:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCreateProduct)
        Me.Panel1.Controls.Add(Me.BtnUpdateProduct)
        Me.Panel1.Controls.Add(Me.BtnDeleteProduct)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 54)
        Me.Panel1.TabIndex = 0
        '
        'BtnCreateProduct
        '
        Me.BtnCreateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateProduct.Location = New System.Drawing.Point(7, 13)
        Me.BtnCreateProduct.Name = "BtnCreateProduct"
        Me.BtnCreateProduct.Size = New System.Drawing.Size(154, 29)
        Me.BtnCreateProduct.TabIndex = 2
        Me.BtnCreateProduct.Text = "Crear un producto"
        Me.BtnCreateProduct.UseVisualStyleBackColor = True
        '
        'BtnUpdateProduct
        '
        Me.BtnUpdateProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUpdateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateProduct.Location = New System.Drawing.Point(476, 13)
        Me.BtnUpdateProduct.Name = "BtnUpdateProduct"
        Me.BtnUpdateProduct.Size = New System.Drawing.Size(105, 29)
        Me.BtnUpdateProduct.TabIndex = 1
        Me.BtnUpdateProduct.Text = "Actualizar"
        Me.BtnUpdateProduct.UseVisualStyleBackColor = True
        '
        'BtnDeleteProduct
        '
        Me.BtnDeleteProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteProduct.Location = New System.Drawing.Point(587, 13)
        Me.BtnDeleteProduct.Name = "BtnDeleteProduct"
        Me.BtnDeleteProduct.Size = New System.Drawing.Size(99, 29)
        Me.BtnDeleteProduct.TabIndex = 0
        Me.BtnDeleteProduct.Text = "Eliminar"
        Me.BtnDeleteProduct.UseVisualStyleBackColor = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 411)
        Me.Controls.Add(Me.PnlProduct)
        Me.Controls.Add(Me.PnlProductList)
        Me.Controls.Add(Me.PnlTitle)
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Productos"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.PnlProductList.ResumeLayout(False)
        Me.PnlProduct.ResumeLayout(False)
        Me.PnlProduct.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents PnlProductList As Panel
    Friend WithEvents BtnRefreshProducts As Button
    Friend WithEvents ListBoxProducts As ListBox
    Friend WithEvents PnlProduct As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDeleteProduct As Button
    Friend WithEvents BtnUpdateProduct As Button
    Friend WithEvents BtnCreateProduct As Button
    Friend WithEvents LblProductName As Label
    Friend WithEvents TextBoxProductName As TextBox
    Friend WithEvents TextBoxProductCode As TextBox
    Friend WithEvents LblProductCode As Label
    Friend WithEvents LblProductDesc As Label
    Friend WithEvents TextBoxProductDesc As TextBox
    Friend WithEvents LblProductPrice As Label
    Friend WithEvents LblProductMinQuantity As Label
    Friend WithEvents TextBoxProductMinQuantity As TextBox
    Friend WithEvents TextBoxProductPrice As TextBox
End Class
