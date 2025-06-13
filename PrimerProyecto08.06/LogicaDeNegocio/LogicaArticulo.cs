// Universidad: UNED
// Cuatrimestre: II Cuatrimestre 2025
// Descripción: Clase de entidad que representa un tipo de artículo
// Nombre del estudiante: Esteban
// Fecha: 09/06/2025
using PrimerProyecto08._06.Datos;
using PrimerProyecto08._06.Entidades;
using System;

namespace PrimerProyecto08._06.Logica
{
    public class LogicaArticulo
    {
        private DatosArticulo datosArticulo;

        public LogicaArticulo()
        {
            datosArticulo = new DatosArticulo();
        }

        // Agrega un nuevo artículo si no existe ya un Id igual
        public bool Agregar(Articulo articulo)
        {
            // Validar que el Id no esté repetido
            if (datosArticulo.BuscarPorId(articulo.Id) != null)
            {
                return false; // Ya existe un artículo con este ID
            }

            // Agregar el artículo
            datosArticulo.Agregar(articulo);
            return true;
        }

        // Devuelve todos los artículos registrados
        public Articulo[] ObtenerTodos()
        {
            return datosArticulo.Listar();
        }

        // Buscar un artículo por su Id
        public Articulo BuscarPorId(int id)
        {
            return datosArticulo.BuscarPorId(id);
        }
    }
}

