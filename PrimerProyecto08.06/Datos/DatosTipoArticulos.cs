using System;
using PrimerProyecto08._06.Entidades;

// Universidad: UNED
// Cuatrimestre: II Cuatrimestre 2025
// Descripción: Clase de capa de datos para manejar los tipos de artículo
// Nombre del estudiante: Esteban
// Fecha: 09/06/2025

namespace PrimerProyecto08._06.Datos
{
    internal class DatosTipoArticulo
    {
        // Arreglo fijo para almacenar hasta 10 tipos de artículo
        private TipoArticulo[] tiposArticulo;

        // Lleva el control de cuántos elementos se han agregado
        private int contador;

        // Constructor
        public DatosTipoArticulo()
        {
            tiposArticulo = new TipoArticulo[10];
            contador = 0;
        }

        // Agrega un nuevo tipo de artículo al arreglo
        public bool Agregar(TipoArticulo nuevoTipo)
        {
            if (contador >= tiposArticulo.Length)
                return false; // Arreglo lleno

            if (ExisteId(nuevoTipo.Id))
                return false; // ID duplicado

            tiposArticulo[contador] = nuevoTipo;
            contador++;
            return true;
        }

        // Verifica si un ID ya existe en el arreglo
        public bool ExisteId(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (tiposArticulo[i].Id == id)
                    return true;
            }
            return false;
        }

        // Devuelve una copia del arreglo con los tipos registrados
        public TipoArticulo[] Listar()
        {
            TipoArticulo[] resultado = new TipoArticulo[contador];
            Array.Copy(tiposArticulo, resultado, contador);
            return resultado;
        }

        // Busca un tipo de artículo por su ID
        public TipoArticulo BuscarPorId(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (tiposArticulo[i].Id == id)
                    return tiposArticulo[i];
            }
            return null; // No encontrado
        }
    }
}
