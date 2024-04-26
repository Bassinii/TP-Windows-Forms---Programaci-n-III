using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasesdeDominio;

namespace Negocio
{
    public class NegocioArticulo
    {
        //private string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog = CATALOGO_P3_DB; Integrated Security = True";
        //   public NegocioArticulo()
        // public string GetRuta() { return ruta; }
        public List<Articulo> listar()
        {   //DECLARO LOS OBJETOS NECESARIOS PARA LA CONEXION
            /*SList<Articulo> lista = new List<Articulo>();
            qlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
           
                 conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.ID, A.Codigo, A.Nombre, A.Descripcion, A.Precio, I.ImagenUrl FROM ARTICULOS A, IMAGENES I Where A.ID = I.ID ";

                
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = lector.GetInt32(0);
                    aux.codigo = (string)lector["Codigo"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.precio = (float)lector.GetDecimal(4);
                    aux.imagenArticulo = new Imagenes { urlImagen = (string)lector["ImagenUrl"] };

                    
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }*/

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datosArticulo = new AccesoDatos();
            try
            {
                datosArticulo.setearConsulta("SELECT A.Id,Codigo,Nombre,A.Descripcion, M.Descripcion Marca,C.Descripcion Categoria,Precio,I.ImagenUrl FROM Articulos A, Categorias C, Marcas M, IMAGENES I WHERE A.Id = C.Id AND M.Id = A.Id AND I.Id=A.Id");
                datosArticulo.ejecutarLectura();

                while (datosArticulo.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = datosArticulo.Lector.GetInt32(0);
                    aux.codigo = (string)datosArticulo.Lector["Codigo"];
                    aux.nombre = (string)datosArticulo.Lector["Nombre"];
                    aux.descripcion = (string)datosArticulo.Lector["Descripcion"];
                    aux.marca = new Marca { descripcion = (string)datosArticulo.Lector["Marca"] };
                    aux.categoria = new Categoria { descripcion = (string)datosArticulo.Lector["Categoria"] };
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


        public void agregar(Articulo aux)
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

    }
}      