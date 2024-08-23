using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Entidades;

namespace Dao
{
    public class AccesoDatos
    {
        
        String ruta = @"Server=localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo";
        public AccesoDatos()
        {

        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public SqlDataAdapter ObtenerAdaptador(string consultaSql)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, ObtenerConexion());
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private DataTable ObtenerTabla(string Nombre, string Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
             adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }

        public DataTable ObtenerTodosDatos(string tabla, string consulta)
        {
            return ObtenerTabla(tabla, consulta);
        }
    }

    public class AccesoClientes
    {
        AccesoDatos ds = new AccesoDatos();
        public AccesoClientes()
        {

        }

        public int agregarCliente(string consulta, Cliente cliente)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            string nombre = cliente.getNombre();
            string telefono = cliente.getTelefono();
            string correo = cliente.getCorreo();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@Valor1", nombre);
                        command.Parameters.AddWithValue("@Valor2", telefono);
                        command.Parameters.AddWithValue("@Valor3", correo);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();
                        
                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }
        public int agregarProducto(string consulta, Producto producto)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            string nombre = producto.getNombre();
            string precio = producto.getPrecio();
            string categoria = producto.getCategoria();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@VALOR1", nombre);
                        command.Parameters.AddWithValue("@VALOR2", precio);
                        command.Parameters.AddWithValue("@VALOR3", categoria);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

