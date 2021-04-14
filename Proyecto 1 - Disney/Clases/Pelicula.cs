using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Clases
{
    class Pelicula
    {
        public string titulo { get; set; }
        public Categoria? categoria { get; set; }

        public Pelicula()
        {
            this.titulo = "";
            this.categoria = null;
        }
        public Pelicula(string titulo, Categoria categoria)
        {
            this.titulo = titulo;
            this.categoria = categoria;
        }
    }
    public enum Categoria
    {       
        Disney, 
        Pixar, 
        Marvel, 
        StarWars,
        NationalGeographic
    }
}
