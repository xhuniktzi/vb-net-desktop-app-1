<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryInvoicesForm
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
        Me.GrpInvoiceQueryInfo = New System.Windows.Forms.GroupBox()
        Me.TxtBoxInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBoxSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSelectBranch = New System.Windows.Forms.Button()
        Me.TxtBoxBranch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSelectProduct = New System.Windows.Forms.Button()
        Me.TxtBoxProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSelectClient = New System.Windows.Forms.Button()
        Me.TxtBoxClient = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimeStart = New System.Windows.Forms.DateTimePicker()
        Me.DataGridInvoiceDetail = New System.Windows.Forms.DataGridView()
        Me.OrderIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientDirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientNitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchDirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Order_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnQuery = New System.Windows.Forms.Button()
        Me.BtnClearQuery = New System.Windows.Forms.Button()
        Me.PnlTitle.SuspendLayout()
        Me.GrpInvoiceQueryInfo.SuspendLayout()
        CType(Me.DataGridInvoiceDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlTitle.Size = New System.Drawing.Size(1008, 80)
        Me.PnlTitle.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(448, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Consultar Facturas"
        '
        'GrpInvoiceQueryInfo
        '
        Me.GrpInvoiceQueryInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.TxtBoxInvoiceNumber)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.Label8)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.TxtBoxSerialNumber)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.Label7)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.BtnSelectBranch)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.TxtBoxBranch)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.Label6)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.BtnSelectProduct)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.TxtBoxProduct)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.Label5)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.BtnSelectClient)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.TxtBoxClient)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.Label4)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.Label2)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.DateTimeEnd)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.Label1)
        Me.GrpInvoiceQueryInfo.Controls.Add(Me.DateTimeStart)
        Me.GrpInvoiceQueryInfo.Location = New System.Drawing.Point(13, 88)
        Me.GrpInvoiceQueryInfo.Name = "GrpInvoiceQueryInfo"
        Me.GrpInvoiceQueryInfo.Size = New System.Drawing.Size(983, 237)
        Me.GrpInvoiceQueryInfo.TabIndex = 12
        Me.GrpInvoiceQueryInfo.TabStop = False
        Me.GrpInvoiceQueryInfo.Text = "Información de la Consulta"
        '
        'TxtBoxInvoiceNumber
        '
        Me.TxtBoxInvoiceNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxInvoiceNumber.Location = New System.Drawing.Point(638, 199)
        Me.TxtBoxInvoiceNumber.Name = "TxtBoxInvoiceNumber"
        Me.TxtBoxInvoiceNumber.Size = New System.Drawing.Size(339, 24)
        Me.TxtBoxInvoiceNumber.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(464, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Numero de Factura:"
        '
        'TxtBoxSerialNumber
        '
        Me.TxtBoxSerialNumber.Location = New System.Drawing.Point(202, 199)
        Me.TxtBoxSerialNumber.Name = "TxtBoxSerialNumber"
        Me.TxtBoxSerialNumber.Size = New System.Drawing.Size(221, 24)
        Me.TxtBoxSerialNumber.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Numero de Serie:"
        '
        'BtnSelectBranch
        '
        Me.BtnSelectBranch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectBranch.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectBranch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectBranch.FlatAppearance.BorderSize = 0
        Me.BtnSelectBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectBranch.ForeColor = System.Drawing.Color.White
        Me.BtnSelectBranch.Location = New System.Drawing.Point(693, 160)
        Me.BtnSelectBranch.Name = "BtnSelectBranch"
        Me.BtnSelectBranch.Size = New System.Drawing.Size(284, 27)
        Me.BtnSelectBranch.TabIndex = 17
        Me.BtnSelectBranch.Text = "Seleccionar Sucursal"
        Me.BtnSelectBranch.UseVisualStyleBackColor = False
        '
        'TxtBoxBranch
        '
        Me.TxtBoxBranch.Enabled = False
        Me.TxtBoxBranch.Location = New System.Drawing.Point(202, 161)
        Me.TxtBoxBranch.Name = "TxtBoxBranch"
        Me.TxtBoxBranch.Size = New System.Drawing.Size(485, 24)
        Me.TxtBoxBranch.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Sucursal:"
        '
        'BtnSelectProduct
        '
        Me.BtnSelectProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectProduct.FlatAppearance.BorderSize = 0
        Me.BtnSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectProduct.ForeColor = System.Drawing.Color.White
        Me.BtnSelectProduct.Location = New System.Drawing.Point(693, 124)
        Me.BtnSelectProduct.Name = "BtnSelectProduct"
        Me.BtnSelectProduct.Size = New System.Drawing.Size(284, 27)
        Me.BtnSelectProduct.TabIndex = 14
        Me.BtnSelectProduct.Text = "Seleccionar Producto"
        Me.BtnSelectProduct.UseVisualStyleBackColor = False
        '
        'TxtBoxProduct
        '
        Me.TxtBoxProduct.Enabled = False
        Me.TxtBoxProduct.Location = New System.Drawing.Point(202, 125)
        Me.TxtBoxProduct.Name = "TxtBoxProduct"
        Me.TxtBoxProduct.Size = New System.Drawing.Size(485, 24)
        Me.TxtBoxProduct.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Producto:"
        '
        'BtnSelectClient
        '
        Me.BtnSelectClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSelectClient.FlatAppearance.BorderSize = 0
        Me.BtnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectClient.ForeColor = System.Drawing.Color.White
        Me.BtnSelectClient.Location = New System.Drawing.Point(693, 88)
        Me.BtnSelectClient.Name = "BtnSelectClient"
        Me.BtnSelectClient.Size = New System.Drawing.Size(284, 27)
        Me.BtnSelectClient.TabIndex = 11
        Me.BtnSelectClient.Text = "Seleccionar Cliente"
        Me.BtnSelectClient.UseVisualStyleBackColor = False
        '
        'TxtBoxClient
        '
        Me.TxtBoxClient.Enabled = False
        Me.TxtBoxClient.Location = New System.Drawing.Point(202, 89)
        Me.TxtBoxClient.Name = "TxtBoxClient"
        Me.TxtBoxClient.Size = New System.Drawing.Size(485, 24)
        Me.TxtBoxClient.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de Finalización:"
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimeEnd.Location = New System.Drawing.Point(202, 52)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(775, 24)
        Me.DateTimeEnd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de Inicio:"
        '
        'DateTimeStart
        '
        Me.DateTimeStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimeStart.Checked = False
        Me.DateTimeStart.Location = New System.Drawing.Point(202, 20)
        Me.DateTimeStart.Name = "DateTimeStart"
        Me.DateTimeStart.Size = New System.Drawing.Size(775, 24)
        Me.DateTimeStart.TabIndex = 0
        '
        'DataGridInvoiceDetail
        '
        Me.DataGridInvoiceDetail.AllowUserToAddRows = False
        Me.DataGridInvoiceDetail.AllowUserToDeleteRows = False
        Me.DataGridInvoiceDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridInvoiceDetail.AutoGenerateColumns = False
        Me.DataGridInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridInvoiceDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIdDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn, Me.InvoiceNumberDataGridViewTextBoxColumn, Me.ClientNameDataGridViewTextBoxColumn, Me.ClientDirectionDataGridViewTextBoxColumn, Me.ClientNitDataGridViewTextBoxColumn, Me.BranchNameDataGridViewTextBoxColumn, Me.BranchDirectionDataGridViewTextBoxColumn, Me.OrderDateDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.Order_Total})
        Me.DataGridInvoiceDetail.DataSource = Me.InvoiceDetailBindingSource
        Me.DataGridInvoiceDetail.Location = New System.Drawing.Point(13, 331)
        Me.DataGridInvoiceDetail.Name = "DataGridInvoiceDetail"
        Me.DataGridInvoiceDetail.ReadOnly = True
        Me.DataGridInvoiceDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridInvoiceDetail.Size = New System.Drawing.Size(983, 228)
        Me.DataGridInvoiceDetail.TabIndex = 13
        '
        'OrderIdDataGridViewTextBoxColumn
        '
        Me.OrderIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OrderIdDataGridViewTextBoxColumn.DataPropertyName = "Order_Id"
        Me.OrderIdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.OrderIdDataGridViewTextBoxColumn.Name = "OrderIdDataGridViewTextBoxColumn"
        Me.OrderIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderIdDataGridViewTextBoxColumn.Width = 47
        '
        'SerialNumberDataGridViewTextBoxColumn
        '
        Me.SerialNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "Serial_Number"
        Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
        Me.SerialNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerialNumberDataGridViewTextBoxColumn.Width = 67
        '
        'InvoiceNumberDataGridViewTextBoxColumn
        '
        Me.InvoiceNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.InvoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "Invoice_Number"
        Me.InvoiceNumberDataGridViewTextBoxColumn.HeaderText = "Numero de Factura"
        Me.InvoiceNumberDataGridViewTextBoxColumn.Name = "InvoiceNumberDataGridViewTextBoxColumn"
        Me.InvoiceNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoiceNumberDataGridViewTextBoxColumn.Width = 147
        '
        'ClientNameDataGridViewTextBoxColumn
        '
        Me.ClientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name"
        Me.ClientNameDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClientNameDataGridViewTextBoxColumn.Name = "ClientNameDataGridViewTextBoxColumn"
        Me.ClientNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientNameDataGridViewTextBoxColumn.Width = 78
        '
        'ClientDirectionDataGridViewTextBoxColumn
        '
        Me.ClientDirectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClientDirectionDataGridViewTextBoxColumn.DataPropertyName = "Client_Direction"
        Me.ClientDirectionDataGridViewTextBoxColumn.HeaderText = "Descripción del Cliente"
        Me.ClientDirectionDataGridViewTextBoxColumn.Name = "ClientDirectionDataGridViewTextBoxColumn"
        Me.ClientDirectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientDirectionDataGridViewTextBoxColumn.Width = 127
        '
        'ClientNitDataGridViewTextBoxColumn
        '
        Me.ClientNitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClientNitDataGridViewTextBoxColumn.DataPropertyName = "Client_Nit"
        Me.ClientNitDataGridViewTextBoxColumn.HeaderText = "Nit"
        Me.ClientNitDataGridViewTextBoxColumn.Name = "ClientNitDataGridViewTextBoxColumn"
        Me.ClientNitDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientNitDataGridViewTextBoxColumn.Width = 51
        '
        'BranchNameDataGridViewTextBoxColumn
        '
        Me.BranchNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BranchNameDataGridViewTextBoxColumn.DataPropertyName = "Branch_Name"
        Me.BranchNameDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.BranchNameDataGridViewTextBoxColumn.Name = "BranchNameDataGridViewTextBoxColumn"
        Me.BranchNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BranchNameDataGridViewTextBoxColumn.Width = 91
        '
        'BranchDirectionDataGridViewTextBoxColumn
        '
        Me.BranchDirectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BranchDirectionDataGridViewTextBoxColumn.DataPropertyName = "Branch_Direction"
        Me.BranchDirectionDataGridViewTextBoxColumn.HeaderText = "Dirección de la Sucursal"
        Me.BranchDirectionDataGridViewTextBoxColumn.Name = "BranchDirectionDataGridViewTextBoxColumn"
        Me.BranchDirectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.BranchDirectionDataGridViewTextBoxColumn.Width = 123
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "Order_Date"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        Me.OrderDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderDateDataGridViewTextBoxColumn.Width = 74
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductCodeDataGridViewTextBoxColumn.Width = 81
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 94
        '
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        Me.ProductDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductDescriptionDataGridViewTextBoxColumn.Width = 112
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 91
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 76
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 66
        '
        'Order_Total
        '
        Me.Order_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Order_Total.DataPropertyName = "Order_Total"
        Me.Order_Total.HeaderText = "Total de la Factura"
        Me.Order_Total.Name = "Order_Total"
        Me.Order_Total.ReadOnly = True
        Me.Order_Total.Width = 141
        '
        'InvoiceDetailBindingSource
        '
        Me.InvoiceDetailBindingSource.DataSource = GetType(vb_net_desktop_app_1.InvoiceDetail)
        '
        'BtnQuery
        '
        Me.BtnQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnQuery.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnQuery.FlatAppearance.BorderSize = 0
        Me.BtnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuery.ForeColor = System.Drawing.Color.White
        Me.BtnQuery.Location = New System.Drawing.Point(825, 626)
        Me.BtnQuery.Name = "BtnQuery"
        Me.BtnQuery.Size = New System.Drawing.Size(171, 27)
        Me.BtnQuery.TabIndex = 22
        Me.BtnQuery.Text = "Buscar"
        Me.BtnQuery.UseVisualStyleBackColor = False
        '
        'BtnClearQuery
        '
        Me.BtnClearQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClearQuery.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnClearQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClearQuery.FlatAppearance.BorderSize = 0
        Me.BtnClearQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearQuery.ForeColor = System.Drawing.Color.White
        Me.BtnClearQuery.Location = New System.Drawing.Point(13, 626)
        Me.BtnClearQuery.Name = "BtnClearQuery"
        Me.BtnClearQuery.Size = New System.Drawing.Size(155, 27)
        Me.BtnClearQuery.TabIndex = 23
        Me.BtnClearQuery.Text = "Limpiar Consulta"
        Me.BtnClearQuery.UseVisualStyleBackColor = False
        '
        'QueryInvoicesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.BtnClearQuery)
        Me.Controls.Add(Me.BtnQuery)
        Me.Controls.Add(Me.DataGridInvoiceDetail)
        Me.Controls.Add(Me.GrpInvoiceQueryInfo)
        Me.Controls.Add(Me.PnlTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "QueryInvoicesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueryInvoicesForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.GrpInvoiceQueryInfo.ResumeLayout(False)
        Me.GrpInvoiceQueryInfo.PerformLayout()
        CType(Me.DataGridInvoiceDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GrpInvoiceQueryInfo As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimeStart As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimeEnd As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxClient As TextBox
    Friend WithEvents BtnSelectClient As Button
    Friend WithEvents BtnSelectProduct As Button
    Friend WithEvents TxtBoxProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnSelectBranch As Button
    Friend WithEvents TxtBoxBranch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBoxSerialNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridInvoiceDetail As DataGridView
    Friend WithEvents InvoiceDetailBindingSource As BindingSource
    Friend WithEvents BtnQuery As Button
    Friend WithEvents TxtBoxInvoiceNumber As TextBox
    Friend WithEvents BtnClearQuery As Button
    Friend WithEvents OrderIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientDirectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientNitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchDirectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Order_Total As DataGridViewTextBoxColumn
End Class
