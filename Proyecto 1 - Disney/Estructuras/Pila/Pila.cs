using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.Pila
{
    public class Pila
    {
        public NodoPila cima { get; set; }
        public int numeroElementos { get; set; }

        public Pila()
        {
            cima = null;
            numeroElementos = 0;
        }

        public Boolean PilaVacia()
        {
            return (cima == null);
        }

        public void Push(object pDato)
        {
            NodoPila nuevo = new NodoPila(pDato);

            if (PilaVacia())
            {
                cima = nuevo;
                numeroElementos++;
            }
            else
            {
                nuevo.siguiente = cima;
                cima = nuevo;
                numeroElementos++;
            }
        }

        public void Pop()
        {
            if (!PilaVacia())
            {
                cima = cima.siguiente;
                numeroElementos--;
            }
        }

        public void BorrarPila()
        {
            cima = null;
            numeroElementos = 0;
        }

        public override string ToString()
        {
            return cima.ToString();
        }
    }
}
