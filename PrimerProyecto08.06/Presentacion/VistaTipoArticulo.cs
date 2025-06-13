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
    public partial class VistaTipoArticulo : Form
    {
        private LogicaTipoArticulo _logicaTipoArticulo;
        public VistaTipoArticulo(LogicaTipoArticulo logica)
        {
            _logicaTipoArticulo = logica;
            InitializeComponent();
        }

        private void VistaTipoArticulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Registrar(object sender, EventArgs e)
        {
            // Step 1: Retrieve data from the form
            int id;
            string nombreTipoProducto = textBox2.Text.Trim();
            string descripcion = richTextBox1.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(nombreTipoProducto))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el tipo de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, ingrese una descripción para el tipo de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate ID (ensure it's a number and positive)
            if (!int.TryParse(textBox1.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Create the TipoArticulo object
            TipoArticulo tipo = new TipoArticulo
            {
                Id = id,
                Nombre = nombreTipoProducto,
                Descripcion = descripcion
            };

            // Step 3: Create an instance of LogicaTipoArticulo
            LogicaTipoArticulo logicaTipoArticulo = new LogicaTipoArticulo();

            // Step 4: Try to add the TipoArticulo
            if (logicaTipoArticulo.Agregar(tipo))
            {
                MessageBox.Show("Tipo de artículo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Clear the form fields after successful registration
            }
            else
            {
                MessageBox.Show("No se pudo registrar el tipo de artículo. Puede que ya exista un artículo con el mismo ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear the form fields after successful registration
        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
