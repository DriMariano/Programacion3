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
        Negocio negocio=new Negocio(); //creo una nueva instancia de la clase Negocio.
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Si es la primera vez que se carga la página, cargo las provincias en el DropDownList.
                cargarprovincias();
            }
           
        }

        private void cargarprovincias()
        {
            //Establezco la fuente de datos del DropDownList con lo retornado de un metodo de la clase negocios
            ddlProvincias.DataSource = negocio.ObtenerProvincias();
            ddlProvincias.DataTextField = "DescripcionProvincia";// establezco el campo que obtiene el texto 
            ddlProvincias.DataValueField = "Id_Provincia";//establezco el campo que obtiene el value
            ddlProvincias.DataBind(); //enlazo los datos al ddl
          
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre =txtNombreSucursal.Text;
            string descripcion=txtDescripcion.Text;
            int provincia= int.Parse(ddlProvincias.SelectedValue);
            string direccion= txtDireccion.Text;
            int filas = negocio.agregarSucursal(nombre,descripcion,provincia,direccion);
            
            //Envio la variable filas para verificar
            mostrarMensaje(filas);// Mensaje de exito o error de agregado a la base de datos
            limpiarCampos();      //vacio el contenido de los textbox   
        }
        private void mostrarMensaje(int filasAfectadas)
        {
            //verifico si pudo cargar a la base de datos 
            if (filasAfectadas == 1)
            {
                lblMensaje.Text = "Sucursal agregada con exito.";
            }
            else
            {
                lblMensaje.Text = "La sucursal no se pudo agregar.";
            }
        }

        private void limpiarCampos()
        {
            //vacio el contenido de los textbox y asigno una selección al DDL
            txtNombreSucursal.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            ddlProvincias.SelectedValue = "0";
        }
    }
}