using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MySQLproject.CapaNegocio
{
    interface ILibro
    {
        DataTable Listar();

        bool Agregar(String codLibro, string titulo, string editorial, int anio);

        bool eliminar(string codLibro);

        bool actualizar(string codLibro, string titulo, string editorial, int anio);

        DataTable buscar(string texto, string criterio);
    }
}
