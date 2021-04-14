using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1___Disney.Clases
{
    class Reproduccion
    {
        public Pelicula pelicula { get; set; }
        public int estado { get; set; }
        
        /*
         * Estados:
         * -1 pelicula no reproducida
         *  0 pelicula en reproduccion
         *  1 pelicula finalizada
         */

        public Reproduccion()
        {
            this.pelicula = null;
            this.estado = -1;
        }
        public Reproduccion(Pelicula pelicula, int estado)
        {
            this.pelicula = pelicula;
            this.estado = estado;
        }
    }
}
