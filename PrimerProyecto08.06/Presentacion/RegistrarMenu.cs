using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto08._06.Presentacion
{
    public partial class RegistrarMenu : Form
    {
        VistaEntregasSA VistaEntregas;
        public RegistrarMenu(VistaEntregasSA vistaEntregasSA)
        {
            VistaEntregas = vistaEntregasSA;
            InitializeComponent();
        }

        private void RegistrarMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var vistaTipos = new PrimerProyecto08._06.Presentacion.RegistrarTipo(VistaEntregas.logicaTipoArticulo);

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaTipos.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaTipos.Show();

            // Ocultar Form1
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var vistaArticulos = new PrimerProyecto08._06.Presentacion.RegistrarArticulo();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaArticulos.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaArticulos.Show();

            // Ocultar Form1
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var vistaClientes = new PrimerProyecto08._06.Presentacion.RegistrarClientes();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaClientes.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaClientes.Show();

            // Ocultar Form1
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var vistaRepartidores = new PrimerProyecto08._06.Presentacion.RegistrarRepartidores();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaRepartidores.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaRepartidores.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var vistaPedidos = new PrimerProyecto08._06.Presentacion.RegistroPedidos();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaPedidos.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaPedidos.Show();

            // Ocultar Form1
            this.Hide();

        }
    }
}
