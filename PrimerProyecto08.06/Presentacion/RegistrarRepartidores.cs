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
    public partial class RegistrarRepartidores : Form
    {
        private LogicaRepartidor logicaRepartidor;
        public RegistrarRepartidores(LogicaRepartidor repartidor)
        {
            logicaRepartidor = repartidor;
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void RegistrarRepartidores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que el ID sea numérico
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el ID no esté repetido
            if (logicaRepartidor.BuscarPorId(id) != null)
            {
                MessageBox.Show("Ya existe un repartidor con este ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar mayoría de edad
            DateTime fechaNacimiento = dateTimePicker1.Value;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Today.AddYears(-edad)) edad--;

            if (edad < 18)
            {
                MessageBox.Show("El repartidor debe ser mayor de edad (mínimo 18 años).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la fecha de contratación no sea futura
            DateTime fechaContratacion = dateTimePicker2.Value;
            if (fechaContratacion > DateTime.Today)
            {
                MessageBox.Show("La fecha de contratación no puede ser posterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el objeto Repartidor
            var nuevoRepartidor = new PrimerProyecto08._06.Entidades.Repartidor
            {
                Identificacion = id,
                Nombre = textBox2.Text.Trim(),
                PrimerApellido = textBox4.Text.Trim(),
                SegundoApellido = textBox5.Text.Trim(),
                FechaNacimiento = fechaNacimiento,
                FechaContratacion = fechaContratacion,
                Activo = checkBox1.Checked
            };

            // Intentar registrar
            bool registrado = logicaRepartidor.Agregar(nuevoRepartidor);

            if (registrado)
            {
                MessageBox.Show("Repartidor registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Ocurrió un error al registrar el repartidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
