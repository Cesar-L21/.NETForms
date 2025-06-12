using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto08._06.Datos
{
    public class DatosArticulo
    {
        private Articulo[] articulos;
        private int contador;

        // Constructor con capacidad máxima del arreglo
        public DatosArticulo()
        {
            articulos = new Articulo[20];
            contador = 0;
        }

        // Método para agregar un artículo nuevo
        public bool Agregar(Articulo nuevoArticulo)
        {
            if (contador >= articulos.Length)
                return false; // Arreglo lleno

            if (ExisteId(nuevoArticulo.Id))
                return false; // ID duplicado

            articulos[contador] = nuevoArticulo;
            contador++;
            return true;
        }

        // Verifica si un ID ya existe
        public bool ExisteId(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (articulos[i].Id == id)
                    return true;
            }
            return false;
        }

        // Devuelve la lista de artículos agregados
        public Articulo[] Listar()
        {
            Articulo[] resultado = new Articulo[contador];
            Array.Copy(articulos, resultado, contador);
            return resultado;
        }

        // Busca un artículo por su ID
        public Articulo BuscarPorId(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (articulos[i].Id == id)
                    return articulos[i];
            }
            return null;
        }
    }
}