        public int actualizarCliente(string consulta, Cliente cliente)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            int ID = cliente.getID();
            string nombre = cliente.getNombre();
            string telefono = cliente.getTelefono();
            string correo = cliente.getCorreo();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@VALOR1", nombre);
                        command.Parameters.AddWithValue("@VALOR2", telefono);
                        command.Parameters.AddWithValue("@VALOR3", correo);
                        command.Parameters.AddWithValue("VALOR4", ID);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }
        public int actualizarProducto(string consulta, Producto producto)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            int ID = producto.getID();
            string nombre = producto.getNombre();
            string precio = producto.getPrecio();
            string categoria = producto.getCategoria();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@VALOR1", nombre);
                        command.Parameters.AddWithValue("@VALOR2", precio);
                        command.Parameters.AddWithValue("@VALOR3", categoria);
                        command.Parameters.AddWithValue("VALOR4", ID);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

        public int eliminarCliente(string consulta, Cliente cliente)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            int ID = cliente.getID();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@ID", ID);


                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

        public int eliminarProducto(string consulta, Producto producto)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            int ID = producto.getID();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@ID", ID);


                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

    }

    public class AccesoDetalle
    {
        AccesoDatos ds = new AccesoDatos();
        public AccesoDetalle()
        {

        }

        public int agregarDetalle(string consulta, DetalleVenta detalle)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@VALOR1", detalle.getIDVenta());
                        command.Parameters.AddWithValue("@VALOR2", detalle.getIdProducto());
                        command.Parameters.AddWithValue("@VALOR3", detalle.getPrecioUnitario());
                        command.Parameters.AddWithValue("@VALOR4", detalle.getCantidad());
                        command.Parameters.AddWithValue("@VALOR5", detalle.getPrecioTotal());

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

        public int actualizarDetalle(string consulta, DetalleVenta detalle)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@VALOR1", detalle.getIDVenta());
                        command.Parameters.AddWithValue("@VALOR2", detalle.getIdProducto());
                        command.Parameters.AddWithValue("@VALOR3", detalle.getPrecioUnitario());
                        command.Parameters.AddWithValue("@VALOR4", detalle.getCantidad());
                        command.Parameters.AddWithValue("@VALOR5", detalle.getPrecioTotal());
                        command.Parameters.AddWithValue("@VALOR6", detalle.getID());

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

        public int actualizarVentaPostDetalle(string consulta, string id, string total)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores

                        command.Parameters.AddWithValue("@VALOR1", total);
                        command.Parameters.AddWithValue("@VALOR2", id);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }
        

        public int actualizarVentaPostDetalleModificar(string consulta, string id, string total, string totalAnterior)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores

                        command.Parameters.AddWithValue("@VALOR1", totalAnterior);
                        command.Parameters.AddWithValue("@VALOR2", total);
                        command.Parameters.AddWithValue("@VALOR3", id);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

        public int actualizarVentaPostDetalleEliminar(string consulta, string id, string totalAnterior)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores

                        command.Parameters.AddWithValue("@VALOR1", totalAnterior);
                        command.Parameters.AddWithValue("@VALOR2", id);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }
        public int eliminarDetalleVenta(string consulta1, DetalleVenta detalle)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            string ID = detalle.getID();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    using (SqlCommand command = new SqlCommand(consulta1, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@ID", ID);


                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

        public int obtenerPrecio(string consulta, string idProducto)
        {

            SqlConnection cn;
            int precio = 0;
            // Crea una conexión SQL
            using (cn = ds.ObtenerConexion())
            {
                // Crea un comando SQL
                SqlCommand command = new SqlCommand(consulta, cn);
                command.Parameters.AddWithValue("@VALOR1", idProducto);

                try
                {

                    // Ejecuta el comando y obtiene un lector de datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifica si el lector tiene filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Obtén los valores de las columnas
                                precio = Convert.ToInt32(reader["Precio"]);

                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron filas.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return precio;
        }

        public string obtenerNombreProducto(string consulta, string idProducto)
        {

            SqlConnection cn;
            string nombre = "";
            // Crea una conexión SQL
            using (cn = ds.ObtenerConexion())
            {
                // Crea un comando SQL
                SqlCommand command = new SqlCommand(consulta, cn);
                command.Parameters.AddWithValue("@VALOR1", idProducto);

                try
                {

                    // Ejecuta el comando y obtiene un lector de datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifica si el lector tiene filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Obtén los valores de las columnas
                                nombre = reader["Nombre"].ToString();

                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron filas.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return nombre;
        }
    }

   
}

public class AccesoVentas
{
        AccesoDatos ds = new AccesoDatos();
        public AccesoVentas()
        {

        }

        public int agregarVenta(string consulta, Venta venta)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            int idCliente = venta.getIdCliente();
            string fecha = venta.getFecha();
            int precio = venta.getPrecioTotal();

            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@VALOR1", idCliente);
                        command.Parameters.AddWithValue("@VALOR2", fecha);
                        command.Parameters.AddWithValue("@VALOR3", precio);

                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
        }

    public int modificarVenta(string consulta, Venta venta)
    {
        int FilasAfectadas = 0;
        SqlConnection cn;

        int idCliente = venta.getIdCliente();
        string fecha = venta.getFecha();
        int precio = venta.getPrecioTotal();
        int id = venta.getID();

        using (cn = ds.ObtenerConexion())
        {

            try
            {

                // Crear el comando
                using (SqlCommand command = new SqlCommand(consulta, cn))
                {
                    // Definir los parámetros y asignarles valores
                    command.Parameters.AddWithValue("@VALOR1", idCliente);
                    command.Parameters.AddWithValue("@VALOR2", fecha);
                    command.Parameters.AddWithValue("@VALOR3", precio);
                    command.Parameters.AddWithValue("@VALOR4", id);

                    // Ejecutar la consulta
                    FilasAfectadas = command.ExecuteNonQuery();

                    Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }
        cn.Close();
        return FilasAfectadas;
    }
    public int eliminarVenta(string consulta1, string consulta2, Venta venta)
        {
            int FilasAfectadas = 0;
            SqlConnection cn;

            int ID = venta.getID();


            using (cn = ds.ObtenerConexion())
            {

                try
                {

                    // Crear el comando
                    using (SqlCommand command = new SqlCommand(consulta2, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@ID", ID);


                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }

                    using (SqlCommand command = new SqlCommand(consulta1, cn))
                    {
                        // Definir los parámetros y asignarles valores
                        command.Parameters.AddWithValue("@ID", ID);


                        // Ejecutar la consulta
                        FilasAfectadas = command.ExecuteNonQuery();

                        Console.WriteLine("Filas afectadas: " + FilasAfectadas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }
            cn.Close();
            return FilasAfectadas;
    }

    public string buscarUltimaIdVenta(string consulta)
    {

        SqlConnection cn;
        string id = "";
        // Crea una conexión SQL
        using (cn = ds.ObtenerConexion())
        {
            // Crea un comando SQL
            SqlCommand command = new SqlCommand(consulta, cn);

            try
            {

                // Ejecuta el comando y obtiene un lector de datos
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Verifica si el lector tiene filas
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Obtén los valores de las columnas
                            id = reader["ID"].ToString();

                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron filas.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }
        cn.Close();
        return id;
    }

    public decimal ReporteVenta(string consulta)
    {
        SqlConnection cn;
        decimal total = 0;
        using (cn = ds.ObtenerConexion())
        {
            try
            {

                using (SqlCommand command = new SqlCommand(consulta, cn))
                {
                    var result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }

        // Muestra el resultado
        Console.WriteLine("La suma total es: " + total);
        return total;
    }

    public decimal ReporteVentaCant(string consulta)
    {
        SqlConnection cn;
        decimal total = 0;
        using (cn = ds.ObtenerConexion())
        {
            try
            {

                using (SqlCommand command = new SqlCommand(consulta, cn))
                {
                    var result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }

        // Muestra el resultado
        Console.WriteLine("La suma total es: " + total);
        return total;
    }
}

