using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLP2VargasTP3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmMenu();
            formulario.MdiParent= this;
            formulario.Show();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form formulario = new frmListadoOrdenado();
        }
    }
}
