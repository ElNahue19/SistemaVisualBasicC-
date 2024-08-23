Imports Negocio

Public Class clientes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridCliente(dgClientes)
    End Sub

    Private Sub dgClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellClick
        lblIDResultado.Text = dgClientes.SelectedCells(0).Value
        tbNombre.Text = dgClientes.SelectedCells(1).Value
        tbTelefono.Text = dgClientes.SelectedCells(2).Value
        tbCorreo.Text = dgClientes.SelectedCells(3).Value
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim negocio As New Clase_Negocio()
        negocio.agregarCliente(tbNombre.Text, tbTelefono.Text, tbCorreo.Text)
        negocio.cargarGridCliente(dgClientes)
        tbNombre.Text = ""
        tbTelefono.Text = ""
        tbCorreo.Text = ""

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim negocio As New Clase_Negocio()
        negocio.actualizarCliente(lblIDResultado.Text, tbNombre.Text, tbTelefono.Text, tbCorreo.Text)
        negocio.cargarGridCliente(dgClientes)
        lblIDResultado.Text = dgClientes.SelectedCells(0).Value
        tbNombre.Text = dgClientes.SelectedCells(1).Value
        tbTelefono.Text = dgClientes.SelectedCells(2).Value
        tbCorreo.Text = dgClientes.SelectedCells(3).Value
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim negocio As New Clase_Negocio()
        negocio.eliminarCliente(lblIDResultado.Text)
        negocio.cargarGridCliente(dgClientes)
        tbNombre.Text = ""
        tbTelefono.Text = ""
        tbCorreo.Text = ""
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

    Private Sub btnFiltrarID_Click(sender As Object, e As EventArgs)
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridClientesFiltrarID(dgClientes, tbFiltrarID.Text)
    End Sub

    Private Sub btnFiltrarNombre_Click(sender As Object, e As EventArgs) 
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridClienteFiltrarNombre(dgClientes, tbFiltrarNombre.Text)
    End Sub

    Private Sub tbFiltrarID_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarID.TextChanged
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridClientesFiltrarID(dgClientes, tbFiltrarID.Text)
    End Sub

    Private Sub tbFiltrarNombre_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarNombre.TextChanged
        Dim negocio As New Clase_Negocio()
        negocio.cargarGridClienteFiltrarNombre(dgClientes, tbFiltrarNombre.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventas As New ventas()
        Me.Hide()
        ventas.ShowDialog()
        Me.Close()
    End Sub
End Class
