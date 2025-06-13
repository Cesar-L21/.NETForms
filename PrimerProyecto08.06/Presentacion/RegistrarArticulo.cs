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
    public partial class RegistrarArticulo : Form
    {
        private LogicaArticulo Articulos;
        private LogicaTipoArticulo Tipos;
        public RegistrarArticulo(LogicaArticulo articulos,LogicaTipoArticulo tipos)
        {
            Articulos = articulos;
            Tipos = tipos;
            InitializeComponent();
        }

        private void RegistrarArticulo_Load(object sender, EventArgs e)
        {
            
            var tiposArticulo = Tipos.ObtenerTodos();

            comboBox1.Items.Clear();

            foreach (var tipo in tiposArticulo)
            {
                comboBox1.Items.Add(tipo.Nombre);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int idArticulo))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var articuloExistente = Articulos.BuscarPorId(idArticulo);
            if (articuloExistente != null)
            {
                MessageBox.Show("Ya existe un artículo con este ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBox3.Text, out double monto) || monto <= 0)
            {
                MessageBox.Show("El monto debe ser un valor numérico mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tipoArticuloSeleccionado = Tipos.ObtenerTodos().FirstOrDefault(t => t.Nombre == comboBox1.SelectedItem.ToString());
            if (tipoArticuloSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Articulo nuevoArticulo = new Articulo
            {
                Id = idArticulo,
                Nombre = textBox2.Text,
                TipoArticulo = tipoArticuloSeleccionado,
                Valor = monto,
                Activo = checkBox1.Checked
            };

            bool resultado = Articulos.Agregar(nuevoArticulo);

            if (resultado)
            {
                MessageBox.Show("Artículo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Error al registrar el artículo. Inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }

