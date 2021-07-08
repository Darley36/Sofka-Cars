using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaJuegoDeCarros.Datos;

namespace PruebaJuegoDeCarros.Clases
{
    class cls_Carro
    {
        private string marca;
        private string color;
        private int id;

        public cls_Carro() { }
        public cls_Carro(string marca, string color, int id)
        {
            this.marca = marca;
            this.color = color;
            this.id = id;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public int Id { get => id; set => id = value; }

        public List<string> llamarCarros()
        {
            DB db = new DB();
            List<string> lista = db.consultaCarros();
            return lista;
        }
    }
}
