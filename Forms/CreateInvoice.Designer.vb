<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateInvoice
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridProductDetail = New System.Windows.Forms.DataGridView()
        Me.BtnCreateInvoice = New System.Windows.Forms.Button()
        Me.BtnClearInvoice = New System.Windows.Forms.Button()
        Me.BtnViewInvoice = New System.Windows.Forms.Button()
        Me.GrpInvoiceClient = New System.Windows.Forms.GroupBox()
        Me.BtnSelectClient = New System.Windows.Forms.Button()
        Me.TxtBoxClientNit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxClientName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSelectBranch = New System.Windows.Forms.Button()
        Me.TxtBoxBranchDirection = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxBranchName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumBoxInvoiceNumber = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBoxInvoiceSerial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnDeleteProduct = New System.Windows.Forms.Button()
        Me.BtnAddProduct = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBoxTotalInvoice = New System.Windows.Forms.TextBox()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDetailInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridProductDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpInvoiceClient.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumBoxInvoiceNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDetailInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridProductDetail
        '
        Me.DataGridProductDetail.AllowUserToAddRows = False
        Me.DataGridProductDetail.AllowUserToDeleteRows = False
        Me.DataGridProductDetail.AutoGenerateColumns = False
        Me.DataGridProductDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProductDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridProductDetail.DataSource = Me.ProductDetailInvoiceBindingSource
        Me.DataGridProductDetail.Location = New System.Drawing.Point(16, 338)
        Me.DataGridProductDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridProductDetail.Name = "DataGridProductDetail"
        Me.DataGridProductDetail.ReadOnly = True
        Me.DataGridProductDetail.Size = New System.Drawing.Size(868, 208)
        Me.DataGridProductDetail.TabIndex = 0
        '
        'BtnCreateInvoice
        '
        Me.BtnCreateInvoice.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCreateInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCreateInvoice.FlatAppearance.BorderSize = 0
        Me.BtnCreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreateInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateInvoice.ForeColor = System.Drawing.Color.White
        Me.BtnCreateInvoice.Location = New System.Drawing.Point(751, 585)
        Me.BtnCreateInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCreateInvoice.Name = "BtnCreateInvoice"
        Me.BtnCreateInvoice.Size = New System.Drawing.Size(134, 29)
        Me.BtnCreateInvoice.TabIndex = 1
        Me.BtnCreateInvoice.Text = "Crear Factura"
        Me.BtnCreateInvoice.UseVisualStyleBackColor = False
        '
        'BtnClearInvoice
        '
        Me.BtnClearInvoice.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnClearInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClearInvoice.FlatAppearance.BorderSize = 0
        Me.BtnClearInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearInvoice.ForeColor = System.Drawing.Color.White
        Me.BtnClearInvoice.Location = New System.Drawing.Point(599, 585)
        Me.BtnClearInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClearInvoice.Name = "BtnClearInvoice"
        Me.BtnClearInvoice.Size = New System.Drawing.Size(144, 29)
        Me.BtnClearInvoice.TabIndex = 2
        Me.BtnClearInvoice.Text = "Limpiar Factura"
        Me.BtnClearInvoice.UseVisualStyleBackColor = False
        '
        'BtnViewInvoice
        '
        Me.BtnViewInvoice.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnViewInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnViewInvoice.FlatAppearance.BorderSize = 0
        Me.BtnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewInvoice.ForeColor = System.Drawing.Color.White
        Me.BtnViewInvoice.Location = New System.Drawing.Point(16, 585)
        Me.BtnViewInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnViewInvoice.Name = "BtnViewInvoice"
        Me.BtnViewInvoice.Size = New System.Drawing.Size(190, 29)
        Me.BtnViewInvoice.TabIndex = 3
        Me.BtnViewInvoice.Text = "Consulta de Facturas"
        Me.BtnViewInvoice.UseVisualStyleBackColor = False
        '
        'GrpInvoiceClient
        '
        Me.GrpInvoiceClient.Controls.Add(Me.BtnSelectClient)
        Me.GrpInvoiceClient.Controls.Add(Me.TxtBoxClientNit)
        Me.GrpInvoiceClient.Controls.Add(Me.Label2)
        Me.GrpInvoiceClient.Controls.Add(Me.TxtBoxClientName)
        Me.GrpInvoiceClient.Controls.Add(Me.Label1)
        Me.GrpInvoiceClient.Location = New System.Drawing.Point(16, 87)
        Me.GrpInvoiceClient.Name = "GrpInvoiceClient"
        Me.GrpInvoiceClient.Size = New System.Drawing.Size(869, 85)
        Me.GrpInvoiceClient.TabIndex = 4
        Me.GrpInvoiceClient.TabStop = False
        Me.GrpInvoiceClient.Text = "Información del Cliente"
        '
        'BtnSelectClient
        '
        Me.BtnSelectClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectClient.FlatAppearance.BorderSize = 0
        Me.BtnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectClient.ForeColor = System.Drawing.Color.White
        Me.BtnSelectClient.Location = New System.Drawing.Point(746, 22)
        Me.BtnSelectClient.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSelectClient.Name = "BtnSelectClient"
        Me.BtnSelectClient.Size = New System.Drawing.Size(112, 53)
        Me.BtnSelectClient.TabIndex = 5
        Me.BtnSelectClient.Text = "Seleccionar Cliente"
        Me.BtnSelectClient.UseVisualStyleBackColor = False
        '
        'TxtBoxClientNit
        '
        Me.TxtBoxClientNit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxClientNit.BackColor = System.Drawing.Color.White
        Me.TxtBoxClientNit.Enabled = False
        Me.TxtBoxClientNit.Location = New System.Drawing.Point(102, 52)
        Me.TxtBoxClientNit.Name = "TxtBoxClientNit"
        Me.TxtBoxClientNit.Size = New System.Drawing.Size(637, 24)
        Me.TxtBoxClientNit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nit:"
        '
        'TxtBoxClientName
        '
        Me.TxtBoxClientName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxClientName.BackColor = System.Drawing.Color.White
        Me.TxtBoxClientName.Enabled = False
        Me.TxtBoxClientName.Location = New System.Drawing.Point(102, 22)
        Me.TxtBoxClientName.Name = "TxtBoxClientName"
        Me.TxtBoxClientName.Size = New System.Drawing.Size(637, 24)
        Me.TxtBoxClientName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.Orange
        Me.PnlTitle.Controls.Add(Me.Label3)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(897, 82)
        Me.PnlTitle.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(707, 73)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sistema de facturación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSelectBranch)
        Me.GroupBox1.Controls.Add(Me.TxtBoxBranchDirection)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtBoxBranchName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 85)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de la Sucursal"
        '
        'BtnSelectBranch
        '
        Me.BtnSelectBranch.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectBranch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectBranch.FlatAppearance.BorderSize = 0
        Me.BtnSelectBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectBranch.ForeColor = System.Drawing.Color.White
        Me.BtnSelectBranch.Location = New System.Drawing.Point(745, 22)
        Me.BtnSelectBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSelectBranch.Name = "BtnSelectBranch"
        Me.BtnSelectBranch.Size = New System.Drawing.Size(112, 53)
        Me.BtnSelectBranch.TabIndex = 5
        Me.BtnSelectBranch.Text = "Seleccionar Sucursal"
        Me.BtnSelectBranch.UseVisualStyleBackColor = False
        '
        'TxtBoxBranchDirection
        '
        Me.TxtBoxBranchDirection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxBranchDirection.BackColor = System.Drawing.Color.White
        Me.TxtBoxBranchDirection.Enabled = False
        Me.TxtBoxBranchDirection.Location = New System.Drawing.Point(102, 52)
        Me.TxtBoxBranchDirection.Name = "TxtBoxBranchDirection"
        Me.TxtBoxBranchDirection.Size = New System.Drawing.Size(636, 24)
        Me.TxtBoxBranchDirection.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Dirección:"
        '
        'TxtBoxBranchName
        '
        Me.TxtBoxBranchName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxBranchName.BackColor = System.Drawing.Color.White
        Me.TxtBoxBranchName.Enabled = False
        Me.TxtBoxBranchName.Location = New System.Drawing.Point(102, 22)
        Me.TxtBoxBranchName.Name = "TxtBoxBranchName"
        Me.TxtBoxBranchName.Size = New System.Drawing.Size(636, 24)
        Me.TxtBoxBranchName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumBoxInvoiceNumber)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtBoxInvoiceSerial)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 62)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de la Factura"
        '
        'NumBoxInvoiceNumber
        '
        Me.NumBoxInvoiceNumber.Location = New System.Drawing.Point(352, 23)
        Me.NumBoxInvoiceNumber.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumBoxInvoiceNumber.Name = "NumBoxInvoiceNumber"
        Me.NumBoxInvoiceNumber.Size = New System.Drawing.Size(109, 24)
        Me.NumBoxInvoiceNumber.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(180, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Numero de Factura:"
        '
        'TxtBoxInvoiceSerial
        '
        Me.TxtBoxInvoiceSerial.BackColor = System.Drawing.Color.White
        Me.TxtBoxInvoiceSerial.Location = New System.Drawing.Point(69, 23)
        Me.TxtBoxInvoiceSerial.Name = "TxtBoxInvoiceSerial"
        Me.TxtBoxInvoiceSerial.Size = New System.Drawing.Size(108, 24)
        Me.TxtBoxInvoiceSerial.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Serie:"
        '
        'BtnDeleteProduct
        '
        Me.BtnDeleteProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteProduct.FlatAppearance.BorderSize = 0
        Me.BtnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteProduct.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteProduct.Location = New System.Drawing.Point(724, 292)
        Me.BtnDeleteProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeleteProduct.Name = "BtnDeleteProduct"
        Me.BtnDeleteProduct.Size = New System.Drawing.Size(160, 29)
        Me.BtnDeleteProduct.TabIndex = 8
        Me.BtnDeleteProduct.Text = "Eliminar Producto"
        Me.BtnDeleteProduct.UseVisualStyleBackColor = False
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddProduct.FlatAppearance.BorderSize = 0
        Me.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProduct.ForeColor = System.Drawing.Color.White
        Me.BtnAddProduct.Location = New System.Drawing.Point(556, 292)
        Me.BtnAddProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(160, 29)
        Me.BtnAddProduct.TabIndex = 9
        Me.BtnAddProduct.Text = "Agregar Producto"
        Me.BtnAddProduct.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(701, 558)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total:"
        '
        'TxtBoxTotalInvoice
        '
        Me.TxtBoxTotalInvoice.BackColor = System.Drawing.Color.White
        Me.TxtBoxTotalInvoice.Enabled = False
        Me.TxtBoxTotalInvoice.Location = New System.Drawing.Point(777, 554)
        Me.TxtBoxTotalInvoice.Name = "TxtBoxTotalInvoice"
        Me.TxtBoxTotalInvoice.Size = New System.Drawing.Size(108, 24)
        Me.TxtBoxTotalInvoice.TabIndex = 7
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Codigo del Producto"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeDataGridViewTextBoxColumn.Width = 154
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Nombre del Producto"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 91
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Precio Unitario"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 120
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 66
        '
        'ProductDetailInvoiceBindingSource
        '
        Me.ProductDetailInvoiceBindingSource.DataSource = GetType(vb_net_desktop_app_1.ProductDetailInvoice)
        '
        'CreateInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(897, 621)
        Me.Controls.Add(Me.TxtBoxTotalInvoice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAddProduct)
        Me.Controls.Add(Me.BtnDeleteProduct)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlTitle)
        Me.Controls.Add(Me.GrpInvoiceClient)
        Me.Controls.Add(Me.BtnViewInvoice)
        Me.Controls.Add(Me.BtnClearInvoice)
        Me.Controls.Add(Me.BtnCreateInvoice)
        Me.Controls.Add(Me.DataGridProductDetail)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreateInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateInvoice"
        CType(Me.DataGridProductDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpInvoiceClient.ResumeLayout(False)
        Me.GrpInvoiceClient.PerformLayout()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumBoxInvoiceNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDetailInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridProductDetail As DataGridView
    Friend WithEvents BtnCreateInvoice As Button
    Friend WithEvents BtnClearInvoice As Button
    Friend WithEvents BtnViewInvoice As Button
    Friend WithEvents GrpInvoiceClient As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxClientName As TextBox
    Friend WithEvents TxtBoxClientNit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSelectClient As Button
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSelectBranch As Button
    Friend WithEvents TxtBoxBranchDirection As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxBranchName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtBoxInvoiceSerial As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NumBoxInvoiceNumber As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnDeleteProduct As Button
    Friend WithEvents BtnAddProduct As Button
    Friend WithEvents ProductDetailInvoiceBindingSource As BindingSource
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBoxTotalInvoice As TextBox
End Class
