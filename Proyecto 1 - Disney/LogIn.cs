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

    public partial class LogIn : Form
    {
        Estructuras.ListaDobleEnlazada.ListaDoble listaUsuario = new Estructuras.ListaDobleEnlazada.ListaDoble();
        public static string selectedUser = "";
        public static int selectedTypeUser = -1;

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton registro
            Usuario nuevoUsuario = new Usuario(textBox1.Text, comboBox2.SelectedIndex,null);
            listaUsuario.agregarAlFinal(nuevoUsuario);
            comboBox1.Items.Add(nuevoUsuario.ToString());
            limpiarRegistro();
        }

        private void limpiarRegistro()
        {
            textBox1.Text = "";
            comboBox2.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Boton iniciar sesion
            if (comboBox1.SelectedIndex != -1)
            {
                selectedUser = comboBox1.SelectedItem.ToString();
                var mostratPantallaPrincipal = new PantallPrincipal();
                mostratPantallaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No selecciono un usuario para ingresar.");
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
