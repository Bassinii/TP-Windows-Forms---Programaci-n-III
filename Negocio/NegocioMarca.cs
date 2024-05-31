using ClasesDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class NegocioMarca
    {
        public List<Marca> listar()
        {

            List<Marca> lista = new List<Marca>();
            AccesoDatos datosArticulo = new AccesoDatos();
            try
            {
                datosArticulo.setearConsulta("SELECT Id, Descripcion FROM MARCAS");

                datosArticulo.ejecutarLectura();

                while (datosArticulo.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.id = datosArticulo.Lector.GetInt32(0);
                    aux.descripcion = (string)datosArticulo.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                datosArticulo.CerrarConexion();
            }
        }
        public void  AgregarMarca(Marca obj)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta($"INSERT INTO MARCAS (Descripcion) VALUES ('{obj.descripcion}')");
                datos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ModificarMarca(Marca obj)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta($"UPDATE MARCAS SET Descripcion = '{obj.descripcion}' WHERE Id = '{obj.id}' ");
                datos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta($"delete from MARCAS where id= @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
