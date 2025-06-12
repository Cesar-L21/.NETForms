// Universidad: UNED
// Cuatrimestre: II Cuatrimestre 2025
// Descripción: Clase de lógica para repartidores
// Nombre del estudiante: Esteban
// Fecha: 09/06/2025

using PrimerProyecto08._06.Datos;
using PrimerProyecto08._06.Entidades;
using System;

namespace PrimerProyecto08._06.Logica
{
    public class LogicaRepartidor
    {
        private DatosRepartidor datosRepartidor = new DatosRepartidor();

        // Agrega un nuevo repartidor si no existe ya uno con la misma identificación
        public bool Agregar(Repartidor repartidor)
        {
            if (datosRepartidor.BuscarPorId(repartidor.Identificacion) != null)
            {
                return false; // Ya existe un repartidor con esta identificación
            }

            datosRepartidor.Agregar(repartidor);
            return true;
        }

        // Devuelve todos los repartidores registrados
        public Repartidor[] ObtenerTodos()
        {
            return datosRepartidor.Listar();
        }

        // Busca un repartidor por su identificación
        public Repartidor BuscarPorId(int id)
        {
            return datosRepartidor.BuscarPorId(id);
        }

    }
}
