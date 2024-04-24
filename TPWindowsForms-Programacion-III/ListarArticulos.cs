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

namespace TPWindowsFormsProgramacionIII
{
    public partial class ListarArticulos : Form
    {
        public ListarArticulos()
        {
            InitializeComponent();
            CargarGrilla("select * from ARTICULOS");
        }
        public void CargarGrilla(string consulta)
        {
            AccesoDatos miaccesoDatos= new AccesoDatos();
            SqlConnection Cn = new SqlConnection(miaccesoDatos.GetRuta());
            SqlCommand cmd = new SqlCommand(consulta,Cn);
            Cn.Open();
            SqlDataReader dataReader= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            gdvListadoDeArticulos.DataSource = dt;
            Cn.Close();
        }
    }

}
