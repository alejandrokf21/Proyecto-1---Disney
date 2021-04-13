using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.ListaSimpleEnlazada
{
    public class ListaSimple
    {
        public NodoLista primero;

        public ListaSimple()
        {
            primero = null;
        }

        public void InsertarInicioListaSimple(object pDato)
        {
            NodoLista nuevo = new NodoLista(pDato);
            nuevo.siguiente = primero;
            primero = nuevo;
        }

        public ListaSimple insertarUltimo(NodoLista ultimo, object entrada)
        {
            ultimo.siguiente = new NodoLista(entrada);
            ultimo = ultimo.siguiente;
            return this;
        }

        public ListaSimple insertarLista(NodoLista anterior, object entrada)
        {
            NodoLista nuevo;
            nuevo = new NodoLista(entrada);
            nuevo.siguiente = anterior.siguiente;
            anterior.siguiente = nuevo;
            return this;
        }

        public ListaSimple insertarLista(object testigo, object entrada)
        {
            NodoLista nuevo, anterior;
            anterior = buscarLista(testigo);
            if (anterior != null)
            {
                nuevo = new NodoLista(entrada);
                nuevo.siguiente = anterior.siguiente;
                anterior.siguiente = nuevo;
            }
            return this;
        }

        public NodoLista buscarLista(object destino)
        {
            NodoLista indice;
            for (indice = primero; indice != null; indice = indice.siguiente)
                if (destino == indice.Dato) // (destino.equals(indice.dato))
                    return indice;
            return null;
        }

        public NodoLista primerNodo()
        {
            return primero;
        }

        public void eliminar(object entrada)
        {
            NodoLista actual, anterior;
            Boolean encontrado;
            //inicializa los apuntadores
            actual = primero;
            anterior = null;
            encontrado = false;
            // búsqueda del nodo y del anterior
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.Dato == entrada);
                //con objetos: actual.dato.equals(entrada)
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                }
            }

            // siguiente del nodo anterior con el siguiente
            if (actual != null)
            {
                // Distingue entre que el nodo sea el cabecera,
                // o del resto de la lista
                if (actual == primero)
                {
                    primero = actual.siguiente;
                }
                else
                {
                    anterior.siguiente = actual.siguiente;
                }
                actual = null; // no es necesario al ser una variable local
            }
        }
    }
}
