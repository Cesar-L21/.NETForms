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
    public partial class ConsultarTipos : Form
    {
        private LogicaTipoArticulo logicaTiArticulo;
        public ConsultarTipos(LogicaTipoArticulo logica)
        {
            logicaTiArticulo = logica;
            InitializeComponent();
        }

        private void ConsultarTipos_Load(object sender, EventArgs e)
        {
            // Recuperamos todos los tipos de artículo desde la lógica
            var tiposArticulo = logicaTiArticulo.ObtenerTodos();

            // Asignamos los tipos de artículo al DataGridView
            dataGridView1.DataSource = tiposArticulo;

            // Si deseas personalizar las columnas
            dataGridView1.Columns["Id"].HeaderText = "ID del Tipo";
            dataGridView1.Columns["Nombre"].HeaderText = "Nombre del Tipo";
            dataGridView1.Columns["Descripcion"].HeaderText = "Descripción";

            // Ajustar el tamaño de las columnas automáticamente
            dataGridView1.AutoResizeColumns();

        }
    }
}
