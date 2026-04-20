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

        static public RegCli[] vecClientes = new RegCli[20];

        static public int i = 0;

        static public void ordenarCodigoAscendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Codigo > vecClientes[ind + 1].Codigo)
                    {
                        Aux = vecClientes[ind];
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void ordenarCodigoDescendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Codigo < vecClientes[ind + 1].Codigo)
                    {
                        Aux = vecClientes[ind];        // ⚠️ Bug: debería ser vecClientes[ind]
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void ordenarNombreAscendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Nombre.CompareTo(vecClientes[ind + 1].Nombre) > 0)
                    {
                        Aux = vecClientes[ind];
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void ordenarNombreDescendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Nombre.CompareTo(vecClientes[ind + 1].Nombre) < 0) 
                    {
                        Aux = vecClientes[ind];
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void ordenarLimiteAscendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Limite > vecClientes[ind + 1].Limite)
                    {
                        Aux = vecClientes[ind];
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void ordenarLimiteDescendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Limite < vecClientes[ind + 1].Limite)
                    {
                        Aux = vecClientes[ind];        
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void ordenarDeudaAscendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Deuda > vecClientes[ind + 1].Deuda)
                    {
                        Aux = vecClientes[ind];
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void ordenarDeudaDescendente()
        {
            Int32 c = 0;
            Int32 ind = 0;
            RegCli Aux;
            while (c < i - 1)
            {
                ind = 0;
                while (ind < i - 1)
                {
                    if (vecClientes[ind].Deuda < vecClientes[ind + 1].Deuda)
                    {
                        Aux = vecClientes[ind];        
                        vecClientes[ind] = vecClientes[ind + 1];
                        vecClientes[ind + 1] = Aux;
                    }
                    ind++;
                }
                c++;
            }
        }

        static public void precarga()
        {
            vecClientes[i].Codigo = 111;
            vecClientes[i].Nombre = "Pepe";
            vecClientes[i].Limite = 1500;
            vecClientes[i].Deuda = 10000;
            i++;

            vecClientes[i].Codigo = 222;
            vecClientes[i].Nombre = "Juan";
            vecClientes[i].Limite = 800;
            vecClientes[i].Deuda = 0;
            i++;

            vecClientes[i].Codigo = 333;
            vecClientes[i].Nombre = "Ana";
            vecClientes[i].Limite = 20000;
            vecClientes[i].Deuda = 1000;
            i++;

            vecClientes[i].Codigo = 1121321;
            vecClientes[i].Nombre = "Lisando";
            vecClientes[i].Limite = 1500;
            vecClientes[i].Deuda = 10000;
            i++;

            vecClientes[i].Codigo = 22231232;
            vecClientes[i].Nombre = "Rodrigo";
            vecClientes[i].Limite = 4535;
            vecClientes[i].Deuda = 123123;
            i++;

            vecClientes[i].Codigo = 5345;
            vecClientes[i].Nombre = "Ramiro";
            vecClientes[i].Limite = 1111;
            vecClientes[i].Deuda = 1523;
            i++;
        }
    }
}