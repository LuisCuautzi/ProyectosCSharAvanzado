using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3_Enumerator
{
    
    internal class CTiendaAutos
    {
        private CAuto[] disponibles;

        public CTiendaAutos()
        {
            disponibles = new CAuto[3];

            disponibles[0] = new CAuto("Soul", 222000.20);
            disponibles[1] = new CAuto("Fit", 1752000.02);
            disponibles[2] = new CAuto("Tiida", 120000.00);
        }

        public IEnumerator GetEnumerator()
        {
            return disponibles.GetEnumerator();
        }
    }
}
