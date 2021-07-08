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

namespace PruebaJuegoDeCarros
{
    public partial class Form1 : Form
    {
        List<cls_Carro> lista;
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mostrarVictorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_victorias fv = new form_victorias();
            fv.Show();
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_juego fj = new form_juego();
            fj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cls_Carro carro = new cls_Carro();
            lista = carro.llamarCarros();
            foreach (cls_Carro element in lista)
            {
                this.lb_carro.Items.Add(element.Marca);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_Jugador jugador = new cls_Jugador();
            if (String.IsNullOrEmpty(txt_nickname.Text))
            {
                MessageBox.Show("Digite el Nombre de usuario");
            }
            else if (String.IsNullOrEmpty(txt_edad.Text))
            {
                MessageBox.Show("Digite la edad");
            }
            else if (String.IsNullOrEmpty(lb_carro.Text))
            {
                MessageBox.Show("Seleccione el carro");
            }
            else
            {

                jugador.NombreUsuario = txt_nickname.Text.Trim();
                jugador.Edad = Int32.Parse(txt_edad.Text.Trim());
                jugador.NumeroVictorias = 0;
                jugador.Id_Carro = 0;

                foreach (cls_Carro element in lista)
                {
                    if(lb_carro.Text == element.Marca)
                    {
                        jugador.Id_Carro = element.Id;
                    }
                }
                if (jugador.buscaruser(jugador.NombreUsuario) == 0)
                {
                    int n=db.insertarUser(jugador);
                    if(n > 0)
                    {
                        txt_nickname.Clear();
                        txt_edad.Clear();
                        lb_carro.ClearSelected();
                        MessageBox.Show("Datos ingresados con exito");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de ususario ya existe");
                }
            }

        }
    }
}
