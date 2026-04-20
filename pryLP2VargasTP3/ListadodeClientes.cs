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
    public partial class ListadodeClientes : Form
    {
        public ListadodeClientes()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void ListadodeClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dgvClientes.Rows.Clear();
            Decimal TotalDeuda = 0;
            for (Int32 i = 0; i < VECTORcs.i; i++)
            {
                dgvClientes.Rows.Add(VECTORcs.vecClientes[i].Codigo,
                    VECTORcs.vecClientes[i].Nombre,
                    VECTORcs.vecClientes[i].Deuda,
                    VECTORcs.vecClientes[i].Limite);
                TotalDeuda = TotalDeuda + VECTORcs.vecClientes[i].Deuda;
            }
            lblTotal.Text = total.ToString();


        }

        private void gpbConsultaDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
