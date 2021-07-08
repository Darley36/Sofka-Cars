using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaJuegoDeCarros.Datos;

namespace PruebaJuegoDeCarros.Clases
{
    class cls_Pista
    {
        private string nombre;
        private int id;
        private double longitud;
        private string pais;

        public cls_Pista() { }
        public cls_Pista(string nombre, int id, double longitud, string pais)
        {
            this.nombre = nombre;
            this.id = id;
            this.longitud = longitud;
            this.pais = pais;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public double Longitud { get => longitud; set => longitud = value; }
        public string Pais { get => pais; set => pais = value; }

        public List<cls_Pista> llamarPista()
        {
            DB db = new DB();
            List<cls_Pista> lista = db.consultaPista();
            return lista;
        }
    }
}
