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
    public partial class VentanaAgregarArticulo : Form
    {
        public VentanaAgregarArticulo()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Articulo arti = new Articulo();
            NegocioArticulo artiNeg = new NegocioArticulo();
            try
            {
                arti.id = int.Parse(textID.Text);
                arti.nombre = textBoxNombre.Text;
                arti.descripcion = textBoxDescripcion.Text;
                arti.codigo = textBoxCodigo.Text;

                arti.marca = new Marca { id = int.Parse(textBoxMarca.Text) };
                arti.categoria = new Categoria { id = int.Parse(textBoxCategoria.Text)};
                
                arti.precio = float.Parse(textBoxPrecio.Text);
                arti.imagenArticulo = new Imagenes { urlImagen = textBoxUrlImagen.Text };


                artiNeg.agregar(arti, arti.imagenArticulo.urlImagen);
                
                MessageBox.Show("Agregado exitosamente");
                
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
