using PrimerProyecto08._06.Entidades;
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
    public partial class ConsultaClientes : Form
    {
        private LogicaCliente Cliente;
        public ConsultaClientes(LogicaCliente cliente)
        {
            Cliente = cliente;
            InitializeComponent();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            // Obtener los clientes desde la lógica
            var clientes = Cliente.ObtenerTodos();

            // Crear un DataTable para almacenar los clientes
            DataTable dtClientes = new DataTable();

            // Agregar columnas al DataTable
            dtClientes.Columns.Add("ID", typeof(int));
            dtClientes.Columns.Add("Nombre", typeof(string));
            dtClientes.Columns.Add("Primer Apellido", typeof(string));
            dtClientes.Columns.Add("Segundo Apellido", typeof(string));
            dtClientes.Columns.Add("Fecha Nacimiento", typeof(string)); // lo dejamos como string para mostrarlo formateado
            dtClientes.Columns.Add("Activo", typeof(bool));

            // Llenar el DataTable con los clientes
            foreach (var cliente in clientes)
            {
                dtClientes.Rows.Add(
                    cliente.Identificacion,
                    cliente.Nombre,
                    cliente.PrimerApellido,
                    cliente.SegundoApellido,
                    cliente.FechaNacimiento.ToShortDateString(), // Formato corto de fecha
                    cliente.Activo
                );
            }

            // Asignar el DataTable al DataGridView
            dataGridView1.DataSource = dtClientes;

            // Opcional: mejorar visualmente el DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
