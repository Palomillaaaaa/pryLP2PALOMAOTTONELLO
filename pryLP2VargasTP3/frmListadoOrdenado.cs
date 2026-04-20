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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            VECTORcs.precarga();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        VECTORcs.ordenarCodigoAscendente();
                    }
                    else
                    {
                        VECTORcs.ordenarCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        VECTORcs.ordenarNombreAscendente();
                    }
                    else
                    {
                        VECTORcs.ordenarNombreDescendente();
                    }
                    break;
                case 2:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        VECTORcs.ordenarLimiteAscendente();
                    }
                    else
                    {
                        VECTORcs.ordenarLimiteDescendente();
                    }
                    break;
                case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        VECTORcs.ordenarDeudaAscendente();
                    }
                    else
                    {
                        VECTORcs.ordenarDeudaDescendente();
                    }
                    break;
            }

            int indice = 0;
            decimal deuda = 0;
            dgvUsuario.Rows.Clear();
            while (indice < VECTORcs.i)
            {
                dgvUsuario.Rows.Add(VECTORcs.vecClientes[indice].Codigo, VECTORcs.vecClientes[indice].Nombre,
                    VECTORcs.vecClientes[indice].Limite, VECTORcs.vecClientes[indice].Deuda);
                deuda = deuda + VECTORcs.vecClientes[indice].Deuda;
                indice++;
            }
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}