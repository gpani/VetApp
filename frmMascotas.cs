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
    public partial class frmMascotas : Form
    {
        public frmMascotas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dueñoM_Click(object sender, EventArgs e)
        {

        }

        private void refrescarListaMascotas()
        {
            txtNombreM.Clear();
            numEdadM.Value = 0;
            comboCliente.Text = "Seleccione...";
            txtRazaM.Clear();
            txtPeso.Clear();
            comboVerMascota.Items.Clear();
            foreach (Mascota m in Program.getVeterinaria().mascotas)
            {
                comboVerMascota.Items.Add(m);
            }
            comboCliente.Items.Clear();
            foreach (Cliente c in Program.getVeterinaria().clientes)
            {
                comboCliente.Items.Add(c);
            }
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota(txtNombreM.Text, txtRazaM.Text, (int)numEdadM.Value,
                (Cliente)comboCliente.SelectedItem, float.Parse(txtPeso.Text));

            if (Program.getVeterinaria().agregarMascota(m))
            {
                refrescarListaMascotas();
                MessageBox.Show("Mascota agregada!");
            }
                
        }

        private void btnHistorialM_Click(object sender, EventArgs e)
        {

        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMascotas_Load(object sender, EventArgs e)
        {
            refrescarListaMascotas();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarMascota_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota(txtNombreM.Text, txtRazaM.Text, (int)numEdadM.Value,
                (Cliente)comboCliente.SelectedItem, float.Parse(txtPeso.Text));
            if (Program.getVeterinaria().modificarMascota(m))
            {
                refrescarListaMascotas();
                MessageBox.Show("Mascota editada!");
            }
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            Mascota m = (Mascota)comboVerMascota.SelectedItem;
            if (Program.getVeterinaria().eliminarMascota(m))
            {
                refrescarListaMascotas();
                MessageBox.Show("Mascota eliminada!");
            }
        }

        private void comboVerMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mascota m = (Mascota)comboVerMascota.SelectedItem;
            txtNombreM.Text = m.nombre;
            txtRazaM.Text = m.raza;
            numEdadM.Value = m.edad;
            comboCliente.SelectedItem = m.duenno;
            txtPeso.Text = m.peso.ToString();
        }
    }
}
