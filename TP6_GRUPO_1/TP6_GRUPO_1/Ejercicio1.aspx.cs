using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarProductos();
            }
        }

        private void cargarProductos()
        {

            GestionProductos gestionProductos = new GestionProductos();
            gvProductos.DataSource = gestionProductos.ObtenerProductos(); /// DATA TABLE
            gvProductos.DataBind();
        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // BUSCAR ID DEL ITEM TEMPLATE
            int idProducto = int.Parse(((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_IdProducto")).Text);


            /// ELIMINAR PRODUCTO
            GestionProductos gestionProductos = new GestionProductos();
            bool prodEliminado = gestionProductos.EliminarProducto(idProducto);
            mostrarMensaje(prodEliminado);
            cargarProductos();
        }

        private void mostrarMensaje(bool exito)
        {
            if (exito)
            {
                lblMensaje.Text = "Operación realizada exitosamente.";
            }
            else
            {
                lblMensaje.Text = "No se pudo realizar la operación.";
            }
        }
         //YO
        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            lblMensaje.Text = string.Empty;
            gvProductos.EditIndex = e.NewEditIndex;
            cargarProductos();
        }
        //YO
        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            cargarProductos();
        }
        //YO
        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1; //seteo el indice para que no haya ningun elemento seleccionado.
            cargarProductos();
        }
        //YO
        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            /// BUSCAR FILA DENTRO DEL EDIT ITEM TEMPLATE
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            string nombre = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            string cantidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_CantidadUnidad")).Text;
            string precio = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;


            // CREAR PRODUCTO
            Producto producto = new Producto(Convert.ToInt32(idProducto), nombre, cantidad, Convert.ToDecimal(precio));

            // ACTUALIZAR PRODUCTO
            GestionProductos gestionProductos = new GestionProductos();
            bool productoModificado = gestionProductos.ActualizarProducto(producto);
            mostrarMensaje(productoModificado);
            gvProductos.EditIndex = -1;
            cargarProductos();
        }
    }
}