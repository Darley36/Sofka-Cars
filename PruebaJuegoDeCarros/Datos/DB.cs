using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PruebaJuegoDeCarros.Datos
{
    class DB
    {
        static string cadena = "server= localhost; database= NAME;" +
            "integrated security= true";

        SqlConnection con = new SqlConnection(cadena);

    }
}
