using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio con Collecciones");
            Console.WriteLine("ArrayList");

            int n = 0;
            int r = 0;

            //Ejer1
            //ArrayList Nos permite agrgar o eliminar elementos en tiempo de ejecucion
            //Se crea la intancia
            //ArrayList palabras = new ArrayList();

            ////Adicional los elemtos
            //palabras.AddRange(new string[] { "hola", "como", "Estas?" });

            //Console.WriteLine("Cantidad de elemtos {0}", palabras.Count);

            ////Recoremos con el ciclo for
            //for (n =0; n< palabras.Count; n++)
            //{
            //    Console.WriteLine(palabras[n]);
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------");
            //Console.ReadLine();

            //Ejer2
            //Console.WriteLine("ArrayList Adicionando elementos");

            //ArrayList palabras = new ArrayList();
            //palabras.Add("bien y tu?");

            //foreach(string palabra in palabras)
            //{
            //    Console.WriteLine("{0}", palabra);
            //}

            //Console.WriteLine();
            //Console.WriteLine("------");

            //Ejer3
            Console.WriteLine("ArrayList Adicionando Valores Enteros");

            ArrayList valores = new ArrayList();

            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            //Recoremos con el ciclo for
            for (n = 0; n < valores.Count; n++)
            {
                //Se utiliza un typecast por qoe lo que estamos guardando son objetos
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.ReadKey();

            //Ejer4
            //Vemos si existe un elemento en el ArrayList regresa un true
            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));
            Console.WriteLine("---------");

            //Ejer5
            //Insertar en un indece en particular
            valores.Insert(2, 55);

            for(n= 0; n < valores.Count; ++n)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("--------");

            //Ejer6
            //Remover un elemento
            valores.Remove(55);
            for(n = 0; n < valores.Count; n++)
            { 
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("---------");

            //Ejer7
            //Remover un elemento en un indice
            valores.RemoveAt(0);

            for(n = 0; n < valores.Count ; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("------");

            Console.ReadKey();
        }
    }
}
