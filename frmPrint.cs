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
        public frmPrint()
        {
            InitializeComponent();
        }
        public void frmPrint_Load(object sender, EventArgs e)
        {
            Veterinaria Vet = Program.getVeterinaria();

            foreach (Veterinaria element in Vet)
            {
                
            }
        }
    }
}