<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuerySelectProduct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.TxtBoxProductName = New System.Windows.Forms.TextBox()
        Me.BtnSearchProductByName = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxProductCode = New System.Windows.Forms.TextBox()
        Me.BtnSearchProduct = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSelectProduct = New System.Windows.Forms.Button()
        Me.DataGridProducts = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpSearch.SuspendLayout()
        CType(Me.DataGridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.TxtBoxProductName)
        Me.GrpSearch.Controls.Add(Me.BtnSearchProductByName)
        Me.GrpSearch.Controls.Add(Me.Label2)
        Me.GrpSearch.Controls.Add(Me.TxtBoxProductCode)
        Me.GrpSearch.Controls.Add(Me.BtnSearchProduct)
        Me.GrpSearch.Controls.Add(Me.Label1)
        Me.GrpSearch.Location = New System.Drawing.Point(12, 87)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(425, 94)
        Me.GrpSearch.TabIndex = 17
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Busqueda"
        '
        'TxtBoxProductName
        '
        Me.TxtBoxProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxProductName.Location = New System.Drawing.Point(175, 59)
        Me.TxtBoxProductName.Name = "TxtBoxProductName"
        Me.TxtBoxProductName.Size = New System.Drawing.Size(126, 26)
        Me.TxtBoxProductName.TabIndex = 14
        '
        'BtnSearchProductByName
        '
        Me.BtnSearchProductByName.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSearchProductByName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchProductByName.FlatAppearance.BorderSize = 0
        Me.BtnSearchProductByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchProductByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchProductByName.ForeColor = System.Drawing.Color.White
        Me.BtnSearchProductByName.Location = New System.Drawing.Point(307, 58)
        Me.BtnSearchProductByName.Name = "BtnSearchProductByName"
        Me.BtnSearchProductByName.Size = New System.Drawing.Size(112, 27)
        Me.BtnSearchProductByName.TabIndex = 13
        Me.BtnSearchProductByName.Text = "Buscar"
        Me.BtnSearchProductByName.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Buscar por Nombre:"
        '
        'TxtBoxProductCode
        '
        Me.TxtBoxProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxProductCode.Location = New System.Drawing.Point(175, 22)
        Me.TxtBoxProductCode.Name = "TxtBoxProductCode"
        Me.TxtBoxProductCode.Size = New System.Drawing.Size(126, 26)
        Me.TxtBoxProductCode.TabIndex = 11
        '
        'BtnSearchProduct
        '
        Me.BtnSearchProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSearchProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchProduct.FlatAppearance.BorderSize = 0
        Me.BtnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchProduct.ForeColor = System.Drawing.Color.White
        Me.BtnSearchProduct.Location = New System.Drawing.Point(307, 21)
        Me.BtnSearchProduct.Name = "BtnSearchProduct"
        Me.BtnSearchProduct.Size = New System.Drawing.Size(112, 27)
        Me.BtnSearchProduct.TabIndex = 10
        Me.BtnSearchProduct.Text = "Buscar"
        Me.BtnSearchProduct.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por Codigo:"
        '
        'BtnSelectProduct
        '
        Me.BtnSelectProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectProduct.FlatAppearance.BorderSize = 0
        Me.BtnSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectProduct.ForeColor = System.Drawing.Color.White
        Me.BtnSelectProduct.Location = New System.Drawing.Point(459, 108)
        Me.BtnSelectProduct.Name = "BtnSelectProduct"
        Me.BtnSelectProduct.Size = New System.Drawing.Size(112, 27)
        Me.BtnSelectProduct.TabIndex = 16
        Me.BtnSelectProduct.Text = "Seleccionar"
        Me.BtnSelectProduct.UseVisualStyleBackColor = False
        '
        'DataGridProducts
        '
        Me.DataGridProducts.AllowUserToAddRows = False
        Me.DataGridProducts.AllowUserToDeleteRows = False
        Me.DataGridProducts.AutoGenerateColumns = False
        Me.DataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridProducts.DataSource = Me.ProductBindingSource
        Me.DataGridProducts.Location = New System.Drawing.Point(11, 187)
        Me.DataGridProducts.Name = "DataGridProducts"
        Me.DataGridProducts.ReadOnly = True
        Me.DataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridProducts.Size = New System.Drawing.Size(560, 193)
        Me.DataGridProducts.TabIndex = 15
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeDataGridViewTextBoxColumn.Width = 81
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 76
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(vb_net_desktop_app_1.Product)
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.Orange
        Me.PnlTitle.Controls.Add(Me.Label3)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(585, 80)
        Me.PnlTitle.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(501, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seleccionar Producto"
        '
        'QuerySelectProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(585, 393)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.BtnSelectProduct)
        Me.Controls.Add(Me.DataGridProducts)
        Me.Controls.Add(Me.PnlTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "QuerySelectProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Producto"
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        CType(Me.DataGridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents TxtBoxProductCode As TextBox
    Friend WithEvents BtnSearchProduct As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSelectProduct As Button
    Friend WithEvents DataGridProducts As DataGridView
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents TxtBoxProductName As TextBox
    Friend WithEvents BtnSearchProductByName As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
