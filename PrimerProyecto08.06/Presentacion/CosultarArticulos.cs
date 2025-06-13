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
    public partial class CosultarArticulos : Form
    {
        private LogicaArticulo Articulo;
        public CosultarArticulos(LogicaArticulo Articulos)
        {
            Articulo = Articulos;
            InitializeComponent();
        }

        private void CosultarArticulos_Load(object sender, EventArgs e)
        {
            // Obtener todos los artículos
            var articulos = Articulo.ObtenerTodos();

            // Crear un DataTable para almacenar los artículos
            DataTable dtArticulos = new DataTable();

            // Agregar columnas al DataTable
            dtArticulos.Columns.Add("ID", typeof(int));
            dtArticulos.Columns.Add("Nombre", typeof(string));
            dtArticulos.Columns.Add("Tipo", typeof(string));
            dtArticulos.Columns.Add("Monto", typeof(decimal));
            dtArticulos.Columns.Add("Activo", typeof(bool));

            // Llenar el DataTable con los artículos
            foreach (var articulo in articulos)
            {
                dtArticulos.Rows.Add(articulo.Id, articulo.Nombre, articulo.TipoArticulo.Nombre, articulo.Valor, articulo.Activo);
            }

            // Asignar el DataTable al DataGridView
            dataGridView1.DataSource = dtArticulos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
