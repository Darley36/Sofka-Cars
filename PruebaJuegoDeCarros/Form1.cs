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

namespace PruebaJuegoDeCarros
{
    public partial class Form1 : Form
    {
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
            List<string> lista = carro.llamarCarros();
            foreach (string element in lista)
            {
                this.lb_carro.Items.Add(element);
            }
        }
    }
}
