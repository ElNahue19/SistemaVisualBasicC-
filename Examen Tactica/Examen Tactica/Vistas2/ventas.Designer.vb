<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblEntre = New System.Windows.Forms.Label()
        Me.tbFecha2 = New System.Windows.Forms.TextBox()
        Me.tbFiltroCliente = New System.Windows.Forms.TextBox()
        Me.lblFiltrarNombre = New System.Windows.Forms.Label()
        Me.tbFecha1 = New System.Windows.Forms.TextBox()
        Me.tbFiltrarID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFiltrarID = New System.Windows.Forms.Label()
        Me.btnFiltrarFecha = New System.Windows.Forms.Button()
        Me.lbProductos = New System.Windows.Forms.Button()
        Me.lbClientes = New System.Windows.Forms.Button()
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.btnModificarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.lblIDResultadoVenta = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblIDCliente = New System.Windows.Forms.Label()
        Me.lblIDVenta = New System.Windows.Forms.Label()
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalVenta = New System.Windows.Forms.Label()
        Me.btnVerDetalle = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEntre
        '
        Me.lblEntre.AutoSize = True
        Me.lblEntre.Location = New System.Drawing.Point(780, 318)
        Me.lblEntre.Name = "lblEntre"
        Me.lblEntre.Size = New System.Drawing.Size(31, 13)
        Me.lblEntre.TabIndex = 69
        Me.lblEntre.Text = "entre"
        '
        'tbFecha2
        '
        Me.tbFecha2.Location = New System.Drawing.Point(826, 311)
        Me.tbFecha2.Name = "tbFecha2"
        Me.tbFecha2.Size = New System.Drawing.Size(100, 20)
        Me.tbFecha2.TabIndex = 68
        '
        'tbFiltroCliente
        '
        Me.tbFiltroCliente.Location = New System.Drawing.Point(739, 264)
        Me.tbFiltroCliente.Name = "tbFiltroCliente"
        Me.tbFiltroCliente.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltroCliente.TabIndex = 67
        '
        'lblFiltrarNombre
        '
        Me.lblFiltrarNombre.AutoSize = True
        Me.lblFiltrarNombre.Location = New System.Drawing.Point(567, 271)
        Me.lblFiltrarNombre.Name = "lblFiltrarNombre"
        Me.lblFiltrarNombre.Size = New System.Drawing.Size(99, 13)
        Me.lblFiltrarNombre.TabIndex = 66
        Me.lblFiltrarNombre.Text = "Filtrar por ID Cliente"
        '
        'tbFecha1
        '
        Me.tbFecha1.Location = New System.Drawing.Point(664, 311)
        Me.tbFecha1.Name = "tbFecha1"
        Me.tbFecha1.Size = New System.Drawing.Size(100, 20)
        Me.tbFecha1.TabIndex = 63
        '
        'tbFiltrarID
        '
        Me.tbFiltrarID.Location = New System.Drawing.Point(739, 229)
        Me.tbFiltrarID.Name = "tbFiltrarID"
        Me.tbFiltrarID.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarID.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(567, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Filtrar por Fecha"
        '
        'lblFiltrarID
        '
        Me.lblFiltrarID.AutoSize = True
        Me.lblFiltrarID.Location = New System.Drawing.Point(567, 236)
        Me.lblFiltrarID.Name = "lblFiltrarID"
        Me.lblFiltrarID.Size = New System.Drawing.Size(65, 13)
        Me.lblFiltrarID.TabIndex = 59
        Me.lblFiltrarID.Text = "Filtrar Por ID"
        '
        'btnFiltrarFecha
        '
        Me.btnFiltrarFecha.Location = New System.Drawing.Point(962, 309)
        Me.btnFiltrarFecha.Name = "btnFiltrarFecha"
        Me.btnFiltrarFecha.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrarFecha.TabIndex = 57
        Me.btnFiltrarFecha.Text = "Filtrar Fechas"
        Me.btnFiltrarFecha.UseVisualStyleBackColor = True
        '
        'lbProductos
        '
        Me.lbProductos.Location = New System.Drawing.Point(938, 419)
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Size = New System.Drawing.Size(75, 23)
        Me.lbProductos.TabIndex = 55
        Me.lbProductos.Text = "Productos"
        Me.lbProductos.UseVisualStyleBackColor = True
        '
        'lbClientes
        '
        Me.lbClientes.Location = New System.Drawing.Point(655, 420)
        Me.lbClientes.Name = "lbClientes"
        Me.lbClientes.Size = New System.Drawing.Size(75, 23)
        Me.lbClientes.TabIndex = 54
        Me.lbClientes.Text = "Clientes"
        Me.lbClientes.UseVisualStyleBackColor = True
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.Location = New System.Drawing.Point(836, 143)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarVenta.TabIndex = 53
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = True
        '
        'btnModificarVenta
        '
        Me.btnModificarVenta.Location = New System.Drawing.Point(747, 143)
        Me.btnModificarVenta.Name = "btnModificarVenta"
        Me.btnModificarVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarVenta.TabIndex = 52
        Me.btnModificarVenta.Text = "Modificar"
        Me.btnModificarVenta.UseVisualStyleBackColor = True
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.Location = New System.Drawing.Point(661, 143)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarVenta.TabIndex = 51
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = True
        '
        'tbFecha
        '
        Me.tbFecha.Location = New System.Drawing.Point(739, 67)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(100, 20)
        Me.tbFecha.TabIndex = 49
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(739, 40)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(100, 20)
        Me.tbCliente.TabIndex = 48
        '
        'lblIDResultadoVenta
        '
        Me.lblIDResultadoVenta.AutoSize = True
        Me.lblIDResultadoVenta.Location = New System.Drawing.Point(736, 19)
        Me.lblIDResultadoVenta.Name = "lblIDResultadoVenta"
        Me.lblIDResultadoVenta.Size = New System.Drawing.Size(0, 13)
        Me.lblIDResultadoVenta.TabIndex = 47
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(684, 89)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.Text = "Total:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(684, 64)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 45
        Me.lblFecha.Text = "Fecha:"
        '
        'lblIDCliente
        '
        Me.lblIDCliente.AutoSize = True
        Me.lblIDCliente.Location = New System.Drawing.Point(684, 40)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(56, 13)
        Me.lblIDCliente.TabIndex = 44
        Me.lblIDCliente.Text = "ID Cliente:"
        '
        'lblIDVenta
        '
        Me.lblIDVenta.AutoSize = True
        Me.lblIDVenta.Location = New System.Drawing.Point(684, 19)
        Me.lblIDVenta.Name = "lblIDVenta"
        Me.lblIDVenta.Size = New System.Drawing.Size(21, 13)
        Me.lblIDVenta.TabIndex = 43
        Me.lblIDVenta.Text = "ID:"
        '
        'dgVentas
        '
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.Location = New System.Drawing.Point(-3, 12)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVentas.Size = New System.Drawing.Size(564, 430)
        Me.dgVentas.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(884, -11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(773, -11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "ID:"
        '
        'lblTotalVenta
        '
        Me.lblTotalVenta.AutoSize = True
        Me.lblTotalVenta.Location = New System.Drawing.Point(739, 97)
        Me.lblTotalVenta.Name = "lblTotalVenta"
        Me.lblTotalVenta.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalVenta.TabIndex = 88
        '
        'btnVerDetalle
        '
        Me.btnVerDetalle.Location = New System.Drawing.Point(938, 54)
        Me.btnVerDetalle.Name = "btnVerDetalle"
        Me.btnVerDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnVerDetalle.TabIndex = 90
        Me.btnVerDetalle.Text = "Ver Detalle"
        Me.btnVerDetalle.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(799, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "Ventas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVerDetalle)
        Me.Controls.Add(Me.lblTotalVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblEntre)
        Me.Controls.Add(Me.tbFecha2)
        Me.Controls.Add(Me.tbFiltroCliente)
        Me.Controls.Add(Me.lblFiltrarNombre)
        Me.Controls.Add(Me.tbFecha1)
        Me.Controls.Add(Me.tbFiltrarID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFiltrarID)
        Me.Controls.Add(Me.btnFiltrarFecha)
        Me.Controls.Add(Me.lbProductos)
        Me.Controls.Add(Me.lbClientes)
        Me.Controls.Add(Me.btnEliminarVenta)
        Me.Controls.Add(Me.btnModificarVenta)
        Me.Controls.Add(Me.btnAgregarVenta)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbCliente)
        Me.Controls.Add(Me.lblIDResultadoVenta)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblIDCliente)
        Me.Controls.Add(Me.lblIDVenta)
        Me.Controls.Add(Me.dgVentas)
        Me.Name = "ventas"
        Me.Text = "ventas"
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEntre As Label
    Friend WithEvents tbFecha2 As TextBox
    Friend WithEvents tbFiltroCliente As TextBox
    Friend WithEvents lblFiltrarNombre As Label
    Friend WithEvents tbFecha1 As TextBox
    Friend WithEvents tbFiltrarID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFiltrarID As Label
    Friend WithEvents btnFiltrarFecha As Button
    Friend WithEvents lbProductos As Button
    Friend WithEvents lbClientes As Button
    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents btnModificarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents lblIDResultadoVenta As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblIDCliente As Label
    Friend WithEvents lblIDVenta As Label
    Friend WithEvents dgVentas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalVenta As Label
    Friend WithEvents btnVerDetalle As Button
    Friend WithEvents Button1 As Button
End Class
