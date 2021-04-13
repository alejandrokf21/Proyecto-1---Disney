using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.ListaSimpleEnlazada
{
    public class NodoLista
    {
        public NodoLista siguiente;
        public Object Dato;

        public NodoLista()
        {
            siguiente = null;
            Dato = null;
        }

        public NodoLista(Object pDato)
        {
            siguiente = null;
            Dato = pDato;
        }

        public NodoLista(Object pDato, NodoLista pNodo)
        {
            Dato = pDato;
            siguiente = pNodo;
        }
    }
}
