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

        public void OrdenarPorNombreAscendente() 
        { 
            Int32 c = 0;
            Int32 i = 0;
            while (c < IND - 1)
            {
                if (vecClientes [i].Nombre.CompareTo(vecClientes [i].Nombre) > 0) 
                { 
                    Aux = vecClientes [i];
                    vecClientes [i] = vecClientes[i + 1];
                    vecClientes[i + 1] = Aux;
                }
                i++;
            }
            c++;
        
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
