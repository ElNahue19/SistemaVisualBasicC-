Imports Negocio

Public Class Reportes2
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim negocio As New Clase_Negocio()

        lblRespuesta1.Text = negocio.reporteVentas(tbFecha1.Text, tbFecha2.Text)
        lblRespuesta2.Text = negocio.reporteVentasCant(tbFecha1.Text, tbFecha2.Text)

    End Sub
End Class