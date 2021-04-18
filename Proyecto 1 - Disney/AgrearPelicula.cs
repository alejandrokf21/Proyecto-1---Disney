using Proyecto_1___Disney.Clases;
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
  
    public partial class AgrearPelicula : Form
    {
        //Estructuras.ListaSimpleEnlazada.ListaSimple nuevaPelicula = new Estructuras.ListaSimpleEnlazada.ListaSimple();
        
        public AgrearPelicula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria selectedCategory = new Categoria();          


            //int categoria = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex != -1 || textBox1.Text=="")
            {
                try
                {
                    selectedCategory = (Categoria)Enum.Parse(typeof(Categoria), comboBox1.Text);
                    Pelicula nuevaPelicula = new Pelicula(textBox1.Text, selectedCategory);
                    var mostratPantallaPrincipal = new PantallPrincipal(nuevaPelicula, comboBox1.SelectedIndex);
                    mostratPantallaPrincipal.Show();                    
                    this.Close();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("'{0}' is not a member of the Colors enumeration.", selectedCategory);
                }      
                

            }
            else
            {
                MessageBox.Show("Asegurese de ingresar el titulo y la categoria de la pelicula.");
            }
            
        }
    }
}
