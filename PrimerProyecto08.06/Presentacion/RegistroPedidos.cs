using PrimerProyecto08._06.Entidades;
using PrimerProyecto08._06.Logica;
using System;
using System.Windows.Forms;

namespace PrimerProyecto08._06.Presentacion
{
    public partial class RegistroPedidos : Form
    {
        LogicaArticulo Articulos;
        LogicaCliente LogicaCliente;
        LogicaRepartidor LogicaRepartidor;
        LogicaPedido logicaPedido;

        public RegistroPedidos(LogicaCliente clientes, LogicaRepartidor repartidores, LogicaArticulo articulos)
        {
            this.LogicaRepartidor = repartidores;
            this.LogicaCliente = clientes;
            this.Articulos = articulos;
            this.logicaPedido = new LogicaPedido(); 
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Validar que el número de pedido es entero
            if (!int.TryParse(txtNumeroPedido.Text, out int numeroPedido))
            {
                MessageBox.Show("Número de pedido inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que no exista ya ese número
            if (logicaPedido.BuscarPedidoPorId(numeroPedido) != null)
            {
                MessageBox.Show("Este número de pedido ya fue registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar la fecha
            DateTime fechaPedido = dtpFechaPedido.Value.Date;
            if (fechaPedido < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser menor al día actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar selección de cliente
            Cliente cliente = cmbClientes.SelectedItem as Cliente;
            if (cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar selección de repartidor
            Repartidor repartidor = cmbRepartidores.SelectedItem as Repartidor;
            if (repartidor == null)
            {
                MessageBox.Show("Debe seleccionar un repartidor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar dirección
            string direccion = txtDireccion.Text.Trim();
            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Debe ingresar la dirección de entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto Pedido
            Pedido nuevoPedido = new Pedido
            {
                Id = numeroPedido,
                Cliente = cliente,
                Repartidor = repartidor,
                FechaPedido = fechaPedido,
                Direccion = direccion
            };

            // Registrar con nueva implementación
            bool registrado = logicaPedido.RegistrarPedido(nuevoPedido, out string mensaje);

            MessageBox.Show(mensaje,
                registrado ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                registrado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

          
        }

        private void RegistroPedidos_Load(object sender, EventArgs e)
        {
            CargarClientesYRepartidores();
        }

        private void CargarClientesYRepartidores()
        {
            // Cargar clientes
            var clientes = LogicaCliente.ObtenerTodos();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nombre"; // Mostrar solo el nombre
            cmbClientes.ValueMember = "Identificacion";

            // Cargar repartidores
            var repartidores = LogicaRepartidor.ObtenerTodos();
            cmbRepartidores.DataSource = repartidores;
            cmbRepartidores.DisplayMember = "Nombre"; // Mostrar solo el nombre
            cmbRepartidores.ValueMember = "Identificacion";
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            var vistaDetalle = new PrimerProyecto08._06.Presentacion.DetallePedido(this.Articulos);

            // Cuando la ventana VistaTipoArticulo se cierre, mostrar Form1 de nuevo
            vistaDetalle.FormClosed += (s, args) => this.Show();

            // Mostrar VistaTipoArticulo
            vistaDetalle.Show();

            // Ocultar Form1
            this.Hide();
        }
    }
}
