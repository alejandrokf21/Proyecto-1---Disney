using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.ListaDobleEnlazada
{
    public class NodoListaDoble
    {
        public Object dato { get; set; }
        public NodoListaDoble siguiente { get; set; }
        public NodoListaDoble anterior { get; set; }

        public NodoListaDoble(Object pDato)
        {
            siguiente = anterior = null;
            dato = pDato;
        }
        public NodoListaDoble(Object pDato, NodoListaDoble pNodoSiguiente, NodoListaDoble pNodoAtras)
        {
            dato = pDato;
            siguiente = pNodoSiguiente;
            anterior = pNodoAtras;
        }
    }
}

