using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetApp
{
    public partial class frmApp : Form
    {
        private void refrescarListaConsulta()
        {
            clienteInput.Clear();
            mascotaInput.Clear();
            razonInput.Clear();
            consultaBox.Items.Clear();
            estadoBox.Items.Clear();
        }

        public frmApp()
        {
            InitializeComponent();
        }

        private void frmAppVet_Load(object sender, EventArgs e)
        {

        }

        private void addConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta(clienteInput.Text, mascotaInput.Text, mascotaInput.Text, consultaBox.Text, estadoBox.Text, int.Parse(nmbrInput.Text)); 
            if (Program.getVeterinaria().agregarConsulta(cli))
            {
                refrescarListaConsulta();
                MessageBox.Show("Consulta agregada!");
            }
        }

        private void editConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta(clienteInput.Text, mascotaInput.Text, mascotaInput.Text, consultaBox.Text, estadoBox.Text, int.Parse(nmbrInput.Text));
            if (Program.getVeterinaria().modificarConsulta(cli))
            {
                refrescarListaConsulta();
            }
        }

        private void deleteConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta(clienteInput.Text, mascotaInput.Text, mascotaInput.Text, consultaBox.Text, estadoBox.Text, int.Parse(nmbrInput.Text));
            if (Program.getVeterinaria().eliminarConsulta(cli))
            {
                refrescarListaConsulta();
                MessageBox.Show("Consulta agregada!");
            }
        }
    }
}
