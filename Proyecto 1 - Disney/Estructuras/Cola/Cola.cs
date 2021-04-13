using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.Cola
{
    public class Cola
    {
        public NodoCola primero;
        public NodoCola ultimo;
        public int numeroElementos;

        public Cola()
        {
            primero = ultimo = null;
            numeroElementos = 0;
        }

        public void Insertar(Object pDato)
        {
            NodoCola nuevoNodo = new NodoCola(pDato);

            if (ColaVacia())
            {
                primero = nuevoNodo;

            }
            else
            {
                ultimo.Siguiente = nuevoNodo;
            }
            ultimo = nuevoNodo;
            numeroElementos++;
        }

        public bool ColaVacia()
        {
            return (primero == null);
        }

        public Object eliminar()
        {
            Object aux = primero.Dato;
            primero = primero.Siguiente;
            numeroElementos--;
            return aux;
        }
    }
}
