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

        public List<cls_Carro> consultaCarros()
        {
            List<cls_Carro> lista = new List<cls_Carro>();
            con.Open();
            string Query = "SELECT Marca, ID FROM CARRO";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cls_Carro carro = new cls_Carro(dr.GetString(0),"", dr.GetInt32(1));
                    lista.Add(carro);
                }
            }
            con.Close();
            return lista;
        }

        public int buscarUsername(string name)
        {
            int count;
            con.Open();
            string Query = "SELECT COUNT(*) FROM JUGADOR where NombreUsuario = '" + name + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public int insertarUser(cls_Jugador cj)
        {
            string Query = "INSERT INTO JUGADOR (NombreUsuario,Edad,NumVictorias,Id_carro) VALUES"+
                "(@nombre, @edad, @numVictoria, @id_carro)";
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@nombre", cj.NombreUsuario);
            cmd.Parameters.AddWithValue("@edad", cj.Edad);
            cmd.Parameters.AddWithValue("@numVictoria", cj.NumeroVictorias);
            cmd.Parameters.AddWithValue("@id_carro", cj.Id_Carro);
            int cont = cmd.ExecuteNonQuery();
            con.Close();
            return cont;
        }

        public List<cls_Pista> consultaPista()
        {
            List<cls_Pista> lista = new List<cls_Pista>();
            con.Open();
            string Query = "SELECT Nombre, ID, Km FROM PISTA";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cls_Pista pista = new cls_Pista(dr.GetString(0), dr.GetInt32(1), dr.GetDouble(2), "");
                    lista.Add(pista);
                }
            }
            con.Close();
            return lista;
        }
    }
}
