using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace TP6_GRUPO_1
{
    public class GestionProductos
    {
        AccesoDatos datos = new AccesoDatos();
        public GestionProductos()
        {
            /// CONSTRUCTOR POR DEFECTO O VACIO
        }

        /// METODOS
        private DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = datos.ObtenerAdaptador(consultaSQL);
            adapter.Fill(ds, nombreTabla);
            return ds.Tables[nombreTabla];
        }

        public DataTable ObtenerProductos()
        {
            return ObtenerTabla("Productos", "SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad FROM Productos");
        }

        public DataTable ObtenerProductos2()
        {
            return ObtenerTabla("Productos", "SELECT IdProducto, NombreProducto, IdProveedor, PrecioUnidad FROM Productos");
        }
        //VIKY
        public bool EliminarProducto (int idProd)
        {
            datos.configurarComando("spEliminarProducto", CommandType.StoredProcedure);
            datos.agregarParametro("@IdProducto", idProd);

            int filasAfectadas = datos.ejecutarConsulta();
            
            
            if (filasAfectadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //YO
        public bool ActualizarProducto(Producto producto)
        {
            datos.configurarComando("spActualizarProducto", CommandType.StoredProcedure);
            datos.agregarParametro("@IdProducto", producto.idProducto);
            datos.agregarParametro("@NombreProducto", producto.nombreProducto);
            datos.agregarParametro("@CantidadUnidad", producto.cantidadUnidad);
            datos.agregarParametro("@PrecioUnitario", producto.precioUnitario);

            int filasAfectadas = datos.ejecutarConsulta();


            if (filasAfectadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}