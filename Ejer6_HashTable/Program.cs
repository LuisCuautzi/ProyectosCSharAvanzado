using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios HashTable");
            //Estructura de datos no secuencial, colocan la informacion en un valor calculado al que se le conoce como key y realiza una operacion de hash
            //Guarda la tupla de una llave con  el valor
            //Sirve para poner un numero de empleado por ejemplo y atraves de la llave acceder al nombre del empleado

            Hashtable miTabla = new Hashtable();
            miTabla.Add(123, "hola");
            miTabla.Add(234, "saludos");
            miTabla.Add(125, "otro mas");

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.Write("({0},{1})", elemento.Key, elemento.Value);
            }
            //Cantidad de elementos
            Console.WriteLine(miTabla.Count);
            Console.ReadLine();

            //Obtener el elemento de determina llave
            Console.WriteLine(miTabla[123]);
            Console.ReadLine();

            //Colocamos elemento en una llave
            miTabla[123] = "Avanzando";  
            foreach(DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("{0},{1}", elemento.Key, elemento.Value);
            }
            Console.WriteLine("------------");
            Console.ReadLine();

            //acceder a los elentos utilizando la llave
            foreach (int llave in miTabla.Keys)
            {
                Console.WriteLine(llave);
            }
            Console.WriteLine("------------");
            Console.ReadLine();

            //acceder a los elemtos utilizados la llave
            foreach (string valor in miTabla.Values)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("------------");
            Console.ReadLine();


            //Acceder a los elementos
        }
    }
}
