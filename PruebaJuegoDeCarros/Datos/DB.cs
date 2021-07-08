using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PruebaJuegoDeCarros.Clases;

namespace PruebaJuegoDeCarros.Datos
{
    class DB
    {
        static string cadena = "server= localhost; database= JUEGOCARROS;" +
            "integrated security= true";

        SqlConnection con = new SqlConnection(cadena);

        public List<string> consultaCarros()
        {
            List<string> lista = new List<string>();
            con.Open();
            string Query = "SELECT Marca FROM CARRO";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }
            }
            con.Close();
            return lista;
        }

    }
}
