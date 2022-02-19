using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatronDisenoSingleton.DAO;

namespace PatronDisenoSingleton.UserInterface
{
    public partial class FormularioClientes : Form
    {
        //PATRON SINGLETON
        public FormularioClientes()
        {
            InitializeComponent();
        }
        private static FormularioClientes Instancia = null;
        public static FormularioClientes ObtenerInstancia() {
            if (Instancia == null)
            {
                Instancia = new FormularioClientes();
            }
            return Instancia;
        } 
        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            VerRegistros("");
        }
        private void VerRegistros(string condicion) 
        {
            ClienteDao Dao = new ClienteDao();
            dataGridView1.DataSource = Dao.VerRegistros(condicion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }
    }
}
