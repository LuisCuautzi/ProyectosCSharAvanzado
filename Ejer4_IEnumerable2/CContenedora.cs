using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4_IEnumerable2
{
    internal class CContenedora : IEnumerable
    {
        private int[] valores = new int[20];

        public CContenedora() { 
            for (int n = 0; n < 20; n++)
            {
                valores[n] = n * n;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }
    }

    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        public int position = -1;

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        public bool MoveNext()
        {
            position++;
            if (position < arreglo.Length)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return arreglo[position]; }
        }
    }
}
