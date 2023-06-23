using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer11_MetodosAnonimos
{
    internal class CPunto
    {
        public delegate void DelMensaje();

        public DelMensaje mensaje;

        private int x;
        private int y;

        public CPunto(int px, int py)
        {
            x = px; y = py; 
        }
        //Para que no se impriman los valoresque trae el objeto

        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}", x, y);
        }
    }
}
