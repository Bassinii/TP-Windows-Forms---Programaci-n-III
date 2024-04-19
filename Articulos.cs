using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWindowsFormsProgramacionIII
{
    internal class Articulos
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marcas marca { get; set; }
        public Categorias categoria { get; set; }
        List <string> listImagenes = new List<string>();

        public Articulos() {;}

    }
}
