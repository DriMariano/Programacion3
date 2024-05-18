using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_1
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        Negocio negocio = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = negocio.EliminarSucursal(txtIdSucursalEliminar.Text);
            txtIdSucursalEliminar.Text = string.Empty;
            mostarMensaje(filasAfectadas);
        }
        private void mostarMensaje(int filasAfectadas)
        {
            if (filasAfectadas == 1)
            {
                lblMensaje.Text = "Sucursal eliminada con éxito.";
            }
            else
            {
                lblMensaje.Text = "La sucursal es inexistente.";
            }
        }
    }
}