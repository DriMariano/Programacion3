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
    public partial class frmEjercicio3 : Form
    {
        frmPrincipal principal;
        public frmEjercicio3(frmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }
        private void frmEjercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string resultado;
            resultado = "Usted seleccionó los siguientes elementos: \n" +
                "Sexo: " + (string)(rbtnFemenino.Checked ? "Femenino" : "Masculino") + "\n" +
                "Estado Civil: " + (string)(rbtnCasado.Checked ? "Casado" : "Soltero") + "\n" +
                "Oficio: \n";
            foreach(string oficio in clbOficio.CheckedItems)
            {
                resultado += "    -" + oficio + "\n";
            }
            lblResultados.Text = resultado;
                
        }
    }
}
