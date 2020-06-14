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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }


        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTurnoVet_Click(object sender, EventArgs e)
        {
            frmAppVet form = new frmAppVet();
            form.Show();
        }

        private void btnPelu_Click(object sender, EventArgs e)
        {
            frmTurnoPelu form = new frmTurnoPelu();
            form.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClient form = new frmClient();
            form.Show();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            frmMascotas form = new frmMascotas ();
            form.Show();
        }

    }
}
