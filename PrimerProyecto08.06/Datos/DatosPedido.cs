using PrimerProyecto08._06.Entidades;
using System;

namespace PrimerProyecto08._06.Datos
{
    public class DatosPedido
    {
        // Arreglo para almacenar pedidos
        private Pedido[] pedidos = new Pedido[40];
        private int contador = 0;

        // Método para registrar un pedido 
        public bool RegistrarPedido(Pedido pedido)
        {
            if (contador >= pedidos.Length)
                return false;

            pedidos[contador++] = pedido;
            return true;
        }

        // Método para buscar un pedido por ID
        public Pedido BuscarPedidoPorId(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (pedidos[i].Id == id)
                    return pedidos[i];
            }
            return null;
        }

        // Método para obtener todos los pedidos (opcional, útil para reportes)
        public Pedido[] ObtenerPedidos()
        {
            Pedido[] resultado = new Pedido[contador];
            for (int i = 0; i < contador; i++)
            {
                resultado[i] = pedidos[i];
            }
            return resultado;
        }
    }
}
