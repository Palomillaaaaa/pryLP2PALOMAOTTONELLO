using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLP2VargasTP3
{
    internal class VECTORcs
    {
        public struct RegCli
        {
            public Int32 Codigo;
            public string Nombre;
            public decimal Deuda;
            public decimal Limite;
        }

        static public RegCli[] Clientes = new RegCli[10];
        static public Int32 IND = 0;
    }
}
