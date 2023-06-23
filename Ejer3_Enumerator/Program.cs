using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3_Enumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IEnumerater!");

            CTiendaAutos tienda = new CTiendaAutos();

            foreach (CAuto miAuto in tienda)
            {
                miAuto.CalcularTenencia(0.05);
                miAuto.MuestraInformacion();    
            }
        }
    }
}
