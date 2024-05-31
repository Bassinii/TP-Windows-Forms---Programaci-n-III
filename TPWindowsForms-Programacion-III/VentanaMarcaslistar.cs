using ClasesDeDominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWindowsFormsProgramacionIII
{
    public partial class VentanaMarcaslistar : Form
    {
        public VentanaMarcaslistar()
        {
            InitializeComponent();
            CargarGrilla();
        }
        public void CargarGrilla()
        {
            NegocioMarca negMarca = new NegocioMarca();
            List<Marca> list = new List<Marca>();
            list = negMarca.listar();
            dtgMarcas.DataSource = list;
        }
        private void btnAgragar_Click(object sender, EventArgs e)
        {
            AgregarMarca agregarMarca= new AgregarMarca();
            agregarMarca.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnModifM_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            NegocioMarca Marca = new NegocioMarca();
            if (dtgMarcas.CurrentRow != null)
            {
                seleccionado = (Marca)dtgMarcas.CurrentRow.DataBoundItem;
                
                AgregarMarca modificar = new AgregarMarca(seleccionado);
                modificar.ShowDialog();
                CargarGrilla(); //Para que puede mostrar en la grilla nuevamente lo cargado
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NegocioMarca baja = new NegocioMarca();
            Marca seleccionado;
            if (dtgMarcas.CurrentRow != null)
            {
                try
                {
                    seleccionado = (Marca)dtgMarcas.CurrentRow.DataBoundItem;
                    baja.eliminar(seleccionado.id);
                    CargarGrilla();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void VentanaMarcaslistar_Load(object sender, EventArgs e)
        {

        }
    }
}
