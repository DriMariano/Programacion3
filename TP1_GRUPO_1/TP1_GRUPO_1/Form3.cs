using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_1
{
    public partial class frmEjercicio2 : Form
    {
        frmPrincipal principal;
        public frmEjercicio2(frmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmEjercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Los campos deben estar completos.");
                return;
            }
            foreach(string nombre in lbNombreApellido.Items)
            {
                if(nombre.ToUpper() == txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper())
                {
                    MessageBox.Show("El nombre ingresado ya existe en la lista.");
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    return;
                }
            }
            lbNombreApellido.Items.Add(txtNombre.Text.Trim() + " " + txtApellido.Text.Trim());
            lbNombreApellido.Sorted = true;
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lbNombreApellido.SelectedItems.Contains(lbNombreApellido.SelectedItem))
            {
                lbNombreApellido.Items.Remove(lbNombreApellido.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para borrar.");
            }
            
                
            
            
        }
    }
}
