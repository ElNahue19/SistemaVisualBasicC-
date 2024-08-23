Imports Negocio
Public Class ventas
    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridVentas(dgVentas)
    End Sub

    Private Sub dgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellClick
        lblIDResultadoVenta.Text = dgVentas.SelectedCells(0).Value
        tbCliente.Text = dgVentas.SelectedCells(1).Value
        tbFecha.Text = dgVentas.SelectedCells(2).Value
        lblTotalVenta.Text = dgVentas.SelectedCells(3).Value
    End Sub

    Private Sub btnVerDetalle_Click(sender As Object, e As EventArgs) Handles btnVerDetalle.Click
        Dim negocio As New Clase_Negocio()
        Dim ventasDetalle As New ventasDetalle(lblIDResultadoVenta.Text)
        Me.Hide()
        ventasDetalle.ShowDialog()
        Me.Show()
        Negocio.cargarGridVentas(dgVentas)
    End Sub

    Private Sub btnVerVentas_Click(sender As Object, e As EventArgs)
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridVentas(dgVentas)
    End Sub

    Private Sub btnAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        Dim negocio As New Clase_Negocio()
        negocio.agregarVenta(tbCliente.Text, tbFecha.Text)
        lblIDResultadoVenta.Text = negocio.buscarIdVenta()
        negocio.cargarGridVentas(dgVentas)
        Dim ventasDetalle As New ventasDetalle(lblIDResultadoVenta.Text)
        Me.Hide()
        ventasDetalle.ShowDialog()
        Me.Show()
        negocio.cargarGridVentas(dgVentas)

        tbCliente.Text = ""
        tbFecha.Text = ""
        lblTotal.Text = ""


    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        Dim negocio As New Clase_Negocio()
        negocio.eliminarVenta(lblIDResultadoVenta.Text)
        negocio.cargarGridVentas(dgVentas)
        tbCliente.Text = ""
        tbFecha.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub btnModificarVenta_Click(sender As Object, e As EventArgs) Handles btnModificarVenta.Click
        Dim negocio As New Clase_Negocio()
        negocio.modificarVenta(lblIDResultadoVenta.Text, tbCliente.Text, tbFecha.Text, lblTotalVenta.Text)
        negocio.cargarGridVentas(dgVentas)
    End Sub

    Private Sub tbFiltrarID_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarID.TextChanged
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridVentasFiltroIdVentas(dgVentas, tbFiltrarID.Text)
    End Sub

    Private Sub tbFiltrarNombre_TextChanged(sender As Object, e As EventArgs) Handles tbFiltroCliente.TextChanged
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridVentasFiltroIdCliente(dgVentas, tbFiltroCliente.Text)
    End Sub

    Private Sub btnFiltrarFecha_Click(sender As Object, e As EventArgs) Handles btnFiltrarFecha.Click
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridVentasFiltroFechas(dgVentas, tbFecha1.Text, tbFecha2.Text)
    End Sub

    Private Sub lbClientes_Click(sender As Object, e As EventArgs) Handles lbClientes.Click
        Dim clientes As New clientes()
        Me.Hide()
        clientes.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventas As New ventas()
        Me.Hide()
        ventas.ShowDialog()
        Me.Close()
    End Sub

    Private Sub lbProductos_Click(sender As Object, e As EventArgs) Handles lbProductos.Click
        Dim productos As New productos()
        Me.Hide()
        productos.ShowDialog()
        Me.Close()
    End Sub
End Class