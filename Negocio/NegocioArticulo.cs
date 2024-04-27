using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasesdeDominio;
using System.Windows.Forms;

namespace Negocio
{
    public class NegocioArticulo
    {
        //private string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog = CATALOGO_P3_DB; Integrated Security = True";
        //   public NegocioArticulo()
        // public string GetRuta() { return ruta; }
        public List<Articulo> listar()
        {   

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datosArticulo = new AccesoDatos();
            try
            {
                //datosArticulo.setearConsulta("SELECT A.Id,Codigo,Nombre,A.Descripcion, M.Descripcion Marca,C.Descripcion Categoria,Precio,I.ImagenUrl FROM Articulos A, Categorias C, Marcas M, IMAGENES I WHERE A.Id = C.Id AND M.Id = A.Id AND I.Id=A.Id");
                // datosArticulo.setearConsulta("SELECT A.Id,Codigo,Nombre,A.Descripcion,A.Descripcion, A.IdMarca , A.Precio,I.ImagenUrl FROM Articulos A, IMAGENES I WHERE A.Id = I.Id");
                datosArticulo.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl FROM Articulos A LEFT JOIN Categorias C ON A.IdCategoria = C.Id LEFT JOIN Marcas M ON A.IdMarca = M.Id LEFT JOIN IMAGENES I ON A.Id = I.Id");

                datosArticulo.ejecutarLectura();

                while (datosArticulo.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = datosArticulo.Lector.GetInt32(0);
                    aux.codigo = (string)datosArticulo.Lector["Codigo"];
                    aux.nombre = (string)datosArticulo.Lector["Nombre"];
                    aux.descripcion = (string)datosArticulo.Lector["Descripcion"];
                    //aux.marca = new Marca { id = int.Parse(textbox) };
                    //aux.categoria = new Categoria { descripcion = (string)datosArticulo.Lector["Categoria"] };
                    aux.marca = new Marca { descripcion = (string)datosArticulo.Lector["Marca"] };
                    string categoria = string.Empty;
                    if (!datosArticulo.Lector.IsDBNull(datosArticulo.Lector.GetOrdinal("Categoria")))
                    {
                        categoria = (string)datosArticulo.Lector["Categoria"];
                    }
                    else
                    {
                        // Si la categoría es NULL en la base de datos, asigna un valor predeterminado o un mensaje alternativo.
                        categoria = "Sin categoría";
                    }
                    aux.categoria = new Categoria { descripcion = categoria };
                    aux.precio = (float)datosArticulo.Lector.GetDecimal(6);
                    aux.imagenArticulo = new Imagenes { urlImagen = (string)datosArticulo.Lector["ImagenUrl"] };


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datosArticulo.CerrarConexion();
            }
        }


        /* public void agregar(Articulo aux)
         {
             AccesoDatos datos = new AccesoDatos();
             try
             {

                 datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (" + aux.codigo + ", '" + aux.nombre + "', '" + aux.descripcion + "', " + aux.marca.id + ", " + aux.categoria.id + ", " + aux.precio + ")");
                 datos.ejecutarAccion();
             }        
             catch (Exception ex)
             {

                 throw ex;
             }
             finally
             {
                 datos.CerrarConexion();
             }
         }
       
        public void agregar(Articulo aux, string urlImagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Paso 1: Insertar el artículo en la tabla ARTICULOS
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('" + aux.codigo + "', '" + aux.nombre + "', '" + aux.descripcion + "', " + aux.marca.id + ", " + aux.categoria.id + ", " + aux.precio + ")");
                datos.ejecutarAccion();
                datos.CerrarConexion();

                // Paso 2: Obtener el ID autonumérico del artículo recién insertado
                datos.setearConsulta("SELECT SCOPE_IDENTITY()");
                datos.ejecutarLectura();
                int idArticulo = 0;
                if (datos.Lector.Read())
                {
                    idArticulo = datos.Lector.IsDBNull(0) ? 0 : Convert.ToInt32(datos.Lector[0]);
                }
                datos.Lector.Close();
                datos.CerrarConexion();

                // Paso 3: Insertar la URL de la imagen junto con el ID del artículo en la tabla IMAGENES
                datos.setearConsulta("INSERT INTO IMAGENES (Id, ImagenUrl) VALUES (" + idArticulo + ", '" + urlImagen + "')");
                datos.ejecutarAccion();
                datos.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
         */
        public void agregar(Articulo aux, string urlImagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Paso 1: Insertar el artículo en la tabla ARTICULOS
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('" + aux.codigo + "', '" + aux.nombre + "', '" + aux.descripcion + "', " + aux.marca.id + ", " + aux.categoria.id + ", " + aux.precio + ")");
                datos.ejecutarAccion();
                datos.CerrarConexion();

                /* Paso 2: Obtener el ID autonumérico del artículo recién insertado
                datos.setearConsulta("SELECT SCOPE_IDENTITY()");
                datos.ejecutarLectura();
                int idArticulo = 0;
                if (datos.Lector.Read())
                {
                    idArticulo = Convert.ToInt32(datos.Lector[0]);
                }
                datos.Lector.Close();
                datos.CerrarConexion();
                */

                // Paso 3: Insertar la URL de la imagen junto con el ID del artículo en la tabla IMAGENES
                datos.setearConsulta("INSERT INTO IMAGENES (ImagenUrl, IdArticulo) VALUES ('" + urlImagen + "', " + 3 + ")");
                datos.ejecutarAccion();
                datos.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

    }
}      