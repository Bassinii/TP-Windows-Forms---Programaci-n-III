using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesDeDominio;
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
            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(VentanaListarArticulos)){ return; }
                        

            }
            VentanaListarArticulos Lista = new VentanaListarArticulos();
            Lista.MdiParent = this;
           
            Lista.Show();
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaAgregarArticulo Alta = new VentanaAgregarArticulo();
            
            Alta.Show();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaMarcaslistar listarM = new VentanaMarcaslistar();
            listarM.Show();
        }
    }
}
