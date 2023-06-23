using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12_ExpresionesLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXpresiones Lamda");

            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Ejercicio 1
            //De forma implicita colocamos el valor de i que actua como parametro y despues el codigo que va a evaluar
            //Si la expresion me va a regresar un valor que
            List<int> numPares = numeros.FindAll(i => (i % 2) == 0);

            foreach (int n in numPares)
                Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
