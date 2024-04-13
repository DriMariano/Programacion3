using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing; //agrego el espacio de nobre para poder trabajar con colores.

namespace TP2_GRUPO_1
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbRojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Red;       //al hacer click en rojo el color de texto del label cambia a rojo.
        }

        protected void lbAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Blue;
        }

        protected void lbVerde_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Green;
        }
    }
}