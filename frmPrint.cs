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
    public partial class frmPrint : Form
    {
        Veterinaria Vet = Program.getVeterinaria();
        public frmPrint()
        {
            InitializeComponent();
        }
        public void frmPrint_Load(object sender, EventArgs e)
        {



        }

        private void cargarClientes_Click(object sender, EventArgs e)
        {
            this.listadoClientes.DataSource = null;
            this.listadoClientes.Rows.Clear();
            this.listadoClientes.Refresh();

            this.listadoMascotas.Hide();
            this.listadoTurnos.Hide();
            this.listadoClientes.Show();

            foreach (Cliente element in Vet.clientes)
            {
                string[] fila = new string[] { element.nombreApellido, element.edad.ToString(), element.dni.ToString(), element.telefono, element.domicilio};
                listadoClientes.Rows.Add(fila);
            }

        }

        private void cargarMascotas_Click(object sender, EventArgs e)
        {
            this.listadoMascotas.DataSource = null;
            this.listadoMascotas.Rows.Clear();
            this.listadoMascotas.Refresh();

            this.listadoMascotas.Show();
            this.listadoTurnos.Hide();
            this.listadoClientes.Hide();

            foreach (Mascota element in Vet.mascotas)
            {
                string[] fila = new string[] { element.nombre, element.edad.ToString(), element.duenno.nombreApellido, element.peso.ToString() };
                listadoMascotas.Rows.Add(fila);
            }
        }

        private void cargarTurnos_Click(object sender, EventArgs e)
        {
            this.listadoTurnos.DataSource = null;
            this.listadoTurnos.Rows.Clear();
            this.listadoTurnos.Refresh();

            this.listadoMascotas.Hide();
            this.listadoTurnos.Show();
            this.listadoClientes.Hide();

            foreach (Consulta element in Vet.consultas)
            {
                string[] fila = new string[] { element.cliente, element.mascota, element.razon, element.tipoConsulta, element.nroConsulta.ToString(), element.estado };
                listadoTurnos.Rows.Add(fila);
            }
        }

        private void listadoHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listadoTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}