using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaJuegoDeCarros.Clases
{
    class cls_Juego
    {
        private int numero;
        private string nombreJuego;
        private string primerPuesto;
        private string segundoPuesto;
        private string tercerPuesto;

        public cls_Juego(int numero, string nombreJuego, string primerPuesto, string segundoPuesto, string tercerPuesto)
        {
            this.numero = numero;
            this.nombreJuego = nombreJuego;
            this.primerPuesto = primerPuesto;
            this.segundoPuesto = segundoPuesto;
            this.tercerPuesto = tercerPuesto;
        }

        public int Numero { get => numero; set => numero = value; }
        public string NombreJuego { get => nombreJuego; set => nombreJuego = value; }
        public string PrimerPuesto { get => primerPuesto; set => primerPuesto = value; }
        public string SegundoPuesto { get => segundoPuesto; set => segundoPuesto = value; }
        public string TercerPuesto { get => tercerPuesto; set => tercerPuesto = value; }
    }
}
