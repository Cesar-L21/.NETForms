// Universidad: UNED
// Cuatrimestre: II Cuatrimestre 2025
// Descripción: Clase para artículos
// Nombre del estudiante: Esteban
// Fecha: 09/06/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto08._06.Datos
{
    public class Articulo
    {
            // Identificador único del artículo
            public int Id { get; set; }

            // Nombre del artículo
            public string Nombre { get; set; }

            // Objeto de tipo de artículo (se seleccionará mediante ComboBox)
            public TipoArticulo TipoArticulo { get; set; }

            // Valor del artículo (solo valores numéricos)
            public double Valor { get; set; }

            // Cantidad disponible en inventario
            public int Inventario { get; set; }

            // Estado del artículo (activo o inactivo)
            public bool Activo { get; set; }

            // Constructor vacío
            public Articulo() { }

            // Constructor con parámetros
            public Articulo(int id, string nombre, TipoArticulo tipoArticulo, double valor, int inventario, bool activo)
            {
                Id = id;
                Nombre = nombre;
                TipoArticulo = tipoArticulo;
                Valor = valor;
                Inventario = inventario;
                Activo = activo;
            }
    }

}

