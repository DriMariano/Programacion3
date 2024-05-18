using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace TP5_GRUPO_1
{
    public class AccesoDatos
    {
        private static string rutaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";
        public DataTable ObtenerTablas(string consultaSQL, string nombreTabla)
        {
            SqlConnection conexion = new SqlConnection(rutaConexion);
            conexion.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, conexion);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "NombreTabla");
            conexion.Close();
            return dataset.Tables["NombreTabla"];
        }

        public int EjecutarConsulta(string consultaSQL)
        {
            SqlConnection conexion = new SqlConnection(rutaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand(consultaSQL, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery(); // PARA INSERT-UPDATE-DELETE
            conexion.Close();
            return filasAfectadas;
        }
    }
}