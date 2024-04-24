using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TPWindowsFormsProgramacionIII
{
    public class AccesoDatos
    {
        private string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog = CATALOGO_P3_DB; Integrated Security = True";
        
        public AccesoDatos()
        {
        }

        public string GetRuta() { return ruta; }

    }
}
