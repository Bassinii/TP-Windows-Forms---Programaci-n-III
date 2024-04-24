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
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try //LOS CONFIGURO IdMarca, IdCategoria,
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT ID, Codigo, Nombre, Descripcion, Precio FROM ARTICULOS";
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
                    //aux.marca = lector.GetInt32(3);
                    //aux.categoria = lector["Idcategoria"];
                    aux.precio = (float)lector.GetDecimal(4);
                    
                    lista.Add(aux);

                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}
