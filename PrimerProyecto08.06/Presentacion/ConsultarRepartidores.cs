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
    public partial class ConsultarRepartidores : Form
    {
        private LogicaRepartidor repartidor1;
        public ConsultarRepartidores(LogicaRepartidor repartidor)
        {
            repartidor1 = repartidor;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la lista de repartidores
            var repartidores = repartidor1.ObtenerTodos();

            // Crear un DataTable para mostrar los datos
            DataTable dtRepartidores = new DataTable();

            // Agregar columnas
            dtRepartidores.Columns.Add("ID", typeof(int));
            dtRepartidores.Columns.Add("Nombre", typeof(string));
            dtRepartidores.Columns.Add("Primer Apellido", typeof(string));
            dtRepartidores.Columns.Add("Segundo Apellido", typeof(string));
            dtRepartidores.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            dtRepartidores.Columns.Add("Fecha Contratación", typeof(DateTime));
            dtRepartidores.Columns.Add("Activo", typeof(bool));

            // Llenar el DataTable con los datos de repartidores
            foreach (var r in repartidores)
            {
                dtRepartidores.Rows.Add(
                    r.Identificacion,
                    r.Nombre,
                    r.PrimerApellido,
                    r.SegundoApellido,
                    r.FechaNacimiento,
                    r.FechaContratacion,
                    r.Activo
                );
            }

            // Asignar al DataGridView
            dataGridView1.DataSource = dtRepartidores;
        }

        private void ConsultarRepartidores_Load(object sender, EventArgs e)
        {
            // Obtener la lista de repartidores
            var repartidores = repartidor1.ObtenerTodos();

            // Crear un DataTable para mostrar los datos
            DataTable dtRepartidores = new DataTable();

            // Agregar columnas
            dtRepartidores.Columns.Add("ID", typeof(int));
            dtRepartidores.Columns.Add("Nombre", typeof(string));
            dtRepartidores.Columns.Add("Primer Apellido", typeof(string));
            dtRepartidores.Columns.Add("Segundo Apellido", typeof(string));
            dtRepartidores.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            dtRepartidores.Columns.Add("Fecha Contratación", typeof(DateTime));
            dtRepartidores.Columns.Add("Activo", typeof(bool));

            // Llenar el DataTable con los datos de repartidores
            foreach (var r in repartidores)
            {
                dtRepartidores.Rows.Add(
                    r.Identificacion,
                    r.Nombre,
                    r.PrimerApellido,
                    r.SegundoApellido,
                    r.FechaNacimiento,
                    r.FechaContratacion,
                    r.Activo
                );
            }

            // Asignar al DataGridView
            dataGridView1.DataSource = dtRepartidores;

        }
    }
}
