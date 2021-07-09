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
        List<cls_Pista> lpistas;
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
            fc.datosI(cmb_pista.Text, jugadores);
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
                            ///MessageBox.Show("Jugador ingresado correctamente");
                            if(lb_jugadores.Items.Count == 2)
                            {
                                btn_empezar.Enabled = true;
                            }                           
                        }
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

            llenarPistas();
        }

        void llenarPistas()
        {
            cls_Pista pista = new cls_Pista();
            lpistas = pista.llamarPista();
            foreach (cls_Pista element in lpistas)
            {
                this.cmb_pista.Items.Add(element.Nombre);
            }

            cmb_pista.SelectedIndex = 0;
            buscarKM(cmb_pista.Text);
        }

        void buscarKM(string km)
        {
            foreach (cls_Pista element in lpistas)
            {
                if(km == element.Nombre)
                {
                    txt_km.Text = element.Longitud.ToString();
                }
            }
        }

        private void cmb_pista_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarKM(cmb_pista.Text);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int cont = 1;
            cls_Pista pista = new cls_Pista();
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Digite el Nombre de ula pista");
            }
            else if (String.IsNullOrEmpty(txt_distancia.Text))
            {
                MessageBox.Show("Digite la distancia en kilometros");
            }
            else if (String.IsNullOrEmpty(txt_pais.Text))
            {
                MessageBox.Show("ingrese el pais");
            }
            else
            {
                pista.Nombre = txt_nombre.Text;
                pista.Longitud = Double.Parse(txt_distancia.Text);
                pista.Pais = txt_pais.Text;
                pista.Id = 0;

                foreach (cls_Pista element in lpistas)
                {
                    if (txt_nombre.Text == element.Nombre)
                    {
                        MessageBox.Show("El nombre de la pista ya ha sido utilizado");
                        cont = 0;
                    }
                }
                if (cont==1)
                {
                    int n = db.insertarPista(pista);
                    if (n > 0)
                    {
                        txt_nombre.Clear();
                        txt_distancia.Clear();
                        txt_pais.Clear();
                        cmb_pista.Items.Clear();
                        llenarPistas();
                        MessageBox.Show("Datos ingresados con exito");
                    }
                }
                else
                {
                    MessageBox.Show("La pista no fue ingresada");
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
