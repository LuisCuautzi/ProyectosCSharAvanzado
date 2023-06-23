using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9_VariablesImplicitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio con variables Implicitas");
            Console.WriteLine("Var");

            //Inicializamos
            var a = 5;
            var b = "Hola Mundo";

            //Imprimimos
            Console.WriteLine(a);
            Console.WriteLine(b);

            //Obtenemos el tipo de datosdado que es fuertemente tipificado
            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("B es {0}", b.GetType().Name);
            Console.ReadKey();

            //Operador ?. Permite ejecutar una variable saltandose la excepcion di trae null
            int? dato = 5;
            Console.WriteLine("Dato {0}",dato);

            dato = null;
            Console.WriteLine("Dato {0}", dato);

            double? precio = 5.5;
            Console.WriteLine("Dato {0}", precio);

            precio = null;

            Console.WriteLine("Precio {0}", precio);
            //Validar si un datos tiene valor
            if (precio.HasValue)
            {
                Console.WriteLine("Tiene valor");
            }
            else
            {
                Console.WriteLine("No tiene valor");
            }

            //El operador ?? nos permite asignar un valor en caso de que tenga null
            double? numero = asignador() ?? 5.55;
            Console.WriteLine(numero);
            Console.ReadKey();
        }

        public static double? asignador()
        {
            return 4.5;
            //return null;
        }
    }
}
