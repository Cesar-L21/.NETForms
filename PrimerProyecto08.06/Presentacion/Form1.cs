using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto08._06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var vistaTipoArticulo = new PrimerProyecto08._06.Presentacion.VistaTipoArticulo();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaTipoArticulo.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaTipoArticulo.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
