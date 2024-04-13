using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_1
{
    public partial class Ejercicio2A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            //CARGA DE DROPDOWNLIST
        {
            if (!IsPostBack)     //pregunto si es la primera creación de la pagina
            {
                ListItemCollection ciudades = new ListItemCollection();    //creo una instacia de una colección de listItems
                ciudades.Add(new ListItem("Gral. Pacheco", "Norte"));  // agrego cada items con su value
                ciudades.Add(new ListItem("San Miguel", "Oeste"));
                ciudades.Add(new ListItem("Boedo", "Sur"));
                ddlCiudad.DataSource = ciudades;           //asigno a la fuente de recursos de datos la coleccion(ciudades)
                ddlCiudad.DataTextField = "Text";          // relleno del dropdownlist
                ddlCiudad.DataValueField = "Value";                
                ddlCiudad.DataBind();

            }
        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio2B.aspx");     //transfiero la info de este form al sitio del ejercicio2B mediante el servidor
           
        }
    }
}