using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TP5_GRUPO_1
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataAdapter adapter;
        private SqlDataReader reader;
        private DataSet ds;
        

        //private string cadenaConexion ="Data Source=localhost\\sqlexpress01;Initial Catalog=BDSucursales;Integrated Security=True";

       

        public AccesoDatos()
        {
            //Establezco la cadena de conexion a la base de datos
            conexion = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True");
            comando = new SqlCommand(); //inicio un nuevo comando y le asigno la conexion
            comando.Connection = conexion;
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

        //metodo que nos devuelve una tabla a partir de un comando sql
        public DataTable obtenerTablas(string nombreTabla)
        {
            DataTable tabla = null;
            try
            {
                // se usa el adapter para rellenar un dataset
                adapter = new SqlDataAdapter(comando);
                ds = new DataSet();
                adapter.Fill(ds, nombreTabla);
                tabla = ds.Tables[nombreTabla];//asigno el dataset a una variable llamada tabla que es lo que se va a retornar
            }
            catch (Exception ex)
            {
               throw ex;

            }
            finally
            {
                //cierro la conexion independientemente de que se ejecute lo contenido en el try o que se genere una excepcion
                conexion.Close();
                
            }
            return tabla;
        }
    

        public int ejecutarConsulta()
        {
            try
            {
                conexion.Open();
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