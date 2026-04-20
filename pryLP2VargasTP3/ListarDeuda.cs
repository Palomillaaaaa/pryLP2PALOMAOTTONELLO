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
    public partial class ListarDeuda : Form
    {
        public ListarDeuda()
        {
            InitializeComponent();
        }

        private void ListarDeuda_Load(object sender, EventArgs e)
        {
            {
                
                Decimal total = 0;
                dgvClientes.Rows.Clear();
                for (int i = 0; i < VECTORcs.i; i++)
                {
                    if (VECTORcs.vecClientes[i].Deuda > 0)
                    {
                        dgvClientes.Rows.Add(VECTORcs.vecClientes[i].Codigo, VECTORcs.vecClientes[i].Nombre, VECTORcs.vecClientes[i].Deuda, VECTORcs.vecClientes[i].Limite);
                        total = total + VECTORcs.vecClientes[i].Deuda;
                    }
                }

               lblTotal.Text = total.ToString();
              
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gpbConsultaDatos_Enter(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
