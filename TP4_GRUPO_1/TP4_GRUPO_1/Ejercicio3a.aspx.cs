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
    public partial class Ejercicio3a : System.Web.UI.Page
    {
        private const string cadenaConexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarLibros();
            }
            
        }
        public void cargarLibros()
        {
            string consultaSQL = "SELECT * FROM Libros WHERE IdTema = ";
            
            //establezco la conexión con la base de datos
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            
            //ejecuto la consulta SQL
            consultaSQL += Request["ddlTemas"].ToString();
            
            SqlCommand sqlCommand = new SqlCommand(consultaSQL, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
           
            //enlazo los datos al gridview Libros
            gvLibros.DataSource = reader;
            gvLibros.DataBind();
            //cierro la conexion
            conexion.Close();
        }

        protected void lbtnConsultar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio3.aspx");
        }
    }
}