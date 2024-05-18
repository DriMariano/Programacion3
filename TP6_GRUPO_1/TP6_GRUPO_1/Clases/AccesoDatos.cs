using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_1
{
    public class AccesoDatos
    {
        /// PROPIEDADES
        string rutaNeptuno = "Data Source=localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True";
        SqlCommand comando = new SqlCommand();
        /// METODO CONSTRUCTOR
        public AccesoDatos()
        {
            // TODO: Agregar aquí la lógica del constructor
        }

        /// METODOS
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(rutaNeptuno);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //metodo que recibe una consulta y un tipo de comando(texto o procedimiento almacenado) y los asigna al comando
        public void configurarComando(string consulta, CommandType tipo)
        {
            comando.CommandType = tipo;
            comando.CommandText = consulta;
        }

        //agrega parametros al comando en nuestro caso para terminar de armar las consultas
        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }


        public SqlDataAdapter ObtenerAdaptador(string consultaSql)
        {
            SqlDataAdapter sqlDataAdapter;
            try
            {
                sqlDataAdapter = new SqlDataAdapter(consultaSql, ObtenerConexion());
                return sqlDataAdapter;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int ejecutarConsulta()
        {
            SqlConnection conexion = ObtenerConexion();
            try
            {

                comando.Connection = conexion;
                int filas = (int)comando.ExecuteNonQuery(); //sirve para ejecutar consultas de tipo insert, update o delete

                return filas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}