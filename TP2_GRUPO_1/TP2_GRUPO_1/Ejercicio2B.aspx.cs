using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_1
{
    public partial class Ejercicio2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string zona;
            string tema = "";
            nombre = ((TextBox)PreviousPage.FindControl("txtNombre")).Text; //obtengo el texto del control y lo asigno a la variable
            apellido = Request["txtApellido"].ToString();
            zona = ((DropDownList)PreviousPage.FindControl("ddlCiudad")).Text; //con .Text obtengo la propiedad listControl.SelectedValue
                                                                               //del control
            lblDatos.Text = nombre + "<br/>" + apellido + "<br/>" + zona;   //asigno las cadenas a la etiqueta
                                                                            //<br/> (etiqueta HTML salto de linea)
              // recorro el checkBoxList buscando selecionados.
            foreach(ListItem i in ((CheckBoxList)PreviousPage.FindControl("cblTemas")).Items)
            {
                if (i.Selected)
                {
                    tema += i + "<br/>";
                }
                
            }
            lblTemas.Text = tema;
        }
    }
}