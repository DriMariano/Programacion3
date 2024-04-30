using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TP4_GRUPO_1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
        private string consultaSQL = "SELECT * FROM Provincias";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarProvincia();
            }

        }

        protected void ddlProvInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargarLocalidades(ddlProvInicio.SelectedValue, ddlLocalidadInicio);

            if (ddlProvInicio.SelectedValue != "0")
            {
                ddlProvFinal.Enabled = true;
                cargarProvinciasFinal(ddlProvInicio.SelectedValue); //llamada al metodo
            }
            else
            {  
                ddlProvFinal.Enabled = false;  
                ddlProvFinal.Items.Clear();
                ddlProvFinal.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
            ddlLocalidadFinal.Items.Clear();
            ddlLocalidadFinal.Items.Insert(0, new ListItem("--Seleccionar--", "0"));

        }

        protected void ddlProvFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidades(ddlProvFinal.SelectedValue, ddlLocalidadFinal); 
        }


        public void cargarProvincia()
        {
            ///Establecer la conexión a la base de datos en SQL Server

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            /// Consulta SQL que se desea ejecutar

            SqlCommand comando = new SqlCommand(consultaSQL, conexion);
            SqlDataReader sqlDataReader = comando.ExecuteReader();

            /// Asigno la tabla de datos como origen de datos del DropDownList

            ddlProvInicio.DataSource = sqlDataReader;  
            ddlProvInicio.DataTextField = "NombreProvincia";
            ddlProvInicio.DataValueField = "IdProvincia";
            ddlProvInicio.DataBind();
            ddlProvInicio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));

            conexion.Close();
        }

        public void cargarLocalidades(string idProvincia, DropDownList ddlLocalidades)
        {
            ///Establecer la conexión a la base de datos en SQL Server

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            /// Consulta SQL que se desea ejecutar

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spCargarLocalidades";
            comando.Parameters.Add("@idprovincia", SqlDbType.Int).Value = idProvincia;
           
            /// Asignar la tabla de datos como origen de datos del DropDownList

            ddlLocalidades.DataSource = comando.ExecuteReader();
            ddlLocalidades.DataTextField = "NombreLocalidad";
            ddlLocalidades.DataValueField = "IdLocalidad";
            ddlLocalidades.DataBind();
            ddlLocalidades.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
       
            conexion.Close();
        }

        private void cargarProvinciasFinal(string idProvincia) //Recibe el Id (value) de la provincia seleccionada en el ddlProvInicio
        {
            ///Establezco y abro la conexión a la base de datos en SQL Server
            
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
           
            /// Realizo la consulta SQL que se desea ejecutar
           
            SqlCommand comando = new SqlCommand();  //Creo una nueva instancia de un comando SQL
            comando.Connection = conexion;           //conecto el comando a la conexion SQL
            comando.CommandType = CommandType.StoredProcedure;  //Asigno el tipo de comando a utilizar (Procedimiento Almacenado)
            comando.CommandText = "spCargarProvinciasFinal";   // asigno el nombre del Procedimiento
            comando.Parameters.Add("@idprovincia", SqlDbType.Int).Value = idProvincia;  // doy Valor al parametro que recibira el Procedimiento

            /// Asigno la tabla de datos como origen de datos del DropDownList
            
            ddlProvFinal.DataSource = comando.ExecuteReader(); // establesco la fuente de datos
            ddlProvFinal.DataTextField = "NombreProvincia";   // establesco el campo
            ddlProvFinal.DataValueField = "IdProvincia";      // establesco el value
            ddlProvFinal.DataBind();                         // relleno el DDL
            ddlProvFinal.Items.Insert(0, new ListItem("--Seleccionar--", "0"));  // agrego un item al DDL

            conexion.Close(); // cierro la conexion a la base de datos
        }
     
       
    }
}