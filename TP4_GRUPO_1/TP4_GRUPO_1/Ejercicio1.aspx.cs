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
                cargar_provincia();
            }

        }

        public void cargar_provincia()
        {
            ///Establecer la conexión a la base de datos en SQL Server

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            /// Consulta SQL que se desea ejecutar

            SqlCommand comando = new SqlCommand(consultaSQL, conexion);
            SqlDataReader sqlDataReader = comando.ExecuteReader();

            /// Asignar la tabla de datos como origen de datos del DropDownList

            ddlProvInicio.DataSource = sqlDataReader;
            ddlProvInicio.DataTextField = "NombreProvincia";
            ddlProvInicio.DataValueField = "IdProvincia";
            ddlProvInicio.DataBind();
            ddlProvInicio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));

            conexion.Close();
        }

        public void cargar_localidades(string IdProvincia)
        {
            ///Establecer la conexión a la base de datos en SQL Server

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();


            /// Consulta SQL que se desea ejecutar

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spCargarLocalidades";
            comando.Parameters.Add("@idprovincia", SqlDbType.Int).Value = IdProvincia;
           
            /// Asignar la tabla de datos como origen de datos del DropDownList

            ddlLocalidadInicio.DataSource = comando.ExecuteReader();
            ddlLocalidadInicio.DataTextField = "NombreLocalidad";
            ddlLocalidadInicio.DataValueField = "IdLocalidad";
            ddlLocalidadInicio.DataBind();
            ddlLocalidadInicio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));

            conexion.Close();
        }

        protected void ddlProvInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_localidades(ddlProvInicio.SelectedValue);
        }
    }
}