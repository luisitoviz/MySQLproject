using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MySQLproject.CapaNegocio
{
    public class Librocs : ILibro
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);
        public bool actualizar(string codLibro, string titulo, string editorial, int anio)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(string codLibro, string titulo, string editorial, int anio)
        {
            throw new NotImplementedException();
        }

        public DataTable buscar(string texto, string criterio)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(string codLibro)
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            string consulta = "select * from TLibro";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}