using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Estructuras.ListaDobleEnlazada
{
    public class ListaDoble
    {

        private NodoListaDoble primero;
        private NodoListaDoble ultimo;

        public ListaDoble()
        {
            primero = ultimo = null;
        }

        //Metodo para verificar si la lista esta vacia
        public bool listaVacia()
        {
            return primero == null;
        }

        //Metodo para agregar nodos al final
        public void agregarAlFinal(Object pDato)
        {
            if (!listaVacia())
            {
                ultimo = new NodoListaDoble(pDato, null, ultimo);
                ultimo.anterior.siguiente = ultimo;
            }
            else
            {
                primero = ultimo = new NodoListaDoble(pDato);
            }
        }

        //Metodo para mostrar datos de la lista
        public NodoListaDoble primerNodo()
        {
            return primero;
        }

        //Metodo para mostrar los datos del nodo
        public void mostrarListaIniciFin()
        {
            if (!listaVacia())
            {
                String datos = "<=>";
                NodoListaDoble auxiliar = primero;
                while (auxiliar != null)
                {
                    datos = datos + "[" + auxiliar.dato.ToString() + "] <=> ";
                    auxiliar = auxiliar.siguiente;
                }
                System.Console.WriteLine("Lista: " + datos);
                System.Windows.Forms.MessageBox.Show("Listado de Cursos: " + datos, "Listado de Cursos");
            }
        }

    }
}
