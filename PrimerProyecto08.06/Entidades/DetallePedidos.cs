using PrimerProyecto08._06.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto08._06.Entidades
{
    public class DetallePedido
    {
        // Número del pedido al que pertenece el detalle
        public int NumeroPedido { get; set; }

        // Artículo incluido en el detalle
        public Articulo Articulo { get; set; }

        // Cantidad solicitada del artículo
        public int Cantidad { get; set; }

        // Monto total del detalle (incluye 12% adicional)
        public double Monto => (Articulo?.Valor ?? 0) * Cantidad * 1.12;

        // Constructor vacío
        public DetallePedido() { }

        // Constructor con parámetros
        public DetallePedido(int numeroPedido, Articulo articulo, int cantidad)
        {
            NumeroPedido = numeroPedido;
            Articulo = articulo;
            Cantidad = cantidad;
        }
    }
}
