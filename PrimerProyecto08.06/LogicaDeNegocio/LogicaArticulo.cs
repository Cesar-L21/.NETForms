using System;

// Universidad: UNED
// Cuatrimestre: II Cuatrimestre 2025
// Descripción: Clase de entidad que representa un tipo de artículo
// Nombre del estudiante: Esteban
// Fecha: 09/06/2025

namespace PrimerProyecto08._06.Entidades
{
    public class TipoArticulo
    {
        // Identificador único del tipo de artículo
        public int Id { get; set; }

        // Nombre del tipo de artículo
        public string Nombre { get; set; }

        // Descripción del tipo de artículo
        public string Descripcion { get; set; }

        // Constructor vacío
        public TipoArticulo() { }

        // Constructor con parámetros
        public TipoArticulo(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
