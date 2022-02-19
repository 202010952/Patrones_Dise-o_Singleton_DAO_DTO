﻿using PatronDisenoSingleton.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronDisenoSingleton
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioClientes FrmClientes = FormularioClientes.ObtenerInstancia();
            FrmClientes.MdiParent = this;
            FrmClientes.Show();
        }
    }
}