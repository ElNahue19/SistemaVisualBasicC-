Imports Negocio
Public Class ventasDetalle
    Private _IdVenta As String
    Private _Total As Int32
    Public Sub New(idVenta As String)
        InitializeComponent()
        _IdVenta = idVenta
    End Sub

    Private Sub ventasDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Negocio As New Clase_Negocio()
        Negocio.cargarGridDetallePostVentas(dgVentas, _IdVenta)
        tbIdVentaRefDetalle.Text = _IdVenta
    End Sub

    Private Sub dgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellClick
        lblIdDetalleResultado.Text = dgVentas.SelectedCells(0).Value
        tbIdVentaRefDetalle.Text = dgVentas.SelectedCells(1).Value
        tbIdProducto.Text = dgVentas.SelectedCells(2).Value
        lblProducto.Text = dgVentas.SelectedCells(3).Value
        lblPrecioResultado.Text = dgVentas.SelectedCells(4).Value
        tbCantidad.Text = dgVentas.SelectedCells(5).Value
        lblTotalDetalleResultado.Text = dgVentas.SelectedCells(6).Value
        _Total = dgVentas.SelectedCells(6).Value

    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        Dim negocio As New Clase_Negocio()
        negocio.actualizarVentaPostDetalle(tbIdVentaRefDetalle.Text, lblTotalDetalleResultado.Text)
        negocio.agregarDetalle(tbIdVentaRefDetalle.Text, tbIdProducto.Text, lblPrecioResultado.Text, tbCantidad.Text, lblTotalDetalleResultado.Text)
        negocio.cargarGridDetallePostVentas(dgVentas, _IdVenta)

        tbIdProducto.Text = ""
        tbCantidad.Text = ""


    End Sub

    Private Sub btnModificarDetalle_Click(sender As Object, e As EventArgs) Handles btnModificarDetalle.Click
        Dim negocio As New Clase_Negocio()
        negocio.actualizarVentaPostDetalleModificar(tbIdVentaRefDetalle.Text, lblTotalDetalleResultado.Text, _Total)
        negocio.actualizarDetalle(lblIdDetalleResultado.Text, tbIdVentaRefDetalle.Text, tbIdProducto.Text, lblPrecioResultado.Text, tbCantidad.Text, lblTotalDetalleResultado.Text)
        negocio.cargarGridDetallePostVentas(dgVentas, _IdVenta)
        tbIdVentaRefDetalle.Text = dgVentas.SelectedCells(1).Value
        tbIdProducto.Text = dgVentas.SelectedCells(2).Value
        lblNombreProducto.Text = dgVentas.SelectedCells(3).Value
        lblPrecioResultado.Text = dgVentas.SelectedCells(4).Value
        tbCantidad.Text = dgVentas.SelectedCells(5).Value
        lblTotalDetalleResultado.Text = dgVentas.SelectedCells(6).Value
    End Sub

    Private Sub tbIdProducto_TextChanged(sender As Object, e As EventArgs) Handles tbIdProducto.TextChanged
        Dim negocio As New Clase_Negocio()
        lblPrecioResultado.Text = negocio.obtenerPrecio(tbIdProducto.Text)
        lblNombreProducto.Text = negocio.obtenerNombreProducto(tbIdProducto.Text)
    End Sub

    Private Sub tbCantidad_TextChanged(sender As Object, e As EventArgs) Handles tbCantidad.TextChanged
        lblTotalDetalleResultado.Text = ""

        Dim total As Int32
        If tbCantidad.Text = "" Then
            Console.WriteLine("Las cadenas son diferentes.")
        Else
            total = tbCantidad.Text * lblPrecioResultado.Text
        End If
        lblTotalDetalleResultado.Text = total
    End Sub

    Private Sub btnEliminarDetalle_Click(sender As Object, e As EventArgs) Handles btnEliminarDetalle.Click
        Dim negocio As New Clase_Negocio()
        negocio.actualizarVentaPostDetalleEliminar(tbIdVentaRefDetalle.Text, _Total)
        negocio.eliminarDetalleVenta(lblIdDetalleResultado.Text)
        negocio.cargarGridDetallePostVentas(dgVentas, _IdVenta)

        tbIdProducto.Text = ""
        tbCantidad.Text = ""
    End Sub
End Class