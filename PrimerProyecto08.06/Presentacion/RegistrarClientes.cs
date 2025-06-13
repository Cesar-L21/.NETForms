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
    public partial class RegistrarClientes : Form
    {
        private LogicaCliente cliente;
        public RegistrarClientes(LogicaCliente Clientes)
        {
            cliente = Clientes;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que el ID sea un número
            if (!int.TryParse(textBox1.Text.Trim(), out int idCliente))
            {
                MessageBox.Show("El ID debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el ID no esté repetido
            var clienteExistente = cliente.BuscarPorId(idCliente);
            if (clienteExistente != null)
            {
                MessageBox.Show("Ya existe un cliente con este ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recuperar y validar nombre
            string nombre = textBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recuperar apellidos
            string primerApellido = textBox4.Text.Trim();
            string segundoApellido = textBox5.Text.Trim();

            // Recuperar la fecha de nacimiento sin validación
            DateTime fechaNacimiento = dateTimePicker1.Value;

            // Recuperar estado activo
            bool activo = checkBox1.Checked;

            // Crear el objeto cliente
            var nuevoCliente = new Cliente
            {
                Identificacion = idCliente,
                Nombre = nombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                FechaNacimiento = fechaNacimiento,
                Activo = activo
            };

            // Registrar el cliente
            bool resultado = cliente.Agregar(nuevoCliente);

            if (resultado)
            {
                MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Error al registrar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
