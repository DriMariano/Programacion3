using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            //generar una tabla en HTML
            int cantidad1 = int.Parse(txtCantidad1.Text);  //parseo de texto a entero
            int cantidad2 = int.Parse(txtCantidad2.Text);
            string tabla = "<table border = '1'>";               // a la tabla le asigno el ancho del borde con la etiqueta table de html 
            tabla += "<tr><th>Producto</th><th>Cantidad</th>";   // td para las columnas th para el encabezado tr para la fila (html)
            tabla += "<tr><td>" + txtProducto1.Text.Trim() + "</td>";
            tabla += "<td>" + cantidad1 + "</td>";
            tabla += "<tr><td>" + txtProducto2.Text.Trim() + "</td>";
            tabla += "<td>" + cantidad2 + "</td>";
            tabla += "</tr>";
            tabla += "<tr><td>Total</td>";
            tabla += "<td>" + (cantidad1 + cantidad2) + "</td>";
            tabla += "</tr>";
            tabla += "<table>";
            lblTabla.Text = tabla;    // asigno la tabla al label
        }
    }
}