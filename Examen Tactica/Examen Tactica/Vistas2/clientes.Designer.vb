<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clientes
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
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblIDResultado = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbCorreo = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lbClientes = New System.Windows.Forms.Button()
        Me.lbProductos = New System.Windows.Forms.Button()
        Me.lblFiltrarID = New System.Windows.Forms.Label()
        Me.tbFiltrarID = New System.Windows.Forms.TextBox()
        Me.lblFiltrarNombre = New System.Windows.Forms.Label()
        Me.tbFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgClientes
        '
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Location = New System.Drawing.Point(22, 13)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientes.Size = New System.Drawing.Size(443, 430)
        Me.dgClientes.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(518, 13)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(518, 34)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(518, 58)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(518, 83)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 4
        Me.lblCorreo.Text = "Correo:"
        '
        'lblIDResultado
        '
        Me.lblIDResultado.AutoSize = True
        Me.lblIDResultado.Location = New System.Drawing.Point(629, 13)
        Me.lblIDResultado.Name = "lblIDResultado"
        Me.lblIDResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblIDResultado.TabIndex = 5
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(632, 34)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 6
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(632, 61)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.tbTelefono.TabIndex = 7
        '
        'tbCorreo
        '
        Me.tbCorreo.Location = New System.Drawing.Point(632, 88)
        Me.tbCorreo.Name = "tbCorreo"
        Me.tbCorreo.Size = New System.Drawing.Size(100, 20)
        Me.tbCorreo.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(495, 137)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(632, 137)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(767, 137)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lbClientes
        '
        Me.lbClientes.Location = New System.Drawing.Point(560, 421)
        Me.lbClientes.Name = "lbClientes"
        Me.lbClientes.Size = New System.Drawing.Size(75, 23)
        Me.lbClientes.TabIndex = 12
        Me.lbClientes.Text = "Clientes"
        Me.lbClientes.UseVisualStyleBackColor = True
        '
        'lbProductos
        '
        Me.lbProductos.Location = New System.Drawing.Point(843, 420)
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Size = New System.Drawing.Size(75, 23)
        Me.lbProductos.TabIndex = 13
        Me.lbProductos.Text = "Productos"
        Me.lbProductos.UseVisualStyleBackColor = True
        '
        'lblFiltrarID
        '
        Me.lblFiltrarID.AutoSize = True
        Me.lblFiltrarID.Location = New System.Drawing.Point(514, 275)
        Me.lblFiltrarID.Name = "lblFiltrarID"
        Me.lblFiltrarID.Size = New System.Drawing.Size(65, 13)
        Me.lblFiltrarID.TabIndex = 45
        Me.lblFiltrarID.Text = "Filtrar Por ID"
        '
        'tbFiltrarID
        '
        Me.tbFiltrarID.Location = New System.Drawing.Point(686, 268)
        Me.tbFiltrarID.Name = "tbFiltrarID"
        Me.tbFiltrarID.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarID.TabIndex = 48
        '
        'lblFiltrarNombre
        '
        Me.lblFiltrarNombre.AutoSize = True
        Me.lblFiltrarNombre.Location = New System.Drawing.Point(514, 310)
        Me.lblFiltrarNombre.Name = "lblFiltrarNombre"
        Me.lblFiltrarNombre.Size = New System.Drawing.Size(90, 13)
        Me.lblFiltrarNombre.TabIndex = 52
        Me.lblFiltrarNombre.Text = "Filtrar por Nombre"
        '
        'tbFiltrarNombre
        '
        Me.tbFiltrarNombre.Location = New System.Drawing.Point(686, 303)
        Me.tbFiltrarNombre.Name = "tbFiltrarNombre"
        Me.tbFiltrarNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbFiltrarNombre.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Ventas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbFiltrarNombre)
        Me.Controls.Add(Me.lblFiltrarNombre)
        Me.Controls.Add(Me.tbFiltrarID)
        Me.Controls.Add(Me.lblFiltrarID)
        Me.Controls.Add(Me.lbProductos)
        Me.Controls.Add(Me.lbClientes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tbCorreo)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblIDResultado)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dgClientes)
        Me.Name = "clientes"
        Me.Text = "Form1"
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgClientes As DataGridView
    Friend WithEvents lblID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblIDResultado As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lbClientes As Button
    Friend WithEvents lbProductos As Button
    Friend WithEvents lblFiltrarID As Label
    Friend WithEvents tbFiltrarID As TextBox
    Friend WithEvents lblFiltrarNombre As Label
    Friend WithEvents tbFiltrarNombre As TextBox
    Friend WithEvents Button1 As Button
End Class
