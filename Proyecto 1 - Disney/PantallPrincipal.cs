using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1___Disney
{
    public partial class PantallPrincipal : Form
    {
        Estructuras.ListaSimpleEnlazada.ListaSimple categoriaDisney = new Estructuras.ListaSimpleEnlazada.ListaSimple();
        Estructuras.ListaSimpleEnlazada.ListaSimple categoriaPixar = new Estructuras.ListaSimpleEnlazada.ListaSimple();
        Estructuras.ListaSimpleEnlazada.ListaSimple categoriaStarWars = new Estructuras.ListaSimpleEnlazada.ListaSimple();
        Estructuras.ListaSimpleEnlazada.ListaSimple categoriaNatGeo = new Estructuras.ListaSimpleEnlazada.ListaSimple();
        Estructuras.ListaSimpleEnlazada.ListaSimple categoriaMarvel = new Estructuras.ListaSimpleEnlazada.ListaSimple();

        public PantallPrincipal()
        {
            InitializeComponent();
        }
        public PantallPrincipal(object nuevaPelicula, int categoria)
        {
            InitializeComponent();
            switch (categoria)
            {
                case 0:
                    //Disney
                    categoriaDisney.InsertarInicioListaSimple(nuevaPelicula);
                    break;
                case 1:
                    //Pixar
                    categoriaPixar.InsertarInicioListaSimple(nuevaPelicula);
                    break;
                case 2:
                    //Marvel
                    categoriaMarvel.InsertarInicioListaSimple(nuevaPelicula);

                    break;
                case 3:
                    //StarWars
                    categoriaStarWars.InsertarInicioListaSimple(nuevaPelicula);
                    break;
                case 4:
                    //National Geographic
                    categoriaNatGeo.InsertarInicioListaSimple(nuevaPelicula);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargar el nombre del usuario al menu
            usuarioToolStripMenuItem.Text = LogIn.selectedUser;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var mostraLogIn = new LogIn();
            mostraLogIn.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agreagrPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mostrarPantallaAgregarPelicula = new AgrearPelicula();
            mostrarPantallaAgregarPelicula.Show();
        }
    }
}
