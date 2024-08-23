<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes2
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
        Me.tbFecha2 = New System.Windows.Forms.TextBox()
        Me.lblEntre = New System.Windows.Forms.Label()
        Me.lblInicio1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblRespuesta1 = New System.Windows.Forms.Label()
        Me.tbFecha1 = New System.Windows.Forms.TextBox()
        Me.lblRespuesta2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbFecha2
        '
        Me.tbFecha2.Location = New System.Drawing.Point(563, 65)
        Me.tbFecha2.Name = "tbFecha2"
        Me.tbFecha2.Size = New System.Drawing.Size(100, 20)
        Me.tbFecha2.TabIndex = 1
        '
        'lblEntre
        '
        Me.lblEntre.AutoSize = True
        Me.lblEntre.Location = New System.Drawing.Point(500, 68)
        Me.lblEntre.Name = "lblEntre"
        Me.lblEntre.Size = New System.Drawing.Size(31, 13)
        Me.lblEntre.TabIndex = 2
        Me.lblEntre.Text = "entre"
        '
        'lblInicio1
        '
        Me.lblInicio1.AutoSize = True
        Me.lblInicio1.Location = New System.Drawing.Point(469, 28)
        Me.lblInicio1.Name = "lblInicio1"
        Me.lblInicio1.Size = New System.Drawing.Size(81, 13)
        Me.lblInicio1.TabIndex = 3
        Me.lblInicio1.Text = "Reporte Ventas"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(475, 127)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblRespuesta1
        '
        Me.lblRespuesta1.AutoSize = True
        Me.lblRespuesta1.Location = New System.Drawing.Point(377, 250)
        Me.lblRespuesta1.Name = "lblRespuesta1"
        Me.lblRespuesta1.Size = New System.Drawing.Size(0, 13)
        Me.lblRespuesta1.TabIndex = 5
        '
        'tbFecha1
        '
        Me.tbFecha1.Location = New System.Drawing.Point(376, 65)
        Me.tbFecha1.Name = "tbFecha1"
        Me.tbFecha1.Size = New System.Drawing.Size(100, 20)
        Me.tbFecha1.TabIndex = 6
        '
        'lblRespuesta2
        '
        Me.lblRespuesta2.AutoSize = True
        Me.lblRespuesta2.Location = New System.Drawing.Point(373, 288)
        Me.lblRespuesta2.Name = "lblRespuesta2"
        Me.lblRespuesta2.Size = New System.Drawing.Size(0, 13)
        Me.lblRespuesta2.TabIndex = 7
        '
        'Reportes2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 458)
        Me.Controls.Add(Me.lblRespuesta2)
        Me.Controls.Add(Me.tbFecha1)
        Me.Controls.Add(Me.lblRespuesta1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblInicio1)
        Me.Controls.Add(Me.lblEntre)
        Me.Controls.Add(Me.tbFecha2)
        Me.Name = "Reportes2"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbFecha2 As TextBox
    Friend WithEvents lblEntre As Label
    Friend WithEvents lblInicio1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblRespuesta1 As Label
    Friend WithEvents tbFecha1 As TextBox
    Friend WithEvents lblRespuesta2 As Label
End Class
