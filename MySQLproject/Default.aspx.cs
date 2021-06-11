using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MySQLproject
{
    public partial class Default : System.Web.UI.Page
    {
        //cadena de conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);
        private void Listar()
        {
            string consulta = "select * from tautor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgv.DataSource = tabla;
            dgv.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}