using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP6_GRUPO_1
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                cargarProductos();
            }
        }
        private void cargarProductos()
        {
            GestionProductos gestionProductos = new GestionProductos();
            gvProductos.DataSource = gestionProductos.ObtenerProductos2(); /// DATA TABLE
            gvProductos.DataBind();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            cargarProductos();
        }

        protected void gvProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            /// BUSCAR LOS DATOS EN FILA DENTRO DEL ITEM TEMPLATE
            string idProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_idProducto")).Text;
            string nombreProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_nombreProducto")).Text;
            string idProveedor = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_idProveedor")).Text;
            string precio = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_precioUnitario")).Text;

            /// MOSTRAR LO SELECCIONADO EN UN LABEL
            lblMensaje.ForeColor = System.Drawing.Color.Black;
            lblMensaje.Text = "Productos agregados: " + nombreProducto;

            if (Session["tabla"] == null)
            {
                Session["tabla"] = CrearTabla();
            }
           
            DataTable tabla = (DataTable)Session["tabla"];
            if (existeProducto(tabla,idProducto))
            {
                agregarFila((DataTable)Session["tabla"], idProducto, nombreProducto, idProveedor, precio);
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Producto ya seleccionado.";
            }
        }
        private DataTable CrearTabla()
        {
            DataTable dataTable = new DataTable();

            DataColumn dataColumn = new DataColumn("Id_Producto", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Nombre_Producto", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);
            
            dataColumn = new DataColumn("Id_Proveedor", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);
            
            dataColumn = new DataColumn("Precio_Unidad", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);
            
            return dataTable;
        }

        private DataTable agregarFila(DataTable dataTable, string idProd, string nombre, string idProv, string precio)
        {
            DataRow dataRow = dataTable.NewRow();

            dataRow["Id_Producto"] = idProd;
            dataRow["Nombre_Producto"] = nombre;
            dataRow["Id_Proveedor"] = idProv;
            dataRow["Precio_Unidad"] = precio;
            dataTable.Rows.Add(dataRow);

            return dataTable;
        }

        private bool existeProducto(DataTable tabla, string idProd)
        {
            foreach(DataRow fila in tabla.Rows)
            {
                if(idProd == fila["Id_Producto"].ToString())
                {
                    return false;
                }
            }
            return true;
        }
    }
}