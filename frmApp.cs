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
            comboCliente.Text = "Seleccione...";
            comboMascota.Text = "Seleccione...";
            razonInput.Clear();
            consultaBox.Text = "Seleccione...";
            estadoBox.Text = "Seleccione...";
            nmbrInput.Text = Program.getVeterinaria().ultimoNumeroConsulta.ToString();
            comboConsulta.Items.Clear();
            foreach (Consulta c in Program.getVeterinaria().consultas)
            {
                comboConsulta.Items.Add(c);
            }
            comboCliente.Items.Clear();
            foreach (Cliente c in Program.getVeterinaria().clientes)
            {
                comboCliente.Items.Add(c);
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
            Consulta c = new Consulta((Cliente)comboCliente.SelectedItem, (Mascota) comboMascota.SelectedItem, 
                razonInput.Text, estadoBox.Text, consultaBox.Text, int.Parse(nmbrInput.Text)); 
            if (Program.getVeterinaria().agregarConsulta(c))
            {
                refrescarListaConsulta();
                MessageBox.Show("Consulta agregada!");
            }
        }

        private void editConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta((Cliente)comboCliente.SelectedItem, (Mascota)comboMascota.SelectedItem,
                razonInput.Text, estadoBox.Text, consultaBox.Text, int.Parse(nmbrInput.Text));
            if (Program.getVeterinaria().modificarConsulta(cli))
            {
                MessageBox.Show("Consulta modificada!");
                refrescarListaConsulta();
            }
        }

        private void deleteConsulta_Click(object sender, EventArgs e)
        {
            Consulta cli = new Consulta((Cliente)comboCliente.SelectedItem, (Mascota)comboMascota.SelectedItem,
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
            comboCliente.SelectedItem = c.cliente;
            comboMascota.SelectedItem = c.mascota;
            razonInput.Text = c.razon;
            estadoBox.SelectedItem = c.estado;
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMascota.Items.Clear();
            foreach (Mascota m in Program.getVeterinaria().mascotas)
            {
                if (((Cliente)comboCliente.SelectedItem).coincideCon(m.duenno))
                {
                    comboMascota.Items.Add(m);
                }
            }
        }
    }
}
