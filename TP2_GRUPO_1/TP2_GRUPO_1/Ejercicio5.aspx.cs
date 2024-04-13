using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_1
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //carga del drodownlist a traves de listItems

                ListItem item2GB = new ListItem();
                item2GB.Text = "2 GB";
                item2GB.Value = "200";
                ListItem item4GB = new ListItem();
                item4GB.Text = "4 GB";
                item4GB.Value = "375";
                ListItem item6GB = new ListItem();
                item6GB.Text = "6 GB";
                item6GB.Value = "500";
                ddlMemoria.Items.Add(item2GB);
                ddlMemoria.Items.Add(item4GB);
                ddlMemoria.Items.Add(item6GB);

                //carga del checkboxlist a traves de listItems
                ListItem monitor = new ListItem();
                monitor.Text = "Monitor LCD";
                monitor.Value = "2000,50";
                ListItem hd500 = new ListItem();
                hd500.Text = "HD 500GB";
                hd500.Value = "550,50";
                ListItem grabador = new ListItem();
                grabador.Text = "Grabador DVD";
                grabador.Value = "1200";
                cblAccesorios.Items.Add(monitor);
                cblAccesorios.Items.Add(hd500);
                cblAccesorios.Items.Add(grabador);
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            float total;
            string pMemoria = ddlMemoria.SelectedValue.ToString();   // asigno a la variable el texto del value
            string pAccesorio; 
            total = Convert.ToSingle(pMemoria);                   // convierto a float el string y lo asigno al total
            
            foreach(ListItem accesorio in cblAccesorios.Items)     //recorro el checkboxlist
            {
                if (accesorio.Selected)                           //pregunto si esta seleccionado
                {
                    pAccesorio = accesorio.Value;                  //asigno el value a la variable string
                    total += Convert.ToSingle(pAccesorio);     //convierto y acumulo 
                }  
            }
            
            lblResultado.Text = "El Precio final es de " + total + " $";
            
            
        }
    }
}