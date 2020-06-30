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
            consultaBox.Text = "Seleccione...";
            estadoBox.Text = "Seleccione...";
            nmbrInput.Text = Program.getVeterinaria().ultimoNumeroConsulta.ToString();
            comboConsulta.Items.Clear();
            foreach (Consulta c in Program.getVeterinaria().consultas)
            {
                comboConsulta.Items.Add(c);
            }
        }

        public frmApp()
        {
            InitializeComponent();
        }

        private void frmAppVet_Load(object sender, EventArgs e)
        {
            refrescarListaConsulta();

        }

        private void addConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta(clienteInput.Text, mascotaInput.Text, 
                razonInput.Text, estadoBox.Text, consultaBox.Text, int.Parse(nmbrInput.Text)); 
            if (Program.getVeterinaria().agregarConsulta(cli))
            {
                refrescarListaConsulta();
                MessageBox.Show("Consulta agregada!");
            }
        }

        private void editConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta(clienteInput.Text, mascotaInput.Text,
                razonInput.Text, estadoBox.Text, consultaBox.Text, int.Parse(nmbrInput.Text));
            if (Program.getVeterinaria().modificarConsulta(cli))
            {
                MessageBox.Show("Consulta modificada!");
                refrescarListaConsulta();
            }
        }

        private void deleteConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta(clienteInput.Text, mascotaInput.Text,
                 razonInput.Text, estadoBox.Text, consultaBox.Text, int.Parse(nmbrInput.Text));
            if (Program.getVeterinaria().eliminarConsulta(cli))
            {
                refrescarListaConsulta();
                MessageBox.Show("Consulta eliminada!");
            }
        }

        private void comboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consulta c = (Consulta)comboConsulta.SelectedItem;
            nmbrInput.Text = c.nroConsulta.ToString();
            consultaBox.SelectedItem = c.tipoConsulta;
            clienteInput.Text = c.cliente;
            mascotaInput.Text = c.mascota;
            razonInput.Text = c.razon;
            estadoBox.SelectedItem = c.estado;
        }

    }
}
