using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de Interfaz");

            int opcion = 0;
            double vala = 0.0;
            double valb = 0.0;

            string valor = " ";

            //Variables que pueden actuar como cualquier clase
            IOperacion operacion = new CSumar();
            while (opcion != 5)
            {
                Console.WriteLine("1.Suma, 2.Resta, 5.Salir");
                Console.WriteLine("¿Que opción deseas?");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor de a");
                valor = Console.ReadLine() ;
                vala = Convert.ToInt32(valor) ;

                Console.WriteLine("Dame el valor de b");
                valor = Console.ReadLine();
                valb = Convert.ToInt32(valor);

                if(opcion == 1)
                    operacion = new CSumar();
                if(opcion == 2)
                    operacion = new CRestar();

                operacion.calcular(vala, valb);
                operacion.mostrar();
            }
        }
    }
}
