using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeDominio
{
    public class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca marca { get; set; } = new Marca();    //CHAT GPT ME RECOMENDO ESTO
        public Categoria categoria { get; set; } = new Categoria();     //CHAT GPT ME RECOMENDO ESTO, INVOCAR AL CONSTRUCTOR

        //List<Imagenes> listImagenes = new List<Imagenes>();
        public Imagenes imagenArticulo;
        public float precio { get; set; }

        public Articulo() {;}

    }
}
