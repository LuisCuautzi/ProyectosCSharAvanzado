using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Stack(Pila)");
            //Este ejercicio muestra somo se usa la pila o estructura LiFo

            string palabra;

            Stack miPila = new Stack();
            miPila.Push("Hola");
            miPila.Push("Soy");
            miPila.Push("Yo");

            for (byte i = 0; i <3;  i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
            }
            Console.ReadKey();

        }
    }
}
