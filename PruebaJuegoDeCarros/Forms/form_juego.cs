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

namespace PruebaJuegoDeCarros.Forms
{
    public partial class form_juego : Form
    {
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
    }
}
