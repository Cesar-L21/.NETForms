using PrimerProyecto08._06.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto08._06.Entidades
{
    public class Pedido
    {
        // Identificador único del pedido
        public int Id { get; set; }

        // Cliente que realiza el pedido
        public Cliente Cliente { get; set; }

        // Repartidor asignado al pedido
        public Repartidor Repartidor { get; set; }

        // Artículo solicitado
        public Articulo Articulo { get; set; }

        // Fecha en que se realizó el pedido
        public DateTime FechaPedido { get; set; }

        // Cantidad de artículos solicitados
        public int Cantidad { get; set; }

        public string Direccion { get; set; }

        // Total del pedido (se puede calcular automáticamente)
        public double Total => Cantidad * Articulo?.Valor ?? 0;

        // Constructor vacío
        public Pedido() { }

        // Constructor con parámetros
        public Pedido(int id, Cliente cliente, Repartidor repartidor, Articulo articulo, DateTime fechaPedido, int cantidad, string direccion)
        {
            Id = id;
            Cliente = cliente;
            Repartidor = repartidor;
            Articulo = articulo;
            FechaPedido = fechaPedido;
            Cantidad = cantidad;
            Direccion = direccion;
        }
    }

}

