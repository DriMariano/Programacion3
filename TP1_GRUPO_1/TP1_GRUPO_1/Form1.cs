﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            frmEjercicio1 ejercicio1 = new frmEjercicio1(this);
            ejercicio1.Show();
            this.Hide();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            frmEjercicio2 ejercicio2 = new frmEjercicio2(this);
            ejercicio2.Show();
            this.Hide();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            frmEjercicio3 ejercicio3 = new frmEjercicio3(this);
            ejercicio3.Show();
            this.Hide();
        }
    }
}
