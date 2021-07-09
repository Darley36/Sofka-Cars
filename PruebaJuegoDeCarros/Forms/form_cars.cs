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
        List<int> posicion;
        List<double> recorrido;
        DB db = new DB();
        public form_cars()
        {
            InitializeComponent();
        }
        public void datosI(string namepista, List<string> jugadores)
        {
            jugador = jugadores;
            llenardistancia(namepista);
            llenarjugadores();
            posicion = establecerPosicion(jugador.Count());
            recorrido = new List<double>(jugador.Count());

            //foreach (string element in jugadores)
            //{
            //    this.cmb_jugador.Items.Add(element);
            //}
        }

        void llenardistancia(string namepista)
        {
            double km = db.consultakm(namepista);
            txt_km.Text = km.ToString() + "KM";
        }

        void llenarjugadores()
        {
            foreach (string element in jugador)
            {
                this.cmb_jugador.Items.Add(element);
            }
        }

        List<int> establecerPosicion(int cont)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int from = 1;
            int to = cont + 1;
            List<int> num = new List<int>();
            int randomValue = rnd.Next(from, to);
            num.Add(randomValue);
            for (int i = 1; i < cont; i++)
            {
                while (num.Contains(randomValue))
                {
                    randomValue = rnd.Next(from, to);
                }
                num.Add(randomValue);
            }
            return num;
        }

        void ubicar()
        {
            for (int i = 0; i < jugador.Count(); i++)
            {
                txt_jugador.Text = jugador[posicion[i]];
                btn_dado.Enabled = true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dado_Click(object sender, EventArgs e)
        {
            Random nume = new Random();
            txt_dado.Text = nume.Next(1, 7).ToString();
        }
    }
}
