using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_Delegados
{
    internal class CPastel
    {
        public static void MostrarPastel(string pAnunucio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El Pastel llevara el mensaje de {0} ", pAnunucio);
            Console.ReadKey();   
        }
    }
}
