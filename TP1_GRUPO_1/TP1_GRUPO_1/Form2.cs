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
    public partial class frmEjercicio1 : Form
    {
        frmPrincipal principal;

        public frmEjercicio1(frmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmEjercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0)
            {
                foreach(string nombre in lbIzquierdo.Items)
                {
                    if (nombre.ToUpper() == txtNombre.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("El nombre ingresado ya existe.\n Ingrese un nuevo nombre.");
                        txtNombre.Text = "";
                        return;
                    }
                }
                lbIzquierdo.Items.Add(txtNombre.Text.Trim());
                txtNombre.Text = "";

            }
            else
            {
                MessageBox.Show("Ingrese un nombre.");
            }
        }

        private void btnPasar1_Click(object sender, EventArgs e)
        {
            if(lbIzquierdo.SelectedItem != null)
            {
                lbDerecho.Items.Add(lbIzquierdo.SelectedItem);
                lbIzquierdo.Items.Remove(lbIzquierdo.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre de la lista.");
            }
            
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            lbDerecho.Items.AddRange(lbIzquierdo.Items);
            lbIzquierdo.Items.Clear();
        }
    }
}
