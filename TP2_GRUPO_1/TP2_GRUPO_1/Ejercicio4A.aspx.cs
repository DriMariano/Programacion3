using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_1
{
    public partial class Ejercicio4A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            //con la propiedad textMode en password para que el txtClave se vea en *.

            if(txtUsuario.Text == "Claudio" && txtCalve.Text == "casas") 
            {
                Response.Redirect("Ejercicio4B.aspx?Nombre=" + txtUsuario.Text);  //redirijo al fomulario válido enviando parametros por url.
            }
            else
            {
                Response.Redirect("Ejercicio4C.aspx"); // redirijo al furmulario de error mediante el servidor.
            }
            
        }
    }
}