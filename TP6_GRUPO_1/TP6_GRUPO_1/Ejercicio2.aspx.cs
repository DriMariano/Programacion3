﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_1
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnEliminar_Click(object sender, EventArgs e)
        {
            Session["tabla"] = null;
            lblMensaje.Text = "Tabla eliminada exitosamente.";
        }
    }
}