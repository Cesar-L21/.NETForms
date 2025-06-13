using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerProyecto08._06.Entidades;

namespace PrimerProyecto08._06.Datos
{
    public class DatosCliente
    {
        private static Cliente[] clientes = new Cliente[20];
        private static int contador = 0;

        // Método para agregar un cliente
        public  bool Agregar(Cliente nuevoCliente)
        {
            if (contador >= clientes.Length)
                return false;

            // Validar que el Id no se repita
            if (BuscarPorId(nuevoCliente.Identificacion) != null)
                return false;

            clientes[contador] = nuevoCliente;
            contador++;
            return true;
        }

        // Método para listar todos los clientes
        public  Cliente[] Listar()
        {
            Cliente[] resultado = new Cliente[contador];
            Array.Copy(clientes, resultado, contador);
            return resultado;
        }

        // Método para buscar un cliente por su ID
        public  Cliente BuscarPorId(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i].Identificacion == id)
                    return clientes[i];
            }
            return null;
        }

        // Método para modificar un cliente existente
        public static bool Modificar(Cliente clienteModificado)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i].Identificacion == clienteModificado.Identificacion)
                {
                    clientes[i] = clienteModificado;
                    return true;
                }
            }
            return false;
        }

        // Método para eliminar un cliente por su ID
        public static bool Eliminar(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i].Identificacion == id)
                {
                    for (int j = i; j < contador - 1; j++)
                    {
                        clientes[j] = clientes[j + 1];
                    }
                    clientes[contador - 1] = null;
                    contador--;
                    return true;
                }
            }
            return false;
        }
    }
}
