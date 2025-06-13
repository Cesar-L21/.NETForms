using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerProyecto08._06.Entidades;

namespace PrimerProyecto08._06.Datos
{
    public class DatosRepartidor
    {
        private static Repartidor[] repartidores = new Repartidor[20];
        private static int contador = 0;

        // Método para agregar un repartidor
        public  bool Agregar(Repartidor nuevoRepartidor)
        {
            if (contador >= repartidores.Length)
                return false;

            // Validar que el Id no se repita
            if (BuscarPorId(nuevoRepartidor.Identificacion) != null)
                return false;

            repartidores[contador] = nuevoRepartidor;
            contador++;
            return true;
        }

        // Método para listar todos los repartidores
        public  Repartidor[] Listar()
        {
            Repartidor[] resultado = new Repartidor[contador];
            Array.Copy(repartidores, resultado, contador);
            return resultado;
        }

        // Método para buscar un repartidor por su ID
        public  Repartidor BuscarPorId(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (repartidores[i].Identificacion == id)
                    return repartidores[i];
            }
            return null;
        }

        // Método para modificar un repartidor existente
        public static bool Modificar(Repartidor repartidorModificado)
        {
            for (int i = 0; i < contador; i++)
            {
                if (repartidores[i].Identificacion == repartidorModificado.Identificacion)
                {
                    repartidores[i] = repartidorModificado;
                    return true;
                }
            }
            return false;
        }

        // Método para eliminar un repartidor por su ID
        public static bool Eliminar(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (repartidores[i].Identificacion == id)
                {
                    for (int j = i; j < contador - 1; j++)
                    {
                        repartidores[j] = repartidores[j + 1];
                    }
                    repartidores[contador - 1] = null;
                    contador--;
                    return true;
                }
            }
            return false;
        }
    }
}
