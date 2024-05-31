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
    public partial class AgregarMarca : Form
    {
        public bool modificar = false;
        public Marca objMarca = new Marca();
        public AgregarMarca()
        {
            InitializeComponent();
            modificar = false;
        }
        public AgregarMarca(Marca obj)
        {
            InitializeComponent();
            texbAgregarMarca.Text = obj.ToString();
            modificar = true; 
            this.objMarca= obj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarM_Click(object sender, EventArgs e)
        {
            try
            {

                if(modificar==true)
                {
              
                    NegocioMarca negMarca = new NegocioMarca();
                    objMarca.descripcion = texbAgregarMarca.Text;
                    negMarca.ModificarMarca(objMarca);
                    texbAgregarMarca.Text = "";
                    MessageBox.Show("Se ha Modificado correctamente");
                
                }
                else
                {
                    Marca marca = new Marca();
                    NegocioMarca negMarca= new NegocioMarca();
                    marca.descripcion = texbAgregarMarca.Text;
                    negMarca.AgregarMarca(marca);
                    texbAgregarMarca.Text = "";
                    MessageBox.Show("Se ha agregado correctamente");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
            finally
            {
                Close();
            }

        }
    }
}
