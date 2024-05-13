using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using ClasesDeDominio;

namespace TPWindowsFormsProgramacionIII
{
    public partial class VentanaListarArticulos : Form
    {   
        private List<Articulo> listaArticulos;
        List<Categoria> categorias;

        List<string> listadImagenes = new List<string>(); //declaramos lista de imagen generales (para usar en funciones distintas)
        int indiceImagen = 0;

        public VentanaListarArticulos()
        {
            InitializeComponent();
            //CargarGrilla("select * from ARTICULOS");
        }
        /*public void CargarGrilla(string consulta)
        {
            NegocioArticulo miaccesoDatos= new NegocioArticulo();
            SqlConnection Cn = new SqlConnection(miaccesoDatos.GetRuta());
            SqlCommand cmd = new SqlCommand(consulta,Cn);
            Cn.Open();
            SqlDataReader dataReader= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            gdvListadoDeArticulos.DataSource = dt;
            Cn.Close();
        }
        */

        private void ListarArticulos_Load(object sender, EventArgs e)
        {
            cargar(); //Se pasa dentro del metodo cargar
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            categorias = negocioCategoria.listar();
            foreach (Categoria categoria in categorias)
            {
                comboBoxCategoria.Items.Add(categoria);
            }

            comboBoxPrecio.Items.Add("Mayor a");
            comboBoxPrecio.Items.Add("Menor a");
            comboBoxPrecio.Items.Add("Igual a");
        }

            private void gdvListadoDeArticulos_SelectionChanged(object sender, EventArgs e) 
        {
            NegocioArticulo NArti = new NegocioArticulo();//aca esta la funcion que devuelve las imagenes
            Articulo seleccionado = (Articulo)gdvListadoDeArticulos.CurrentRow.DataBoundItem;//se guardan los datos del articulo al que se hace clic en esta variable
       
            //se corrige Metodo para que acepte imagenes en Null
            
            int idArticulo = seleccionado.id > 0 ? seleccionado.id : -1;
            List<Imagenes> lista = NArti.GetImagenes(idArticulo); //creamos lista de imagenes de ese articulo seleccionado

            if(lista.Count > 1)
            {
                cantidadImagen.Text = indiceImagen + 1 + " / " + lista.Count;
                for(int y = 0; y < lista.Count; y++)
                {
                   
                    listadImagenes.Add(lista[y].urlImagen);//aca guardamos todas las imagenes de nuestro art
                    //verif.Text = lista[y].urlImagen;
                    cargarImagen(lista[y].urlImagen); //cargamos las fotos

                }
            }
            else
            {
                if(listadImagenes != null)
                {
                    listadImagenes.Clear();


                }
                cantidadImagen.Text = "";
                cargarImagen(lista[0].urlImagen);
                //verif.Text = lista[0].urlImagen;
            }

            
        }
        private void MostrarImagenActual()
        {
            if(indiceImagen < 0)
            {
                indiceImagen = listadImagenes.Count - 1;

            }
            else if(indiceImagen >= listadImagenes.Count) {
                indiceImagen = 0;
            }
            pictureBoxImagen.Load(listadImagenes[indiceImagen]);
        }
        //Se crea Metodo cargar
        private void cargar()
        {
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                listaArticulos = negocio.listar();

                gdvListadoDeArticulos.DataSource = listaArticulos;

                //gdvListadoDeArticulos.Columns["ImagenUrl"].Visible = false;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].listImagenes[0].urlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagen.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxImagen.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
                
            }
            
        }

        private void ocultarColumnas()
        {
            gdvListadoDeArticulos.Columns["Codigo"].Visible = false;
            gdvListadoDeArticulos.Columns["Descripcion"].Visible = false;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            VentanaAgregarArticulo alta = new VentanaAgregarArticulo();
           
            alta.ShowDialog();
            cargar(); //Para que puede mostrar en la grilla nuevamente lo cargado
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            NegocioArticulo baja = new NegocioArticulo();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)gdvListadoDeArticulos.CurrentRow.DataBoundItem;
                baja.eliminar(seleccionado.id);
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            NegocioArticulo baja = new NegocioArticulo();
            Articulo seleccionado;
            if (gdvListadoDeArticulos.CurrentRow != null)
            {
                try
                {
                    seleccionado = (Articulo)gdvListadoDeArticulos.CurrentRow.DataBoundItem;
                    baja.eliminar(seleccionado.id);
                    cargar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Validar Fltros

        private bool validarFiltro()
        {
            if(comboBoxCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Falta seleccionar algun item");
                return true;
            }
            if(comboBoxPrecio.SelectedIndex < 0)
            {
                MessageBox.Show("Falta seleccionar algun item");
                return true;
            }
            if (string.IsNullOrEmpty(textBoxFiltro.Text))
            {
                MessageBox.Show("El campo *Filtro* no puede estar vacio");
                return true;
            }
            if (!soloNumeros(textBoxFiltro.Text))
            {
                MessageBox.Show("Por favor solo numeros");
                return true;
            }

            return false;
        }
        //Para validar que sea un nro
        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        //busqueda por filtros
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                //usamos para validar que se ha ingresado un item
                if (validarFiltro())
                    return;

                string categoria = comboBoxCategoria.SelectedItem.ToString();
                string precio = comboBoxPrecio.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;
                gdvListadoDeArticulos.DataSource = negocio.filtrar(categoria, precio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //LE PASO POR PARAMENTRO EL OBJETO ARTICULO QUE QUIERO MODIFAR, A LA VENTANA O FRM

            Articulo seleccionado;
            if (gdvListadoDeArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)gdvListadoDeArticulos.CurrentRow.DataBoundItem; 
                VentanaAgregarArticulo modificar = new VentanaAgregarArticulo(seleccionado);
                modificar.ShowDialog();
                cargar(); //Para que puede mostrar en la grilla nuevamente lo cargado
            }
        }
        //buscar ya
        private void buttonBuscarR_Click(object sender, EventArgs e)
        {
            //lo pasamos al mas rapido

        }
        //Para Busqueda mas rapida
        private void textBoxFiltrarR_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxFiltrarR_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltrarR.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.nombre.ToUpper().Contains(filtro.ToUpper()) || x.marca.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.categoria.descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            gdvListadoDeArticulos.DataSource = null;
            gdvListadoDeArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {


                if (listadImagenes.Count > 1 && listadImagenes != null)
                {
                    indiceImagen--;
                    MostrarImagenActual();
                    cantidadImagen.Text = indiceImagen + 1 + " / " + listadImagenes.Count;
            }
                else if(listadImagenes == null)
                {
                    MostrarImagenActual();
                }

         
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (listadImagenes.Count > 1)
            {
                indiceImagen++;
                MostrarImagenActual();
                cantidadImagen.Text = indiceImagen + 1 + " / " + listadImagenes.Count;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
