using Proyecto_1___Disney.Estructuras.Pila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Clases
{
    class Usuario
    {
        public string nUsuario { get; set; }
        public int tipoUsuario { get; set; }
        public Estructuras.Pila.Pila miLista { get; set; }

        public Usuario()
        {
            this.nUsuario = "";
            this.tipoUsuario = -1;
            this.miLista = null;
        }

        public Usuario(string nUsuario, int tipoUsuario, Pila miLista)
        {
            this.nUsuario = nUsuario;
            this.tipoUsuario = tipoUsuario;
            this.miLista = miLista;
        }

        public int TipoUsuario()
        {
            return tipoUsuario;
        }

        public override string ToString()
        {
            return nUsuario;
        }
    }
}
