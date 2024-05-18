using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_1
{
    public partial class ListarSucursal : System.Web.UI.Page
    {
        Negocio negocio = new Negocio();  //creo una nueva instancia de la clase Negocio.
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarSucursales();  // Cargo la lista de sucursales en la primer carga de la página
            }
        }

        private void cargarSucursales()
        {
            // Establezco la fuente de datos del gv con la lista obtenida de un metodo de la clase negocio
            gvSucursales.DataSource = negocio.listarSucursales();
            gvSucursales.DataBind(); // Vinculo los datos al GridView.
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string id = txtIDSucursal.Text; // asigno el ID de la sucursal desde el textbox

            // Establezco la fuente de datos del gv con la lista obtenida de un metodo de la clase negocio
            //Envio el id de sucursal al metodo para que pueda filtrar
            gvSucursales.DataSource = negocio.filtrarSucursales(id);
            gvSucursales.DataBind();   // Vinculo los datos al GridView. 
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            
            cargarSucursales(); // Cargo y muestro todas las sucursales nuevamente.
            txtIDSucursal.Text = string.Empty; // Limpio el textbox del ID de la sucursal.
        }
    }
}