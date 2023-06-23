using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //es la coleccion FIFO, nos permite almacenar la informacion en colas
            Console.WriteLine("Queue");

            Queue miQ = new Queue();

            //Agregar Elementos
            miQ.Enqueue("Manzanas");
            miQ.Enqueue("Fresa");
            miQ.Enqueue("Pera");

            foreach (string fruta in miQ)
            {
                Console.WriteLine("->{0}", fruta);
            }
            Console.WriteLine("-------");

            //Obtener un objecto
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());
            foreach (string fruta in miQ)
            {
                Console.WriteLine("Despues dequeue->{0}", fruta);
            }
            Console.WriteLine("--------");

            //Adicionar objetos
            miQ.Enqueue("Limon");
            miQ.Enqueue("Mango");
            miQ.Enqueue("Ciruela");

            Console.WriteLine("Peek: {0}", miQ.Peek());

            foreach (string fruta in miQ)
            {
                Console.WriteLine("Despues dequeue->{0}", fruta);
            }
            Console.WriteLine("--------");

            Console.WriteLine(miQ.Count);

            Console.WriteLine(miQ.Contains("Limon"));

            Console.ReadKey();

        }
    }
}
