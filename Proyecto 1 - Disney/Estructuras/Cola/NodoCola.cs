using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.Cola
{
    public class NodoCola
    {
        public object Dato;
        public NodoCola Siguiente;
        public NodoCola Anterior;

        public NodoCola()
        {
            Siguiente = Anterior = null;
        }

        public NodoCola(Object pDato)
        {
            Dato = pDato;
            Siguiente = Anterior = null;
        }
    }
}
