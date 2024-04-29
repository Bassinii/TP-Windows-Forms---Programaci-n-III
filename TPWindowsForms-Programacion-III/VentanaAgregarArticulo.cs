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
        private Articulo articulo = null;

        public VentanaAgregarArticulo()
        {
            InitializeComponent();
        }
        public VentanaAgregarArticulo(Articulo arti)
        {
            InitializeComponent();
            this.articulo = arti;
            Text = "Modificar articulo";
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
                cboCategoria.Items.Add(categoria);
            }
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";

            if (articulo != null)
            {
                textBoxNombre.Text = articulo.nombre;
                textBoxDescripcion.Text = articulo.descripcion;
                textBoxCodigo.Text = articulo.codigo;
                textBoxPrecio.Text = articulo.precio.ToString();
                textBoxUrlImagen.Text = articulo.imagenArticulo.urlImagen;
                cargarImagen(articulo.imagenArticulo.urlImagen);
                cboMarca.SelectedItem = articulo.marca;
                cboCategoria.SelectedItem = articulo.categoria;
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarAceptar()
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                MessageBox.Show("Escribe un Nombre.");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                MessageBox.Show("Escribe un Codigo.");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                MessageBox.Show("Escribe una Descripcion.");
                return false;
            }

            if (cboMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Marca.");
                return false;
            }

            if (cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Categoria.");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxPrecio.Text))
            {
                MessageBox.Show("Escribe un Precio.");
                return false;
            }

            if (!(soloNumeros(textBoxPrecio.Text)))
            {
                MessageBox.Show("El campo Precio solo acepta numeros.");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxUrlImagen.Text))
            {
                MessageBox.Show("Escribe una URL.");
                return false;
            }

            return true;
        }

        private bool soloNumeros(string text)
        {
            foreach (char caracter in text)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }

            return true;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            NegocioArticulo artiNeg = new NegocioArticulo();

            if (articulo == null)
            {
                articulo = new Articulo();
            }

            if (validarAceptar())
            {
                try
                {
                    articulo.nombre = textBoxNombre.Text;
                    articulo.descripcion = textBoxDescripcion.Text;
                    articulo.codigo = textBoxCodigo.Text;
                    articulo.precio = float.Parse(textBoxPrecio.Text);
                    articulo.imagenArticulo = new Imagenes { urlImagen = textBoxUrlImagen.Text };
                    //SELECCION DE MARCA

                    Marca marcaSeleccionada = (Marca)cboMarca.SelectedItem;
                    articulo.marca.descripcion = marcaSeleccionada.descripcion;
                    articulo.marca.id = marcaSeleccionada.id;
                    //SELECCION CATEGORIA
                    Categoria categoriaSeleccionada = (Categoria)cboCategoria.SelectedItem;
                    articulo.categoria.descripcion = categoriaSeleccionada.descripcion;
                    articulo.categoria.id = categoriaSeleccionada.id;

                    if (articulo.id != 0)
                    {

                        artiNeg.modificar(articulo);
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        artiNeg.agregar(articulo, articulo.imagenArticulo.urlImagen);
                        MessageBox.Show("Agregado exitosamente");
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

        //ESTA FUNCION TAMBIEN SE HACE CUANTO TEXTBOXURLIMAGEN CAMBIA
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
