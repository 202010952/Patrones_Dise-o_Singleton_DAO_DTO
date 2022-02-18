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
        public FormularioClientes()
        {
            InitializeComponent();
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
    }
}
