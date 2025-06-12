// Universidad: UNED
// Cuatrimestre: II Cuatrimestre 2025
// Descripción: Clase de lógica para Clientes
// Nombre del estudiante: Esteban
// Fecha: 09/06/2025

using PrimerProyecto08._06.Datos;
using PrimerProyecto08._06.Entidades;
using System;

namespace PrimerProyecto08._06.Logica
{
    public class LogicaCliente
    {
        private DatosCliente datosCliente;

        public LogicaCliente()
        {
            datosCliente = new DatosCliente();
        }

        // Agrega un nuevo cliente si no existe ya un Id igual
        public bool Agregar(Cliente cliente)
        {
            // Validar que el Id no esté repetido
            if (datosCliente.BuscarPorId(cliente.Identificacion) != null)
            {
                return false; // Ya existe un cliente con esta identificación
            }

            datosCliente.Agregar(cliente);
            return true;
        }

        // Devuelve todos los clientes registrados
        public Cliente[] ObtenerTodos()
        {
            return datosCliente.Listar();
        }

        // Buscar un cliente por su Id
        public Cliente BuscarPorId(int id)
        {
            return datosCliente.BuscarPorId(id);
        }

        
    }
}
