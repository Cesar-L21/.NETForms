using PrimerProyecto08._06.Entidades;
using PrimerProyecto08._06.Datos;
using System;

namespace PrimerProyecto08._06.Logica
{
    public class LogicaPedido
    {
        private DatosPedido datos;

        public LogicaPedido()
        {
            datos = new DatosPedido();
        }

        public bool RegistrarPedido(Pedido pedido, out string mensaje)
        {
            if (pedido == null)
            {
                mensaje = "El pedido no puede ser nulo.";
                return false;
            }

            if (datos.BuscarPedidoPorId(pedido.Id) != null)
            {
                mensaje = "El número de pedido ya existe.";
                return false;
            }

            if (pedido.FechaPedido.Date < DateTime.Now.Date)
            {
                mensaje = "La fecha del pedido no puede ser anterior al día de hoy.";
                return false;
            }

            if (pedido.Cliente == null)
            {
                mensaje = "Debe seleccionar un cliente.";
                return false;
            }

            if (pedido.Repartidor == null)
            {
                mensaje = "Debe seleccionar un repartidor.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(pedido.Direccion))
            {
                mensaje = "Debe ingresar una dirección.";
                return false;
            }

            bool registrado = datos.RegistrarPedido(pedido);
            mensaje = registrado ? "Pedido registrado correctamente." : "No se pudo registrar el pedido (límite alcanzado).";
            return registrado;
        }


        public Pedido BuscarPedidoPorId(int id)
        {
            return datos.BuscarPedidoPorId(id);
        }

        public Pedido[] ObtenerPedidos()
        {
            return datos.ObtenerPedidos();
        }
    }
}
