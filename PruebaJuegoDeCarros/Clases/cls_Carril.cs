using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaJuegoDeCarros.Clases
{
    class cls_Carril
    {
        private int numero;
        private int id;
        private int id_usuario;
        private int id_pista;

        public cls_Carril(int numero, int id, int id_usuario, int id_pista)
        {
            this.numero = numero;
            this.id = id;
            this.id_usuario = id_usuario;
            this.id_pista = id_pista;
        }

        public int Numero { get => numero; set => numero = value; }
        public int Id { get => id; set => id = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_pista { get => id_pista; set => id_pista = value; }
    }
}
