﻿using System;
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
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                listaArticulos = negocio.listar();

                gdvListadoDeArticulos.DataSource = listaArticulos;
                //gdvListadoDeArticulos.Columns["ImagenUrl"].Visible = false;

                cargarImagen(listaArticulos[0].imagenArticulo.urlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

            private void gdvListadoDeArticulos_SelectionChanged(object sender, EventArgs e) 
        {
            Articulo seleccionado = (Articulo)gdvListadoDeArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.imagenArticulo.urlImagen);

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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            VentanaAgregarArticulo alta = new VentanaAgregarArticulo();
            alta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
