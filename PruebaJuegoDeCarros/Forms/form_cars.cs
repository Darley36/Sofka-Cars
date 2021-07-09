using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaJuegoDeCarros.Clases;
using PruebaJuegoDeCarros.Datos;

namespace PruebaJuegoDeCarros.Forms
{
    public partial class form_cars : Form
    {
        List<cls_Pista> pista;
        List<string> jugador;
        public form_cars()
        {
            InitializeComponent();
        }
        public void datosI(List<cls_Pista> Pistas, List<string> jugadores)
        {
            pista = Pistas;
            jugador = jugadores;
            foreach (string element in jugadores)
            {
                this.cmb_jugador.Items.Add(element);
            }
        }

    }
}
