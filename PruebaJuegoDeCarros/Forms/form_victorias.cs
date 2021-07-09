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
    public partial class form_victorias : Form
    {
        cls_Juego cg = new cls_Juego();
        DB db = new DB();
        public form_victorias()
        {
            InitializeComponent();
        }

        private void form_victorias_Load(object sender, EventArgs e)
        {
            DGV_victorias.DataSource = db.consultaJuegos("");
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void DGV_victorias_Click(object sender, EventArgs e)
        {
            txt_name.Text = DGV_victorias.SelectedCells[1].Value.ToString();
            int num = db.consultaVictoria(DGV_victorias.SelectedCells[1].Value.ToString());
            txt_vic.Text = num.ToString();
        }
    }
}
