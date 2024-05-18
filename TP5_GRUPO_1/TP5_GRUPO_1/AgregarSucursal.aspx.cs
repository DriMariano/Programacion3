using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_1
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        Negocio negocio = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarProvincias();
            }
        }
        private void CargarProvincias()
        {
            ddlProvincias.DataSource = negocio.ObtenerProvincias();
            ddlProvincias.DataTextField = "DescripcionProvincia";
            ddlProvincias.DataValueField = "Id_Provincia";
            ddlProvincias.DataBind();
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = negocio.AgregarSucursal(txtNombreSucursal.Text, txtDescripcion.Text, ddlProvincias.SelectedValue, txtDireccion.Text);
            limpiarCampos();
            mostarMensaje(filasAfectadas);
        }

        private void mostarMensaje(int filasAfectadas)
        {
            if(filasAfectadas == 1)
            {
                lblMensaje.Text = "Sucursal agregada con éxito.";
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "No se pudo agregar las sucursal.";
            }
        }
        private void limpiarCampos()
        {
            txtNombreSucursal.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            ddlProvincias.SelectedValue = "0";
        }
    }
}