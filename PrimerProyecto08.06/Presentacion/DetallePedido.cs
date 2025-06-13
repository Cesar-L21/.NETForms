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
    public partial class DetallePedido : Form
    {
        LogicaArticulo Articulos { get; set; }
        public DetallePedido(LogicaArticulo articulo)
        {
            Articulos = articulo;
            InitializeComponent();
        }

        private void DetallePedido_Load(object sender, EventArgs e)
        {
            CargarClientesYArticulos();
        }

        private void CargarClientesYArticulos()
        {
            // Cargar clientes
            var clientes = Articulos.ObtenerTodos();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Inventario";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
