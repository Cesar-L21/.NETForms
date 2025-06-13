using PrimerProyecto08._06.Logica;
using PrimerProyecto08._06.LogicaDeNegocio;
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
    public partial class VistaEntregasSA : Form
    {
        private LogicaTipoArticulo TipoArticulo;
        private LogicaPedido Pedido;
        private LogicaCliente cliente;
        private LogicaRepartidor repartido;
        private LogicaArticulo articulo;

        public VistaEntregasSA()
        {
            InitializeComponent();
            TipoArticulo = new LogicaTipoArticulo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var MenuRegistro = new PrimerProyecto08._06.Presentacion.RegistrarMenu();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            MenuRegistro.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            MenuRegistro.Show();

            // Ocultar Form1
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var ConsultaElementos = new PrimerProyecto08._06.Presentacion.ConsultaElementos();

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            ConsultaElementos.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            ConsultaElementos.Show();

            // Ocultar Form1
            this.Hide();
        }
    }
}
