using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1_Clases
{
    public class CCalculadora
    {
        //Atributos
        public double a, b, r;

        //Metodos
        public void Sumar()
        {
            double r;
            r = 9;
            this.r = a + b + this.r + r;
            r = a + b + r;

            //Invocamos un metodo para mostrar el resultado
            Muestra();
        }

        private void Muestra()
        {
            Console.WriteLine("a = {0}, b = {1} y r = {2}", a, b, r);
            Console.ReadLine();
        }
    }
}
