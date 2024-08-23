<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.lbClientes = New System.Windows.Forms.Button()
        Me.lbProductos = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbClientes
        '
        Me.lbClientes.Location = New System.Drawing.Point(219, 187)
        Me.lbClientes.Name = "lbClientes"
        Me.lbClientes.Size = New System.Drawing.Size(75, 23)
        Me.lbClientes.TabIndex = 0
        Me.lbClientes.Text = "Clientes"
        Me.lbClientes.UseVisualStyleBackColor = True
        '
        'lbProductos
        '
        Me.lbProductos.Location = New System.Drawing.Point(456, 187)
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Size = New System.Drawing.Size(75, 23)
        Me.lbProductos.TabIndex = 1
        Me.lbProductos.Text = "Productos"
        Me.lbProductos.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(712, 187)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnVenta.TabIndex = 2
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.Location = New System.Drawing.Point(251, 388)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(493, 50)
        Me.btnReportes.TabIndex = 3
        Me.btnReportes.Text = "REPORTES"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 450)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.lbProductos)
        Me.Controls.Add(Me.lbClientes)
        Me.Name = "inicio"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbClientes As Button
    Friend WithEvents lbProductos As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents btnReportes As Button
End Class
