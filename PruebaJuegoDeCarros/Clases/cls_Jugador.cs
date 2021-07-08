using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaJuegoDeCarros.Clases
{
    class cls_Jugador
    {
        private string nombreUsuario;
        private int id;
        private int edad;
        private int numeroVictorias;
        private int id_Carro;

        public cls_Jugador(){}

        public cls_Jugador(string nombreUsuario, int id, int edad, int numeroVictorias, int id_Carro)
        {
            this.nombreUsuario = nombreUsuario;
            this.id = id;
            this.edad = edad;
            this.numeroVictorias = numeroVictorias;
            this.id_Carro = id_Carro;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int Id { get => id; set => id = value; }
        public int Edad { get => edad; set => edad = value; }
        public int NumeroVictorias { get => numeroVictorias; set => numeroVictorias = value; }
        public int Id_Carro { get => id_Carro; set => id_Carro = value; }
    }
}
