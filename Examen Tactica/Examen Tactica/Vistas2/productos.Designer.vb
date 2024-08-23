<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos
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
        Me.lbProductos = New System.Windows.Forms.Button()
        Me.lbClientes = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblIDResultado = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.dgProductos = New System.Windows.Forms.DataGridView()
        Me.btnFiltrarPrecio = New System.Windows.Forms.Button()
        Me.lblFiltrarID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFiltrarCategoria = New System.Windows.Forms.Label()
        Me.tbFiltrarID = New System.Windows.Forms.TextBox()
        Me.tbFiltrarPrecio1 = New System.Windows.Forms.TextBox()
        Me.tbFiltrarCategoria = New System.Windows.Forms.TextBox()
        Me.lblFiltrarNombre = New System.Windows.Forms.Label()
        Me.tbFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.tbFiltrarPrecio2 = New System.Windows.Forms.TextBox()
        Me.lblEntre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbProductos
        '
        Me.lbProductos.Location = New System.Drawing.Point(833, 415)
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Size = New System.Drawing.Size(75, 23)
        Me.lbProductos.TabIndex = 27
        Me.lbProductos.Text = "Productos"
        Me.lbProductos.UseVisualStyleBackColor = True
        '
        'lbClientes
        '
        Me.lbClientes.Location = New System.Drawing.Point(550, 416)
        Me.lbClientes.Name = "lbClientes"
        Me.lbClientes.Size = New System.Drawing.Size(75, 23)
        Me.lbClientes.TabIndex = 26
        Me.lbClientes.Text = "Clientes"
        Me.lbClientes.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(757, 132)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(622, 132)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(485, 132)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(622, 83)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.Size = New System.Drawing.Size(100, 20)
        Me.tbCategoria.TabIndex = 22
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(622, 56)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(100, 20)
        Me.tbPrecio.TabIndex = 21
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(622, 29)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 20
        '
        'lblIDResultado
        '
        Me.lblIDResultado.AutoSize = True
        Me.lblIDResultado.Location = New System.Drawing.Point(619, 8)
        Me.lblIDResultado.Name = "lblIDResultado"
        Me.lblIDResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblIDResultado.TabIndex = 19
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(508, 78)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 18
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(508, 53)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 17
        Me.lblPrecio.Text = "Precio:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(508, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(508, 8)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "ID:"
        '
        'dgProductos
        '
        Me.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductos.Location = New System.Drawing.Point(12, 8)
        Me.dgProductos.Name = "dgProductos"
        Me.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProductos.Size = New System.Drawing.Size(443, 430)
        Me.dgProductos.TabIndex = 14
        '
        'btnFiltrarPrecio
        '
        Me.btnFiltrarPrecio.Location = New System.Drawing.Point(920, 299)
        Me.btnFiltrarPrecio.Name = "btnFiltrarPrecio"
        Me.btnFiltrarPrecio.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrarPrecio.TabIndex = 29
        Me.btnFiltrarPrecio.Text = "Filtrar Precio"
        Me.btnFiltrarPrecio.UseVisualStyleBackColor = True
        '
        'lblFiltrarID
        '
        Me.lblFiltrarID.AutoSize = True
        Me.lblFiltrarID.Location = New System.Drawing.Point(525, 234)
        Me.lblFiltrarID.Name = "lblFiltrarID"
        Me.lblFiltrarID.Size = New System.Drawing.Size(65, 13)
        Me.lblFiltrarID.TabIndex = 31
        Me.lblFiltrarID.Text = "Filtrar Por ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Filtrar por Precio"
        '
        'lblFiltrarCategoria
        '
        Me.lblFiltrarCategoria.AutoSize = True
        Me.lblFiltrarCategoria.Location = New System.Drawing.Point(525, 356)
        Me.lblFiltrarCategoria.Name = "lblFiltrarCategoria"
        Me.lblFiltrarCategoria.Size = New System.Drawing.Size(98, 13)
        Me.lblFiltrarCategoria.TabIndex = 33
        Me.lblFiltrarCategoria.Text = "Filtrar por Categoria"
        '
        'tbFiltrarID
        '
        Me.tbFiltrarID.Location = New System.Drawing.Point(697, 227)
        Me.tbFiltrarID.Name = "tbFiltrarID"
        Me.tbFiltrarID.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarID.TabIndex = 34
        '
        'tbFiltrarPrecio1
        '
        Me.tbFiltrarPrecio1.Location = New System.Drawing.Point(622, 309)
        Me.tbFiltrarPrecio1.Name = "tbFiltrarPrecio1"
        Me.tbFiltrarPrecio1.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarPrecio1.TabIndex = 35
        '
        'tbFiltrarCategoria
        '
        Me.tbFiltrarCategoria.Location = New System.Drawing.Point(697, 349)
        Me.tbFiltrarCategoria.Name = "tbFiltrarCategoria"
        Me.tbFiltrarCategoria.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarCategoria.TabIndex = 36
        '
        'lblFiltrarNombre
        '
        Me.lblFiltrarNombre.AutoSize = True
        Me.lblFiltrarNombre.Location = New System.Drawing.Point(525, 269)
        Me.lblFiltrarNombre.Name = "lblFiltrarNombre"
        Me.lblFiltrarNombre.Size = New System.Drawing.Size(90, 13)
        Me.lblFiltrarNombre.TabIndex = 38
        Me.lblFiltrarNombre.Text = "Filtrar por Nombre"
        '
        'tbFiltrarNombre
        '
        Me.tbFiltrarNombre.Location = New System.Drawing.Point(697, 262)
        Me.tbFiltrarNombre.Name = "tbFiltrarNombre"
        Me.tbFiltrarNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarNombre.TabIndex = 39
        '
        'tbFiltrarPrecio2
        '
        Me.tbFiltrarPrecio2.Location = New System.Drawing.Point(784, 309)
        Me.tbFiltrarPrecio2.Name = "tbFiltrarPrecio2"
        Me.tbFiltrarPrecio2.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarPrecio2.TabIndex = 40
        '
        'lblEntre
        '
        Me.lblEntre.AutoSize = True
        Me.lblEntre.Location = New System.Drawing.Point(738, 316)
        Me.lblEntre.Name = "lblEntre"
        Me.lblEntre.Size = New System.Drawing.Size(31, 13)
        Me.lblEntre.TabIndex = 41
        Me.lblEntre.Text = "entre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Ventas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEntre)
        Me.Controls.Add(Me.tbFiltrarPrecio2)
        Me.Controls.Add(Me.tbFiltrarNombre)
        Me.Controls.Add(Me.lblFiltrarNombre)
        Me.Controls.Add(Me.tbFiltrarCategoria)
        Me.Controls.Add(Me.tbFiltrarPrecio1)
        Me.Controls.Add(Me.tbFiltrarID)
        Me.Controls.Add(Me.lblFiltrarCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFiltrarID)
        Me.Controls.Add(Me.btnFiltrarPrecio)
        Me.Controls.Add(Me.lbProductos)
        Me.Controls.Add(Me.lbClientes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tbCategoria)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblIDResultado)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dgProductos)
        Me.Name = "productos"
        Me.Text = "Form3"
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbProductos As Button
    Friend WithEvents lbClientes As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblIDResultado As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblID As Label
    Friend WithEvents dgProductos As DataGridView
    Friend WithEvents btnFiltrarPrecio As Button
    Friend WithEvents lblFiltrarID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFiltrarCategoria As Label
    Friend WithEvents tbFiltrarID As TextBox
    Friend WithEvents tbFiltrarPrecio1 As TextBox
    Friend WithEvents tbFiltrarCategoria As TextBox
    Friend WithEvents lblFiltrarNombre As Label
    Friend WithEvents tbFiltrarNombre As TextBox
    Friend WithEvents tbFiltrarPrecio2 As TextBox
    Friend WithEvents lblEntre As Label
    Friend WithEvents Button1 As Button
End Class
