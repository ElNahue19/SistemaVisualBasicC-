Public Class inicio
    Private Sub lbClientes_Click(sender As Object, e As EventArgs) Handles lbClientes.Click
        Dim clientes As New clientes()
        Me.Hide()
        clientes.ShowDialog()
        Me.Close()
    End Sub

    Private Sub lbProductos_Click(sender As Object, e As EventArgs) Handles lbProductos.Click
        Dim productos As New productos()
        Me.Hide()
        productos.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim ventas As New ventas()
        Me.Hide()
        ventas.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim Reportes As New Reportes2()
        Me.Hide()
        Reportes.ShowDialog()
        Me.Close()
    End Sub
End Class