// Universidad: UNED
// Cuatrimestre: II Cuatrimestre 2025
// Descripción: Clase de lógica para Tipo de Artículo
// Nombre del estudiante: Esteban
// Fecha: 09/06/2025

using PrimerProyecto08._06.Datos;

namespace PrimerProyecto08._06.Logica
{
    public class LogicaTipoArticulo
    {
        private DatosTipoArticulo datosTipoArticulo;

        public LogicaTipoArticulo()
        {
            datosTipoArticulo = new DatosTipoArticulo();
        }

        // Agrega un nuevo tipo de artículo si no existe ya un Id igual
        public bool Agregar(TipoArticulo tipo)
        {
            if (datosTipoArticulo.BuscarPorId(tipo.Id) != null)
            {
                return false;
            }

            return datosTipoArticulo.Agregar(tipo);
        }

        // Devuelve todos los tipos de artículos registrados
        public TipoArticulo[] ObtenerTodos()
        {
            return datosTipoArticulo.Listar();
        }

        // Buscar un tipo de artículo por Id
        public TipoArticulo BuscarPorId(int id)
        {
            return datosTipoArticulo.BuscarPorId(id);
        }
    }
}
