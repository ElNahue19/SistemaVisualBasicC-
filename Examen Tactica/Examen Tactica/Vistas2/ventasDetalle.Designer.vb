<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventasDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblTotalDetalleResultado = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.btnEliminarDetalle = New System.Windows.Forms.Button()
        Me.btnModificarDetalle = New System.Windows.Forms.Button()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.tbIdProducto = New System.Windows.Forms.TextBox()
        Me.tbIdVentaRefDetalle = New System.Windows.Forms.TextBox()
        Me.lblIdDetalleResultado = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblIdProducto = New System.Windows.Forms.Label()
        Me.lblIdVentaRefDetalle = New System.Windows.Forms.Label()
        Me.lblIdDetalle = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblPrecioResultado = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVentas
        '
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.Location = New System.Drawing.Point(-4, 8)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVentas.Size = New System.Drawing.Size(764, 430)
        Me.dgVentas.TabIndex = 43
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(964, 81)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreProducto.TabIndex = 103
        '
        'lblTotalDetalleResultado
        '
        Me.lblTotalDetalleResultado.AutoSize = True
        Me.lblTotalDetalleResultado.Location = New System.Drawing.Point(860, 161)
        Me.lblTotalDetalleResultado.Name = "lblTotalDetalleResultado"
        Me.lblTotalDetalleResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalDetalleResultado.TabIndex = 102
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Location = New System.Drawing.Point(803, 161)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(34, 13)
        Me.lblDetalle.TabIndex = 101
        Me.lblDetalle.Text = "Total:"
        '
        'btnEliminarDetalle
        '
        Me.btnEliminarDetalle.Location = New System.Drawing.Point(952, 177)
        Me.btnEliminarDetalle.Name = "btnEliminarDetalle"
        Me.btnEliminarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarDetalle.TabIndex = 100
        Me.btnEliminarDetalle.Text = "Eliminar"
        Me.btnEliminarDetalle.UseVisualStyleBackColor = True
        '
        'btnModificarDetalle
        '
        Me.btnModificarDetalle.Location = New System.Drawing.Point(863, 177)
        Me.btnModificarDetalle.Name = "btnModificarDetalle"
        Me.btnModificarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarDetalle.TabIndex = 99
        Me.btnModificarDetalle.Text = "Modificar"
        Me.btnModificarDetalle.UseVisualStyleBackColor = True
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(777, 177)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarDetalle.TabIndex = 98
        Me.btnAgregarDetalle.Text = "Agregar"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(858, 105)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(100, 20)
        Me.tbCantidad.TabIndex = 97
        '
        'tbIdProducto
        '
        Me.tbIdProducto.Location = New System.Drawing.Point(858, 78)
        Me.tbIdProducto.Name = "tbIdProducto"
        Me.tbIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.tbIdProducto.TabIndex = 96
        '
        'tbIdVentaRefDetalle
        '
        Me.tbIdVentaRefDetalle.Location = New System.Drawing.Point(858, 51)
        Me.tbIdVentaRefDetalle.Name = "tbIdVentaRefDetalle"
        Me.tbIdVentaRefDetalle.Size = New System.Drawing.Size(100, 20)
        Me.tbIdVentaRefDetalle.TabIndex = 95
        '
        'lblIdDetalleResultado
        '
        Me.lblIdDetalleResultado.AutoSize = True
        Me.lblIdDetalleResultado.Location = New System.Drawing.Point(855, 30)
        Me.lblIdDetalleResultado.Name = "lblIdDetalleResultado"
        Me.lblIdDetalleResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblIdDetalleResultado.TabIndex = 94
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(800, 108)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 93
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblIdProducto
        '
        Me.lblIdProducto.AutoSize = True
        Me.lblIdProducto.Location = New System.Drawing.Point(785, 81)
        Me.lblIdProducto.Name = "lblIdProducto"
        Me.lblIdProducto.Size = New System.Drawing.Size(67, 13)
        Me.lblIdProducto.TabIndex = 92
        Me.lblIdProducto.Text = "ID Producto:"
        '
        'lblIdVentaRefDetalle
        '
        Me.lblIdVentaRefDetalle.AutoSize = True
        Me.lblIdVentaRefDetalle.Location = New System.Drawing.Point(800, 54)
        Me.lblIdVentaRefDetalle.Name = "lblIdVentaRefDetalle"
        Me.lblIdVentaRefDetalle.Size = New System.Drawing.Size(52, 13)
        Me.lblIdVentaRefDetalle.TabIndex = 91
        Me.lblIdVentaRefDetalle.Text = "ID Venta:"
        '
        'lblIdDetalle
        '
        Me.lblIdDetalle.AutoSize = True
        Me.lblIdDetalle.Location = New System.Drawing.Point(803, 30)
        Me.lblIdDetalle.Name = "lblIdDetalle"
        Me.lblIdDetalle.Size = New System.Drawing.Size(21, 13)
        Me.lblIdDetalle.TabIndex = 90
        Me.lblIdDetalle.Text = "ID:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(803, 134)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 104
        Me.lblPrecio.Text = "Precio:"
        '
        'lblPrecioResultado
        '
        Me.lblPrecioResultado.AutoSize = True
        Me.lblPrecioResultado.Location = New System.Drawing.Point(860, 134)
        Me.lblPrecioResultado.Name = "lblPrecioResultado"
        Me.lblPrecioResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblPrecioResultado.TabIndex = 105
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(970, 81)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(0, 13)
        Me.lblProducto.TabIndex = 106
        '
        'ventasDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 450)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblPrecioResultado)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Controls.Add(Me.lblTotalDetalleResultado)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.btnEliminarDetalle)
        Me.Controls.Add(Me.btnModificarDetalle)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.tbIdProducto)
        Me.Controls.Add(Me.tbIdVentaRefDetalle)
        Me.Controls.Add(Me.lblIdDetalleResultado)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblIdProducto)
        Me.Controls.Add(Me.lblIdVentaRefDetalle)
        Me.Controls.Add(Me.lblIdDetalle)
        Me.Controls.Add(Me.dgVentas)
        Me.Name = "ventasDetalle"
        Me.Text = "ventasDetalle"
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgVentas As DataGridView
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblTotalDetalleResultado As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents btnEliminarDetalle As Button
    Friend WithEvents btnModificarDetalle As Button
    Friend WithEvents btnAgregarDetalle As Button
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents tbIdProducto As TextBox
    Friend WithEvents tbIdVentaRefDetalle As TextBox
    Friend WithEvents lblIdDetalleResultado As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblIdProducto As Label
    Friend WithEvents lblIdVentaRefDetalle As Label
    Friend WithEvents lblIdDetalle As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblPrecioResultado As Label
    Friend WithEvents lblProducto As Label
End Class
