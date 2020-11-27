using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_Notas.Net
{
    public partial class PpalMdi : Form
    {
        public PpalMdi()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cargar el formulario correspondiente

            Form1 ventanaEstudiantes = new Form1();
            ventanaEstudiantes.MdiParent = this;
            ventanaEstudiantes.Show();
        }

        private void papeleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ventanaPapelera = new Form2();
            ventanaPapelera.MdiParent = this;
            ventanaPapelera.Show();
        }
    }
}
