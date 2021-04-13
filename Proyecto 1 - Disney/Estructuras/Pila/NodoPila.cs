using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.Pila
{
    public class NodoPila
    {
        public Object dato;
        public NodoPila siguiente;

        public NodoPila()
        {
            siguiente = null;
        }

        public NodoPila(Object pDato)
        {
            dato = pDato;
            siguiente = null;
        }
    }
}
