using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_Delegados
{
    internal class Program
    {
        public delegate void MiDelegado(string m);
        static void Main(string[] args)
        {
            Console.WriteLine("Elegir Delegado");

            MiDelegado dlegado = new MiDelegado(CRadio.MetodoRadio);

            dlegado("Hola a Todos");

            dlegado = new MiDelegado(CPastel.MostrarPastel);

            dlegado("Feliz Cumpleaños");
        }
    }
}
