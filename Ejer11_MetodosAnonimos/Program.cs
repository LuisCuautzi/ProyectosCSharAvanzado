using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer11_MetodosAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios de Metodos Anonimos");

            CPunto miPunto = new CPunto(5, 6);

            //Creamos el metodo anonimo para el delegado
            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Estoy desde el metodo anonimo");
            };

            Console.WriteLine(miPunto.ToString());

            miPunto.mensaje();

            //Adicionamos otro
            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Este es otro metodo anonimo");
            };

            Console.WriteLine(miPunto.ToString());
            miPunto.mensaje();
            Console.ReadKey();
        }
    }
}
