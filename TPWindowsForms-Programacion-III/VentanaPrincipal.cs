using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesdeDominio;
using Negocio;

namespace TPWindowsFormsProgramacionIII
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaListarArticulos Lista = new VentanaListarArticulos();
            Lista.Show();
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaAgregarArticulo Lista = new VentanaAgregarArticulo();
            Lista.Show();
        }
    }
}
