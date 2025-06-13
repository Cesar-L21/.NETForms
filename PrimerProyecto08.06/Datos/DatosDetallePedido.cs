using PrimerProyecto08._06.Entidades;
using System;

namespace PrimerProyecto08._06.Datos
{
    public class DatosDetallePedido
    {
        private DetallePedido[] detalles = new DetallePedido[500];
        private int contador = 0;

        // Registrar un nuevo detalle
        public bool RegistrarDetalle(DetallePedido detalle)
        {
            if (contador >= detalles.Length)
                return false;

            detalles[contador++] = detalle;
            return true;
        }

        // Obtener todos los detalles para un pedido específico
        public DetallePedido[] ObtenerDetallesPorPedido(int numeroPedido)
        {
            int cantidad = 0;

            // Primero contar cuántos hay
            for (int i = 0; i < contador; i++)
            {
                if (detalles[i].NumeroPedido == numeroPedido)
                    cantidad++;
            }

            // Crear arreglo del tamaño correcto
            DetallePedido[] resultado = new DetallePedido[cantidad];
            int j = 0;

            for (int i = 0; i < contador; i++)
            {
                if (detalles[i].NumeroPedido == numeroPedido)
                    resultado[j++] = detalles[i];
            }

            return resultado;
        }

        // Obtener todos los detalles registrados
        public DetallePedido[] ObtenerTodos()
        {
            DetallePedido[] resultado = new DetallePedido[contador];
            for (int i = 0; i < contador; i++)
            {
                resultado[i] = detalles[i];
            }
            return resultado;
        }
    }
}
