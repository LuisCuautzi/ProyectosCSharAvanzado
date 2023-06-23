using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3_Enumerator
{
    internal class CAuto : IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;
        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }

        public void CalcularTenencia(double imp)
        {
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Tiene un costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0} ", costo + tenencia);
            Console.WriteLine("--------");
            Console.ReadKey();
        }
    }
}
