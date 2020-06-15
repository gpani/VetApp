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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void refrescarListaClientes()
        {
            nameInput.Clear();
            ageInput.Clear();
            idInput.Clear();
            phoneInput.Clear();
            addressInput.Clear();
            comboVerClientes.Items.Clear();
            foreach (Cliente c in Program.getVeterinaria().clientes)
            {
                comboVerClientes.Items.Add(c);
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            refrescarListaClientes();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(nameInput.Text, int.Parse(ageInput.Text), int.Parse(idInput.Text), phoneInput.Text, addressInput.Text);
            Program.getVeterinaria().agregarCliente(c);
            refrescarListaClientes();
            MessageBox.Show("Cliente agregado!");
        }

        private void comboVerClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)comboVerClientes.SelectedItem;
            nameInput.Text = c.nombreApellido;
            ageInput.Text = c.edad.ToString();
            addressInput.Text = c.domicilio;
            idInput.Text = c.dni.ToString();
            phoneInput.Text = c.telefono;
            
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(nameInput.Text, int.Parse(ageInput.Text), int.Parse(idInput.Text), phoneInput.Text, addressInput.Text);
            Program.getVeterinaria().modificarCliente(c);
            refrescarListaClientes();
            MessageBox.Show("Cliente editado!");
        }

        private void removeClient_Click(object sender, EventArgs e)
        {
            Cliente c = (Cliente)comboVerClientes.SelectedItem;
            Program.getVeterinaria().eliminarCliente(c);
            refrescarListaClientes();
            MessageBox.Show("Cliente eliminado!");
        }
    }
}
