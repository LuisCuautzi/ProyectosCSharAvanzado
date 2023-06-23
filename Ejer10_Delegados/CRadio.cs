using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_Delegados
{
    internal class CRadio
    {
        //Para que funcione el delegado, este metodo debe ser de tipo static
        public static void MetodoRadio(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase Radio");
            Console.WriteLine("Este es tu mensaje {0}", pMensaje);
            Console.ReadKey();  
        }
    }
}
