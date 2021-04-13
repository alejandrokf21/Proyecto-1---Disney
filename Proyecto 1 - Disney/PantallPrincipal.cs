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
        public PantallPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargar el nombre del usuario al menu
            usuarioToolStripMenuItem.Text = "Prueba";
        }
    }
}
