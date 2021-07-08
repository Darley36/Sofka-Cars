using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaJuegoDeCarros.Forms;
using PruebaJuegoDeCarros.Clases;
using PruebaJuegoDeCarros.Datos;

namespace PruebaJuegoDeCarros.Forms
{
    public partial class form_juego : Form
    {
        DB db = new DB();
        List<string> jugadores = new List<string>();
        public form_juego()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_empezar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_cars fc = new form_cars();
            fc.Show();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            cls_Jugador jugador = new cls_Jugador();
            if (String.IsNullOrEmpty(txt_jugador.Text))
            {
                MessageBox.Show("Digite el Jugador(Nombre de usuario)");
            }
            else
            {
                jugador.NombreUsuario = txt_jugador.Text.Trim();
                if (jugador.buscaruser(jugador.NombreUsuario) == 1)
                {
                    int cont = 0;
                    if (jugadores != null)
                    {
                        foreach (string element in jugadores)
                        {
                            if (jugador.NombreUsuario == element)
                            {
                                cont += 1;
                            }
                        }
                        if (cont > 0)
                        {
                            txt_jugador.Clear();
                            MessageBox.Show("El jugador ya ha sido ingresado");
                        }
                        else
                        {
                            jugadores.Add(jugador.NombreUsuario);
                            txt_jugador.Clear();
                            this.lb_jugadores.Items.Add(jugador.NombreUsuario);
                            MessageBox.Show("Jugador ingresado correctamente");
                        }
                    }
                    else
                    {
                        jugadores.Add("SZS");
                        txt_jugador.Clear();
                        this.lb_jugadores.Items.Add(jugador.NombreUsuario);
                        MessageBox.Show("Jugador ingresado correctamente");
                    }                                                    
                }
                else
                {
                    txt_jugador.Clear();
                    MessageBox.Show("El jugador no existe");
                }
            }
        }

        private void form_juego_Load(object sender, EventArgs e)
        {
            if(jugadores != null)
            {
                foreach (string element in jugadores)
                {
                    this.lb_jugadores.Items.Add(element);
                }
            }          
        }
    }
}
