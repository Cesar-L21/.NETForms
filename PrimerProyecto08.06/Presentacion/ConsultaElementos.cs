using PrimerProyecto08._06.Logica;
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
    public partial class ConsultaElementos : Form
    {
        private VistaEntregasSA EntregasSA;
        public ConsultaElementos(VistaEntregasSA vista)
        {
            EntregasSA = vista;
            InitializeComponent();
        }

        private void ConsultaElementos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vistaConsultaTipos = new PrimerProyecto08._06.Presentacion.ConsultarTipos(EntregasSA.logicaTipoArticulo);

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaConsultaTipos.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaConsultaTipos.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var vistaConsultaArticulos = new PrimerProyecto08._06.Presentacion.CosultarArticulos(EntregasSA.logicaArticulo);

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaConsultaArticulos.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaConsultaArticulos.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var vistaConsultaClientes = new PrimerProyecto08._06.Presentacion.ConsultaClientes(EntregasSA.logicaCliente);

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaConsultaClientes.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaConsultaClientes.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var vistaConsultaRepartidores = new PrimerProyecto08._06.Presentacion.ConsultarRepartidores();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaConsultaRepartidores.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaConsultaRepartidores.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var vistaConsultaPedidos = new PrimerProyecto08._06.Presentacion.ConsultaPedidos();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaConsultaPedidos.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaConsultaPedidos.Show();

            // Ocultar Form1
            this.Hide();
        }
    }
}
