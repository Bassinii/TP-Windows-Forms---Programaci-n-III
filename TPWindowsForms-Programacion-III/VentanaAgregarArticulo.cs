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
    public partial class VentanaAgregarArticulo : Form
    {
        List<Marca> marcas;
        List<Categoria> categorias;

        public VentanaAgregarArticulo()
        {
            InitializeComponent();
        }


        private void VentanaAgregarArticulo_Load(object sender, EventArgs e)
        {
            //CON LA CARGA DE LA VENTANA SE CREAN LISTAS DE LAS MARCAS Y LAS CATEGORIAS
            //Y SE LE ASIGNAN LOS VALORES DE LA BASE DE DATOS
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            marcas = negocioMarca.listar();
            categorias = negocioCategoria.listar();
            foreach (Marca marca in marcas)
            {
                cboMarca.Items.Add(marca);
            }
            foreach (Categoria categoria in categorias)
            {
                comboBoxCat2.Items.Add(categoria);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Articulo arti = new Articulo();
            NegocioArticulo artiNeg = new NegocioArticulo();
            try
            {
                arti.nombre = textBoxNombre.Text;
                arti.descripcion = textBoxDescripcion.Text;
                arti.codigo = textBoxCodigo.Text;
                arti.precio = float.Parse(textBoxPrecio.Text);
                arti.imagenArticulo = new Imagenes { urlImagen = textBoxUrlImagen.Text };
                //SELECCION DE MARCA
               
                Marca marcaSeleccionada = (Marca)cboMarca.SelectedItem;
                arti.marca.descripcion = marcaSeleccionada.descripcion;
                arti.marca.id = marcaSeleccionada.id;
                //SELECCION CATEGORIA
                Categoria categoriaSeleccionada = (Categoria)comboBoxCat2.SelectedItem;
                arti.categoria.descripcion = categoriaSeleccionada.descripcion;
                arti.categoria.id = categoriaSeleccionada.id;

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

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxAgregar.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxAgregar.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");

            }

        }
    }
}
