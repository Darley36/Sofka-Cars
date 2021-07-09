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
        List<int> recorrido;
        List<int> excluido;
        int cont = 0;
        DB db = new DB();
        string namePista;
        public form_cars()
        {
            InitializeComponent();
        }
        public void datosI(string namepista, List<string> jugadores)
        {
            namePista = namepista;
            jugador = jugadores;
            llenardistancia(namepista);
            llenarjugadores();
            posicion = establecerPosicion(jugador.Count());
            recorrido = llenarR();
            excluido = new List<int>(3);
            MessageBox.Show(posicion[0].ToString() + posicion[1].ToString() + posicion[2].ToString());
            ubicar(0);
        }

        List<int> llenarR()
        {
            List<int> R = new List<int>();
            for (int i = 1; i <= jugador.Count; i++)
            {
                R.Add(0);
            }
            return R;
        }
        void llenardistancia(string namepista)
        {
            double km = db.consultakm(namepista);
            txt_km.Text = (km*1000).ToString();
        }

        void llenarjugadores()
        {
            foreach (string element in jugador)
            {
                this.cmb_jugador.Items.Add(element);
            }
        }

        List<int> establecerPosicion(int contador)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int from = 0;
            int to = contador;
            List<int> num = new List<int>();
            int randomValue = rnd.Next(from, to);
            num.Add(randomValue);
            for (int i = 1; i < contador; i++)
            {
                while (num.Contains(randomValue))
                {
                    randomValue = rnd.Next(from, to);
                }
                num.Add(randomValue);
            }
            return num;
        }

        void ubicar(int i)
        {
                txt_jugador.Text = jugador[posicion[i]];
            if (String.IsNullOrEmpty(recorrido[posicion[i]].ToString()))
            {
                txt_Dis.Text = "0";
            }
            else
            {
                txt_Dis.Text = recorrido[i].ToString();
                btn_dado.Enabled = true;
            }
                
        }

        //void recorridojugador(int posicion)
        //{
        //    recorrido[posicion] = 
        //}

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dado_Click(object sender, EventArgs e)
        {
            btn_dado.Enabled = false;
            if(cont < jugador.Count && !excluido.Contains(cont))
            {
                Random nume = new Random();
                txt_dado.Text = nume.Next(1, 7).ToString();
                recorrido[cont]= recorrido[cont] + calculaDistancia(Int32.Parse(txt_dado.Text));
                txt_Dis.Text = recorrido[cont].ToString();
                if (excluido.Count()==3)
                {
                    MessageBox.Show("ya casi");
                }
                if (saberDistancia(recorrido[cont]))
                {
                    if (excluido.Count() == 3)
                    {
                        MessageBox.Show("ya casi");
                    }

                    while (excluido.Contains(cont))
                    {
                        
                        if (cont < jugador.Count-1)
                        {
                            cont = cont + 1;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
                }
                else
                {
                    if (excluido.Contains(cont))
                    {
                        while (excluido.Contains(cont))
                        {
                            if (cont < jugador.Count - 1)
                            {
                                cont = cont + 1;
                            }
                            else
                            {
                                cont = 0;
                            }
                        }
                    }
                    else
                    {
                        cont = cont + 1;
                        if (cont == jugador.Count)
                        {
                            cont = 0;
                        }
                        if (excluido.Contains(cont))
                        {
                            while (excluido.Contains(cont))
                            {
                                if (cont < jugador.Count - 1)
                                {
                                    cont = cont + 1;
                                }
                                else
                                {
                                    cont = 0;
                                }
                            }
                        }
                    }
                }                
            }
            else
            {
                if (excluido.Contains(cont))
                {
                    while (excluido.Contains(cont))
                    {
                        if (cont < jugador.Count-1)
                        {
                            cont = cont + 1;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("VIDAAAA");
                    cont = cont + 1;
                    if (cont == jugador.Count)
                    {
                        cont = 0;
                    }
                }
            }
        }
        
        int calculaDistancia(int pos)
        {            
            return pos * 100;
        }

        bool saberDistancia(int rec)
        {
            if (rec >= Int32.Parse(txt_km.Text))
            {
                excluido.Add(cont);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cont.ToString());
            txt_dado.Clear();
            txt_Dis.Clear();
            ubicar(cont);
        }

        void actualizarVictoria()
        {
            cls_Jugador cj = new cls_Jugador();
            cj.NombreUsuario = jugador[posicion[excluido[0]]];
            int contUp = db.actualizarVictorias(cj);
            cls_Juego cg = new cls_Juego(0, namePista, jugador[posicion[excluido[0]]],
                jugador[posicion[excluido[1]]], jugador[posicion[excluido[2]]]);

        }
    }
}
