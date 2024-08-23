using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {

        private int ID;
        private string Nombre;
        private string Telefono;
        private string Correo;

        public Cliente()
        { }

        public void setID(int id)
        {
            ID = id;
        }
        public int getID()
        {
            return ID;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setTelefono(string telefono)
        {
            Telefono = telefono;
        }
        public string getTelefono()
        {
            return Telefono;
        }
        public void setCorreo(string correo)
        {
            Correo = correo;
        }
        public string getCorreo()
        {
            return Correo;
        }
    }

    public class Producto
    {

        private int ID;
        private string Nombre;
        private string Precio;
        private string Categoria;

        public Producto()
        { }

        public void setID(int id)
        {
            ID = id;
        }
        public int getID()
        {
            return ID;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setPrecio(string precio)
        {
            Precio = precio;
        }
        public string getPrecio()
        {
            return Precio;
        }
        public void setCategoria(string categoria)
        {
            Categoria = categoria;
        }
        public string getCategoria()
        {
            return Categoria;
        }
    }

    public class Venta
    {
        private int IDVenta;
        private int IdCliente;
        private string Fecha;
        private int precioTotal;

        public Venta()
        { }

        public void setID(int id)
        {
            IDVenta = id;
        }
        public int getID()
        {
            return IDVenta;
        }
        public void setIdCliente(int idCliente)
        {
            IdCliente = idCliente;
        }
        public int getIdCliente()
        {
            return IdCliente;
        }
        public void setFecha(string fecha)
        {
            Fecha = fecha;
        }
        public string getFecha()
        {
            return Fecha;
        }
        public void setPrecioTotal(int precio)
        {
            precioTotal = precio;
        }
        public int getPrecioTotal()
        {
            return precioTotal;
        }
    }

    public class DetalleVenta
    {
        private string ID;
        private string IDVenta;
        private string IdProducto;
        private string nombreProducto;
        private string PrecioUnitario;
        private string Cantidad;
        private string precioTotal;

        public DetalleVenta()
        { }

        public void setID(string id)
        {
            ID = id;
        }
        public string getID()
        {
            return ID;
        }                 
        public void setIdVenta(string idVenta)
        {
            IDVenta = idVenta;
        }
        public string getIDVenta()
        {
            return IDVenta;
        }
        public void setIdProducto(string idProducto)
        {
            IdProducto = idProducto;
        }
        public string getIdProducto()
        {
            return IdProducto;
        }
        public void setNombreProducto(string nombre)
        {
            nombreProducto = nombre;
        }
        public string getNombreProducto()
        {
            return nombreProducto;
        }
        public void setPrecioUnitario(string precio)
        {
            PrecioUnitario = precio;
        }
        public string getPrecioUnitario()
        {
            return PrecioUnitario;
        }

        public void setCantidad(string cantidad)
        {
            Cantidad = cantidad;
        }
        public string getCantidad()
        {
            return Cantidad;
        }
        public void setPrecioTotal(string total)
        {
            precioTotal = total;  
        }
        public string getPrecioTotal()
        {
            return precioTotal;
        }

    }

}
