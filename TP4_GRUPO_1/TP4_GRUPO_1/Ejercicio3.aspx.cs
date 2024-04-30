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
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        private const string cadenaConexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
        private string consultaSQL = "SELECT * FROM temas";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTemas();
            }
        }
        public void cargarTemas()
        {
            ///Establecer la conexión a la base de datos en SQL Server
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            /// Consulta SQL que se desea ejecutar
            SqlCommand comando = new SqlCommand(consultaSQL, conexion);
            SqlDataReader sqlDataReader = comando.ExecuteReader();
            /// Asigno la tabla de datos como origen de datos del DropDownList
            ddlTemas.DataSource = sqlDataReader;
            ddlTemas.DataTextField = "Tema";
            ddlTemas.DataValueField = "IdTema";
            ddlTemas.DataBind();
            ///cierro conexion
            conexion.Close();
        }

        protected void lbtnVerLibros_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio3a.aspx");
        }
    }
}