using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4_IEnumerable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio IEnumerable");

            CContenedora datos = new CContenedora();

            foreach(int valor in datos)
            {
                Console.WriteLine(valor);
                Console.ReadLine();
            }
        }
    }
}
