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
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        // Cadena de conexión a la base de datos SQL 
        private const string rutaNeptunoSQL = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
        // Consulta SQL para seleccionar productos
        private string consultaProductosSQL = "SELECT IdProducto,NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad\r\nFROM Productos";
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si es la primera vez que se carga la página se listan los productos
            if (!IsPostBack)
            {
                listarProductos();
            }
        }

        private void listarProductos()
        {
            //establezco la conexión con la base de datos
            SqlConnection conexion = new SqlConnection(rutaNeptunoSQL);
            conexion.Open();
            //ejecuto la consulta SQL
            SqlCommand sqlCommand = new SqlCommand(consultaProductosSQL, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //enlazo los datos al gridview Productos
            gvProductos.DataSource = reader;
            gvProductos.DataBind();
            //cierro la conexion
            conexion.Close();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            // construyo de la consulta SQL para filtrar los productos
            string consulta = "SELECT IdProducto,NombreProducto, IdCategoría, CantidadPorUnidad,PrecioUnidad FROM Productos WHERE";

            // Verifico si se ha ingresado un valor en el campo de texto txtProducto
            if (txtProducto.Text != string.Empty)

            {
                // segun el valor seleccionado en ddlProducto añado una condición a la consulta.
                switch (ddlProducto.SelectedValue)
                {
                    case "Igual a":
                        consulta += " IdProducto = " + int.Parse(txtProducto.Text) + " AND ";
                        break;
                    case "Mayor a":
                        consulta += " IdProducto > " + int.Parse(txtProducto.Text) + " AND ";
                        break;
                    case "Menor a":
                        consulta += " IdProducto < " + int.Parse(txtProducto.Text) + " AND ";
                        break;
                }


            }
            // Verifico si se ha ingresado un valor en el campo de texto txtCategoria
            if (txtCategoria.Text != string.Empty)
            {
                // segun el valor seleccionado en ddlCategoria añado una condición a la consulta.
                switch (ddlCategoria.SelectedValue)
                {
                    case "Igual a":
                        consulta += " IdCategoría = " + int.Parse(txtCategoria.Text);
                        break;
                    case "Mayor a":
                        consulta += " IdCategoría > " + int.Parse(txtCategoria.Text);
                        break;
                    case "Menor a":
                        consulta += " IdCategoría < " + int.Parse(txtCategoria.Text);
                        break;

                }

            }
            else
            {
                // Si no se ingreso nada txtCategoria añado una condición verdadera para que la consulta no tire un error
                consulta += "1=1";
            }

            // Si no se ingreso ningún valor en los campos de texto, se muestran todos los productos
            if (string.IsNullOrEmpty(txtProducto.Text) && string.IsNullOrEmpty(txtCategoria.Text))
            {
                listarProductos();
                return;

            }

            //establezco la conexión con la base de datos
            SqlConnection conexion = new SqlConnection(rutaNeptunoSQL);
            conexion.Open();

            //ejecuto la consulta SQL
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            //enlazo los datos al gridview Productos
            gvProductos.DataSource = reader;
            gvProductos.DataBind();
            conexion.Close();
            txtProducto.Text = string.Empty;
            txtCategoria.Text = string.Empty;
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            // limpio los campos de texto y vuelvo a listar todos los productos
            txtProducto.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            listarProductos();
        }
    }
    
}