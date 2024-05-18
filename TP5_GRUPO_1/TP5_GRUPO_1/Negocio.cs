using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP5_GRUPO_1
{
    public class Negocio
    {
        AccesoDatos conexion = new AccesoDatos();
        public DataTable ObtenerProvincias()
        {
            string consultaSQL = "SELECT * FROM Provincia";
            string nombreTabla = "Provincias";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }
        public int AgregarSucursal(string nombre, string descripcion, string idProvincia, string direccion)
        {
            //CONSULTA SQL PARA AGREGAR UNA NUEVA SUCURSAL
            string consultaSQL = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal)" +
                                 "VALUES ('" + nombre + "', '" + descripcion + "', " + idProvincia + ", '" + direccion + "')"; 
            return conexion.EjecutarConsulta(consultaSQL);
        }
        public DataTable ObtenerSucursales()
        {
            //CONSULTA SQL PARA OBTENER SUCURSALES
            string consultaSQL = "SELECT Id_Sucursal AS ID, NombreSucursal AS Nombre,  DescripcionSucursal AS Descripción,  DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección " +
                                 "FROM Sucursal " +
                                 "INNER JOIN Provincia ON Id_Provincia = Id_ProvinciaSucursal";
            string nombreTabla = "Sucursales";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }
        public DataTable BuscarSucursal(string idSucursal)
        {
            //CONSULTA SQL PARA BUSCAR UNA SUCURSAL
            string consultaSQL = "SELECT Id_Sucursal AS ID, NombreSucursal AS Nombre,  DescripcionSucursal AS Descripción,  DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección " +
                                 "FROM Sucursal " +
                                 "INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal " +
                                 "WHERE Id_Sucursal = " + idSucursal + " "; 
            string nombreTabla = "Sucursales";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }
        public int EliminarSucursal(string idSucursal)
        {
            // CONSULTA SQL PARA ELIMINAR UNA SUCURSAL
            string consultaSQL = "DELETE FROM Sucursal" +
                                 " WHERE Id_Sucursal = " + idSucursal + " "; 
            return conexion.EjecutarConsulta(consultaSQL);
        }
    }
}