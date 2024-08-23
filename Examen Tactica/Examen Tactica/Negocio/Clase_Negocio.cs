using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Entidades;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Negocio
{
    public class  Clase_Negocio
    {
        public void cargarGridCliente(DataGridView gv)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("clientes", "SELECT * FROM clientes");
            
        }
        public void cargarGridProductos(DataGridView gv)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("productos", "SELECT * FROM productos");

        }

        public void cargarGridVentas(DataGridView gv)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("ventas", "SELECT ventas.ID, IDCliente, Fecha, ventas.Total FROM ventas ");

        }
        public void cargarGridDetallePostVentas(DataGridView gv, string id)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("ventasitems", "select ventasitems.ID, IDVenta, IDProducto, Nombre, productos.Precio, ventasitems.Cantidad, PrecioTotal from ventasitems inner join productos on ventasitems.IDProducto = productos.ID where IDVenta = " + id);

        }
        public void cargarGridProductosFiltrarID(DataGridView gv, string id)
        {
            AccesoDatos dao = new AccesoDatos();
            if (id != "")
            {
                gv.DataSource = dao.ObtenerTodosDatos("productos", "SELECT * FROM productos ORDER BY ABS(ID - " + id + ")");
            }
        }

        public void cargarGridClientesFiltrarID(DataGridView gv, string id)
        {

            AccesoDatos dao = new AccesoDatos();
            if (id != "")
            {
                gv.DataSource = dao.ObtenerTodosDatos("clientes", "SELECT * FROM clientes ORDER BY ABS(ID - " + id + ")");
            }
        }

        public void cargarGridProductosFiltrarNombre(DataGridView gv, string nombre)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("productos", "SELECT *, DIFFERENCE(Nombre, '" + nombre + "') AS Similaridad FROM productos ORDER BY Similaridad DESC");

        }

        public void cargarGridClienteFiltrarNombre(DataGridView gv, string nombre)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("clientes", "SELECT *, DIFFERENCE(Cliente, '" + nombre + "') AS Similaridad FROM clientes ORDER BY Similaridad DESC");

        }

        public void cargarGridProductosFiltrarPrecio(DataGridView gv, string precio1, string precio2)
        {
            int precioObj = Convert.ToInt32(precio1) + Convert.ToInt32(precio2) / 2;
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("productos", "SELECT * FROM productos WHERE Precio BETWEEN " + precio1 + " AND " + precio2 + " ORDER BY ABS(Precio - " + precioObj + ")");

        }

        public void cargarGridProductosFiltrarCategoria(DataGridView gv, string categoria)
        {
            AccesoDatos dao = new AccesoDatos();
            if (categoria != "")
            {
                gv.DataSource = dao.ObtenerTodosDatos("productos", "SELECT * FROM productos  ORDER BY ABS(Categoria - " + categoria + ")");
            }
        }
        
        public void cargarGridVentasFiltroIdVentas(DataGridView gv, string idVenta)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("ventas", "SELECT * FROM Ventas WHERE CAST(ID AS NVARCHAR) LIKE '" + idVenta + "%' ORDER BY ID");

        }
        public void cargarGridVentasFiltroIdCliente(DataGridView gv, string idCliente)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("ventas", "SELECT * FROM ventas WHERE CAST(IDCliente AS NVARCHAR) LIKE '" + idCliente + "%' ORDER BY IDCliente");

        }
        

        public void cargarGridVentasFiltroFechas(DataGridView gv, string fecha1, string fecha2)
        {
            AccesoDatos dao = new AccesoDatos();
            gv.DataSource = dao.ObtenerTodosDatos("ventas", "SELECT * FROM ventas WHERE Fecha BETWEEN '" + fecha1 + "' AND '" + fecha2 + "' ORDER BY Fecha");

        }

        public bool agregarCliente(string nombre, string telefono, string correo)
        {
            string consulta = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@VALOR1, @VALOR2, @VALOR3)";
            int cantFilas = 0;
            Cliente cliente = new Cliente();

            cliente.setNombre(nombre);
            cliente.setTelefono(telefono);
            cliente.setCorreo(correo);

            AccesoClientes daoCliente = new AccesoClientes();
            cantFilas = daoCliente.agregarCliente(consulta, cliente);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
        public bool agregarProducto(string nombre, string precio, string categoria)
        {
            int cantFilas;
            string consulta = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@VALOR1, @VALOR2, @VALOR3)";
            Producto producto = new Producto();

            producto.setNombre(nombre);
            producto.setPrecio(precio);
            producto.setCategoria(categoria);

            AccesoClientes daoCliente = new AccesoClientes();
            cantFilas = daoCliente.agregarProducto(consulta, producto);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool agregarVenta(int idCliente, string fecha)
        {
            int cantFilas;
            string consulta = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@VALOR1, @VALOR2, @VALOR3)";
            Venta venta = new Venta();

            venta.setIdCliente(idCliente);
            venta.setFecha(fecha);
            venta.setPrecioTotal(0);



            AccesoVentas daoVentas = new AccesoVentas();
            cantFilas = daoVentas.agregarVenta(consulta, venta);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public string buscarIdVenta()
        {
            string consulta = "SELECT TOP 1 ID FROM ventas ORDER BY ID DESC";

            AccesoVentas daoVentas = new AccesoVentas();
            string id = daoVentas.buscarUltimaIdVenta(consulta);

            return id;
        }

        public bool modificarVenta(int idVenta, int idCliente, string fecha, string total)
        {
            int cantFilas;
            string consulta = "UPDATE ventas SET IDCliente = @VALOR1, Fecha = @VALOR2, Total = @VALOR3 WHERE ID = @VALOR4";
            Venta venta = new Venta();

            venta.setID(idVenta);
            venta.setIdCliente(idCliente);
            venta.setFecha(fecha);
            venta.setPrecioTotal(Convert.ToInt32(total));



            AccesoVentas daoVentas = new AccesoVentas();
            cantFilas = daoVentas.modificarVenta(consulta, venta);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool agregarDetalle(string idVenta, string idProducto, string precioUnitario, string cantidad, string precioTotal)
        {
            int cantFilas;
            string consulta = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@VALOR1, @VALOR2, @VALOR3, @VALOR4, @VALOR5)";
            DetalleVenta detalle = new DetalleVenta();

            detalle.setIdVenta(idVenta);
            detalle.setIdProducto(idProducto);
            detalle.setPrecioUnitario(precioUnitario);
            detalle.setCantidad(cantidad);
            detalle.setPrecioTotal(precioTotal);


            AccesoDetalle daoDetalle = new AccesoDetalle();
            cantFilas = daoDetalle.agregarDetalle(consulta, detalle);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool actualizarDetalle(string id, string idVenta, string idProducto, string precioUnitario, string cantidad, string precioTotal)
        {
            int cantFilas;
            string consulta = "UPDATE ventasitems SET IDVenta = @VALOR1, IDProducto = @VALOR2, PrecioUnitario = @VALOR3, Cantidad = @VALOR4, PrecioTotal = @VALOR5 WHERE ID = @VALOR6";
            DetalleVenta detalle = new DetalleVenta();

            detalle.setID(id);
            detalle.setIdVenta(idVenta);
            detalle.setIdProducto(idProducto);
            detalle.setPrecioUnitario(precioUnitario);
            detalle.setCantidad(cantidad);
            detalle.setPrecioTotal(precioTotal);


            AccesoDetalle daoDetalle = new AccesoDetalle();
            cantFilas = daoDetalle.actualizarDetalle(consulta, detalle);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool actualizarVentaPostDetalle(string idVenta, string total)
        {

            int cantFilas;

            string consulta = "UPDATE ventas SET Total = Total + @VALOR1 WHERE ID = @VALOR2";

            AccesoDetalle daoDetalle = new AccesoDetalle();
            cantFilas = daoDetalle.actualizarVentaPostDetalle(consulta, idVenta, total);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
        
        public bool actualizarVentaPostDetalleModificar(string idVenta, string total, string totalAnterior)
        {

            int cantFilas;

            string consulta = "UPDATE ventas SET Total = Total - @VALOR1 + @VALOR2 WHERE ID = @VALOR3";

            AccesoDetalle daoDetalle = new AccesoDetalle();
            cantFilas = daoDetalle.actualizarVentaPostDetalleModificar(consulta, idVenta, total, totalAnterior);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
        

        public bool actualizarVentaPostDetalleEliminar(string idVenta, string totalAnterior)
        {

            int cantFilas;

            string consulta = "UPDATE ventas SET Total = Total - @VALOR1 WHERE ID = @VALOR2";

            AccesoDetalle daoDetalle = new AccesoDetalle();
            cantFilas = daoDetalle.actualizarVentaPostDetalleEliminar(consulta, idVenta, totalAnterior);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }



        public bool actualizarCliente(int id, string nombre, string telefono, string correo)
        {
            string consulta = "UPDATE clientes SET Cliente = @VALOR1, Telefono = @VALOR2, Correo = @VALOR3 WHERE ID=@VALOR4";
            int cantFilas = 0;
            Cliente cliente = new Cliente();

            cliente.setID(id);
            cliente.setNombre(nombre);
            cliente.setTelefono(telefono);
            cliente.setCorreo(correo);

            AccesoClientes daoCliente = new AccesoClientes();
            cantFilas = daoCliente.actualizarCliente(consulta, cliente);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
        public bool actualizarProducto(int id, string nombre, string precio, string categoria)
        {
            string consulta = "UPDATE productos SET Nombre = @VALOR1, Precio = @VALOR2, Categoria = @VALOR3 WHERE ID=@VALOR4";
            int cantFilas = 0;
            Producto producto = new Producto();

            producto.setID(id);
            producto.setNombre(nombre);
            producto.setPrecio(precio);
            producto.setCategoria(categoria);

            AccesoClientes daoCliente = new AccesoClientes();
            cantFilas = daoCliente.actualizarProducto(consulta, producto);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool eliminarCliente(int id)
        {
            string consulta = "DELETE FROM clientes WHERE ID = @ID";
            int cantFilas = 0;
            Cliente cliente = new Cliente();

            cliente.setID(id);

            AccesoClientes daoCliente = new AccesoClientes();
            cantFilas = daoCliente.eliminarCliente(consulta, cliente);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
        public bool eliminarProducto(int id)
        {
            string consulta = "DELETE FROM productos WHERE ID = @ID";
            int cantFilas = 0;
            Producto producto = new Producto();

            producto.setID(id);

            AccesoClientes daoCliente = new AccesoClientes();
            cantFilas = daoCliente.eliminarProducto(consulta, producto);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
        public bool eliminarVenta(int id)
        {
            string consulta1 = "DELETE FROM ventas WHERE ID = @ID";
            string consulta2 = "DELETE FROM ventasitems WHERE ventasitems.IDVenta = @ID";
            int cantFilas = 0;
            Venta venta = new Venta();

            venta.setID(id);

            AccesoVentas daoVenta = new AccesoVentas();
            cantFilas = daoVenta.eliminarVenta(consulta1, consulta2, venta);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool eliminarDetalleVenta(int id)
        {
            string consulta1 = "DELETE FROM ventasitems WHERE ventasitems.ID = @ID";
            int cantFilas = 0;
            DetalleVenta detalle = new DetalleVenta();

            detalle.setID(id.ToString());

            AccesoDetalle daoDetalle = new AccesoDetalle();
            cantFilas = daoDetalle.eliminarDetalleVenta(consulta1, detalle);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public int obtenerPrecio(string idProducto)
        {
            string consulta = "SELECT Precio FROM productos WHERE ID = @VALOR1";

            AccesoDetalle daoDetalle = new AccesoDetalle();
            int precio = daoDetalle.obtenerPrecio(consulta, idProducto);

            return precio;
        }

        public string obtenerNombreProducto(string idProducto)
        {
            string consulta = "SELECT Nombre FROM productos WHERE ID = @VALOR1";

            AccesoDetalle daoDetalle = new AccesoDetalle();
            string nombre = daoDetalle.obtenerNombreProducto(consulta, idProducto);

            return nombre;
        }



        public string reporteVentas(string fecha1, string fecha2)
        {
            AccesoVentas ventas = new AccesoVentas();
            string consulta = "SELECT SUM(Total) as Total FROM ventas WHERE Fecha BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";

            decimal total = 0;


            total = ventas.ReporteVenta(consulta);


            return "El total neto recaudado es de: $" + total;
        }

        public string reporteVentasCant(string fecha1, string fecha2)
        {
            AccesoVentas ventas = new AccesoVentas();
            string consulta = "SELECT COUNT(*) FROM ventas WHERE Fecha BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";

            decimal total = 0;


            total = ventas.ReporteVentaCant(consulta);


            return "El total de registros son: " + total;
        }

    }
}
