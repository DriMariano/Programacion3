using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP5_GRUPO_1
{
    public partial class ListadoDeSucursales : System.Web.UI.Page
    {
        Negocio negocio = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarSucursales();
            }
        }

        private void CargarSucursales()
        {
            gvSucursales.DataSource = negocio.ObtenerSucursales();
            gvSucursales.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            gvSucursales.DataSource  = negocio.BuscarSucursal(txtBuscarSucursal.Text);
            gvSucursales.DataBind();
            txtBuscarSucursal.Text = string.Empty;
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvSucursales.DataSource = negocio.ObtenerSucursales();
            gvSucursales.DataBind();
            txtBuscarSucursal.Text = string.Empty;
        }
    }
}