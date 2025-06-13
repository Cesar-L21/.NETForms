using PrimerProyecto08._06.Entidades;
using PrimerProyecto08._06.Datos;
using System.Linq;

namespace PrimerProyecto08._06.Logica
{
    public class LogicaDetallePedido
    {
        private DatosDetallePedido datosDetalle;

        public LogicaDetallePedido()
        {
            datosDetalle = new DatosDetallePedido();
        }

        public string RegistrarDetalle(DetallePedido detalle)
        {
            if (detalle == null || detalle.Articulo == null)
                return "El detalle o el artículo no puede ser nulo.";

            if (detalle.Cantidad <= 0)
                return "La cantidad debe ser mayor a cero.";

            if (detalle.Cantidad > detalle.Articulo.Inventario)
                return "La cantidad supera el inventario disponible.";

            var detallesExistentes = datosDetalle.ObtenerDetallesPorPedido(detalle.NumeroPedido);
            if (detallesExistentes.Any(d => d.Articulo.Id == detalle.Articulo.Id))
                return "Este artículo ya fue agregado al pedido.";

            bool registrado = datosDetalle.RegistrarDetalle(detalle);
            if (!registrado)
                return "No se pudo registrar el detalle (límite alcanzado).";

            // Actualizar inventario
            detalle.Articulo.Inventario -= detalle.Cantidad;
            if (detalle.Articulo.Inventario == 0)
                detalle.Articulo.Activo = false;

            return "Detalle registrado correctamente.";
        }

        public DetallePedido[] ObtenerDetallesPorPedido(int numeroPedido)
        {
            return datosDetalle.ObtenerDetallesPorPedido(numeroPedido);
        }

        public DetallePedido[] ObtenerTodosLosDetalles()
        {
            return datosDetalle.ObtenerTodos();
        }
    }
}
