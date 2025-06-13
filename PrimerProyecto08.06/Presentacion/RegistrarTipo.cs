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
    public partial class RegistrarTipo : Form
    {
        private LogicaTipoArticulo logica;
        public RegistrarTipo(LogicaTipoArticulo logicaTipo)
        {
            logica = logicaTipo;
            InitializeComponent();
        }


        private void RegistrarTipo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Recuperamos los datos del formulario
            int tipoId;
            string tipoNombre = textBox2.Text;  // Nombre del tipo de artículo
            string descripcion = richTextBox1.Text;  // Descripción del tipo de artículo

            // Validar que el ID sea un número entero
            if (!int.TryParse(textBox1.Text, out tipoId))  // 'textBox1' es para el ID
            {
                MessageBox.Show("Por favor ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Si el ID no es válido, no continuamos
            }

            // Crear el objeto TipoArticulo con los datos ingresados
            var nuevoTipoArticulo = new TipoArticulo
            {
                Id = tipoId,
                Nombre = tipoNombre,
                Descripcion = descripcion  // Asumí que tienes una propiedad de Descripción en la clase TipoArticulo
            };

            // Llamar al método Agregar de LogicaTipoArticulo para agregar el nuevo tipo
            bool resultado = logica.Agregar(nuevoTipoArticulo);

            // Mostrar mensaje dependiendo de si la operación fue exitosa o no
            if (resultado)
            {
                MessageBox.Show("Tipo de artículo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  // Cerrar el formulario una vez registrado correctamente
            }
            else
            {
                MessageBox.Show("El tipo de artículo con este ID ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
