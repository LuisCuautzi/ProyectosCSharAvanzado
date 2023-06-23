using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clases y Objetos");

            CCalculadora objCalcu = new CCalculadora();
            objCalcu.a = 5;
            objCalcu.b = 10;
            objCalcu.r = 3;

            objCalcu.Sumar();
        }
    }
}
