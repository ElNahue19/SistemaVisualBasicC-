Imports Negocio
Public Class productos
    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductos(dgProductos)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim negocio As New Clase_Negocio()
        negocio.agregarProducto(tbNombre.Text, tbPrecio.Text, tbCategoria.Text)
        negocio.cargarGridProductos(dgProductos)
        tbNombre.Text = ""
        tbPrecio.Text = ""
        tbCategoria.Text = ""
    End Sub

    Private Sub dgProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProductos.CellClick
        lblIDResultado.Text = dgProductos.SelectedCells(0).Value
        tbNombre.Text = dgProductos.SelectedCells(1).Value
        tbPrecio.Text = dgProductos.SelectedCells(2).Value
        tbCategoria.Text = dgProductos.SelectedCells(3).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim negocio As New Clase_Negocio()
        negocio.actualizarProducto(lblIDResultado.Text, tbNombre.Text, tbPrecio.Text, tbCategoria.Text)
        negocio.cargarGridProductos(dgProductos)
        lblIDResultado.Text = dgProductos.SelectedCells(0).Value
        tbNombre.Text = dgProductos.SelectedCells(1).Value
        tbPrecio.Text = dgProductos.SelectedCells(2).Value
        tbCategoria.Text = dgProductos.SelectedCells(3).Value
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim negocio As New Clase_Negocio()
        negocio.eliminarProducto(lblIDResultado.Text)
        negocio.cargarGridProductos(dgProductos)
        tbNombre.Text = ""
        tbPrecio.Text = ""
        tbCategoria.Text = ""
    End Sub

    Private Sub btnFiltrarID_Click(sender As Object, e As EventArgs)
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductosFiltrarID(dgProductos, tbFiltrarID.Text)
    End Sub

    Private Sub btnFiltrarNombre_Click(sender As Object, e As EventArgs)
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductosFiltrarNombre(dgProductos, tbFiltrarNombre.Text)
    End Sub

    Private Sub btnFiltrarPrecio_Click(sender As Object, e As EventArgs) Handles btnFiltrarPrecio.Click
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductosFiltrarPrecio(dgProductos, tbFiltrarPrecio1.Text, tbFiltrarPrecio2.Text)
    End Sub

    Private Sub btnFiltrarCategoria_Click(sender As Object, e As EventArgs)
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductosFiltrarCategoria(dgProductos, tbFiltrarCategoria.Text)
    End Sub

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

    Private Sub tbFiltrarID_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarID.TextChanged
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductosFiltrarID(dgProductos, tbFiltrarID.Text)
    End Sub

    Private Sub tbFiltrarNombre_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarNombre.TextChanged
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductosFiltrarNombre(dgProductos, tbFiltrarNombre.Text)
    End Sub

    Private Sub tbFiltrarCategoria_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarCategoria.TextChanged
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridProductosFiltrarCategoria(dgProductos, tbFiltrarCategoria.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventas As New ventas()
        Me.Hide()
        ventas.ShowDialog()
        Me.Close()
    End Sub
End Class