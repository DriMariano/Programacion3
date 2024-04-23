using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_GRUPO_1
{
    public partial class Ejercicio_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardarLocalidad_Click(object sender, EventArgs e)
        {
            ///VALIDACION QUE NO SE REPITA LOCALIDAD (NUESTRA)

            string ciudad;
            ciudad = txtLocalidad.Text;
            foreach (ListItem item in ddlLocalidades.Items)
            {
                if (item.Text.ToUpper() == ciudad.ToUpper())
                {
                    lblError.Text = "La localidad ya está registrada.";
                    limpiarTextBox(txtLocalidad);
                    return;
                }
            }
            ddlLocalidades.Items.Add(ciudad);
            ordenarDropDownList(ddlLocalidades);
            limpiarTextBox(txtLocalidad);
            lblError.Text = string.Empty;

            ///VALIDACION QUE NO SE REPITA LOCALIDAD (PROFE)

            //if (validarLocalidad(txtLocalidad.Text))
            //{
            //    ddlLocalidades.Items.Add(txtLocalidad.Text);
            //    ordenarDropDownList(ddlLocalidades);
            //}
            //else
            //{
            //    //REALIZA UN SCPRIPT EN LA URL DE LA PAGINA
            //    ClientScript.RegisterStartupScript(
            //                                    this.GetType(),
            //                                    "myalert",
            //                                    "alert('" + "La localidad ya está registrada." + "');",
            //                                    true);
            //}
            //limpiarTextBox(txtLocalidad);

        }


        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Bienvenido/a " + txtNombreUsuario.Text;
            limpiarTextBox(txtNombreUsuario);
            limpiarTextBox(txtCorreo);
            limpiarTextBox(txtCP);
            ddlLocalidades.SelectedValue = "--Seleccione Localidad--";
        }

        protected void btnIrInicio_Click(object sender, EventArgs e)
        {

            Response.Redirect("Inicio.aspx");
        }

        ///ORDENAMIENTO DE LOS ITEMS DEL DROPDOWNLIST
        private void ordenarDropDownList(DropDownList ddlOrdenada)
        {
            int i = 0;
            string[] ordenada = new string[ddlOrdenada.Items.Count];  //creo la instancia de un objeto array de string
                                                                      //con la catidad de elementos del DDL

            foreach (ListItem item in ddlOrdenada.Items)
            {
                ordenada[i] = item.ToString();
                i++;
            }
            //ORDENA A PARTIR DEL INDICE 1 (sobrecarga del metodo Sort)
            Array.Sort(ordenada,1,ordenada.Length -1);
           

            ddlOrdenada.DataSource = ordenada;
            ddlOrdenada.DataBind();
        }

        ///VALIDACION QUE NO SE REPITA LOCALIDAD (PROFE)
        
        //private bool validarLocalidad(string localidad)
        //{
        //    for (int i = 0; i < ddlLocalidades.Items.Count; i++)
        //    {
        //        //COMPARA LAS CADENAS LLEVADAS A MAYUSCULAS MEDIANTE EL METODO EQUALS 
        //        if (localidad.ToUpper().Equals(ddlLocalidades.Items[i].ToString().ToUpper()))
        //        {
        //            return false; /// ESTA REPETIDO
        //        }
        //    }
        //    return true;  /// NO ESTA REPETIDO
        //}


        private void limpiarTextBox(TextBox textBox)
        {
            textBox.Text = string.Empty;
        }
    }
}