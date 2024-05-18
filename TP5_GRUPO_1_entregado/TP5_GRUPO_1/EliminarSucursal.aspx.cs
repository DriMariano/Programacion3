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
        Negocio negocio=new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
             string id = txtIdSucursal.Text;// Obtengo  el ID del textbox

            // Llamo al método eliminarSucursal de la clase negocio y guardo el número de filas que devuelve.
            int filas = negocio.eliminarSucursal(id);
            // Llamo al método mostrarMensaje pasando el número de filas 
            mostrarMensaje(filas);
        }
        //metodo para verificar si se elimino la sucursal
        //o si la Id ingresada no corresponde a una sucursal en la base de datos
        private void mostrarMensaje(int filasAfectadas)
        {
            if (filasAfectadas == 1)
            {
                lblMensaje.Text = "Sucursal eliminada con exito";
            }
            else
            {
                lblMensaje.Text = "Id inexistente";
            }
            txtIdSucursal.Text=string.Empty; //limpio el textBox
        }

       
    }
}