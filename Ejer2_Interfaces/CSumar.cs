using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2_Interfaces
{
    internal class CSumar: IOperacion
    {
        private double r = 0;

        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}", r);
        }
    }
}
